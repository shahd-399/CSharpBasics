// See https://aka.ms/new-console-template for more information

#region
#endregion
#region 1-Write a program that allows the user to enter a number then print it.
Console.WriteLine("Enter a Number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);
#endregion

//2-Write C# program that converts a string to an integer, but the string contains non-numeric characters.
//And mention what will happen 
#region 2
string str = "shahd";
int result = int.Parse(str);

//it will give me a FormatException as non-numeric is not in a correct format.
#endregion

#region 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
Console.WriteLine("Enter the first floating-point number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second floating-point number:");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;
double quotient = 0.0;
if (num2 != 0)
    quotient = num1 / num2;
// num2 musn't be zero 

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");

//to make the results = double ==> we must use double dt , and make the 2 nums or one of them double
#endregion


#region 4-	Write C# program that Extract a substring from a given string.
Console.WriteLine("Enter the main string:");
string mainString = Console.ReadLine();

Console.WriteLine("Enter the starting index:");
int startIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the length of the substring:");
int length = Convert.ToInt32(Console.ReadLine());

string substring = mainString.Substring(startIndex, length);
Console.WriteLine($"\nExtracted substring: {substring}");
#endregion


#region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
int firstValue = 10;
int secondValue = firstValue; //secondValue = 10
firstValue = 20;

Console.WriteLine($"Value of firstValue: {firstValue}"); // 20
Console.WriteLine($"Value of secondValue: {secondValue}"); //10

//Modifying firstValue does not impact secondValue since they hold separate copies of the data.
#endregion


#region 6-

//ie we create class and create object from this class obj1 , and create another one obj2
//when assign obj1 to obj2 ,if you modifying in obj1 , obj2 will be the same value
//and if you modifying in obj2 , obj1 will be the same value
#endregion

#region 7-	Write C# program that take two string variables and print them as one variable 
Console.WriteLine("Enter the first string:");
string firstStr = Console.ReadLine();

Console.WriteLine("Enter the second string:");
string secondStr = Console.ReadLine();

string FullString = firstStr + secondStr;
Console.WriteLine(FullString);
#endregion

#region 8-
Console.WriteLine("Enter the principal amount");
double principal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the rate of interest (in %)");
double rate = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time (in years):");
double time = Convert.ToDouble(Console.ReadLine());

double interest = (principal * rate * time) / 100;
Console.WriteLine(interest);

#endregion

#region 9-
Console.WriteLine("Enter your weight in kilograms:");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your height in meters:");
double height = Convert.ToDouble(Console.ReadLine());

double BMI = weight / (height * height);
Console.WriteLine(BMI);
#endregion


#region 10.
Console.WriteLine("Enter the temperature in degrees:");
double temperature = Convert.ToDouble(Console.ReadLine());

string resu = (temperature < 10) ? "Just Cold"
              : (temperature > 30) ? "Just Hot"
              : "Just Good";
Console.WriteLine($"The temperature is: {resu}");

#endregion

#region 11.
Console.WriteLine("Enter the date (dd/MM/yyyy):");
string Date = Console.ReadLine();

DateTime date = DateTime.ParseExact(Date, "dd/MM/yyyy", null);

Console.WriteLine($"Today's date: {date:dd, MM, yyyy}");
Console.WriteLine($"Today's date: {date:dd / MM / yyyy}");
Console.WriteLine($"Today's date: {date:dd – MM – yyyy}");

#endregion

#region 12 : 15
//12.
//a)     The event is on 14/06/2024 

//13.
//f)	A value 1 will be assigned to d.

//14.
//d)	6 1

//15
//d)	7 7



#endregion