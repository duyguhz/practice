using System;
namespace practice
{
    public class Appointment
    {
        public Appointment()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No;
        public string Patient;
        public string Doctor;
        public DateTime StartDate;
        public DateTime EndDate;
        private int _totalCount = 1000;
    }
}
