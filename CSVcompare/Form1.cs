using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSVcompare
{
    public partial class FrmCSVcmpr : Form
    {
        public FrmCSVcmpr()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbxExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxExcel.Checked)
            {
                chkbxExcel.Text = "Open Excel  -  ✓";
            }
            else
            {
                chkbxExcel.Text = "Open Excel  -  ?";
            }
        }

        private void txtbxFile1_Click(object sender, EventArgs e)
        {            
            if (Directory.Exists("C:\\Users\\" + Environment.UserName))
            {
                OpenFile.InitialDirectory = "C:\\Users\\" + Environment.UserName;
            }
            else if (Directory.Exists("C:\\Documents and Settings\\" + Environment.UserName))
            {
                OpenFile.InitialDirectory = "C:\\Documents and Settings\\" + Environment.UserName;
            }

            DialogResult result; 

            //OpenFile.FileName = BaseFileName;
            result = OpenFile.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                //the user decided against starting
                //DispMsg("You must select a file!");
            }
            else
            {
                txtbxFile1.Text = OpenFile.FileName;
            }

        }

        private void txtbxFile2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\Users\\" + Environment.UserName))
            {
                OpenFile.InitialDirectory = "C:\\Users\\" + Environment.UserName;
            }
            else if (Directory.Exists("C:\\Documents and Settings\\" + Environment.UserName))
            {
                OpenFile.InitialDirectory = "C:\\Documents and Settings\\" + Environment.UserName;
            }

            DialogResult result;

            //OpenFile.FileName = BaseFileName;
            result = OpenFile.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                //the user decided against starting
                //DispMsg("You must select a file!");
            }
            else
            {
                txtbxFile2.Text = OpenFile.FileName;
            }
        }

        private void DispMsg(string msg2disp)
        {
            MessageBox.Show(msg2disp, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (txtbxFile1.Text == "<Click here to browse for file>" || txtbxFile2.Text == "<Click here to browse for file>")
            {
                DispMsg("You must select a file for File # 1 & 2!!");
            }
            else if (txtbxFile2.Text == txtbxFile1.Text)
            {
                DispMsg("You've selected the same file for each!!!");
                txtbxFile2.Text = "<Click here to browse for file>";
            }
            else
            {
                //do stuff
                CompareFiles(txtbxFile1.Text, txtbxFile2.Text);
            }
        }

        private void CompareFiles(string f1, string f2)
        {
            //string f1_contents = File.ReadAllText(f1);
            string[] f1_contents = File.ReadAllLines(f1);
            //string f2_contents = File.ReadAllText(f2);
            string[] f2_contents = File.ReadAllLines(f2);
            string tmpstring1 = "";
            string tmpstring2 = "";
            bool WasFoundInFile = false;
            string CurrentFileName = OpenFile.InitialDirectory + "\\" + "FileCompare" + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv"; //unique for every run
            int i = 0;
            int k = 0;

            for (i = 0; i < f1_contents.Length; i++)
            {
                for (k = 0; k < f2_contents.Length; k++)
                {
                    tmpstring1 = f1_contents[i].Remove(f1_contents[i].LastIndexOf(",")); //clear off grade level
                    tmpstring2 = f2_contents[k].Remove(f2_contents[k].LastIndexOf(",")); // ^^
                    if (String.Equals(tmpstring1, tmpstring2, StringComparison.OrdinalIgnoreCase)) //case insensitive search
                    {
                        //this line is in both files
                        WasFoundInFile = true;
                        break; //leave inner for loop, search no further
                    }
                    else if (tmpstring2.Contains(tmpstring1.Remove(tmpstring1.IndexOf(","))+"/"))
                    {
                        //this line is in both files, there are some shortened names in files noted by slashes
                        WasFoundInFile = true;
                        break; //leave inner for loop, search no further
                    }
                }
                if (!WasFoundInFile)
                {
                    if (!File.Exists(CurrentFileName))
                    {
                        //write column headers for csv file
                        using (StreamWriter SW = new StreamWriter(CurrentFileName, true))   //true makes it append to the file instead of overwrite
                        {
                            SW.WriteLine("File Absent From,First Name,Last Name,Class"); //column headers for csv
                            SW.Close();
                        }
                    }
                    using (StreamWriter SW = new StreamWriter(CurrentFileName, true))   //true makes it append to the file instead of overwrite
                    {
                        SW.WriteLine(lblFile2.Text +","+ f1_contents[i].ToString());
                        SW.Close();
                    }
                }
                else
                {
                    WasFoundInFile = false;
                }
            }

            WasFoundInFile = false;

            for (i = 0; i < f2_contents.Length; i++)
            {
                for (k = 0; k < f1_contents.Length; k++)
                {
                    tmpstring1 = f1_contents[k].Remove(f1_contents[k].LastIndexOf(",")); //clear off grade level
                    tmpstring2 = f2_contents[i].Remove(f2_contents[i].LastIndexOf(",")); // ^^
                    if (String.Equals(tmpstring2, tmpstring1, StringComparison.OrdinalIgnoreCase)) //case insensitive
                    {
                        //this line is in both files
                        WasFoundInFile = true;
                        break; //leave inner for loop, search no further
                    }
                    else if (tmpstring1.Contains((tmpstring2.Remove(tmpstring2.IndexOf(",")) + "/")))
                    {
                        //this line is in both files, there are some shortened names in files noted by slashes
                        WasFoundInFile = true;
                        break; //leave inner for loop, search no further
                    }
                }
                if (!WasFoundInFile)
                {
                    if (!File.Exists(CurrentFileName))
                    {
                        //write column headers for csv file
                        using (StreamWriter SW = new StreamWriter(CurrentFileName, true))   //true makes it append to the file instead of overwrite
                        {
                            SW.WriteLine("File Absent From,First Name,Last Name,Class"); //column headers for csv
                            SW.Close();
                        }
                    }
                    using (StreamWriter SW = new StreamWriter(CurrentFileName, true))   //true makes it append to the file instead of overwrite
                    {
                        SW.WriteLine(lblFile1.Text +","+ f2_contents[i].ToString());
                        SW.Close();
                    }
                }
                else
                {
                    WasFoundInFile = false;
                }
            }

            DispMsg("All Done!");

            if (chkbxExcel.Checked)
            {
                //open csv in excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                excelApp.Workbooks.OpenText(CurrentFileName);
            }


        }
    }
}
