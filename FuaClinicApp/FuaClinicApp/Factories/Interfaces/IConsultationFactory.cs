using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Factories.Interfaces
{
    public interface IConsultationFactory
    {
        ConsultationDTO CreateConsultationDTO(Consultation consultation);
        IList<ConsultationDTO> CreateConsultationDTO(IList<Consultation> consultations);

        //crrate ConsultationByPatient
    }
}
