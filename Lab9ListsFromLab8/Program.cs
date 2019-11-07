using System;
using System.Collections.Generic;

namespace Lab9ListsFromLab8
{
    class Program
    {

        //Task: Improve your student information system from the previous lab by using a
        //collection.
        //Build Specifications
        //● Refactor your code to use Lists rather than arrays.
        //● Add another list to store another piece of information(so perhaps favorite color or
        //favorite number) about each student.Update your validation to allow the user to
        //select that third piece of information.
        //● Each iteration of the loop, ask first if they’d like to find out info about a student or
        //add another student. If they choose to add another student, get the name and each
        //piece of info and add them to the end of the list.Validate input--don’t accept blanks
        //for any of the questions.
        //Extended Exercises
        //● Create the original lists in alphabetical order by student name.When a user adds a
        //new student, insert them at the correct location alphabetically.Remember to put
        //the information about a particular student at the same index in each list!
        //● If you already know about creating classes, go back and rewrite this:
        //o Make a StudentInfo class with name and other info(hometown, food,
        //whatever you chose) as data members.
        //o Use a single List of StudentInfo instances to store the information.

        public static string GetNonEmptyString()
        {
            bool hasAValidString = false;
            string ValidString = "";
   
            while (hasAValidString == false)
            {
                string input = Console.ReadLine();
                
                if(input != "")
                {
                    hasAValidString = true;
                    ValidString = input;  //
                }
                else  //IF INPUT IS EMPTY
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
            }
            return ValidString;
        }



        static void Main(string[] args)
        {

            List<string> colors = new List<string>() { "red", "green", "blue" };
            List<string> name = new List<string>() { "Michele", "Elena", "Mary" };
            List<string> job = new List<string>() { "OT", "HR Generalist", "Snack Shack Attendant" };
            List<string> course = new List<string>() { "Physics", "Science", "Math" };

            List<string> color = new List<string>();
            color.Add("orange");
            color.Add("yellow");
            color.Add("blue");

            string response = "yes";  //NEED A YES -- OR OTHER VARIABLE NAME -- FOR THE LOOP TO CONTINUE DOWN TO THE WHILE
            while (response == "yes")  //NEED A YES FOR THE LOOP TO CONTINUE
            {
                Console.WriteLine($"Welcome to our C# class. Which student would you like to learn more about Choose 0 - {name.Count - 1}? Type 'add' to add a new student.");  // name.Count increases up to new student

                try
                {
                    string userInput = Console.ReadLine();
                    if (userInput == "add")
                    {
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.WriteLine("What is the student's name?"); // BOOL LOOP
                            string newName = Console.ReadLine();         
                            if (newName == "")
                            {
                                Console.WriteLine("that was not correct");
                            }
                            else
                            {
                                repeat = false;
                            }
                        


                          Console.WriteLine("What is their favorite color?");  // BOOL LOOP
                          string newColor = Console.ReadLine();
                            if (newColor == "")
                            {
                                Console.WriteLine("that was not correct");
                            }
                            else
                            {
                                repeat = false;
                            }

                            Console.WriteLine("What course are they taking?");  //METHOD
                            string newCourse = GetNonEmptyString();


                            Console.WriteLine("What is their job?"); // METHOD
                            string newJob = GetNonEmptyString();

                            name.Add(newName);
                            color.Add(newColor);
                            course.Add(newCourse);
                            job.Add(newJob);
                        }
                    }
                    else  // ELSE USER ENTERED A NUMBER
                    {
                        int input = int.Parse(userInput);

                        Console.WriteLine($"Student {userInput} is {name[input]}. What would you like to know about {name[input]}? (enter job or course or color): "); 
                        string otherinfo = Console.ReadLine();

                        if (otherinfo == "job")
                        {
                            Console.WriteLine($"{name[input]} is a {job[input]}.");
                        }
                        else if (otherinfo == "course")
                        {
                            Console.WriteLine($"{name[input]} is taking a course in {course[input]}");
                        }
                        else if (otherinfo == "color")
                        {
                            Console.WriteLine($"{name[input]}'s favorite color is {color[input]}");
                        }
                        else
                        {
                            throw new Exception("That input is incorrect. Please input 'job' or 'course'"); // USE AS A 'CATCH-ALL' FOR ANYTHING OTHER THAN 'JOB' OR 'COURSE'
                        }

                        Console.WriteLine($"Would you like to learn more about {name[input]} or another student? (Enter 'yes' or 'no') ");
                        response = Console.ReadLine();

                        if (response == "yes")
                        {
                            Console.WriteLine("Ok.");
                        }

                        else if (response == "no")
                        {
                            Console.WriteLine("Thank you for your inquiries. Goodbye.");
                        }
                        else
                        {
                            throw new Exception(); // USE AS A "CATCH-ALL" FOR ANYTHING OTHER THAN YES OR NO HERE (catch (Exception))
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)  // IF NUMBER OTHER THAN 0 - 2  // IF NUMBER OUT OF RANGE - CHANGED FROM LAB 8 FROM IndexOutOfRangeException FOR ARRAYS
                {
                    Console.WriteLine("That student does not exist. Please try again. ");
                }
                catch (FormatException) // IF ANYTHING OTHER THAN AN INT
                {
                    Console.WriteLine("That data does not exist. You must use a student number from 0 - 2. Please try again.");
                }
                catch (Exception)  // FROM 'THROW NEW EXCEPTION' ABOVE AS A KIND OF CATCH ALL
                {
                    Console.WriteLine("Incorrect input. Answers are case sensitive and must be spelled exactly as specified. Please start over.");
                    response = "yes";  // THE 'YES' FORCES THE EXCEPTION TO LOOP BACK TO THE BEGINNING
                }
            }  // WHILE LOOP ENDS HERE
        }
    }
}

