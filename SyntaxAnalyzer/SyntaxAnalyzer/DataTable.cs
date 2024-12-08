using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxAnalyzer
{
    public static class DataTable
    {
        public static List<string> GetServiceWords()
        {
            return new List<string>()
            {
                "begin",
                "end",
                "if",
                "then",
                "else",
                "for",
                "let",
                "while",
                "loop",
                "input",
                "output",
                "true",
                "false",
                "do",
                "end_else",
                "do_while",
                "!"
            };
        }

        public static List<string> GetSeparators()
        {
            return new List<string>()
            {
                "<>",
                "=",
                "<",
                "<=",
                ">",
                ">=",
                "+",
                "-",
                "or",
                "*",
                "and",
                "{",
                "}",
                ";",
                ",",
                ":",
                "/n",
                "(",
                ")",
                "not",
                "div"
            };
        }
           
    }
}
