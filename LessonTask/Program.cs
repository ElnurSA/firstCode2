﻿//task 1

//int n = 15;
//if (n % 2 == 0) 
//{
//    Console.WriteLine("Tekdir");
//}
//else
//{
//    Console.WriteLine("Cutdur");
//}

//task 2

//int m = 19;

//int i;


//for (i = 1;i < m; i++)
//{
//    Console.WriteLine(i);
//}

//task 3

//int sum = 0;
//int m = 10;
//int i;
//for(i = 1; i <= m; i++)
//{
//     sum += i;
//}
//Console.WriteLine(sum);

//task 4

//int m = 8;
//int count = 0;
//int i;
//for(i = 0; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {

//    }
//    else
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//task 5

//int sum = 0;
//int n = 3;
//int m = 14;
//int i;
//for (i = 0; i <= m; i++)
//{
//    if (i > n && i < m)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i;
//        }
//    }

//}
//Console.WriteLine(sum);

//task 6

//int fakt = 1;
//int i;
//int m = 6;
//for(i=1; i<=m; i++)
//{
//    fakt *= i;
//}

//Console.WriteLine(fakt);


//task 7

//int[] nums = { 5, 6, 3, 124, 48, 24, 56 };
//int multiply = 1;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 1)
//    {
//        multiply *= nums[i];
//    }
//}

//Console.WriteLine(multiply);

//task 8

//int n = 43;

//if(n % 7 == 0 && n % 3 == 0)
//{
//    Console.WriteLine(n + " bolunur 3 ve 7");
//}
//else
//{
//    Console.WriteLine(n + " bolunmur 3 ve 7");
//}

//task 9

//int n = 9;
//int m = 13;
//int sum = 0;

//if (n % 2 == 1 && m % 2 == 1)
//{
//    sum += n + m;
//}
//Console.WriteLine(sum);

//task 10

//int n = 29;
//int m = 40;
//int sum = 0;
//for(int i = n; i <= m; i++)
//{
//    if(i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//task 11

//int[] nums = { 5, 6, 3, 124, 48, 24, 56 };
//int count = 0;
//for(int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 1)
//    {
//        count += 1;
//    }
//}
//Console.WriteLine(count);

// task 12

//int[] nums = { 17, 4, 14, 183, 29, 64, 50, 301 };
//int count = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        count += 1;
//    }
//}
//Console.WriteLine(count);

//task 13

//int n = 19;
//int count = 0;
//for(int i = 1; i <= 17; i++)
//{
//    if(n % i == 0)
//    {
//        count += 1;
//    }
//}
//if(count > 2)
//{
//    Console.WriteLine("Sade");
//}
//else
//{
//    Console.WriteLine("Murekkeb");
//}

//lesson

//int m = 5;
//int fakt = 1;
//for (int i = 1; i <= m; i++)
//{
//    fakt *= i;
//}

//Console.WriteLine(fakt);










//Codes during the lesson

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Hello P418");
//        Console.ReadLine();
//    }  
//}

//int studnetAge = 25;

//Console.WriteLine(studnetAge);

//string name1 = "XXX";
//string name2 = "YYY";

//Console.Write(name1 + "" + name2);

//string result = name1 + name2;

//Console.WriteLine(result);

//bool isOnline = true;

//string name = "asdfa";

//Console.WriteLine(name.GetType());

//bool isOnline = true;

//if (isOnline)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}


//int age = 29;

//if(age > 30)
//{
//    Console.WriteLine("qocalirsan");
//}
//else if(age == 29)
//{
//    Console.WriteLine("Yaxshisan");
//}
//else
//{
//    Console.WriteLine("Gencsen");
//}

//int number = 30;

//string result = number > 30 ? "Qocasan" : "Yaxshisan";

//Console.WriteLine(result);

//bool res = number > 30 ? true : false;

//Console.WriteLine(res);


//if(number > 30)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//int x = 10, y = 100;

//string result = x > y ? "x is greater than y" :
//    x < y ? " x is  less than y" :
//    x == y ? "x is equal to y" : "no result";

//Console.WriteLine(result);

//string name = "Semed";

//var result = name ?? "XXX";

//Console.WriteLine(result);

//Console.WriteLine("Add your email");

//string email = Console.ReadLine();

//Console.WriteLine("Add your password:");

//string password = Console.ReadLine();

//if(email == "cavid@gmail.com" && password == "123")
//{
//    Console.WriteLine("Login success:");
//}
//else
//{
//    Console.WriteLine("Email or password is wrong");
//}


//int weekDay = 2;

//switch (weekDay)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednessday");
//        break;
//    default:
//        Console.WriteLine("Week day not found");
//        break;
//}

//int[] nums = new int[10];
//int[] nums2 = new int[3] { 1, 4, 5
//

//int[] nums = { 3, 2, 6, 2, 9, 2 };

//int count = 0;

//int sumElem = 0;

//int sumIndex = 0;



//for(int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        sumElem += nums[i];

//        sumIndex += i;

//    }
//}

//int result = sumElem - sumIndex;

//Console.WriteLine(result);

int[] nums = { 3, 2, 6, 2, 9, 2 };

//for(int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 0)
//    {
//        Console.WriteLine(nums[i]);
//        break;
//    }
//}

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == 2)
//    {
//        continue;
//    }
//    Console.WriteLine(nums[i]);
//}

//foreach (var item in nums)
//{
//    if(item == 2)
//    {
//        Console.WriteLine(item);
//    }
//}



//string date = DateTime.Now.ToString("MM-dd-yyyy HH:mm");

//Console.WriteLine(date);