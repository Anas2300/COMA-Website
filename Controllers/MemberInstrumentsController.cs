using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicianApp.Models;
using System.Web;


namespace MusicianApp.Controllers
{
    public class MemberInstrumentsController : Controller
    {
        private readonly MusiciansContext _context;

        public MemberInstrumentsController(MusiciansContext context)
        {
            _context = context;
        }

        // GET: MemberInstruments
        public async Task<IActionResult> Index(string ob,
            string userQueryFN,
            string userQueryLN,
            string userQueryInstrument)
        {
            ReadAllCookkies();
            ViewData["memberInstrumentMessage"] = "";
            TempData["stopOrder"] = "No";

            if (userQueryFN != null)
            {
                var list = await _context.
                    PersonInstrument.
                    Where(a => a.memberName == userQueryFN).
                    Where(b => b.lastName == userQueryLN).
                    ToListAsync();

                if (list.Any())
                {
                    TempData["stopOrder"] = "Yes";
                    return View(list);
                }
                else
                {
                    ViewData["memberInstrumentMessage"] = "No records found on this search";
                    return View();
                }

            }
            else if (userQueryInstrument != null)
            {
                var list = await _context.
                PersonInstrument.
                Where(a => a.instrumentName == userQueryInstrument).
                ToListAsync();

                if (list.Any())
                {
                    TempData["stopOrder"] = "Yes";
                    return View(list);
                }
                else
                {
                    ViewData["memberInstrumentMessage"] = "No records found on this search";
                    return View();
                }
            }
            else if (ob == "name")
            {
                return View(await _context.PersonInstrument
                    .OrderBy(o => o.memberName).ToListAsync());
            }
            else if (ob == "instrument")
            {
                return View(await _context.PersonInstrument
                    .OrderBy(o => o.instrumentName).ToListAsync());
            }
            else
            {
                return View(await _context.PersonInstrument.ToListAsync());
            }
        }

        public IActionResult SearchTest()
        {
            ReadAllCookkies();
            ViewBag.list = _context.PersonInstrument;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchTest([Bind("memberName,lastName,instrumentName")] PersonInstrument personInstrument)
        {
            ReadAllCookkies();
            string LastName = personInstrument.lastName;
            string FirstName = personInstrument.memberName;
            string instruments = personInstrument.instrumentName;

            if (FirstName == null && LastName == null && instruments == null)
            {
                ViewBag.list = _context.PersonInstrument;
                return View();
            }
            else if (FirstName != null && LastName == null && instruments == null)
            {
                var list = _context.PersonInstrument
                    .Where(pi => pi.memberName == FirstName);
                ViewBag.list = list;
            }
            else if (FirstName != null && LastName != null && instruments == null)
            {
                var list = await _context.PersonInstrument
                    .Where(pi => pi.memberName == FirstName)
                    .Where(pi => pi.lastName == LastName).ToListAsync();
                ViewBag.list = list;
            }
            else if (FirstName != null && LastName == null && instruments != null)
            {
                var list = await _context.PersonInstrument
                   .Where(pi => pi.memberName == FirstName)
                   .Where(pi => pi.instrumentName == instruments).ToListAsync();
                ViewBag.list = list;
            }
            else if (FirstName == null && LastName != null && instruments == null)
            {
                var list = await _context.PersonInstrument
                   .Where(pi => pi.lastName == LastName).ToListAsync();
                ViewBag.list = list;
            }
            else if (FirstName == null && LastName != null && instruments != null)
            {
                var list = await _context.PersonInstrument
                   .Where(pi => pi.instrumentName == instruments)
                   .Where(pi => pi.lastName == LastName).ToListAsync();
                ViewBag.list = list;
            }
            else if (FirstName == null && LastName == null && instruments != null)
            {
                var list = await _context.PersonInstrument
                   .Where(pi => pi.instrumentName == instruments).ToListAsync();
                ViewBag.list = list;
            }
            else if (FirstName != null && LastName != null && instruments != null)
            {
                var list = await _context.PersonInstrument
                   .Where(pi => pi.memberName == FirstName)
                   .Where(pi => pi.lastName == LastName)
                   .Where(pi => pi.instrumentName == instruments).ToListAsync();
                ViewBag.list = list;
            }

            return View();
        }

        public async Task<IActionResult> Contact(string name, string last)
        {
            ReadAllCookkies();
            if (name == null || last == null)
            {
                return NotFound();
            }

            int id = _context.Person.Where(c => c.FirstName == name)
                .Where(c => c.LastName == last).First().MemberId;

            var personContact = await _context.Person
              .FirstOrDefaultAsync(m => m.MemberId == id);

            if (personContact != null)
            {
                return View(personContact);
            }
            else
            {
                return NotFound();
            }
        }

        // GET: MemberInstruments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ReadAllCookkies();
            if (id == null)
            {
                return NotFound();
            }

            var personInstrument = await _context.PersonInstrument
                .FirstOrDefaultAsync(m => m.PersonInstrumentId == id);
            if (personInstrument == null)
            {
                return NotFound();
            }

            return View(personInstrument);
        }

