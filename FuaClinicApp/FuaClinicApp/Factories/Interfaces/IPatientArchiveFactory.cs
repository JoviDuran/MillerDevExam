using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Factories.Interfaces
{
    public interface IPatientArchiveFactory
    {
        PatientArchiveDTO CreatePatientArchiveDTO(PatientArchive patientArchive);
        IList<PatientArchiveDTO> CreatePatientArchiveDTO(IList<PatientArchive> patientArchives);
    }
}
