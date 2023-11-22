using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_App
{
    public partial class Form1 : Form
    {
        string[] listOfFile;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            listOfFile = Services.selectFile();
            //lblAddressFile.Text

            listBox1.Items.Clear();
            foreach (var t in listOfFile)
            {
                listBox1.Items.Add(t);
            }
            bindgride();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAddressFile.Text = "";
            lblDestenation.Text = "";
            lblTotal.Text = "";
            lblUnscCopy.Text = "";
            lblNumOfCopy.Text = "";
            numericOFCopy.Visible = false;
            numericOfUnSuccesCopy.Visible = false;
        }

        int tedad_un ;
        int tedad_suc ;
        private async void btnOperate_Click(object sender, EventArgs e)
        {
            numericOFCopy.Value = 0;
            numericOfUnSuccesCopy.Value = 0;

            int a = bindgride();
            lblTotal.Text = Convert.ToString(a);
            int b = a;
            prgrsBar.Minimum = 0;
            prgrsBar.Maximum = b;
            int c = 0;
            if (listBox1.Items.Count == 0 || lblDestenation.Text == "")
            {
                MessageBox.Show("فایل یا مقصد انتخاب نشده");
            }
            else
            {
                foreach (string file in listBox1.Items)//listOfFile)
                {
                    //prgrsBar.Value = b;
                    
                    lblAddressFile.Text = file;
                    await copy_File(tedad_un, tedad_suc);
                    lblUnscCopy.Text = Convert.ToString(numericOfUnSuccesCopy.Value);
                    lblNumOfCopy.Text = Convert.ToString(numericOFCopy.Value);
                    //b += b;
                    //if (b > 100)
                    //{
                    //    b = 100;
                    //}
                    if (prgrsBar.Value < b)
                    {
                        //prgrsBar.Value = b;
                        prgrsBar.Value++;
                    }

                }
                MessageBox.Show("اتمام عملیات");
                prgrsBar.Value = 0;
            }


        }

        private int bindgride()
        {
            int a = listOfFile.Length;
            lblTotal.Text = Convert.ToString(a);
            return a;
        }

        private void btnSelectDestenation_Click(object sender, EventArgs e)
        {
            lblDestenation.Text = Services.selectDestenation();
        }

        static bool DoesFileExistInSubfolders(string directoryPath, string fileName)
        {
            string[] files = Directory.GetFiles(directoryPath, fileName, SearchOption.AllDirectories);
            return files.Length > 0;
        }




        private Task copy_File(int tedad_un, int tedad_suc)
        {
            return Task.Run(() =>
            {
                string sourceFile = lblAddressFile.Text; //@"C:\Users\sinaa\Downloads\Music\2Pac dj belite all eyes on me.mp3";
                string destinationDirectory = lblDestenation.Text;
                string destinationFile = Path.Combine(destinationDirectory, Path.GetFileName(sourceFile));

                if (DoesFileExistInSubfolders(destinationDirectory, Path.GetFileName(destinationFile)))
                {
                    if (checkBox1.Checked)
                    {
                        MessageBox.Show("فایل مورد نظر در ساب فولدرهای مقصد وجود دارد.");
                    }
                     //tedad_un ++;
                    numericOfUnSuccesCopy.Value++;
                    //lblUnscCopy.Text = Convert.ToString(tedad_un);


                }
                else
                {
                    try
                    {
                        File.Copy(sourceFile, destinationFile);
                        if (checkBox1.Checked)
                        {
                            MessageBox.Show($"فایل '{sourceFile}' به مسیر '{destinationFile}' کپی شد.");
                        }
                        //tedad_suc += 1;
                        //lblNumOfCopy.Text = Convert.ToString(tedad_suc);
                        numericOFCopy.Value++;

                    }
                    catch
                    {
                        MessageBox.Show($"خطا در عملیات کپی فایل: ");
                        //lblNumOfCopy.Text = Convert.ToString(tedad_suc);
                    }
                }
            });
        }








        //private void copy_File(int tedad_un, int tedad_suc)
        //{

        //    string sourceFile = lblAddressFile.Text; //@"C:\Users\sinaa\Downloads\Music\2Pac dj belite all eyes on me.mp3";
        //    string destinationDirectory = lblDestenation.Text;
        //    string destinationFile = Path.Combine(destinationDirectory, Path.GetFileName(sourceFile));

        //    if (DoesFileExistInSubfolders(destinationDirectory, Path.GetFileName(destinationFile)))
        //    {
        //        if (checkBox1.Checked)
        //        {
        //            MessageBox.Show("فایل مورد نظر در ساب فولدرهای مقصد وجود دارد.");
        //        }
        //        tedad_un += 1;
        //        //lblUnscCopy.Text = Convert.ToString(tedad_un);


        //    }
        //    else
        //    {
        //        try
        //        {
        //            File.Copy(sourceFile, destinationFile);
        //            if (checkBox1.Checked)
        //            {
        //                MessageBox.Show($"فایل '{sourceFile}' به مسیر '{destinationFile}' کپی شد.");
        //            }
        //            tedad_suc += 1;
        //            //lblNumOfCopy.Text = Convert.ToString(tedad_suc);

        //        }
        //        catch
        //        {
        //            MessageBox.Show($"خطا در عملیات کپی فایل: ");
        //            lblNumOfCopy.Text = Convert.ToString(tedad_suc);
        //        }
        //    }
        //}

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            if (validatiod())
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                bindgride();
            }
            bindgride();

        }

        bool validatiod()
        {
            bool isValid = true;

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("یک مورد از لیست را انتخاب کنید");
                isValid = false;
                return isValid;
            }

            return isValid;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("برای فایل های تعداد بالا ممکن است باعث ایجاد کندی شود");
            }
        }
    }
}
