using System;
using System.Collections.Generic;

namespace _3._ProjectThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> chat = new List<string>();

            while (input != "end")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];

                if (command == "Chat")
                {
                    string message = commandArgs[1];
                    chat.Add(message);
                }
                else if (command == "Delete")
                {
                    string message = commandArgs[1];

                    if (chat.Contains(message))
                    {
                        chat.Remove(message);
                    }
                }
                else if (command == "Edit")
                {
                    string message = commandArgs[1];
                    string editedMessage = commandArgs[2];

                    if (chat.Contains(message))
                    {
                        int index = chat.IndexOf(message);
                        chat[index] = editedMessage;
                    }
                }
                else if (command == "Pin")
                {
                    string message = commandArgs[1];

                    if (chat.Contains(message))
                    {
                        int index = chat.IndexOf(message);

                        chat.Add(message);
                        chat.RemoveAt(index);
                    }
                }

                else if (command == "Spam")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        chat.Add(commandArgs[i]);
                    }
                }

                input = Console.ReadLine();
            }

            if (chat.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, chat));
            }
        }
    }
}
