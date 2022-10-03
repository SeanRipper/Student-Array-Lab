namespace Array_Storing_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool another = true;
            while (another == true)
            {
                Console.WriteLine("Please input a number from 1 to 5");
                int input = int.Parse(Console.ReadLine());
                int index = input - 1;
                string[] students = { "Sean", "Ryan", "Dylan", "Liam", "Rone" };
                string[] hometowns = { "Detroit", "Atlanta", "Chicago", "New York", "Cleveland" };
                string[] favfoods = { "Pizza", "Salmon", "Hamburgers", "Gyros", "Spicy Chicken Sandwich" };
                if (input < 1 || input > students.Length)
                {
                    Console.WriteLine("Please enter a valid number (1-5)");
                    another = true;
                }
                else
                {
                    Console.WriteLine(students[index]);
                    bool horf = true;
                    while (horf == true)
                    {
                        Console.WriteLine("Would you like to know their 'hometown' or 'favorite food'? (h or f respectively)");
                        string reply2 = Console.ReadLine().ToLower();
                        if (reply2 == "h")
                        {
                            Console.WriteLine(hometowns[index]);
                            horf = false;
                        }
                        else if (reply2 == "f")
                        {
                            Console.WriteLine(favfoods[index]);
                            horf = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter h or f");
                            horf = true;
                        }
                    }
                    bool list = true;
                    while (list == true)
                    {
                        Console.WriteLine("Would you like to see a list of all students? y/n");
                        string reply4 = Console.ReadLine().ToLower();
                        if (reply4 == "y")
                        {
                            foreach (string name in students)
                            {
                                Console.WriteLine(name);
                            }
                        }
                        else if (reply4 == "n")
                        {
                            list = false;
                        }
                        else
                        {
                            Console.WriteLine("I'll take that as a no.");
                            list = false;
                        }
                    bool again = true;
                    while (again == true)
                    {
                        Console.WriteLine("Would you like to learn about another student? y/n");
                        string reply3 = Console.ReadLine().ToLower();
                        if (reply3 == "y")
                        {
                            another = true;
                            again = false;
                                list = false;
                        }
                        else if (reply3 == "n")
                        {
                            Console.WriteLine("Thank you for playing!");
                            another = false;
                            again = false;
                                list = false;   
                        }
                        else
                        {
                            Console.WriteLine("Please enter y or n");
                            again = true;
                        }
                    }
                    
                    }
                }
            }
        }
    }
}