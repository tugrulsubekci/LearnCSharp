﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            // Hello, World!
            Console.WriteLine("Hello, World!");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // ASCII art with C#
            Console.WriteLine(" c_     ___");
            Console.WriteLine("    \\\\__|__|__");
            Console.WriteLine("      \\( o_o)");
            Console.WriteLine("       > ~  >");
            Console.WriteLine("　　　/ 　 / \\\\");
            Console.WriteLine("　　 /　　/　 \\\\");
            Console.WriteLine("　　 \\　 )　　c/");
            Console.WriteLine("    /　 /");
            Console.WriteLine("　 /　/|");
            Console.WriteLine("　(　( \\");
            Console.WriteLine("　|　|  \\");
            Console.WriteLine("　| / \\  )");
            Console.WriteLine("　| |　) |");
            Console.WriteLine(" /  )(_/");
            Console.WriteLine("(_ /");
            Console.WriteLine("DANCING MAN");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // DATA TYPES AND VARIABLES

            // Integers
            int evenNumber = 22;
            int oddNumber = 45;
            Console.WriteLine(evenNumber + oddNumber); // Prints 67
            Console.WriteLine(oddNumber - evenNumber); // Prints 23
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // information about a dog
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            
            // Convert string to integer
            Console.WriteLine("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(faveNumber);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // BASIC CALCULATIONS

            // Calculating Net Income 
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;

            Console.WriteLine(netIncome);

            // Calculating a Break-Even Point
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // ARITMETIC OPERATORS: +-*/ (JUPITER AGE EXAMPLE)

            // Your Age
            int userAge = 25;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // OPERATOR SHORTCUTS: += , ++ , --

            // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // MODULO: % (Break up your students into teams)

            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 3;

            // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // BUILT-IN METHODS: Math.Abs() etc.

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

            double number_One = 6.5;
            double number_Two = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(number_One, number_Two));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(number_One));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(number_One, number_Two));
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // BUILDING STRINGS

            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";

            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine();
            Console.WriteLine(firstSpeech);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // STRING CONCATENATION

            // Declare the variables
            string beginning = "bir varmis";
            string middle = "bir yokmus";
            string end = "iki varmis";

            // Concatenate the string and the variables
            string story = beginning + " " + middle + " " + end;

            // Print the story to the console 
            Console.WriteLine(story);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // STRING INTERPOLATION

            // Declare the variables
            string beginning1 = "Once upon a time,";
            string middle1 = "The kid climbed a tree";
            string end1 = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story1 = $"{beginning1} {middle1} {end1}";

            // Print the story to the console 
            Console.WriteLine(story1);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // STRING LENGTH AND INDEX OF

            // create a password
            string password = "Asd123**";

            // get password length
            int passwordLength = password.Length;

            // check if password uses symbols
            int passwordCheck = password.IndexOf("1");

            // print the results
            Console.WriteLine($"My password is {password} and my password length is {passwordLength} and it receives a {passwordCheck} check.");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // SOME BUILT-IN METHODS FOR STRINGS

            // dna strand
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // start point and stop point variables
            int startPoint = 0;
            int stopPoint = tga + 3;

            // define final strand
            string dna = startStrand.Substring(startPoint, stopPoint);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[6]);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // A SCRIPT WORK

            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine(cameraDirections);
            Console.WriteLine(sceneDescription);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // LOGIC IN C# (Boolean Data Types)

            // True or False: The number 500 is greater than 24.
            bool answerOne = true;

            // True or False: “coffee” contains the letter “a”.
            bool answerTwo = false;
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Comporison Operators

            /* You are driving to your family’s house for a holiday and want to see 
                  if you’ll get there before dinner. Dinner will begin at 6:00 PM and the 
                  house is 95 miles away. If you leave at 2:00PM and drive an average of 
                  30 miles per hour, will you get there early (before 6:00pm)? */

            // constants for calculations
            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;

            // calculations
            double tripDuration = distance / rate;
            bool answer = (tripDuration <= timeToDinner);

            // print the result
            Console.WriteLine(answer);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // LOGİCAL OPERATORS

            bool answer1 = (5 > 3 && 1 < 2);
            Console.WriteLine(answer1);

            bool answer2 = (2 < 1 || 1 > 0);
            Console.WriteLine(answer2);

            bool answer3 = !(5 < 3);
            Console.WriteLine(answer3);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // We can create a decision with logical operators and booleans
            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;

            bool tripDecision = yourNeeds && friendNeeds;

            Console.WriteLine(tripDecision);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            //CONDITIONAL STATEMENTS

            int socks = 2;
            if (socks <= 3)
            {
                Console.WriteLine("Time to do laundry!");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // using of ELSE statement
            int people = 12;
            string weather = "bad";
            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // using of ELSE IF statement
            int guests = 0;
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            else if (guests >= 1)
            {
                Console.WriteLine("Innovation");
            }
            else
            {
                Console.WriteLine("Solitaire");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Switch Statements (Movie Recommender Example)

            Console.WriteLine("Genres:\n-Drama\n-Comedy\n-Adventure\n-Horror\n-Science Fiction\nWrite a genre for a movie recommendation: ");
            string genre = Console.ReadLine();
            genre = genre.ToUpper();
            switch (genre)
            {
                case "DRAMA":
                    Console.WriteLine("Citizen Kane");
                    break;

                case "COMEDY":
                    Console.WriteLine("Duck Soup");
                    break;

                case "ADVENTURE":
                    Console.WriteLine("King Kong");
                    break;

                case "HORROR":
                    Console.WriteLine("Psycho");
                    break;

                case "SCİENCE FİCTİON":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;

                default:
                    Console.WriteLine("No movie found");
                    break;
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Ternary Operators

            int pepperLength = 1;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
            Console.WriteLine(message);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // CALL A METHOD

            // Math.Min() & Console.WriteLine() & Substring() 
            string msg = "Yabba dabba doo!";
            Math.Min(10, 15);
            Console.WriteLine(msg);
            msg.Substring(0, 1);

            // IndexOf()
            string designer = "Anders Hejlsberg";
            int indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace);
            Console.WriteLine(secondName);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // My First Method
            VisitPlanets(3);
            VisitPlanets(4);
            VisitPlanets(5);
            VisitPlanets();
            VisitPlanets(numberOfPlanets: 12, name: "Ahsen");
            VisitPlanets(8, "xxxx");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            //My Second Method
            string a = "aykut";
            string b = "aynur";
            string c = "hera";
            NamePets();
            NamePets(a, b);
            NamePets(a, b, c);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // DecoratePlanet() example of method
            string x = DecoratePlanet("Jupiter");
            Console.WriteLine(x);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // Int32.TryParse(string s,out int result)
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;
            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);
            int nameAsInt;
            bool outcome2;
            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // method: whisper
            bool shit;
            Console.WriteLine(Whisper("GARRRRR", out shit));
            Console.WriteLine(shit);
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // to keep console open
            Console.ReadLine();
        }
        // My First Method
        static void VisitPlanets(int numberOfPlanets = 0, string name = "Tugrul")
        {
            Console.WriteLine($"Welcome {name}! You visited {numberOfPlanets} new planets…");
        }
        // My Second Method with OVERLOADS
        static void NamePets(string a, string b)
        {
            Console.WriteLine($"Your pets {a} and {b} will be joining your voyage across space!");
        }
        static void NamePets(string a, string b, string c)
        {
            Console.WriteLine($"Your pets {a}, {b}, and {c} will be joining your voyage across space!");
        }
        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
        // DecoratePlanet() example of method
        static string DecoratePlanet(string a)
        {
            return $"*.*.* Welcome to {a} *.*.*";
        }
        // method: whisper
        static string Whisper(string s, out bool b)
        {
            b = true;
            s = s.ToLower();
            return s;
        }
    }
}
