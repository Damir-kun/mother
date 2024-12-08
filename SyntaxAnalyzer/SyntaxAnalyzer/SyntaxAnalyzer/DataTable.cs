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
                "dim",
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
                "end",
                "end_else",
                "do_while",
                "integer",
                "real",
                "boolean"
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
                "/",
                "and",
                "{",
                "}",
                ";",
                ",",
                ":",
                "/n",
                "(",
                ")",
                "||",
                "mult"
                "div",
                "!",
                " "
            };
        }
           
    }
}
