using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
   
    public class FirstNonRepeatingChar
    {
        public string FirstNonRepeatingCharMethod(string input)
        {
            if (input == null)
                throw new ArgumentException(nameof(input));

            if (input == "")
                return "Please fill input";

            char[] charInput = input.ToLower().Replace(" ", "").ToCharArray();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in charInput)
            {
                if (!dic.Keys.Contains(c))
                    dic[c] = 1;

                else
                    dic[c]++;

            }

            foreach (var pair in dic)
                if (pair.Value == 1)
                    return (pair.Key).ToString();

            return "no duplicates in your input";
        }
    }
}
/*
 Assumptions and Business Questions
    Method takes a string and returns a string (could return a char, but need a string to be returned for error message for empty"
    Null throws exception
    Empty returns string "input is empty"
    White spaces should not fill a key in dictionary
    Case sensitivity
    No punctuation or special characters 

Algorith
    strings are enumerable, so they can be added directly to Dictionary without being made to an arrary?
    Create Dictionary<string, int>
    loop through the input - if a letter doesn't exist as a key already, make it a key, and accumulate it's value, 
        for each c in input, 
        if !dictionary.Key.Contains(c) 
        {Dictionary.Key[i].Add(c), Dictionary.Value[i]++} not sure if this is how the syntax works

    check dictionary for first time a Value is > 1, return its Key
        foreach pair in Dictionary
            if Pair.Value > 1
            return Pair.Key

Test for
    ThrowWhenNull
    Return"Please fill input"WhenInputEmpty
    ReturnCharInsteadOfWhiteSpace
    ReturnFirstInstanceOfDuplicate
    Success
    
 */