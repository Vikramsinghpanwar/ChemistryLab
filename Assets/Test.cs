using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//QUESTION: 01
// Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).

// Specifically, ans is the concatenation of two nums arrays.

// Return the array ans.


// Example 1:
// Input: nums = [1,2,1]
// Output: [1,2,1,1,2,1]
// Explanation: The array ans is formed as follows:
// - ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
// - ans = [1,2,1,1,2,1]

// Example 2:
// Input: nums = [1,3,2,1]
// Output: [1,3,2,1,1,3,2,1]
// Explanation: The array ans is formed as follows:
// - ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
// - ans = [1,3,2,1,1,3,2,1]

class Program
{

    static int[] input = { 1, 1, 1, 1 };

    static int tmp;
    static bool _is = true;
    static bool _isMonotonic;

    // public static void Main (string[] args) {
    //   // int[] input = {1, 3, 2,1};
    //   // int[] ans = new int[2 * input.Length];
    //   // for(int i = 0; i < (2* input.Length); i++){
    //   //   if(i<input.Length){
    //   //     ans[i] = input[i];
    //   //   }
    //   //   else{
    //   //     ans[i] = input[i-input.Length];
    //   //   }
    //   //   Console.WriteLine(ans[i] + " ,");
    //   // }
    //   // //Console.WriteLine ("Hello World");


    // }
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello World");





        for (int j = 0; j < input.Length; j++)
        {

            if (j != input.Length - 1)
            {

                if (input[j] < input[j + 1])
                {
                    _isMonotonic = true;
                    break;
                }
                else if (input[j] > input[j + 1])
                {
                    _isMonotonic = false;
                    break;
                }

                else if (input[j] == input[j + 1])
                {

                    _is = false;
                    Console.WriteLine("Neither increasing nor decreasing");
                }
            }

        }



   


    if(_is){
      Console.WriteLine(Check());

    }

    }

    public static bool Check()
{
    for (int i = 0; i < input.Length; i++)
    {
        /// check weather its continous or not
        if (i == 0)
        {
            tmp = input[i];
        }
        else
        {
            tmp = input[i - 1];
        }


        if (_isMonotonic)
        {
            //is not increasing
            if (tmp > input[i])
            {
                Console.WriteLine("false");

                return false;
                //Console.WriteLine("false");
                break;
            }
        }
        else if (!_isMonotonic)
        {
            // is not decreasing
            if (tmp < input[i])
            {
                Console.WriteLine("false");
                return false;
                //Console.WriteLine("false");
                break;
            }
        }
    }
    Console.WriteLine("true");

    return true;

}
  
}