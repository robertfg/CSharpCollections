﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    static class MorseCodeTranslator
    {
        // static class so all members must be static
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };

        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        // static constructors don't have public or private access modifiers
        static MorseCodeTranslator()
        {
            foreach (KeyValuePair<char, string> code in _textToMorse)
            {
                _morseToText[code.Value] = code.Key;
                _morseToText.Add(code.Value, code.Key);
            }
        }

        public static string ToMorse(string input)
        {
            List<string> output = new List<string>(input.Length);
            foreach (char character in input.ToUpper())
            {
                try
                {
                    string morseCode = _textToMorse[character];
                    output.Add(morseCode);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("!");
                    //throw;
                }
            }
            return string.Join(" ", output);
        }

        public static string ToText(string input)
        {
            string[] inputWords = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> outputWords = new List<string>(inputWords.Length);

            foreach (string morseWord in inputWords)
            {
                string[] morseChars = morseWord.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder outputWord = new StringBuilder(morseChars.Length);

                foreach (string morseChar in morseChars)
                {
                    try
                    {
                        outputWord.Append(_morseToText[morseChar]);
                    }
                    catch (KeyNotFoundException)
                    {
                        outputWord.Append("!");
                    }
                }
                outputWords.Add(outputWord.ToString());
            }
            return string.Join(" ", outputWords);
        }
    }
}