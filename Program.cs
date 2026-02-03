static void PrintInfo()
{
    Console.WriteLine("\nIELTS-meterga xush kelibsiz!\n");
}
static decimal IeltsResult()
{
    decimal balls = 0;
    string[] skills = { "speaking:", "reading:", "listening:", "writing:" };
    Console.WriteLine("IELTS baholarini kiriting:\n");
    for (int i = 0; i < skills.Length; i++)
    {
        decimal ball = 0;
        do
        {
            Console.Write($"{skills[i]} (0-9) ");
            ball = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
        }
        while (ball < 0 || ball > 9);

        balls += ball;
    }
    decimal result = balls / skills.Length;
    return result;
}
PrintInfo();
decimal ieltsBall = IeltsResult();
Console.WriteLine("Sizning EILTS natijangiz:" + ieltsBall);

