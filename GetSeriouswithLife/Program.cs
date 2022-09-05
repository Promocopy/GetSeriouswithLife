using System.Reflection.Emit;

namespace ctor
{

     public class program
    {
        //Assignment Operators-----  = .
        //Arithemetic Operators------ +,-,*,/,% .
        // comparison Operator ---- == - equal to, != - not equal to, =>, >, <, <=,
        // Conditional operators----- && - And , || - Or.
        //Tenary Operator ---- ?

        private static void Main()
        {
            //int b = 7;
            //int c = 5;


            //if (b == 7 && c == 5)
            {
            //int d = b + c;

            //bool isb7 = b == 7 ? true:false;
            //int cod= b == 7 ? 15 : b; 


               // Console.WriteLine("they are correct");
            }

            //else
            {
                //Console.WriteLine("they're not correct");
            }

            //Console.WriteLine("please select 1 to 5");
            //int userchoice= int.Parse(Console.ReadLine());

            //if (userchoice == 1 || userchoice ==2 || userchoice==3 || userchoice==4 || userchoice==5)
            {
                //Console.WriteLine("your choice {0} is correct" , userchoice);
            }
           //else if (userchoice == 2) 
            {
                //Console.WriteLine("your choice {0} is correct", userchoice);
            }
           // else if (userchoice == 3)
            {
                //Console.WriteLine("your choice {0} is correct", userchoice);
            }
            //else if (userchoice == 4)
            {
                //Console.WriteLine("your choice {0} is correct", userchoice);
            }
            //else if (userchoice == 5)
            {
                //Console.WriteLine("your choice {0} is correct", userchoice);
            }

            //else
            {
               // Console.WriteLine("your choice {0} is incorrect" , userchoice);
            }


            //switch(userchoice)
            {
              //case 1:
                    //Console.WriteLine("your coice {0} is correct", userchoice);
                   // break;
             // case 2:
                    //Console.WriteLine("your coice {0} is correct", userchoice);
                    //break;
              //case 3:
                    //Console.WriteLine("your coice {0} is correct", userchoice);
                    //break;
              //case 4:
                    //Console.WriteLine("your coice {0} is correct", userchoice);
                   // break;
              //case 5:
                    //Console.WriteLine("your coice {0} is correct", userchoice);
                    //break;
              //default: 
                    //Console.WriteLine("your choice {0} {1} is incorrect" , userchoice, totalamount);
                    //break ;
            }

            int totalamount = 0;

            
            Start:

            Console.WriteLine("select your choice of fish 1 ....small, 2 .... medium, 3 ... large");
            int Userchoice = int.Parse(Console.ReadLine());

            switch(Userchoice)
            {
                case 1:
                    totalamount += 10000;
                    break;
                case 2: 
                    totalamount += 13000;
                    break;
                case 3:
                    totalamount += 15000;
                    break;
                default :
                    Console.WriteLine ("your choice {0} is invalid" , Userchoice);
                    goto Start;
                
            }

            Console.WriteLine("do you want to buy again yes or no");
            string userdecision =Console.ReadLine();

            confirm:
            switch(userdecision)
            {
                case "yes":
                    goto Start;
                case "no": 
                    break;
                default:
                    Console.WriteLine ("your choice {0} is invalid",userdecision);
                    goto confirm;
            }



            Console.WriteLine("Thank You for shopping with us");
            Console.WriteLine("Your bill is {0}", totalamount); 

        }

        //statement
        // i.conditional statement
        public static void Statement ()
        {
            Console.WriteLine("please state Yes or No");
        }
    }
}