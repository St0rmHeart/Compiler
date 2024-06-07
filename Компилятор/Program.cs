﻿namespace Компилятор
{
    public static class Programm
    {
        public static void Main()
        {
            /*
            LexicalAnalyzer L_Analyzer = new();
            L_Analyzer.Data = "int a = 4;";
            Console.WriteLine(L_Analyzer.IsLexicalCorrect());
            List<int> list = [1, 2, 3, 4];
            var list1 = list[1..];
            var list2 = list[2..];
            var list3 = list[3..];
            var list4 = list[4..];
            */
            List<Terminal> RPNInput = new List<Terminal>();
            //int a; a = 5;
            /*
            RPNInput.Add(new Terminal(ETerminalType.Int));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            */
            //(A[5]+6)*(2-1)
            /*
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.LeftBracket));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBracket));
            RPNInput.Add(new Terminal(ETerminalType.Plus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.Multiply));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.Minus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            */
            // A[5] = "A"
            /*
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.LeftBracket));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBracket));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.String));
            */
            //if (a >= 5) { a = a - 2 }
            /*
            RPNInput.Add(new Terminal(ETerminalType.If));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.GreaterEqual));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.LeftBrace));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Minus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBrace));
            */
            //if (a >= 5) { a = a - 2 } else { a = 2 % 2 }
            /*
            RPNInput.Add(new Terminal(ETerminalType.If));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.GreaterEqual));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.LeftBrace));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Minus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBrace));
            RPNInput.Add(new Terminal(ETerminalType.Else));
            RPNInput.Add(new Terminal(ETerminalType.LeftBrace));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.Modulus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBrace));
            */
            // while (a>b) { a = a - 1 }
            /*
            RPNInput.Add(new Terminal(ETerminalType.While));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.GreaterEqual));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.LeftBrace));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Minus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBrace));
            */
            // input(a); a = a + 2; output(a);
            /*
            RPNInput.Add(new Terminal(ETerminalType.Input));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Plus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            RPNInput.Add(new Terminal(ETerminalType.Output));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            */
            // int[5] A; A[3] = 2;
            /*
            RPNInput.Add(new Terminal(ETerminalType.Int));
            RPNInput.Add(new Terminal(ETerminalType.LeftBracket));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBracket));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.LeftBracket));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightBracket));
            RPNInput.Add(new Terminal(ETerminalType.Assignment));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.Semicolon));
            */
            //((a+2)-(b+3))*6
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Plus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.Minus));
            RPNInput.Add(new Terminal(ETerminalType.LeftParen));
            RPNInput.Add(new Terminal(ETerminalType.Identifier));
            RPNInput.Add(new Terminal(ETerminalType.Plus));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.RightParen));
            RPNInput.Add(new Terminal(ETerminalType.Multiply));
            RPNInput.Add(new Terminal(ETerminalType.Number));
            RPNTranslator translator = new RPNTranslator();
            var RPNOutput = translator.Translate(RPNInput);
            for (int i = 0; i < RPNOutput.Count; i++)
            {
                Console.WriteLine(RPNOutput[i].RPNType.ToString());
            }
        }
    }
}