        // GET: MemberInstruments/Create
        public IActionResult Create()
        {
            ReadAllCookkies();
            TempData["insMessage"] = "";
            ViewData["InstrumentId"] = new SelectList(_context.Instrument, "InstrumentId", "instrumentId");
            ViewData["instrumentName"] = new SelectList(_context.PersonInstrument, "instrumentName", "instrumentName", _context.Instrument);
            return View();
        }

        // POST: MemberInstruments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonInstrumentId,PersonId,InstrumentId,memberName,lastName,instrumentName")] PersonInstrument personInstrument)
        {
            ReadAllCookkies();

            var listOfAvailableInstruments = _context.Instrument;
            if (!listOfAvailableInstruments
               .Where(i => i.InstrumentName == personInstrument.instrumentName)
               .Any())
            {
                TempData["insMessage"] = "Instrument is not included in our instruments list";
                return View();
            }

            personInstrument.PersonInstrumentId = _context
                .PersonInstrument
                .OrderByDescending(p => p.PersonInstrumentId)
                .First()
                .PersonInstrumentId
                + 1;

            //Only administrator has a cookie and session variable. 
            //If he's chaging his own profile, read cookies
            //Otherwise, read sessions
            if (HttpContext.Session.GetString("sessionId") != null)
            {
                personInstrument.PersonId = int.Parse(HttpContext.Session.GetString("sessionId"));
            }
            else
            {
                personInstrument.PersonId = int.Parse((string)ViewData["idCookie"]);
            }
            personInstrument.memberName = _context
                .Person
                .Where(id => id.MemberId == personInstrument.PersonId)
                .First()
                .FirstName;
            personInstrument.lastName = _context
                .Person
                .Where(id => id.MemberId == personInstrument.PersonId)
                .First()
                .LastName;
            personInstrument.InstrumentId = _context
                .Instrument
                .Where(ins => ins.InstrumentName == personInstrument.instrumentName)
                .First()
                .InstrumentId;
            int statusId = _context
                .Person
                .Where(id => id.MemberId == personInstrument.PersonId)
                .First()
                .StatusId;


            if (ModelState.IsValid)
            {
                _context.Add(personInstrument);
                await _context.SaveChangesAsync();

                if (statusId != 1)
                {
                    return RedirectToAction("Details", "Members");
                }

                return RedirectToAction("Index", "Home");
            }
            return View(personInstrument);
        }

        // GET: MemberInstruments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ReadAllCookkies();
            if (id == null)
            {
                return NotFound();
            }

            var personInstrument = await _context.PersonInstrument.FindAsync(id);
            if (personInstrument == null)
            {
                return NotFound();
            }
            return View(personInstrument);
        }

        // POST: MemberInstruments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonInstrumentId,PersonId,InstrumentId,memberName,lastName,instrumentName")] PersonInstrument personInstrument)
        {
            ReadAllCookkies();
            if (id != personInstrument.PersonInstrumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personInstrument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonInstrumentExists(personInstrument.PersonInstrumentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personInstrument);
        }

        // GET: MemberInstruments/Delete/5
        public async Task<IActionResult> Delete(int? id, string instrument)
        {
            ReadAllCookkies();
            if (instrument != null)
            {
                int realId = _context
                    .PersonInstrument
                    .Where(m => m.PersonId == (int)id)
                    .Where(ins => ins.instrumentName == instrument)
                    .First()
                    .PersonInstrumentId;

                id = realId;
            }
            if (id == null)
            {
                return NotFound();
            }

            var personInstrument = await _context.PersonInstrument
                .FirstOrDefaultAsync(m => m.PersonInstrumentId == id);
            if (personInstrument == null)
            {
                return NotFound();
            }

            return View(personInstrument);
        }

        // POST: MemberInstruments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ReadAllCookkies();
            var personInstrument = await _context.PersonInstrument.FindAsync(id);
            _context.PersonInstrument.Remove(personInstrument);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        private bool PersonInstrumentExists(int id)
        {
            return _context.PersonInstrument.Any(e => e.PersonInstrumentId == id);
        }

        private void ReadAllCookkies()
        {
            ViewData["memberStatus"] = Request.Cookies["memberStatus"];
            ViewData["idCookie"] = Request.Cookies["idCookie"];
            ViewData["firstNameCookie"] = Request.Cookies["firstNameCookie"];
        }
    }
}
