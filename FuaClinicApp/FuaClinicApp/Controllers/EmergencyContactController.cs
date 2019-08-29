using FuaClinicApp.Business.Entities;
using FuaClinicApp.Business.Managers;
using FuaClinicApp.Business.Managers.Interfaces;
using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FuaClinicApp.Controllers
{
    [RoutePrefix("api/EmergencyContacts")]
    public class EmergencyContactController : BaseController
    {
        private readonly IEmergencyContactManager _emergencyContactManager;
        private readonly IEmergencyContactFactory _emergencyContactFactory;

        public EmergencyContactController(IEmergencyContactManager emergencyContactManager,
            IEmergencyContactFactory emergencyContactFactory)
        {
            _emergencyContactManager = emergencyContactManager;
            _emergencyContactFactory = emergencyContactFactory;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var emergencyContacts = _emergencyContactManager.GetAll<EmergencyContact>();
                var emergencyContactsDTO = _emergencyContactFactory.CreateEmergencyContactDTO(emergencyContacts);
                return Content(HttpStatusCode.OK, emergencyContactsDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetById(int id)
        {
            try
            {
                var emergencyContact = _emergencyContactManager.GetById<EmergencyContact>(id);
                var emergencyContactDTO = _emergencyContactFactory.CreateEmergencyContactDTO(emergencyContact);
                return Content(HttpStatusCode.OK, emergencyContactDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Route("GetByPatientId/{id}")]
        [HttpGet]
        public IHttpActionResult GetByPatientId(int id)
        {
            try
            {
                var emergencyContact = _emergencyContactManager.GetWithWhereCondition<EmergencyContact>($"PatientId = {id}").FirstOrDefault();
                var emergencyContactDTO = _emergencyContactFactory.CreateEmergencyContactDTO(emergencyContact);
                return Content(HttpStatusCode.OK, emergencyContactDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]EmergencyContact emergencyContact)
        {
            try
            {
                return Content(HttpStatusCode.OK, _emergencyContactManager.Add(emergencyContact));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]EmergencyContact emergencyContact)
        {
            try
            {
                return Content(HttpStatusCode.OK, _emergencyContactManager.Update(emergencyContact));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete([FromBody]int id)
        {
            try
            {
                var ids = new List<int>();
                ids.Add(id);
                return Content(HttpStatusCode.OK, _emergencyContactManager.Delete(ids.ToArray()));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
