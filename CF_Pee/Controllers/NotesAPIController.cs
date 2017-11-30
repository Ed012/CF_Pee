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
using System.Web.Http.OData;

namespace CF_Pee.Controllers
{
    public class NotesAPIController : ApiController
    {
        private MyStudentsContext db = new MyStudentsContext();

        // GET: api/NotesAPI
        [EnableQuery]
        public IQueryable<Notes> GetNotes()
        {
            return db.Notes.AsQueryable();
        }

        // GET: api/NotesAPI/5
        [ResponseType(typeof(Notes))]
        public IHttpActionResult GetNotes(int id)
        {
            Notes notes = db.Notes.Find(id);
            if (notes == null)
            {
                return NotFound();
            }

            return Ok(notes);
        }

        // PUT: api/NotesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNotes(int id, Notes notes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notes.IdNote)
            {
                return BadRequest();
            }

            db.Entry(notes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotesExists(id))
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

        // POST: api/NotesAPI
        [ResponseType(typeof(Notes))]
        public IHttpActionResult PostNotes(Notes notes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notes.Add(notes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = notes.IdNote }, notes);
        }

        // DELETE: api/NotesAPI/5
        [ResponseType(typeof(Notes))]
        public IHttpActionResult DeleteNotes(int id)
        {
            Notes notes = db.Notes.Find(id);
            if (notes == null)
            {
                return NotFound();
            }

            db.Notes.Remove(notes);
            db.SaveChanges();

            return Ok(notes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotesExists(int id)
        {
            return db.Notes.Count(e => e.IdNote == id) > 0;
        }
    }
}