using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Models;
using FuaClinicApp.Business.Entities;

namespace FuaClinicApp.Factories
{
    public class ConsultationFactory : IConsultationFactory
    {
        public ConsultationDTO CreateConsultationDTO(Consultation consultation)
        {
            var consultationDTO = new ConsultationDTO()
            {
                Id = consultation.Id,
                PatientId = consultation.PatientId,
                Diagnosis = consultation.Diagnosis,
                Date = consultation.Date
            };

            return consultationDTO;
        }

        public IList<ConsultationDTO> CreateConsultationDTO(IList<Consultation> consultations)
        {
            var consultationsDTO = new List<ConsultationDTO>();
            foreach (var consultation in consultations)
            {
                var consultationDTO = CreateConsultationDTO(consultation);
                consultationsDTO.Add(consultationDTO);
            }
            return consultationsDTO;
        }


    }
}