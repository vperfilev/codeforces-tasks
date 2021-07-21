using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeforcesTasks.Contest1538
{
    // https://codeforces.com/contest/1538/problem/E
    public class TaskE
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine()!);
            for (var i = 0; i < count; i++)
            {
                var lineCount = int.Parse(Console.ReadLine()!);
                var lines = new string[lineCount];
                for (int j = 0; j < lineCount; j++)
                {
                    lines[j] = Console.ReadLine();
                }
                Console.WriteLine(Solve(lines));
            }
        }
        
        public static long Solve(string[] lines)
        {
            var variables = new Dictionary<string, Variable>();
            var lastValue = new Variable(string.Empty);
            
            foreach (var line in lines)
            {
                var parsedLine = new Line(line);
                if (parsedLine.Operator == "=")
                {
                    lastValue = variables[parsedLine.Operands[0]] + variables[parsedLine.Operands[1]];
                    variables[parsedLine.VarName] = lastValue;
                }
                else
                {
                    lastValue = new Variable(parsedLine.Operands.Single());
                    variables[parsedLine.VarName] = lastValue;
                }
            }

            return lastValue.Count;
        }

        private class Line
        {
            public string VarName { get; }
            public string Operator { get; }
            public string[] Operands { get; }
            
            public Line(string value)
            {
                var endNameIndex = value.IndexOf(' ');
                VarName = value[0 .. endNameIndex];
                var endOperatorIndex = value.IndexOf(' ', endNameIndex + 1);
                Operator = value[(endNameIndex + 1) .. endOperatorIndex];
                var plusIndex = value.IndexOf('+', endOperatorIndex + 1);
                if (plusIndex == -1)
                {
                    Operands = new[] {value[(endOperatorIndex + 1) ..]};
                }
                else
                {
                    Operands = new[]
                    {
                        value[(endOperatorIndex + 1) .. (plusIndex - 1)],
                        value[(plusIndex + 2) ..]
                    };
                }
            }
        }
        
        private class Variable
        {
            public int Length { get; private set; }
            public string Suffix { get; private set; }
            public string Prefix { get; private set; }
            public long Count { get; private set; }
            
            private Variable() { }
            
            public Variable(string value)
            {
                Length = value.Length;
                if (value.Length < 3)
                {
                    Suffix = Prefix = value;
                }
                else
                {
                    Suffix = value[^3..];
                    Prefix = value[..3];
                }

                Count = value.Contains("haha") ? 1 : 0;
            }
            
            public static Variable operator + (Variable a, Variable b)
            {
                var prefix = a.Prefix.Length == 3 ? a.Prefix :
                    a.Prefix + b.Prefix is var p && p.Length > 3 ? p[..3] : p;
                var suffix = b.Suffix.Length == 3 ? b.Suffix :
                    a.Suffix + b.Suffix is var s && s.Length > 3 ? s[^3..] : s;
                
                return new Variable
                {
                    Length = a.Length + b.Length,
                    Prefix = prefix,
                    Suffix = suffix,
                    Count = a.Count + b.Count + HahaCount(a.Suffix, b.Prefix)
                };

                int HahaCount(string a, string b)
                {
                    var line = a + b;
                    if (line == "hahaha") return 2;
                    return line.Contains("haha") ? 1 : 0;
                }
            }
        }
    }
}