using System;

namespace _2.ProjectTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();
            int blacklistedNames = 0;
            int lostNames = 0;

            while (input != "Report")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Blacklist")
                {
                    string name = commands[1];
                    bool nameFound = false;

                    for (int i = 0; i < friendList.Length; i++)
                    {
                        if (name == friendList[i])
                        {
                            friendList[i] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            blacklistedNames++;
                            nameFound = true;
                            break;
                        }
                        
                    }
                    if (!nameFound)
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    
                }
                else if (command == "Error")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < friendList.Length)
                    {
                        string name = friendList[index];

                        if (friendList[index] != "Blacklisted" && friendList[index] != "Lost")
                        {
                            friendList[index] = "Lost";
                            lostNames++;
                            Console.WriteLine($"{name} was lost due to an error.");
                        }
                    }  
                }

                else if (command == "Change")
                {
                    int index = int.Parse(commands[1]);

                    if (index >= 0 && index < friendList.Length)
                    {
                        string currentName = friendList[index];
                        string newName = commands[2];

                        friendList[index] = newName;

                        Console.WriteLine($"{currentName} changed his username to {newName}.");                     
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(string.Join(" ", friendList));
        }
    }
}
