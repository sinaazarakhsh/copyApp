using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_App
{
    internal class Services
    {
        public static string[] selectFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string[] sourceFiles = openFileDialog.FileNames; // آرایه‌ای از فایل‌های انتخاب شده را دریافت می‌کنید
                    return sourceFiles;                                                //  string selectedFilePath = openFileDialog.FileName;
                                                                     //label1.Text = sourceFiles[2];
                }
                else
                {
                    return null; // در صورتی که کاربر انتخاب فایل را لغو کند، برنامه را خروجی می‌دهید
                }
            }
        }


        public static string selectDestenation() 
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    //Console.WriteLine("Selected Folder: " + selectedFolder);
                    //label2.Text = selectedFolder;
                    return selectedFolder;
                }
                else
                {
                    return null;
                }
            }
        }


        






    }
}
