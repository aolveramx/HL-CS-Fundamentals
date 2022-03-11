Operation mySum = Functions.Sum;
//Console.WriteLine(mySum(2, 3));
mySum = Functions.Mul;
//Console.WriteLine(mySum(2, 3));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola Mundo");
//Functions.Some("John", "Doe", cw);

#region Action

string c = "parámetro externo";

Action<string> showMessage = Console.WriteLine;

Action<string, string, string> showMessageThree = (a, b, c) => Console.WriteLine($"{a} {b} {c}");

Action<string, string> showMessageLambda = (a, b) =>
{
    Console.WriteLine($"{a} {b} {c}");
};

showMessageLambda("Ari", "Olvera");

showMessageThree("A", "R", "I");

Functions.SomeAction("Ari", "Olvera", (a) =>
{
    Console.WriteLine("soy una expresion lambda" + a);
});

//showMessage("parametro");
//Functions.SomeAction("Ari", "Olvera", showMessage);

#endregion|

#region Func
Func<int> randomNumber = () => new Random().Next(0, 100);
Func<int, string> randomNumberLimit = (limit) => new Random().Next(0, limit).ToString();

//Console.WriteLine(randomNumber());
//Console.WriteLine(randomNumberLimit(10));
#endregion

#region Predicate
Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("bear"));
Console.WriteLine(hasSpaceOrA("A entonces True"));

var words = new List<string>()
{
    "Alef",
    "Sernunos",
    "Apis",
    "hola mundo",
    "C#"
};

//var newWords = words.FindAll(hasSpaceOrA);
//foreach(var w in newWords) Console.WriteLine(w);

var newWords = words.FindAll(w => !hasSpaceOrA(w));
foreach (var w in newWords) Console.WriteLine(w);
#endregion

#region Delegates
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string messageTwo);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Callback y cuando termines ejecuta...");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Callback y cuando termines ejecuta...");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }
}