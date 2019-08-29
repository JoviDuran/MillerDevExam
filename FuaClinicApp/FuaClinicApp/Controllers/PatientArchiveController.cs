using FuaClinicApp.Business.Entities;
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

    [RoutePrefix("api/PatientArchives")]

    public class PatientArchiveController : BaseController
    {
        private readonly IPatientArchiveManager _patientArchiveManager;
        private readonly IPatientArchiveFactory _patientArchiveFactory;


        public PatientArchiveController(IPatientArchiveManager patientArchiveManager,
            IPatientArchiveFactory patientArchiveFactory)
        {
            _patientArchiveManager = patientArchiveManager;
            _patientArchiveFactory = patientArchiveFactory;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var patientArchives = _patientArchiveManager.GetAll<PatientArchive>();
                var patientArchivesDTO = _patientArchiveFactory.CreatePatientArchiveDTO(patientArchives);
                return Content(HttpStatusCode.OK, patientArchivesDTO);

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
                var patientArchive = _patientArchiveManager.GetById<PatientArchive>(id);
                var patientArchiveDTO = _patientArchiveFactory.CreatePatientArchiveDTO(patientArchive);
                return Content(HttpStatusCode.OK, patientArchiveDTO);

            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]PatientArchive patientArchive)
        {
            try
            {
                return Content(HttpStatusCode.OK, _patientArchiveManager.Add(patientArchive));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IHttpActionResult Delete([FromBody] int id)
        {
            try
            {
                return Content(HttpStatusCode.OK, _patientArchiveManager.Delete(new int[] { id }));
            }

            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
            // TODO: Change code for exception. Done
            // TODO: Put connection string in web config. Done
        }
    }
}
