﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

// 3


//List<string> phones = Console.ReadLine().Split(", ").ToList();

//string input = default;
//while((input = Console.ReadLine()) != "End")
//{
//    string[] command = input.Split(' ');

//    if (command[0] == "Add")
//    {
//        string givenPhone = command[2];
//        bool exist = phones.Contains(givenPhone);
//        if (exist == false)
//        {
//            phones.Add(givenPhone);
//        }
//    }

//    else if (command[0] == "Remove")
//    {
//        string givenPhone = command[2];
//        bool Istrue = phones.Contains(givenPhone);
//        if(Istrue == true)
//        {
//            phones.Remove(givenPhone);
//        }

//    }
//    else if (command[0] == "Bonus")
//    {
//        string[] splitedCommand = command[3].Split(':');
//        string oldPhone = splitedCommand[0];
//        string newPhone = splitedCommand[1];
//        bool IsFalse = phones.Contains(oldPhone);
//        if(IsFalse == true)
//        {
//            for (int i = 0; i < phones.Count; i++)
//            {
//                if (phones[i] == oldPhone)
//                {
//                    phones.Insert(i + 1, newPhone);
//                }
//            }
//        }
//    }
//    else if (command[0] == "Last")
//    {
//        string phoneExist = command[2];
//        bool IsTrue = phones.Contains(phoneExist);
//        if (IsTrue == true)
//        {
//            phones.Remove(phoneExist);
//            phones.Add(phoneExist);
//        }
//    }
//}
//Console.WriteLine(string.Join(", ", phones));


// 2


//List<string> friendList = Console.ReadLine().Split(", ").ToList();
//int countOfBlackListed = 0;
//int countOfLost = 0;
//string input = default;
//while((input = Console.ReadLine()) != "Report")
//{
//    string[] command = input.Split(' ');
//    if (command[0] == "Blacklist")
//    {
//        string name = command[1];
//        bool IsTrue = friendList.Contains(name);
//        if(IsTrue == true)
//        {
//            for (int i = 0; i < friendList.Count; i++)
//            {
//                if(friendList[i] == name)
//                {
//                    friendList[i] = "Blacklisted";
//                    Console.WriteLine($"{name} was blacklisted.");
//                    countOfBlackListed++;
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine($"{name} was not found.");
//        }
//    }


//    else if (command[0] == "Error")
//    {
//        int index = int.Parse(command[1]);
//        if((index >= 0 && index < friendList.Count)
//            && friendList[index] != "Blacklisted" 
//            && friendList[index] != "Lost")
//        {
//            for (int i = 0; i < friendList.Count; i++)
//            {
//                if (i == index)
//                {
//                    string lostName = friendList[i];
//                    friendList[i] = "Lost";
//                    Console.WriteLine($"{lostName} was lost due to an error.");
//                    countOfLost++;
//                }
//            }
//        }
//    }

//    else if (command[0] == "Change")
//    {
//        int index = int.Parse(command[1]);
//        if(index >= 0  &&  index < friendList.Count)
//        {
//            string oldName = friendList[index];
//            string newName = command[2];
//            friendList[index] = newName;
//            Console.WriteLine($"{oldName} changed his username to {newName}.");
//        }
//    }
//}
//Console.WriteLine($"Blacklisted names: {countOfBlackListed}");
//Console.WriteLine($"Lost names: {countOfLost}");
//Console.WriteLine(string.Join(" ", friendList));


// 1


//double budget = double.Parse(Console.ReadLine());
//int students = int.Parse(Console.ReadLine());
//double priceForPackageFlour = double.Parse(Console.ReadLine());
//double priceForSingleEgg = double.Parse(Console.ReadLine());
//double PriceForSingleApron = double.Parse(Console.ReadLine());
//double freePackage = students / 5;
//Math.Floor(freePackage);


//double priceForApron = (PriceForSingleApron * Math.Ceiling(students * 1.2));
//double priceForEggs = (priceForSingleEgg * (10 * students));
//double priceForFlour = (priceForPackageFlour * (students - freePackage));

//double total = priceForApron + priceForEggs + priceForFlour;
//if(total <= budget)
//{
//    Console.WriteLine($"Items purchased for {total:F2}$.");
//}
//else
//{
//    Console.WriteLine($"{total - budget:F2}$ more needed.");
//}