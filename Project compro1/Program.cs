using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = new double[20];
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Welcome to my calculator\n");
                Console.WriteLine("{0} times\n", (i+1));
                int choice1 = Firststep();
                if (choice1 == 1)
                {
                    int naichoice1 = showup();
                    if (naichoice1 == 1)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("( X + Y )");
                        Console.WriteLine("-----------------------");
                        Console.Write("Enter first number : ");
                        double tua1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} + Y )",tua1);
                        Console.Write("Enter second number : ");
                        double tua2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} + {1} )", tua1,tua2);
                        Console.WriteLine("The answer is {0}", Answer1(tua1, tua2, naichoice1));
                        Console.WriteLine();
                        number[i] = tua1 + tua2;
                    }
                    else if (naichoice1 == 2)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("( X - Y )");
                        Console.WriteLine("-----------------------");
                        Console.Write("Enter first number : ");
                        double tua1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} - Y )",tua1);
                        Console.Write("Enter second number : ");
                        double tua2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} - {1} )",tua1,tua2);
                        Console.WriteLine("The answer is {0}", Answer1(tua1, tua2, naichoice1));
                        Console.WriteLine();
                        number[i] = tua1 - tua2;
                    }
                    else if (naichoice1 == 3)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("( X x Y )");
                        Console.WriteLine("-----------------------");
                        Console.Write("Enter first number : ");
                        double tua1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} x Y )", tua1);
                        Console.Write("Enter second number : ");
                        double tua2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} x {1} )", tua1,tua2);
                        Console.WriteLine("The answer is {0}", Answer1(tua1, tua2, naichoice1));
                        Console.WriteLine();
                        number[i] = tua1 * tua2;
                    }
                    else if (naichoice1 == 4)
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("( X / Y )");
                        Console.WriteLine("-----------------------");
                        Console.Write("Enter first number : ");
                        double tua1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} / Y )", tua1);
                        Console.Write("Enter second number : ");
                        double tua2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("( {0} / {1} )", tua1, tua2);
                        Console.WriteLine("The answer is {0}", Answer1(tua1, tua2, naichoice1));
                        Console.WriteLine();
                        number[i] = tua1 / tua2;
                    }
                    else
                    {
                        Console.WriteLine("***SORRY, PLEASE SELECT ONLY 1-4***");
                        Console.WriteLine();
                    }
                }
                else if (choice1 == 2)
                {
                    int sba = Showup2();
                    int sbb1 = showup3(sba);
                    if (sba == 1)
                    {
                        if (sbb1 == 1)
                        {
                            Console.WriteLine("( X + Y ) + Z");
                            Console.WriteLine("-----------------------");
                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + Y ) + Z",nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) + Z", nb1,nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) + {2}", nb1,nb2,nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " + " + nb2 + " ) + " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine("-----------------------");
                            number[i] = (nb1 + nb2) + nb3;
                        }
                        else if (sbb1 == 2)
                        {
                            Console.WriteLine("( X + Y ) - Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + Y ) - Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) - Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) - {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " + " + nb2 + " ) - " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 + nb2) - nb3;
                        }
                        else if (sbb1 == 3)
                        {
                            Console.WriteLine("( X + Y ) * Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + Y ) * Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) * Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) * {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " + " + nb2 + " ) * " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 + nb2) * nb3;
                        }
                        else if (sbb1 == 4)
                        {
                            Console.WriteLine("( X + Y ) / Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + Y ) / Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) / Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} + {1} ) / {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " + " + nb2 + " ) / " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 + nb2) / nb3;
                        }
                        else
                        {
                            Console.WriteLine("***SORRY, PLEASE SELECT 1-4 IN A AND B ONLY.***");
                            Console.WriteLine();
                        }
                    }
                    else if (sba == 4)
                    {
                        if (sbb1 == 1)
                        {
                            Console.WriteLine("( X / Y ) + Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / Y ) + Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) + Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) + {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " / " + nb2 + " ) + " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 / nb2) + nb3;
                        }
                        else if (sbb1 == 2)
                        {
                            Console.WriteLine("( X / Y ) - Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / Y ) - Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) - Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) - {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " / " + nb2 + " ) - " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 / nb2) - nb3;
                        }
                        else if (sbb1 == 3)
                        {
                            Console.WriteLine("( X / Y ) * Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / Y ) * Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) * Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) * {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " / " + nb2 + " ) * " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 / nb2) * nb3;
                        }
                        else if (sbb1 == 4)
                        {
                            Console.WriteLine("( X / Y ) / Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / Y ) / Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) / Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} / {1} ) / {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " / " + nb2 + " ) / " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 / nb2) / nb3;
                        }
                        else
                        {
                            Console.WriteLine("***SORRY, PLEASE SELECT 1-4 IN A AND B ONLY.***");
                            Console.WriteLine();
                        }
                    }
                    else if (sba == 3)
                    {
                        if (sbb1 == 1)
                        {
                            Console.WriteLine("( X * Y ) + Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * Y ) + Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) + Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) + {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " * " + nb2 + " ) + " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 * nb2) + nb3;
                        }
                        else if (sbb1 == 2)
                        {
                            Console.WriteLine("( X * Y ) - Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * Y ) - Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) - Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) - {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " * " + nb2 + " ) - " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 * nb2) - nb3;
                        }
                        else if (sbb1 == 3)
                        {
                            Console.WriteLine("( X * Y ) * Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * Y ) * Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) * Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) * {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " * " + nb2 + " ) * " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 * nb2) * nb3;
                        }
                        else if (sbb1 == 4)
                        {
                            Console.WriteLine("( X * Y ) / Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * Y ) / Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) / Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} * {1} ) / {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " * " + nb2 + " ) / " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine();
                            number[i] = (nb1 * nb2) / nb3;
                        }
                        else
                        {
                            Console.WriteLine("***SORRY, PLEASE SELECT 1-4 IN A AND B ONLY.***");
                            Console.WriteLine();
                        }
                    }
                    else if (sba == 2)
                    {
                        if (sbb1 == 1)
                        {
                            Console.WriteLine("( X - Y ) + Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - Y ) + Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) + Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) + {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " - " + nb2 + " ) + " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine("-----------------------");
                            number[i] = (nb1 - nb2) + nb3;
                        }
                        else if (sbb1 == 2)
                        {
                            Console.WriteLine("( X - Y ) - Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - Y ) - Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) - Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) - {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " - " + nb2 + " ) - " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine("-----------------------");
                            number[i] = (nb1 - nb2) - nb3;
                        }
                        else if (sbb1 == 3)
                        {
                            Console.WriteLine("( X - Y ) * Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - Y ) * Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) * Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) * {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " - " + nb2 + " ) * " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine("-----------------------");
                            number[i] = (nb1 - nb2) * nb3;
                        }
                        else if (sbb1 == 4)
                        {
                            Console.WriteLine("( X - Y ) / Z");
                            Console.WriteLine("-----------------------");

                            Console.Write("Enter X : ");
                            double nb1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - Y ) / Z", nb1);
                            Console.Write("Enter Y : ");
                            double nb2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) / Z", nb1, nb2);
                            Console.Write("Enter Z : ");
                            double nb3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("( {0} - {1} ) / {2}", nb1, nb2, nb3);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine("( " + nb1 + " - " + nb2 + " ) / " + nb3);
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("The result is : {0}", Answer2(nb1, nb2, nb3, sbb1, sba));
                            Console.WriteLine("-----------------------");
                            number[i] = (nb1 - nb2) / nb3;
                        }
                        else
                        {
                            Console.WriteLine("***SORRY, PLEASE SELECT 1-4 IN A AND B ONLY.***");
                            Console.WriteLine();   
                        }
                    }
                    else
                    {
                        Console.WriteLine("***SORRY, PLEASE SELECT 1-4 IN A AND B ONLY.***");
                        Console.WriteLine();
                    }
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("THANK YOU FOR USING.");
                    Console.WriteLine("All number in treasury");
                    Console.WriteLine();

                    foreach (int t in number)
                    {
                        if (t > 0)
                        {
                            Console.Write(t + " ");
                        }
                        if (t < 0)
                        {
                            Console.Write(t + " ");
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("In treasury can't print 0");
                    break;
                }
                else
                {
                    Console.WriteLine("***SORRY, PLEASE SELECT 1-3 ONLY.***");
                    Console.WriteLine();
                }
                

                string Enter = " ";
                while(Enter != "Enter")
                {
                    Console.WriteLine("Push Enter for continue");
                    Enter = Console.ReadLine();
                }
                Console.Clear();
            }
        }
        public static double Answer1(double tua1, double tua2, int naichoice1)
        {
            double sum = 0;
            switch (naichoice1)
            {
                case 1:
                    sum = tua1 + tua2;
                    break;
                case 2:
                    sum = tua1 - tua2;
                    break;
                case 3:
                    sum = tua1 * tua2;
                    break;
                case 4:
                    sum = tua1 / tua2;
                    break;
                default:
                    break;
            }
            return sum;
        }
       public static double Answer2(double nb1, double nb2, double nb3, int sba, int sbb1)
        {
            double sum = 0;
            if (sbb1 == 1)
            {
                if (sba == 1)
                {
                    sum = (nb1 + nb2) + nb3;
                }
                if (sba == 2)
                {
                    sum = (nb1 + nb2) - nb3;
                }
                if (sba == 3)
                {
                    sum = (nb1 + nb2) * nb3;
                }
                if (sba == 4)
                {
                    sum = (nb1 + nb2) / nb3;
                }
            }
            if (sbb1 == 2)
            {
                if (sba == 1)
                {
                    sum = (nb1 - nb2) + nb3;
                }
                if (sba == 2)
                {
                    sum = (nb1 - nb2) - nb3;
                }
                if (sba == 3)
                {
                    sum = (nb1 - nb2) * nb3;
                }
                if (sba == 4)
                {
                    sum = (nb1 - nb2) / nb3;
                }
            }
            if (sbb1 == 3)
            {
                if (sba == 1)
                {
                    sum = (nb1 * nb2) + nb3;
                }
                if (sba == 2)
                {
                    sum = (nb1 * nb2) - nb3;
                }
                if (sba == 3)
                {
                    sum = (nb1 * nb2) * nb3;
                }
                if (sba == 4)
                {
                    sum = (nb1 * nb2) / nb3;
                }
            }
            if (sbb1 == 4)
            {
                if (sba == 1)
                {
                    sum = (nb1 / nb2) + nb3;
                }
                if (sba == 2)
                {
                    sum = (nb1 / nb2) - nb3;
                }
                if (sba == 3)
                {
                    sum = (nb1 / nb2) * nb3;
                }
                if (sba == 4)
                {
                    sum = (nb1 / nb2) / nb3;
                }
            }
            return sum;
        }
        public static int Firststep()
        {
            string[] showups =
            {
                "1. ( X v Y )",
                "2. ( X v Y ) v Z",
                "3.break",
                "-----------------------"
            };
            foreach (string l in showups)
            {
                Console.WriteLine(l);
            }
            Console.Write("Select choice : ");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            return choice1;
        }
        public static int showup()
        {
            string[] showups =
            {
                "-----------------------",
                "( X v Y )",
                "-----------------------",
                "1. (+)",
                "2. (-)",
                "3. (*)",
                "4. (/)"
            };
            foreach(string l in showups)
            {
                Console.WriteLine(l);
            }
            Console.Write("Select Math Symbols : ");
            int naichoice1 = Convert.ToInt32(Console.ReadLine());
            return naichoice1;
        }
        public static int Showup2()
        {
            string[] showups2 =
            {
                "-----------------------",
                "( X a Y ) b Z",
                "Select Math Symbols (a)",
                "1. (+)",
                "2. (-)",
                "3. (*)",
                "4. (/)",
                "-----------------------"
            };
            foreach (string l in showups2)
            {
                Console.WriteLine(l);
            }
            Console.Write("Select : ");
            int sba = Convert.ToInt32(Console.ReadLine());

            return sba;
        }
        public static int showup3(int i)
        {
            int sbb1 = 0;
            if (i == 1)
            {
                Console.WriteLine("( X + Y ) b Z");
            }
            else if (i == 2)
            {
                Console.WriteLine("( X - Y ) b Z");
            }
            else if (i == 3)
            {
                Console.WriteLine("( X * Y ) b Z");
            }
            else if (i == 4)
            {
                Console.WriteLine("( X / Y ) b Z");
            }
            else
            {
                sbb1 += 5;
                return sbb1;
            }          
            string[] showups3 =
            {
                "Select Math Symbols (b)",
                "-----------------------",
                "1. (+)",
                "2. (-)",
                "3. (*)",
                "4. (/)",
                "-----------------------"
            };
            foreach (string l in showups3)
            {
                Console.WriteLine(l);
            }          
                Console.Write("Select : ");
                sbb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------");
            return sbb1;
        }
    }
}