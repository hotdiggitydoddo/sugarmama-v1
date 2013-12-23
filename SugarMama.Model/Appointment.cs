using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarMama.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Time { get; set; }
        public float Duration { get; set; }
        public bool RemindMeViaTxt { get; set; }
    }
}
