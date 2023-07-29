using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace stringBuilder_processing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            input = Processer(input);
            Console.WriteLine(input);
        }
        static StringBuilder Processer(StringBuilder input)
        {
            string command = Console.ReadLine();
            if (command.Substring(0, 6) == "Remove")
            {
                input = Removed(input, command);
            }
            else if (command.Substring(0, 6) == "Append")
            {
                input = Appender(input, command);
            }
            else if (command.Substring(0, 6) == "Insert")
            {
                input = Inserter(input, command);
            }
            else if (command.Substring(0, 7) == "Replace")
            {
                input = Replacer(input, command);
            }
            return input;
        }
        static StringBuilder Removed(StringBuilder sb, string command)
        {
            int start = command.Substring(0, 6).Length;
            int index = 0;
            int len = 0;
            string num = null;
            for(;start< command.Length; start++)
            {
                if (command[start] == ' ' && num != null)
                {
                    break;
                }
                if (char.IsDigit(command[start]))
                {
                    num += command[start];
                }
            }
            if(num.Length > 0)
            {
                index = int.Parse(num);
            }
            num = null;
            for (; start < command.Length; start++)
            {
                if (command[start] == ' ' && num != null)
                {
                    break;
                }
                if (char.IsDigit(command[start]))
                {
                    num += command[start];
                }
            }
            if (num.Length > 0)
            {
                len = int.Parse(num);
            }
            sb.Remove(index, len+1);
            return sb;
        }
        static StringBuilder Appender(StringBuilder sb, string command)
        {
            string num = null;
            for (int i = command.Substring(0, 6).Length; i < command.Length; i++)
            {
                if (Char.IsLetter(command[i]))
                {
                    num += command[i];
                }
            }
            sb.Append(num);
            return sb;
        }
        static StringBuilder Inserter(StringBuilder sb, string command)
        {
            int start = command.Substring(0, 6).Length;
            int index = 0;
            string num = null;
            string word = " ";
            for (; start < command.Length; start++)
            {
                if (command[start] == ' ' && num != null)
                {
                    break;
                }
                if (char.IsDigit(command[start]))
                {
                    num += command[start];
                }
            }
            if (num.Length > 0)
            {
                index = int.Parse(num);
            }
            num = null;
            for (; start < command.Length; start++)
            {
                if (command[start] == ' ' && num != null)
                {
                    break;
                }
                if (char.IsLetter(command[start]))
                {
                    num += command[start];
                }
            }
            word += num;
            sb.Insert(index, word);
            return sb;
        }
        static StringBuilder Replacer(StringBuilder sb, string command)
        {
            int start = command.Substring(0, 7).Length;
            string word = null;
            string rep = null;
            string place = null;
            for (; start < command.Length; start++)
            {
                if (command[start] == ' ' && word != null)
                {
                    break;
                }
                if (char.IsLetter(command[start]))
                {
                    word += command[start];
                }
            }
            rep = word;
            word = null;
            for (; start < command.Length; start++)
            {
                if (command[start] == ' ' && word != null)
                {
                    break;
                }
                if (char.IsLetter(command[start]))
                {
                    word += command[start];
                }
            }
            place = word;
            word = null;
            sb.Replace(rep, place);
            return sb;
        }
    }
}