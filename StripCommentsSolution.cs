using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class StripCommentsSolution
    {
        public static string ChgStr(string inputStr, string[] commentSymbols)
        {
            string tmpStr = inputStr;
            if (inputStr == "!\r") 
                Console.WriteLine("qwe");
            foreach (var s in commentSymbols)
            {
                if (inputStr.Contains(s))
                    tmpStr = tmpStr[..tmpStr.IndexOf(s)];
            }
            if (tmpStr[^1] == ' ') tmpStr = tmpStr[..^1];
            return tmpStr;
        }
        public static string StripComments(string text, string[] commentSymbols)
        {
            var rows = text.Split('\n');
            string[] words = new string[rows.Length];
            int counter = 0;
            foreach(var row in rows)
            {
                words[counter] = (row == string.Empty) ? "" : ChgStr(row, commentSymbols);
                counter++;
            }
            return string.Join('\n', words);
        }

        public static void MainTs()
        {
            StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" });
            string sttrr = "EAADFDF\r\n\r\n!\r\n\r\nBCF\r\n\r\n\r\nBC\r\n\r\nC\r\n\r\n!A\r\n\r\n!A\r\n\r\nF\r\n\r\nB\r\n\r\nA\r\n\r\nDB\r\n\r\nB\r\n\r\nCF\r\n\r\nACC\r\n\r\nC\r\n\r\nC\r\n\r\n!\r\n\r\nCC\r\n\r\nDD\r\n\r\nC\r\n\r\nDBE\r\n\r\n!\r\n\r\n\r\nFB\r\n\r\nE\r\n\r\nD\r\n\r\nE\r\n\r\nD\r\n\r\n!\r\n\r\nB\r\n\r\n\r\n!\r\n\r\nE\r\n\r\nEC\r\n\r\nA\r\n\r\nB\r\n\r\nBDC\r\n\r\n!\r\n\r\nE\r\n\r\n\r\nC\r\n\r\nA\r\n\r\nBB\r\n\r\nEA\r\n\r\nE\r\n\r\nFFAC\r\n\r\nC\r\n\r\nBF\r\n\r\nE!CFAE\r\n\r\nD\r\n\r\nBD\r\nCEB\r\n\r\n\r\n\r\n\r\nF\r\n\r\nE\r\n\r\nD\r\n\r\n\r\nD\r\n\r\n\r\nD\r\n!\r\n\r\nE\r\n\r\nA\r\n\r\nDED\r\n\r\nF!";
            StripComments(sttrr, new string[] { "#", "!" });
        }
    }
}


/*
 EAADFDF

!

BCF


BC

C

!A

!A

F

B

A

DB

B

CF

ACC

C

C

!

CC

DD

C

DBE

!


FB

E

D

E

D

!

B


!

E

EC

A

B

BDC

!

E


C

A

BB

EA

E

FFAC

C

BF

E!CFAE

D

BD
CEB




F

E

D


D


D
!

E

A

DED

F!
 
 */