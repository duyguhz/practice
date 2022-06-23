using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            Appointment app1 = new Appointment()
            {
                No=1001,
                Patient = "zakir",
                Doctor = "qaracuxurlu",

            };
            Appointment app2 = new Appointment()
            {
                No=1002,
                Patient = "zehra",
                Doctor = "hesenli"
            };
            do
            {
                Hospital appointmentz = new Hospital();
                
                Console.WriteLine("1.Appointment yarat");
                Console.WriteLine("2.Appointment-i bitir");
                Console.WriteLine("3.Bütün appointment-lərə bax");
                Console.WriteLine("4. Bu həftəki appointment-lərə bax");
                Console.WriteLine("5. Bugünki appointment-lərə bax");
                Console.WriteLine("6.Bitməmiş appointmentlərə bax");
                Console.WriteLine("7.Menudan cix");
              
               
                do
                {
                    Console.WriteLine("Seciminizi daxil edin:");
                    option  = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(option) );

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Appointmentin nomresini daxil edin:");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);
                        Console.WriteLine("Appointmentdeki xestenin adini daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Hekimin adini daxil edin:");
                        string docName = Console.ReadLine();
                        Appointment app = new Appointment()
                        {
                            No = no,
                            Patient = name,
                            Doctor = docName
                        };
                        appointmentz.AddAppointment(app);
                        Console.WriteLine("Appointment elave olundu!!");
                        break;
                    case "2":

                        Console.WriteLine("Nomreni daxil edin:");
                        string numberStr = Console.ReadLine();
                        int number = Convert.ToInt32(numberStr);
                      
                        appointmentz.EndAppointment(number);

                        break;
                    case "3":

                        appointmentz.GetAllAppointments();
                        break;
                    case "4":

                        appointmentz.GetWeeklyAppointments();
                        break;
                    case "5":
                        appointmentz.GetTodaysAppointments();
                        break;
                    case "6":
                        appointmentz.GetAllContinuingAppointments();
                        break;

                    default:
                        break;
                }
            } while (option!="7");
           

        }
        
           
        }

    }

