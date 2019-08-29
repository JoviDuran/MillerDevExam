using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuaClinicApp.Factories.Interfaces
{
    public interface IAppointmentFactory
    {
        AppointmentDTO CreateAppointmentDTO(Appointment appointment);
        IList<AppointmentDTO> CreateAppointmentDTO(IList<Appointment> appointments);

        // Create Appointment by Patient
    }
}
