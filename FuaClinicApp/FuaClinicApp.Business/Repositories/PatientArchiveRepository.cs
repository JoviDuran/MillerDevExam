using FuaClinicApp.Business.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Business.Repositories
{
    public class PatientArchiveRepository:BaseRepository, IPatientArchiveRepository
    {
        internal override string TableName => "PatientArchive";

    }
}
