using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControl
{
    class AccesControl
    {
        bool DoorCondition;
        int DorrNumber;
        int CardRider1;
        int CardRider2;
        int Cardnumber;
        bool ExitButon;
        public AccesControl(int doornumber, bool exitbuton, int cardrider1,int cardrider2)
        {
            DorrNumber = doornumber;
            ExitButon = exitbuton;
            CardRider1 = cardrider1;
            CardRider2 = cardrider2;

        }
        public AccesControl()
        {

        }
        public void  DoorAcces()
        {
            Console.WriteLine("Введите номер двери");
            DorrNumber = Convert.ToInt32(Console.ReadLine());
            DoorCondition = true;
            if (DoorCondition)
            {
                Console.WriteLine("Дверь закрыта");
                Console.WriteLine("Предьявите карту");
                Cardnumber = Convert.ToInt32(Console.ReadLine());
                CardRider1 = Cardnumber;
                if (Cardnumber <= 100)
                {

                    Console.WriteLine($"Дверь:{DorrNumber} открыта");
                }
                else
                {
                    Console.WriteLine($"Дверь:{DorrNumber} закрыта");
                }

            }
            DoorCondition = true;
            if (DoorCondition)
            {
                Console.WriteLine("Нажмите кноку ");

                int exitbuton = Convert.ToInt32(Console.ReadLine());

                if (exitbuton >= 1)
                {
                    exitbuton = 0;
                }
                ExitButon = Convert.ToBoolean(exitbuton);

            }
            ExitButon = true;



            //CardRider1 = Convert.ToInt32(Console.ReadLine());
            //CardRider2 = Convert.ToInt32((Console.ReadLine()));


            if (ExitButon )
            {
                
                //if (CardRider1 == 1)
                //{
                    
                //    Console.WriteLine($"Дверь:{DorrNumber} Открыта  ");
                //}
                //else
                //{
                //    Console.WriteLine($"Дверь{DorrNumber} закрыта");
                //}

               
                Console.WriteLine($"Дверь:{DorrNumber} Открыта  ");

            }
            else
            {
                Console.WriteLine($"Дверь {DorrNumber} закрыта");
            }
           
        }
      
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            AccesControl control = new AccesControl();
            control.DoorAcces();

        }
    }
}
