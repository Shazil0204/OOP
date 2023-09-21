using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Developer___Exception_handler.View
{
    internal class GUI
    {
        /// <summary>
        /// This method will be used to showing the exception handler messages
        /// </summary>
        /// <param name="error"></param>
        internal void Message(string error)
        {
            Console.WriteLine(error); ;
        }

        /// <summary>
        /// This message will be shown either way program comes up with an exception or not
        /// </summary>
        internal void FinalMessage()
        {
            Console.WriteLine("All is Done!\n");
        }

        internal string EmptyFile()
        {
            return ("The File that you provided to me is Empty.\n");
        }

        /// <summary>
        /// This will show how many times the word error is used inside the txt file and i have an if statement in it that will just change the word error to errors if there are more than one error.
        /// </summary>
        /// <param name="errorCount"></param>
        internal void ShowErrorCount(byte errorCount)
        {
            string plural = "";
            if (errorCount <= 1)
            {
                plural = "error";
            }
            else
            {
                plural = "errors";
            }

            Console.WriteLine("The file contain " + errorCount + " " + plural + "\n");
        }

        /// <summary>
        /// This method will be used if the txt file is not found
        /// </summary>
        internal void FileNotFound()
        {
            Console.WriteLine("The specified file was not found.\n");
        }

        /// <summary>
        /// This method is used if an exception happens while reading txt file
        /// </summary>
        internal void ReadingError()
        {
            Console.WriteLine("There was an issue reading the file.\n");
        }

        /// <summary>
        /// Just to stop program before closing
        /// </summary>
        internal void Readkey()
        {
            Console.ReadKey();
        }
    }
}
