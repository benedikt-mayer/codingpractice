using System;

bool CaseInsensitiveCompare(string firstString, string secondString){
    for (int i = 0; i < firstString.Length; i++){
        if (Char.ToLower(firstString[i]) != Char.ToLower(secondString[i])){
            return false;
        }
    }
    return true;
}

string first = "ABcd";
string second = "AbcD";
string third = "ABce";
Console.WriteLine("first is the same as second: " + CaseInsensitiveCompare(first, second));
Console.WriteLine("first is the same as third: " + CaseInsensitiveCompare(first, third));