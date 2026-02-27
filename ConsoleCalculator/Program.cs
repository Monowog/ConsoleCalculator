// Declare variables and then initialize to zero.
List<string> prevEquations = new List<string>();
List<double> prevAnswers = new List<double>();
bool inUse = true;
double num1 = 0; double num2 = 0;

// Display title as the C# console calculator app.

while(inUse) {
  Console.Clear();
  Console.WriteLine("Console Calculator in C#\r");
  Console.WriteLine("------------------------\n");

  // Ask the user to type the first number.
  Console.WriteLine("Type a number, and then press Enter");
  num1 = Convert.ToDouble(Console.ReadLine());

  // Ask the user to type the second number.
  Console.WriteLine("Type another number, and then press Enter");
  num2 = Convert.ToDouble(Console.ReadLine());

  // Ask the user to choose an option.
  Console.WriteLine("Choose an option from the following list:");
  Console.WriteLine("\ta - Add");
  Console.WriteLine("\ts - Subtract");
  Console.WriteLine("\tm - Multiply");
  Console.WriteLine("\td - Divide");
  Console.Write("Your option? ");

  string equation = string.Empty;

  // Use a switch statement to do the math.
  switch (Console.ReadLine().Trim())
  {
      case "a":
          equation = $"{num1} + {num2} = " + (num1 + num2);
          prevAnswers.Add(num1 + num2);
          break;
      case "s":
          equation = $"{num1} - {num2} = " + (num1 - num2);
          prevAnswers.Add(num1 - num2);
          break;
      case "m":
          equation = $"{num1} * {num2} = " + (num1 * num2);
          prevAnswers.Add(num1 * num2);
          break;
      case "d":
          while(num2 == 0)
          {
            Console.WriteLine("Divisor cannot equal 0. Please input another divisor:");
            num2 = Convert.ToDouble(Console.ReadLine());
          }
          equation = $"{num1} / {num2} = " + (num1 / num2); 
          prevAnswers.Add(num1 / num2);
          break;
      case null:
          Console.WriteLine("Error: Must input an operation type. Press any key to restart.");
          Console.ReadKey();
          continue;
  }

  Console.WriteLine($"Your result: " + equation);
  prevEquations.Add(equation);

  Console.WriteLine("Type [v] to view previous answers,\n[q] to exit,\nor any other key to continue...");
  char reviewInput = Console.ReadKey().KeyChar;
  Console.WriteLine();

  if(reviewInput == 'v')
  {
    int index = 'a';
    foreach (string eq in prevEquations)
    {
      Console.WriteLine($"[{(char)index}]: " + eq);
      index++;
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
  } 
  else if (reviewInput == 'q')
  {
    inUse = false;
  }

}
