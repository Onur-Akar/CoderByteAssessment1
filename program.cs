using System;

class MainClass
{

    public static string ArrayChallenge(string[] strArr)
    {

        // code goes here
        string letter = strArr[0];
        string commaLetter = "";

        for (int i = 1; i < strArr.Length; i++)
        {
            for (int j = 1; j < strArr.Length; j++)
            {
                string checkLetterAsc = strArr[i] + strArr[j];
                string checkLetterDesc = strArr[j] + strArr[i];

                if (checkLetterAsc == letter)
                {
                    commaLetter = strArr[i] + "," + strArr[j];
                    return commaLetter;
                }
                else if (checkLetterDesc == letter)
                {
                    commaLetter = strArr[j] + "," + strArr[i];
                    return commaLetter;
                }
            }
        }

        return "not possible";
    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(ArrayChallenge(Console.ReadLine()?.Split(',')));

        Console.ReadKey();
    }

}
