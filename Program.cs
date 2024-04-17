static void Main(string[] args)
{
    int gradecounter = 1;
    int total = 0;
    while (gradecounter <= 5)
    {
        Console.Write("Enter the grade: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        total = total + grade;
        gradecounter = gradecounter + 1;
    }
    Console.WriteLine("The average of the class is: " + total);
}