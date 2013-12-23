using SugarMama.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarMama.Domain.Contracts
{
    public interface IAppointmentService
    {
        Appointment BookAppointment(Appointment appointment);
        bool CancelAppointment(int id);
        Appointment EditAppointment(int id, Appointment editedAppointment);
        IList<Appointment> GetAllAppointments();
        Appointment GetAppointment(int id);
    }
}
