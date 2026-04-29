/*
* Jorge Ortiz
* CPT 244 - A01H
* Lab Queues
*/
using System;
namespace dmvprogram
{
    public class Ticket
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Reason { get; set; }
    }
    class DMVProgram
    {
        static void Main()
        {
            Queue < Ticket > dmvTickets = new Queue<Ticket>();
            string userInput = "";
            string menu = "Commands: Add, Next,Exit";
            int count = 0;
            while(userInput.ToUpper() != "EXIT")//2
            {
                string name = "";//1
                DateTime dob;//1
                string reason = "";//1

                Console.WriteLine(menu);//1
                userInput = Console.ReadLine();//1
                if (userInput.ToUpper()=="ADD")//2
                { 
                    Console.WriteLine("Please enter your name: ");//1
                    name = Console.ReadLine();//1
                    Console.WriteLine("Please the reason for your visit: ");//1
                    reason = Console.ReadLine();//1
                    Console.WriteLine("Please enter your DOB(yyyy-mm-dd hh:mm:ss): ");//1
                    if (DateTime.TryParse(Console.ReadLine(), out dob))//4
                    {
                        //adding to queue
                        dmvTickets.Enqueue(new Ticket { Name = name, DOB = dob, Reason = reason });//1
                        count++;//1
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter Dob in (yyyy-mm-dd hh:mm:ss) format");//1
                    }//end if
                }
                else if(userInput.ToUpper()=="NEXT")//2
                {
                    if (dmvTickets.TryPeek(out Ticket next))//3
                    {
                        Console.WriteLine($"The next person in queue is: {next.Name}");//1
                    }
                    else 
                    {
                        Console.WriteLine("No one up next. You can be the first!");//1
                    }
                }//end if

                //dequeues every 2 adds
                if (count > 3)//2
                {
                    dmvTickets.Dequeue();//1
                }
                else if (count == count + 2)//2
                {
                    dmvTickets.Dequeue();//1
                }//endif

            }//end while
        }
    }
    
}


  