using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryPractice
{
    //// c# linear search program where a certain type match with array index return that index and attemps
    //class LinearSearch1
    //{
    //    public static void Search(int[] arr, int mySearch)
    //    {
    //        int Left ;
    //        int length = arr.Length;
    //        int right = length - 1;
    //        int position = -1;
    //        for (Left = 0; Left <= right;)
    //        {
    //            if (arr[Left] == mySearch)
    //            {
    //                position = Left;
    //                Console.WriteLine("Element is found at Index:" + (position + 1) + " position with " + (Left + 1) + " attempts");
    //                break;
    //            }
    //            if (arr[right] == mySearch)
    //            {
    //                position = right;
    //                Console.WriteLine("Element is found at Index:" + (position + 1) + " position with " + (length - right) + " attempts");
    //                break;
    //            }

    //            Left++;
    //            right--;

    //        }
    //        if (position == -1)
    //        {
    //            Console.WriteLine("Element is not found in the Array");

    //        }
    //    }
    //    static void (Main)(string[] args)
    //    {
    //        int[] sourcs = { 10, 20, 30, 50, 40, 80, 70, 60 };
    //        int num = 0;
    //        int num1 = 30;


    //        Search(sourcs, num);
    //        Search(sourcs, num1);
    //        // Element is not found in the Array
    //        // Element is found at Index:3 position with 3 attemptsssss
    //    }
    //}
}
