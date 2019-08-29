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
    [RoutePrefix("api/Consultations")]
    public class ConsultationController : BaseController
    {
        private readonly IConsultationManager _consultationManager;
        private readonly IConsultationFactory _consultationFactory;

        public ConsultationController(IConsultationManager consultationManager,
            IConsultationFactory consultationFactory)
        {
            _consultationManager = consultationManager;
            _consultationFactory = consultationFactory;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var consultations = _consultationManager.GetAll<Consultation>();
                var consultationsDTO = _consultationFactory.CreateConsultationDTO(consultations);

                return Content(HttpStatusCode.OK, consultationsDTO);
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
                var consultation = _consultationManager.GetById<Consultation>(id);
                var consultationDTO = _consultationFactory.CreateConsultationDTO(consultation);

                return Content(HttpStatusCode.OK, consultationDTO);
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
                var consultations = _consultationManager.GetWithWhereCondition<Consultation>($"PatientId = {id}");
                var consultationsDTO = _consultationFactory.CreateConsultationDTO(consultations);

                return Content(HttpStatusCode.OK, consultationsDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]Consultation consultation)
        {
            try
            {
                return Content(HttpStatusCode.OK, _consultationManager.Add(consultation));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]Consultation consultation)
        {
            try
            {
                return Content(HttpStatusCode.OK, _consultationManager.Update(consultation));
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
                return Content(HttpStatusCode.OK, _consultationManager.Delete(new int[] { id }));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
