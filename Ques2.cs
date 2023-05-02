using System;

namespace sitecore{
    public class Ques2{

        public class PalindromeChecker
        {
            public static bool IsPalindrome(string inputString, string trashSymbolString)
            {
                // Convert inputString and trashSymbolString to lowercase for case-insensitive comparison
                inputString = inputString.ToLower();
                trashSymbolString = trashSymbolString.ToLower();

                // Initialize variables for scanning inputString
                int startIndex = 0;
                int endIndex = inputString.Length - 1;

                // Scan inputString from both ends and compare characters
                while (startIndex < endIndex)
                {
                    // If the start character is a trash symbol, move to the next character
                    if (trashSymbolString.Contains(inputString[startIndex].ToString()))
                    {
                        startIndex++;
                        continue;
                    }

                    // If the end character is a trash symbol, move to the previous character
                    if (trashSymbolString.Contains(inputString[endIndex].ToString()))
                    {
                        endIndex--;
                        continue;
                    }

                    // Compare the characters
                    if (inputString[startIndex] != inputString[endIndex])
                    {
                        return false;
                    }

                    // Move to the next characters
                    startIndex++;
                    endIndex--;
                }

                // If all characters are compared and no mismatches were found, inputString is a palindrome
                return true;
            }
        }


    }
}