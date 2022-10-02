using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicianApp.Models;

namespace MusicianApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly MusiciansContext _context;

        public LoginController(MusiciansContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            ReadAllCookkies();
            return View(await _context.Person.ToListAsync());
        }

        public IActionResult CleanCookies()
        {
            Response.Cookies.Delete("memberStatus");
            Response.Cookies.Delete("idCookie");
            Response.Cookies.Delete("firstNameCookie");
            return RedirectToAction("Index", "Home");
        }

        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            id = int.Parse(Request.Cookies["idCookie"]); 

            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        public IActionResult Create()
        {
            ReadAllCookkies();
            return View();
        }

        //Login page. The Create method uses Http post to match password and login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Password,Email")] Person person)
        {
            ReadAllCookkies();
            Person emailPerson = new Person();
            if (_context.Person.Any(em => em.Email == person.Email))
            {
                emailPerson = _context.Person.Where(em => em.Email == person.Email).First();
            }
            else
            {
                ViewData["loginErrorMessage"] = "Email or password is wrong";
                return View();
            }

            if (emailPerson.Email == person.Email && emailPerson.Password == person.Password)
            {
                int id = emailPerson.MemberId;
                int memberStatus = emailPerson.StatusId;
                string firstName = emailPerson.FirstName;

                ViewData["loginErrorMessage"] = "Login Sucessfully";

                Response.Cookies.Append("memberStatus", memberStatus.ToString(),
                    new CookieOptions { Expires = DateTime.Today.AddDays(30) });
                Response.Cookies.Append("idCookie", id.ToString(),
                   new CookieOptions { Expires = DateTime.Today.AddDays(30) });
                Response.Cookies.Append("firstNameCookie", firstName,
                   new CookieOptions { Expires = DateTime.Today.AddDays(30) });

                ReadAllCookkies();
                return RedirectToAction("Index", "Home");
                       
            }
            else
            {
                ViewData["loginErrorMessage"] = "Email or password is wrong";
                return View();
            }
        }

      
        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ReadAllCookkies();
            if (Request.Cookies["idCookie"] != null)
            {
                id = int.Parse(Request.Cookies["idCookie"]);
            }
            else if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }     
            return View(person);
        }

        public async Task<IActionResult> GetRestoreEmail( int ? id)
        {
            ReadAllCookkies();

            id = ClassLibrary.Encryption.GetEncryption((int) id);

            var person = await _context.Person.FindAsync(id);
            TempData["passMessage"] = "";
            if (person != null)
            {
                HttpContext.Session.SetInt32("passId",(int) id);
                return View(person);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetRestoreEmail(string password, [Bind("MemberId,FirstName,LastName,Password,AssociationDate,Email,Request,BalanceDue,Balance,StatusId")] Person person)
        {
            ReadAllCookkies();
            int id = (int) HttpContext.Session.GetInt32("passId");
            TempData["passMessage"] = "";

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.MemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return View(person);
                    }
                }
                TempData["passMessage"] = "Updated!";
                return RedirectToAction("Index", "Home");
            }
            return View(person);
        }


        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberId,FirstName,LastName,Password,AssociationDate,Email,Request,BalanceDue,Balance,StatusId")] Person person)
        {
            ReadAllCookkies();
            

            if (id != person.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.MemberId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (Request.Cookies["memberStatus"] == "3")
                {
                    return RedirectToAction("Details");
                }
                return RedirectToAction(nameof(Index));
            }
            if (Request.Cookies["memberStatus"] == "3")
            {
                return RedirectToAction("Details");
            }
            return View(person);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ReadAllCookkies();
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ReadAllCookkies();
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private void ReadAllCookkies()
        {
            ViewData["memberStatus"] = Request.Cookies["memberStatus"];
            ViewData["idCookie"] = Request.Cookies["idCookie"];
            ViewData["firstNameCookie"] = Request.Cookies["firstNameCookie"];
        }

        #region Forget password

        public IActionResult ForgetPassword()
        {
            ReadAllCookkies();
            return View();
        }

        //REdefine Password Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword([Bind("Email")] Person person)
        {
            ReadAllCookkies();
            if (_context.Person.Any(em => em.Email == person.Email))
            {
                int id = _context
                    .Person
                    .Where(mail => mail.Email == person.Email)
                    .First()
                    .MemberId;
            
                SendEmail(person.Email, id);
                ViewData["passwordErrorMessage"] = "Check your email to restore your password";
                return View();
            }
            else
            {
                ViewData["passwordErrorMessage"] = "This email account does not belong to an Ontario Musician Associtaion member";
                return View();
            }       
        }

        public static string BodyEmail(int id)
        {
            string encryptedId = ClassLibrary.Encryption.SetEncryption(id).ToString();
            return "Hello\r\nClick on the link below to redifine your password\r\n"
                + "https://localhost:44306/Login/GetRestoreEmail?id=" + encryptedId;	
        }

        /// <summary>
        /// Send new password instruction to email
        /// </summary>
        /// <param name="email"></param>
        public static void SendEmail(string email, int id)
        {
            string emailBody = BodyEmail(id);

            MailMessage mailMessage = new MailMessage("eric@hotmail.com",
                "eric@hotmail.com");
            mailMessage.Subject = "New password";
            mailMessage.Body = emailBody;

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "ericromagna@hotmail.com",
                Password = "somepassword"
            };
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }

        #endregion


        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.MemberId == id);
        }
    }
}
