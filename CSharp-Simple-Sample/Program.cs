class Program
{
    static void Main(string[] args)
    {
        // if-else conditional structure
        int age = 20;
        if (age >= 18)
        {
            Console.WriteLine("Of legal age");
        }
        else
        {
            Console.WriteLine("Minor");
        }

        // Switch control structure
        char grade = 'B';
        switch (grade)
        {
            case 'A':
                Console.WriteLine("Great");
                break;
            case 'B':
                Console.WriteLine("Good");
                break;
            case 'C':
                Console.WriteLine("Regular");
                break;
            default:
                Console.WriteLine("Invalid note");
                break;
        }

        // for repetition structure
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Score: {i}");
        }
    }
}
