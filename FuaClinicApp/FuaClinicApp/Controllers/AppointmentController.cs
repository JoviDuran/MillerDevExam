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
    [RoutePrefix("api/Appointments")]
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentManager _appointmentManager;
        private readonly IAppointmentFactory _appointmentFactory;

        public AppointmentController(IAppointmentManager appointmentManager,
            IAppointmentFactory appointmentFactory)
        {
            _appointmentManager = appointmentManager;
            _appointmentFactory = appointmentFactory;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            { 
                var appointments = _appointmentManager.GetAll<Appointment>();
                var appointmentsDTO = _appointmentFactory.CreateAppointmentDTO(appointments);
                return Content(HttpStatusCode.OK, appointmentsDTO);
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
                var appointment = _appointmentManager.GetById<Appointment>(id);
                var appointmentDTO = _appointmentFactory.CreateAppointmentDTO(appointment);
                return Content(HttpStatusCode.OK, appointmentDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("GetByPatientId/{id}")]
        public IHttpActionResult GetByPatientId(int id)
        {
            try
            {
                var appointment = _appointmentManager.GetWithWhereCondition<Appointment>($"PatientId = {id}");
                var appointmentsDTO = _appointmentFactory.CreateAppointmentDTO(appointment);
                return Content(HttpStatusCode.OK, appointmentsDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]Appointment appointment)
        {
            try
            {
                return Content(HttpStatusCode.OK, _appointmentManager.Add(appointment));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]Appointment appointment)
        {
            try
            {
                return Content(HttpStatusCode.OK, _appointmentManager.Update(appointment));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete([FromBody]int id) // Must delete multiple ids
        {
            try
            {
                return Content(HttpStatusCode.OK, _appointmentManager.Delete(new int[] { id }));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
