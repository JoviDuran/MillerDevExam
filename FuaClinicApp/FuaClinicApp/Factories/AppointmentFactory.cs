using FuaClinicApp.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuaClinicApp.Business.Entities;
using FuaClinicApp.Models;

namespace FuaClinicApp.Factories
{
    public class AppointmentFactory : IAppointmentFactory
    {
        public AppointmentDTO CreateAppointmentDTO(Appointment appointment)
        {
            var appointmentDTO = new AppointmentDTO()
            {
                Id = appointment.Id,
                PatientId = appointment.PatientId,
                DesiredDateTime = appointment.DesiredDateTime
            };

            return appointmentDTO;
        }

        public IList<AppointmentDTO> CreateAppointmentDTO(IList<Appointment> appointments)
        {
            var appointmentsDTO = new List<AppointmentDTO>();
            foreach (var appointment in appointments)
            {
                var appointmentDTO = CreateAppointmentDTO(appointment);
                appointmentsDTO.Add(appointmentDTO);
            }

            return appointmentsDTO;
        }
    }
}