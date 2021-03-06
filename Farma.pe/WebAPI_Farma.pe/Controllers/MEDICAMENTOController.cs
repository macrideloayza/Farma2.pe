﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI_Farma.pe.Models;

namespace WebAPI_Farma.pe.Controllers
{
    public class MEDICAMENTOController : ApiController
    {
        private BD_FARMACIAEntities db = new BD_FARMACIAEntities();

        // GET: api/MEDICAMENTO
        //public IQueryable<MEDICAMENTO> GetMEDICAMENTOes()
        //{
        //    return db.MEDICAMENTOes;
        //}

        // GET: api/MEDICAMENTO/5
        [ResponseType(typeof(MEDICAMENTO))]
        public IHttpActionResult GetMEDICAMENTO(int id)
        {
            MEDICAMENTO mEDICAMENTO = db.MEDICAMENTOes.Find(id);
            if (mEDICAMENTO == null)
            {
                return NotFound();
            }

            return Ok(mEDICAMENTO);
        }

        [ResponseType(typeof(MEDICAMENTO))]
        public IHttpActionResult GetMEDICAMENTO(string filtro)
        {

            return Ok(db.USP_MEDICAMENTO_FILTRO(filtro));
        }

        // GET: api/MEDICAMENTO/5
        [ResponseType(typeof(MEDICAMENTO))]
        public IHttpActionResult GetTop20Medicamento()
        {
            return Ok(db.USP_TOP20_MEDICAMENTO());
        }

        // PUT: api/MEDICAMENTO/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMEDICAMENTO(int id, MEDICAMENTO mEDICAMENTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mEDICAMENTO.ID_MED)
            {
                return BadRequest();
            }

            db.Entry(mEDICAMENTO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MEDICAMENTOExists(id))
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

        // POST: api/MEDICAMENTO
        [ResponseType(typeof(MEDICAMENTO))]
        public IHttpActionResult PostMEDICAMENTO(MEDICAMENTO mEDICAMENTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MEDICAMENTOes.Add(mEDICAMENTO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mEDICAMENTO.ID_MED }, mEDICAMENTO);
        }

        // DELETE: api/MEDICAMENTO/5
        [ResponseType(typeof(MEDICAMENTO))]
        public IHttpActionResult DeleteMEDICAMENTO(int id)
        {
            MEDICAMENTO mEDICAMENTO = db.MEDICAMENTOes.Find(id);
            if (mEDICAMENTO == null)
            {
                return NotFound();
            }

            db.MEDICAMENTOes.Remove(mEDICAMENTO);
            db.SaveChanges();

            return Ok(mEDICAMENTO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MEDICAMENTOExists(int id)
        {
            return db.MEDICAMENTOes.Count(e => e.ID_MED == id) > 0;
        }
    }
}