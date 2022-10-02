using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicianApp.Models;

namespace MusicianApp.Controllers
{
    public class MembersController : Controller
    {
        private readonly MusiciansContext _context;

        public MembersController(MusiciansContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            ReadCookies();
            return View(await _context.Person.Where(rq => rq.Request == 1).ToListAsync());
        }

        public async Task<IActionResult> IndexInactive()
        {
            ReadCookies();
            return View(await _context.Person.Where(rq => rq.Request == -1).ToListAsync());
        }

        public async Task<IActionResult> IndexRequests()
        {
            ReadCookies();
            return View(await _context.Person.Where(rq => rq.Request == 0).ToListAsync());
        }

        public async Task<IActionResult> IndexBalance(string option)
        {
            ReadCookies();
            if (option == "due")
            {
                return View(await _context.Person.
                    Where(rq => rq.Request == 1).Where(op => op.BalanceDue == true).
                    ToListAsync());
            }
            else if (option == "notdue")
            {
                return View(await _context.Person.
                    Where(rq => rq.Request == 1).Where(op => op.BalanceDue == false).
                    ToListAsync());
            }
            else
            {
                return View(await _context.Person.
                    Where(rq => rq.Request == 1).ToListAsync());
            } 
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ReadCookies();
            if (id == null)
            {
                int idCookie = -1;
                int.TryParse((string) ViewData["idCookie"], out idCookie);
                
                if(idCookie == -1)
                {
                    return NotFound();
                }
                else
                {
                    id = idCookie;
                }            
            }

            var person = await _context.Person
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (person == null)
            {
                return NotFound();
            }
          
            HttpContext.Session.SetString("sessionId", id.ToString());
            var Aintruments = _context.PersonInstrument.Where(m => m.PersonId == id);
            ViewBag.instruments = Aintruments;
            return View(person);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            ReadCookies();
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,FirstName,LastName,Password,AssociationDate,Email,Request,BalanceDue,Balance,StatusId")] Person person)
        {
            ReadCookies();
            person.AssociationDate = DateTime.Now.Date;
            person.BalanceDue = false;
            person.Balance = ClassLibrary.Balance.getBalance((DateTime) person.AssociationDate); //see utility class
            person.Request = 0;
            person.StatusId = 3;

            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();

                Response.Cookies.Append("idCookie", person
                    .MemberId
                    .ToString(),
                   new CookieOptions { Expires = DateTime.Today.AddDays(1) });

                Response.Cookies.Append("memberStatus", person
                   .StatusId
                   .ToString(),
                  new CookieOptions { Expires = DateTime.Today.AddDays(1) });

                return RedirectToAction("Details","Login");
            }
            ViewData["newAccountMessage"] = "Sign up failed. Contact support";
            return View(person);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id, string idS)
        {
            ReadCookies();
            if (id == null)
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

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int? statusId, int? request, [Bind("MemberId,FirstName,LastName,Password,AssociationDate,Email,Request,BalanceDue,Balance,StatusId")] Person person)
        {
            ReadCookies();
            if (id != person.MemberId)
            {
                return NotFound();
            }

            if (request != null && statusId != null)
            {
                person.Request = (int) request;
                person.StatusId = (int) statusId;
            }
            person.Balance = ClassLibrary.Balance.getBalance((DateTime) person.AssociationDate);

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
                return RedirectToAction("Index","Home");
            }
            return View(person);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> EditAccount(int? id, string idS)
        {
            ReadCookies();
            if (id == null)
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

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAccount(int id, [Bind("MemberId,FirstName,LastName,Password,AssociationDate,Email,Request,BalanceDue,Balance,StatusId")] Person person)
        {
            ReadCookies();
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
                return RedirectToAction("IndexBalance");
            }
            return View(person);
        }


        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ReadCookies();
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

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ReadCookies();
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.MemberId == id);
        }

        private void ReadCookies()
        {
            ViewData["memberStatus"] = Request.Cookies["memberStatus"];
            ViewData["idCookie"] = Request.Cookies["idCookie"];
            ViewData["firstNameCookie"] = Request.Cookies["firstNameCookie"];
        }



       
    }
}
