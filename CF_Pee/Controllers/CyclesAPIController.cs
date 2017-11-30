using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CF_Pee.Models;

namespace CF_Pee.Controllers
{
    public class CyclesAPIController : ApiController
    {
        private MyStudentsContext db = new MyStudentsContext();

        // GET: api/CyclesAPI
        public IQueryable<Cycle> GetCycles()
        {
            return db.Cycles;
        }

        // GET: api/CyclesAPI/5
        [ResponseType(typeof(Cycle))]
        public IHttpActionResult GetCycle(int id)
        {
            Cycle cycle = db.Cycles.Find(id);
            if (cycle == null)
            {
                return NotFound();
            }

            return Ok(cycle);
        }

        // PUT: api/CyclesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCycle(int id, Cycle cycle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cycle.IdCycle)
            {
                return BadRequest();
            }

            db.Entry(cycle).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CycleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CyclesAPI
        [ResponseType(typeof(Cycle))]
        public IHttpActionResult PostCycle(Cycle cycle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cycles.Add(cycle);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cycle.IdCycle }, cycle);
        }

        // DELETE: api/CyclesAPI/5
        [ResponseType(typeof(Cycle))]
        public IHttpActionResult DeleteCycle(int id)
        {
            Cycle cycle = db.Cycles.Find(id);
            if (cycle == null)
            {
                return NotFound();
            }

            db.Cycles.Remove(cycle);
            db.SaveChanges();

            return Ok(cycle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CycleExists(int id)
        {
            return db.Cycles.Count(e => e.IdCycle == id) > 0;
        }
    }
}