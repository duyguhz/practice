using System;
using System.Collections.Generic;

namespace practice
{
    public class Hospital
    {
        public Hospital()
        {
        }
        List<Appointment> appointments = new List<Appointment>();
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        public void EndAppointment(int no)
        {

            foreach (var item in appointments)
            {
                if (item.No==no)
                {
                    item.EndDate = DateTime.Now;
                }
            }
        }
        public void  GetAppointment(int no)
        {
            foreach (var item in appointments)
            {
                if (item.No==no)
                {
                    Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}");
                }
            }
        }
        public void GetAllAppointments()
        {
            foreach (var item in appointments)
            {
                Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}");
            }
        }
        public void GetWeeklyAppointments()
        {
            foreach (var item in appointments)
            {
                if (item.StartDate > DateTime.Now.AddDays(-7))
                {
                    Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}");
                }
            }
        }
        public void GetTodaysAppointments()
        {
            foreach (var item in appointments)
            {
                if (item.StartDate==DateTime.Now)
                {
                    Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}");
                }
            }
        }
        public void GetAllContinuingAppointments()
        {
            foreach (var item in appointments)
            {
                if (item.EndDate==null)
                {
                    Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}");
                }
            }


        }

        internal static void EndAppointment()
        {

            throw new NotImplementedException();
        }
    }
}
