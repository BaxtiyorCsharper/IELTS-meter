decimal balls = 0;
Console.WriteLine("\nIELTS-meterga xush kelibsiz!\n");
string [] skills = {"speaking:","reading:","listening:","writing:"};
Console.WriteLine("IELTS baholarini kiriting:\n");
for (int i = 0; i < skills.Length; i++)
{
    Console.Write(skills[i]);
    decimal ball = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine();
    if (ball >= 0 && ball <= 9)
    {
        balls += ball;
    }
    else
    {
        Console.WriteLine("\nxato kiritildi:\n");
    }
}
decimal result = balls / skills.Length;
Console.WriteLine("Sizning EILTS natijangiz:"+result);