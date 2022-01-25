// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// public class Solution {
//     public bool IsMatch(string s, string p) {
//         Console.WriteLine("Hello");
//         return true;
//     }
// }
// Solution n = new Solution();
// Solution.IsMatch("","");
using System;
using System.Collections;

namespace ExpressionMatching {
    public  static class Program {
        public static void Main(string[] args){

            ArrayList combinations = new ArrayList();
            generateAll(new char[2 * 3], 0, combinations);
            

            void generateAll(char[] current, int pos, ArrayList result) {
                foreach(char ch in current)
                Console.Write(ch);
                Console.WriteLine();
                Console.WriteLine(pos);
                foreach(String rs in result)
                Console.WriteLine(rs);     
                Console.WriteLine("----------------");              
                if (pos == current.Length) {
                    if (valid(current))
                        result.Add(new String(current));
                } else {
                    current[pos] = '(';
                    generateAll(current, pos+1, result);
                    current[pos] = ')';
                    generateAll(current, pos+1, result);
                }
            }

            Boolean valid(Char[] current) {
                int balance = 0;
                foreach (Char c in current) {
                    if (c == '(') 
                    balance++;
                    else balance--;
                    if (balance < 0)
                    return false;
                }
                return (balance == 0);
            }

            foreach(String cmp in combinations)
            Console.WriteLine(cmp);
        }
    }
}
