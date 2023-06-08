namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your fvorite school subject?");

            var subject = Console.ReadLine();
            {
                switch (subject.ToLower())
                {
                    case "spanish":
                        Console.WriteLine("spanish is awesome");
                        break;
                    default:
                        Console.WriteLine($"ahh i havent taken that before. { subject } sounds great!");
                        break;
               
                }


            }

        }
    }
}