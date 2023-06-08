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
                        Console.WriteLine("Spanish is great i am trying to learn my self. ");
                        break;
                    case "math":
                        Console.WriteLine("Math is a fascinating subject that requires logic and problem-solving skills.");
                        break;
                    case "science":
                        Console.WriteLine("Science helps us understand the natural world and fuels curiosity and discovery.");
                        break;
                    case "history":
                        Console.WriteLine("History allows us to learn from the past and gain insights into civilization.");
                        break;
                    case "english":
                        Console.WriteLine("English is awesome it enhances our communication skills and nurtures creativity through literature.");
                        break;
                    case "art":
                        Console.WriteLine("Art is a wonderful medium of self-expression and allows us to explore our imagination.");
                        break;
                   
                    default:
                        Console.WriteLine($"Ahh i havent taken that before. { subject } sounds great!");
                        break;
               
                }


            }

        }
    }
}