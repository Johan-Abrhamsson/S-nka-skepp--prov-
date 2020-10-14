using System;

namespace Sänka_skepp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Game = 0;
            Random R = new Random();
            int TargetY = R.Next(1, 10);
            int TargetX = R.Next(1, 10);
            int ChoiseAltX;
            int ChoiseAltY;
            while (Game == 0)
            {
                Console.WriteLine("[Find The enemy!]");
                Console.WriteLine("[Choose a Number Between 1 and 10 for X]");
                string ChoiseX = Console.ReadLine();
                bool SucsessfulX = int.TryParse(ChoiseX, out ChoiseAltX);
                Console.WriteLine("[Choose a Number Between 1 and 10 for Y]");
                string ChoiseY = Console.ReadLine();
                bool SucsessfulY = int.TryParse(ChoiseY, out ChoiseAltY);
                if (!SucsessfulX || ChoiseAltX > 11 || ChoiseAltX < 0)
                {
                    Console.WriteLine("[Sorry sir but you need to try that again for your X number]");
                }
                else if (!SucsessfulY || ChoiseAltY > 11 || ChoiseAltY < 0)
                {
                    Console.WriteLine("[Sorry sir but you need to try that again for your Y number]");
                }
                else if (SucsessfulX)
                {
                    if (SucsessfulY)
                    {
                        if (ChoiseAltY < 11)
                        {
                            if (ChoiseAltY > 0)
                            {
                                if (ChoiseAltX < 11)
                                {
                                    if (ChoiseAltX > 0)
                                    {
                                        if (ChoiseAltX == TargetX && ChoiseAltY == TargetY)
                                        {
                                            Console.WriteLine("FULL HIT!");
                                            Console.WriteLine("YOU WIN");
                                            Game = 1;
                                        }
                                        else if (ChoiseAltX == TargetX && ChoiseAltY > (TargetY - 2) && ChoiseAltY < (TargetY + 2))
                                        {
                                            Console.WriteLine("HIT FOR X");
                                            Console.WriteLine("NEAR FOR Y");
                                        }
                                        else if (ChoiseAltY == TargetY && ChoiseAltX > (TargetX - 2) && ChoiseAltX < (TargetX + 2))
                                        {
                                            Console.WriteLine("HIT FOR Y");
                                            Console.WriteLine("NEAR FOR X");
                                        }
                                        else if (ChoiseAltX > (TargetX - 2) && ChoiseAltX < (TargetX + 2))
                                        {
                                            Console.WriteLine("NEAR MISS FOR X");
                                            if (ChoiseAltY > (TargetY - 2) && ChoiseAltY < (TargetY + 2))
                                            {
                                                Console.WriteLine("NEAR MISS FOR Y");
                                            }
                                            else if (ChoiseAltY == TargetY)
                                            {
                                                Console.WriteLine("HIT FOR Y");
                                            }
                                            else
                                            {
                                                Console.WriteLine("MISS FOR Y");
                                            }
                                        }
                                        else if (ChoiseAltY > (TargetY - 2) && ChoiseAltY < (TargetY + 2))
                                        {
                                            Console.WriteLine("NEAR MISS FOR Y");
                                            if (ChoiseAltY > (TargetX - 2) && ChoiseAltX < (TargetX + 2))
                                            {
                                                Console.WriteLine("NEAR MISS FOR X");
                                            }
                                            else if (ChoiseAltX == TargetX)
                                            {
                                                Console.WriteLine("HIT FOR X");
                                            }
                                            else
                                            {
                                                Console.WriteLine("MISS FOR X");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("FULL MISS");

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
