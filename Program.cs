static void Main(string[] args)
{
    int gradecounter = 1;
    int total = 0;
    while (gradecounter <= 500)
    {
        Console.Write("Enter the grade: ");
        Console.Write("Enter the student name: ");
        
        int grade = Convert.ToInt32(Console.ReadLine());
        total = total + grade;
        gradecounter = gradecounter + 100;
    }
    Console.WriteLine("The average of the class is: " + total);
}
