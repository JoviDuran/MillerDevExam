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
    [RoutePrefix("api/Addresses")]
    public class AddressController : BaseController
    {
        private readonly IAddressManager _addressManager;
        private readonly IAddressFactory _addressFactory;
        public AddressController(IAddressManager addressManager,
            IAddressFactory addressFactory)
        {
            _addressManager = addressManager;
            _addressFactory = addressFactory;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            try
            {
                var addresses = _addressManager.GetAll<Address>();
                var addressesDTO = _addressFactory.CreateAddressDTO(addresses);

                return Content(HttpStatusCode.OK, addressesDTO);
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
                var address = _addressManager.GetById<Address>(id);
                var addressDTO = _addressFactory.CreateAddressDTO(address);
                return Content(HttpStatusCode.OK, addressDTO);
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
                var address = _addressManager.GetWithWhereCondition<Address>($"PatientId = {id}");
                var addressDTO = _addressFactory.CreateAddressDTO(address);
                return Content(HttpStatusCode.OK, addressDTO);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create([FromBody]Address address)
        {
            try
            {
                return Content(HttpStatusCode.OK, _addressManager.Add(address));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public IHttpActionResult Update([FromBody]Address address)
        {
            try
            {
                return Content(HttpStatusCode.OK, _addressManager.Update(address));
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
                return Content(HttpStatusCode.OK, _addressManager.Delete(new int[] { id }));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
