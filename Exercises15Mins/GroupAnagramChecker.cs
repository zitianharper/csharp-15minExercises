using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exercises15Mins
{
    public class GroupAnagramChecker
    {
        public List<List<string>> GroupAnagramCheckerMethod(string[] input)
        {
            
            Dictionary<string, List<string>> dic = new();

            if (input == null)
                throw new ArgumentException(nameof(input));

       
            
            foreach (string s in input)
            {
                string normalised = s.ToLower().Replace(" ", "") ;

                char[] normalisedArray = normalised.ToCharArray();
                Array.Sort(normalisedArray);
                normalised = new string(normalisedArray);
                // ^ All of this had to be done because you can't assign
                // a variable to .Sort() directly. 

                if (!dic.ContainsKey(normalised))
                {
                    dic.Add(normalised, new List<string>());
                }

                dic[normalised].Add(s);

                //if (!dic.ContainsKey(normalised))
                //    {
                //        originalWords.Add(s);
                //        dic.Add(normalised, originalWords);
                //    }

                ////if the normalised word is already a key,
                ////then assign the original word to its value
                //else dic[normalised].Add(s);

            }
            return dic.Values.ToList();
                
            }

            

            
        }
        
    }
}
//input: ["eat", "tea", "tan", "ate", "nat", "bat"]
//s: [ {a, e, t}, {a, b, c}, {a, e, t} ] 

/*
Assumpions and Business
- Input is a string array separated by commas
- Return type is an Array of Arrays or List of Arrays maybe 
- Ignore case - .ToLower
- Ignore leading and trailing spaces - If Statement with Array[0].Repla
ce() and Array[Array.Length].Replace()
- Null throw exception

Algorithm
- Throw null first
- Empty OuterArray should return an error message - how to do this when the return
    type is Array<Array>???
- Empty InnerArrays should be ignored
- Normalise the InnerArrays 
    - .ToLower \
    - .Replace(" ", "")
    - .Sort()
    - .ToCharArray
- Dictionary<normalised word, List<original words>> e.g., <"aet"    , ["eat", "tea", "ate]>