//var r = new Random();
//var favNumber = r.Next(1, 100);
//Console.WriteLine("Can you guess my favorite number?");
//var userInput = int.Parse(Console.ReadLine());

//if (userInput < favNumber)
//{
//    Console.WriteLine("The variable is too low");
//}

//else if (userInput > favNumber)
//{
//    Console.WriteLine("The variable is too high");
//}

//else
//{
//    Console.WriteLine("Good Job! You got it right!");
//}

Console.WriteLine("What is your favorite subject in school?");
string userInput = Console.ReadLine();

switch (userInput.ToLower())
{
    case "science":
        Console.WriteLine("Mine too!");
        break;
    case "math":
        Console.WriteLine("Do you know Pi?");
        break;
    case "english":
        Console.WriteLine("To be or not to be?");
        break;
    case "history":
        Console.WriteLine("Do you know Alexander Hamilton?");
        break;
    case "lunch":
        Console.WriteLine("Food is good!");
        break;
        default: Console.WriteLine("Oh wow! I didn't think of that!");
        break;
}
    

    