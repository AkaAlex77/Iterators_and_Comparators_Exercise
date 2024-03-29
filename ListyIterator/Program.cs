﻿
using ListyIterator;

List<string> items = Console.ReadLine().Split().Skip(1).ToList();

ListyIterator<string> listy = new(items);

string command;

while ((command = Console.ReadLine()) != "END")
{
    switch (command)
    {
        case "Move":
            Console.WriteLine(listy.Move());
            break;
        case "HasNext":
            Console.WriteLine(listy.HasNext());
            break;
        case "Print":
            try
            {
                listy.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        case "PrintAll":
            Console.WriteLine(string.Join(" ", listy));
            break;
    }
}

