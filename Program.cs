using System;

namespace IeltsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IeltsMeter meter = new IeltsMeter();
                meter.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Umumiy xatolik: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nDastur yakunlandi.");
            }
        }
    }

    class IeltsMeter
    {
        public void Start()
        {
            PrintInfo();
            decimal result = CalculateIeltsResult();
            Console.WriteLine("Sizning IELTS natijangiz: " + result);
        }

        private void PrintInfo()
        {
            Console.WriteLine("\nIELTS-meterga xush kelibsiz!\n");
        }

        private decimal CalculateIeltsResult()
        {
            decimal totalBalls = 0;
            string[] skills = { "Speaking", "Reading", "Listening", "Writing" };

            Console.WriteLine("IELTS baholarini kiriting:\n");

            for (int i = 0; i < skills.Length; i++)
            {
                decimal ball = 0;

                while (true)
                {
                    try
                    {
                        Console.Write($"{skills[i]} (0-9): ");
                        ball = Convert.ToDecimal(Console.ReadLine());

                        if (ball < 0 || ball > 9)
                        {
                            Console.WriteLine("Ball 0 dan 9 gacha bo‘lishi kerak!");
                            continue;
                        }

                        break; // to‘g‘ri qiymat kiritildi
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Noto‘g‘ri format! Iltimos son kiriting.");
                    }
                }

                totalBalls += ball;
                Console.WriteLine();
            }

            return totalBalls / skills.Length;
        }
    }
}
