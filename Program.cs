/*ATM PROGRAM */
using codechallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


class program
{
    public static void Main()
    {
        int amount = 23960, deposit, withdraw;
        int choice, pin1 = 1234, x = 0;
        Console.WriteLine("Enter Your 4 Digit Pin ");
        int pin = int.Parse(Console.ReadLine());
        ASSESMENTEntities ctx = new ASSESMENTEntities();
        var obj = ctx.ATMs.Where(a => a.PIN == pin).FirstOrDefault();


        if (obj != null)
        { 
            while (true)
        {
            Console.WriteLine("WELCOME TO SANKET ATM SERVICE\n");
            Console.WriteLine("1. Current Balance\n");
            Console.WriteLine("2. Withdraw \n");
            Console.WriteLine("3. Deposit \n");
            Console.WriteLine("4. Cancel \n");
            Console.WriteLine("***************\n\n");
            Console.WriteLine("ENTER YOUR CHOICE : ");
            choice = int.Parse(Console.ReadLine());
            
            
            
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (obj.ACCOUNT_BALANCE - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            obj.ACCOUNT_BALANCE = obj.ACCOUNT_BALANCE - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        obj.ACCOUNT_BALANCE = obj.ACCOUNT_BALANCE + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU…");

                        Environment.Exit(0);
                        break;
                }
            }

        }
        else
        {
            Console.WriteLine("\n\n PIN IS INCORRECT");
        }
        Console.WriteLine("\n\n THANKS FOR USING SANKET ATM SERVICE");
        Console.WriteLine("\n\n VISIT AGAIN");

        //ASSESMENTEntities ctx = new ASSESMENTEntities():
    }
}
//ASSESMENTEntities ctx = new ASSESMENTEntities():
