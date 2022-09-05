using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Lesson3
{
    internal class EmailCollector
    {
        List<string> _emails;
        private string _inputFileName;
        private string _outputFileName;
        private readonly char[] _delimiterChars = { ' ', '&' };

        public string InputFile { get 
            { 
                return _inputFileName; 
            }
            set 
            {
                if (File.Exists(value))
                {
                    _inputFileName = value;
                   
                }
                else
                {
                    throw new Exception($"Файл {value} не существует");
                }
            } 
        }

        private bool NewFileNameIsValid(string newFileName)
        {
            string path = Path.GetDirectoryName(newFileName);
            if ((path.Length > 0) && (!Directory.Exists(path))) return false;
            string fname = Path.GetFileName(newFileName);
            char[] invalidPathChars = Path.GetInvalidPathChars();
            for (int i = 0; i < invalidPathChars.Length; i++)
            {
                if (fname.Contains(invalidPathChars[i])) return false;
            }
            return true;
        }

        public string OutputFile { get { return _outputFileName; }
            set {
                if (NewFileNameIsValid(value))
                {
                    _outputFileName = value;
                }
                else 
                {
                    throw new ArgumentException($"Имя выходного файла {value} недопустимо");
                }
            }
        }


        
        public EmailCollector(string inputFileName, string outputFileName)
        {
            InputFile = inputFileName;
            OutputFile = outputFileName;
            _emails = new List<string> ();
        }


        private string[] GetData() 
        { 
            return File.ReadAllLines(InputFile);
        }

        private void ProceedString(string s)
        {
            Regex emailRegex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            string[] innerWords = s.Split(_delimiterChars);
            for (int i = 0; i < innerWords.Length; i++)
            {
                if (emailRegex.IsMatch(innerWords[i])) _emails.Add(innerWords[i]);
            }
            
        }

        public void Handle() 
        {
            string[] inputData = GetData();
            for (int i = 0; i < inputData.Length; i++) ProceedString(inputData[i]);
            File.WriteAllLines(OutputFile, _emails);

        }

        public void DisplayREsults() 
        {
            foreach (string email in _emails) 
            {
                Console.WriteLine(email);
            }
        }

    }
}
