using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehaviorOfClassAndConstructor.BL;

namespace BehaviorOfClassAndConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // t1();
            // t2();
            // t3();
            // t4();
            // t5();
            // t6();
            // t7();
            // t8();
            // t9();
            // t10();
            // t11();
            // t12();
            // challenge1();
            // challenge2();
        }

        static void t1()
        {
            student s = new student();
            Console.WriteLine(s.sname);
            Console.WriteLine(s.matricMarks);
            Console.WriteLine(s.fscMarks);
            Console.WriteLine(s.ecatMarks);
            Console.WriteLine(s.aggregate);
            Console.ReadKey();
        }
        static void t2()
        {
            student s = new student();
            Console.ReadKey();
        }
        static void t3()
        {
            stdent s = new stdent();
            Console.Write(s.sname);
            Console.ReadKey();
        }
        static void t4()
        {
            assessH s1 = new assessH();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.ReadKey();
        }
        static void t5()
        {
            assessH s1 = new assessH();
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Console.WriteLine();

            assessH s2 = new assessH();
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);

            Console.ReadKey();
        }
        static void t6()
        {
            student s1 = new student("BILAL");
            Console.WriteLine(s1.sname);

            student s2 = new student("ALI");
            Console.WriteLine(s2.sname);
            Console.ReadKey();
        }
        static void t7()
        {
            stdent s1 = new stdent("Bilal", 985F, 1050F, 175F, 3.24F);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.ReadKey();

        }
        static void t8()
        {
            stdent s1 = new stdent("Bilal", 985F, 1050F, 175F, 3.24F);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.fscMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);

            Console.WriteLine();

            stdent s2 = new stdent("Bilal", 985F, 1050F, 175F, 3.24F);
            Console.WriteLine(s2.sname);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.fscMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);

            Console.ReadKey();

        }
        static void t9()
        {
            student s1 = new student();
            Console.WriteLine();
            s1.sname = "Bilal";
            student s2 = new student(s1);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);
            Console.ReadKey();

        }
        static void t10()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();

        }
        static void t11()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();

        }
        static void t12()
        {

            //              Default Constructor

            clockType emptyTime = new clockType();
            Console.Write("Empty Time");
            emptyTime.printTime();

            //              Parametric Constructor (Hour)

            clockType hour = new clockType(8);
            Console.Write("Hour TIme: ");
            hour.printTime();

            //              Parametric Constructor (Hour, Minute)

            clockType min = new clockType(8, 10);
            Console.Write("Minute TIme: ");
            min.printTime();

            //              Parametric Constructor (Hour, Minute, Second)

            clockType fullTime = new clockType(8, 10, 10);
            Console.Write("Full TIme: ");
            fullTime.printTime();

            //             Icrement Hours

            fullTime.incrementHour();
            Console.Write("Full Time (Increment Hours): ");
            fullTime.printTime();

            //             Icrement Seconds

            fullTime.incrementSecond();
            Console.Write("Full Time (Increment Seconds): ");
            fullTime.printTime();

            //             Icrement Seconds

            fullTime.incrementMinute();
            Console.Write("Full Time (Increment Minutes): ");
            fullTime.printTime();

            //             Check if Equal 

            bool flag = fullTime.isEqual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);

            //             Check if Equal 

            clockType cmp = new clockType(10, 12, 1);
            flag = fullTime.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);

            Console.ReadKey();
        
        }

        //                 Challenge 1

        static void challenge1()
        {
            //      Elapse Time

            clockType2 fullTime = new clockType2(23, 9, 59);
            Console.Write("Full Time: ");
            fullTime.timeP();
            Console.WriteLine();
            int result = fullTime.sec();
            int elapseT = result - 0;
            
            Console.WriteLine();
            Console.WriteLine("Elapse Time In Seconds = " + elapseT + "s");
            Console.Write("Elapse Time In Hours : Minutes : Seconds = ");
            calculate(elapseT);

            //         Remaining Time

            int result1 = fullTime.sec();
            int hours = 24 * 3600;
            int remainingT = hours - result1;
            
            Console.WriteLine();
            Console.WriteLine("Remaining Time In Seconds = " + remainingT + "s");
            Console.Write("Remaining Time In Hours : Minutes : Seconds = ");
            calculate(remainingT);

            //         Diffenrence in Time     

            Console.WriteLine();
            clockType2 time1 = new clockType2(23, 9, 59);
            Console.Write("Full Time: ");
            time1.timeP();

            Console.WriteLine();

            clockType2 time2 = new clockType2(9, 9, 0);
            Console.Write("Full Time: ");
            time2.timeP();
            Console.WriteLine();
            int result2 = time1.sec();
            int result3 = time2.sec();
            int finalResult = result2 - result3;
            
            Console.WriteLine();
            Console.WriteLine("Difference Time In Seconds = " + finalResult + "s");
            Console.Write("Difference Time In Hours : Minutes : Seconds = ");
            calculate(finalResult);

            Console.ReadKey();
        }
   
        static void calculate(int finalResult)
        {
            int temp = finalResult % 3600;
            int resultH = finalResult / 3600;
            int resultM = temp / 60;
            int resultS = temp % 60;
           
            Console.WriteLine(resultH + ":" + resultM + ":" + resultS);
            if (finalResult <= 0)
            {
                finalResult = finalResult * -1;
                resultH = resultH * -1;
                resultM = resultM * -1;
                resultS = resultS * -1;
            }
        }
       
        //                 Challenge 2

        static void challenge2()
        {
            int choice=0;

            List<product> p = new List<product>();

            while (choice != 6)
            {
                choice = menu();
                if (choice == 1)
                {
                    Console.Clear();
                    product s = new product();
                    Console.Write("ENter name of Product: ");
                    s.name = Console.ReadLine();
                    Console.Write("ENter category: ");
                    s.category = Console.ReadLine();
                    Console.Write("ENter Price: ");
                    s.price = int.Parse(Console.ReadLine());
                    Console.Write("ENter Quantity: ");
                    s.quantityS = int.Parse(Console.ReadLine());
                    Console.Write("ENter Minmum: ");
                    s.quantityM = int.Parse(Console.ReadLine());
                    p.Add(s);

                }
                if (choice == 2)
                {
                    Console.Clear();
                    for (int x = 0; x < p.Count; x++)
                    {
                        Console.WriteLine("Product Name: " + p[x].name);
                        Console.WriteLine("Category: " + p[x].category);
                        Console.WriteLine("Price: " + p[x].price);
                        Console.WriteLine("Stock Quantity: " + p[x].quantityS);
                        Console.WriteLine();
                    }


                    Console.ReadKey();
                }
                if (choice == 3)
                {
                    Console.Clear();
                    product s = new product();
                    string highest = s.highest(p);
                    Console.WriteLine("Product with Highest Unit Price: " + highest);
                    Console.ReadKey();
                }
                if (choice == 4)
                {
                    float taxes;
                    Console.Clear();
                    for (int x=0; x <p.Count; x++)
                    {
                        product s = new product();
                        taxes = s.taxPrice(p[x]);
                        Console.WriteLine(" Tax Price is: " + taxes);

                    }
                    Console.ReadKey();
                }
                if (choice == 5)
                {
                    Console.Clear();
                    string ordered;
                    for (int x = 0; x < p.Count; x++)
                    {
                        product s = new product();
                        ordered = s.ord(p[x]);
                        if (ordered != " ")
                        {
                            Console.WriteLine("You want to order a product " +  ordered);
                        }
                        
                    }
                    Console.ReadKey();
                }
                
            }
        }
        static int menu()
        {
            int choice;
            Console.Clear();
            Console.WriteLine(" 1. Add Product: ");
            Console.WriteLine(" 2. View All Product: ");
            Console.WriteLine(" 3. Find Product with Highest Unit Price: ");
            Console.WriteLine(" 4. View sales tax of all Product: ");
            Console.WriteLine(" 5. Products to be Order: ");
            Console.WriteLine(" Enter Your Choice: ");            
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
 