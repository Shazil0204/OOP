using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Developer___Exception_handler.Controller
{
    internal class MainController
    {
        /// <summary>
        /// Instance of my View
        /// </summary>
        private View.GUI _gui = new View.GUI();


        /// <summary>
        /// Instance of my Model
        /// </summary>
        private Model.FileList _fileList = new Model.FileList();

        /// <summary>
        /// String to my file Path
        /// </summary>
        private const string _filePath = @"C:\\Users\\20shi\\OneDrive\\Desktop\\temp1\\testing.txt";

        /// <summary>
        /// My MainController that controlles all my program
        /// </summary>
        internal void Controller()
        {
            CheckingFile(_filePath);
        }

        /// <summary>
        /// This method will read my file and show all the things that happens (This will shów exceptions if there are any)
        /// </summary>
        /// <param name="file"></param>
        private void CheckingFile(string file)
        {
            try
            {
                using (StreamReader txtFile = new StreamReader(file))
                {
                    string fileCont = txtFile.ReadToEnd();
                    _gui.Message(fileCont);
                    if (string.IsNullOrWhiteSpace(fileCont))
                    {
                        throw new Exception(_gui.EmptyFile());
                    }
                    _fileList.files.AddRange(fileCont.Split('\n'));
                    byte countError = ReadTXTFile(fileCont);
                    _gui.ShowErrorCount(countError);
                    _gui.Readkey();
                }
            }
            catch (FileNotFoundException)
            {
                _gui.FileNotFound();
                _gui.Readkey();
            }
            catch (IOException)
            {
                _gui.ReadingError();
                _gui.Readkey();
            }
            catch (Exception e)
            {
                _gui.Message(e.Message);
            }
            finally
            {
                _gui.FinalMessage();
            }
        }

        /// <summary>
        /// This method will just see if there is word error inside the txt file
        /// </summary>
        /// <param name="fileCont"></param>
        /// <returns></returns>
        private byte ReadTXTFile(string fileCont)
        {
            byte count = 0;

            foreach (string line in fileCont.Split('\n'))
            {
                if (line.Contains("ERROR"))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
