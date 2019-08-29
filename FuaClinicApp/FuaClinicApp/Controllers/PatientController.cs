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
    [RoutePrefix("api/Patients")]
    public class PatientController : BaseController
    {
        private readonly IPatientManager _patientManager;
        private readonly IAddressManager _addressManager;
        private readonly IEmergencyContactManager _emergencyContactManager;
        private readonly IConsultationManager _consultationManager;
        private readonly IAppointmentManager _appointmentManager;
        private readonly IPatientFactory _patientFactory;

        public PatientController(IPatientManager patientManager,
            IAddressManager addressManager,
            IEmergencyContactManager emergencyContactManager,
            IConsultationManager consultationManager,
            IAppointmentManager appointmentManager,
            IPatientFactory patientFactory)
        {
            _patientManager = patientManager;
            _addressManager = addressManager;
            _emergencyContactManager = emergencyContactManager;
            _consultationManager = consultationManager;
            _appointmentManager = appointmentManager;
            _patientFactory = patientFactory;
        }
        

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var patients = _patientManager.GetAll<Patient>();
                var addresses = _addressManager.GetAll<Address>();
                var emergencyContacts = _emergencyContactManager.GetAll<EmergencyContact>();
                var consultations = _consultationManager.GetAll<Consultation>();
                var appointments = _appointmentManager.GetAll<Appointment>();

                var patientsDTO = _patientFactory.CreatePatientDTO(patients, addresses, emergencyContacts, consultations, appointments);

                return Content(HttpStatusCode.OK, patientsDTO);
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
                var patient = _patientManager.GetById<Patient>(id);
                var address = _addressManager.GetWithWhereCondition<Address>($"Patientid = {id}").FirstOrDefault();
                var emergencyContact = _emergencyContactManager.GetWithWhereCondition<EmergencyContact>($"Patientid = {id}").FirstOrDefault();
                var consultations = _consultationManager.GetWithWhereCondition<Consultation>($"PatientId = {id}");
                var appointments = _appointmentManager.GetWithWhereCondition<Appointment>($"PatientId = {id}");
                var patientDTO = _patientFactory.CreatePatientDTO(patient, address, emergencyContact, consultations, appointments);

                return Content(HttpStatusCode.OK, patientDTO);

            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]Patient patient)
        {
            try
            {
                return Content(HttpStatusCode.OK, _patientManager.Add(patient));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]Patient patient)
        {
            try
            {
                return Content(HttpStatusCode.OK, _patientManager.Update<Patient>(patient));
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
                return Content(HttpStatusCode.OK, _patientManager.Delete(new int[] { id }));
            }

            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
            // TODO: Put connection string in web config. Done
            // TODO: Change exceptions code. Done
        }
    }
}
