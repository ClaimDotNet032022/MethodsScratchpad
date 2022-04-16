GreetUser();

//int length = ReadlineAsInt("Enter a length:");

//int width = ReadlineAsInt("Enter a width:");

//int height = ReadlineAsInt("Enter a height:");

//int volume = length * width * height;

//Console.WriteLine($"The volume is {volume}");

int[] doSomethingArray = new int[] { 1, 2, 3 };
DoSomething(GetAString(), 42, doSomethingArray);

string theString = GetAString();


int sum = Add(3, 5);
int sum2 = Add(3, 7);
int sum3 = Add(981257, 43195);
int sum4 = Add(3, 5, 7);

int prod = Multiply(3, 5);
int prod2 = Multiply(8, 6, 7, 5, 3, 0, 9);
int prod3 = Multiply(4, 7, 12);


static int Add(int a, int b, int c = 0)
{
    return a + b + c;
}

static int Multiply(int first, int second, params int[] a)
{
    int product = first * second;
    foreach(int element in a)
    {
        product *= element;
    }
    return product;
}



/******************************
 * Main method ends here (where the first
 * other method is defined)
 *****************************/
static int ReadlineAsInt(string prompt)
{
    Console.WriteLine(prompt);
    string lengthString = Console.ReadLine();
    return int.Parse(lengthString);
}

static void GreetUser()
{
    Console.WriteLine("Hello!");
    return;
}

static void DoSomething(string s, int n, int[] arr)
{

}


static string GetAString()
{
    return "Hello, world!";
}