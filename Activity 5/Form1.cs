using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Our Variables
        String str;
        int max_val = 0;
        int max_index = 0;
        int vow_count = 0;
        int vow_index;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLowerCase.Text = "";
            txtAlphabetical.Text = "";
            txtLongestWord.Text = "";
            txtMostVowels.Text = ""; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Open File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Document";
            ofd.Filter = "TXT File|*.txt";
            // See the open file 
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.SafeFileName);
                // Read text from file and convert to string. 
                str = System.IO.File.ReadAllText(ofd.FileName);
                // 1. Convert text to lowercase.
                /* To achieve this we will utilize the ToLower(); method. */
                txtLowerCase.Text = str.ToLower();
                // 2. Find the first and last word alphabetically.
                /* To achieve this we will create an array and seperate the string into individual words using str.Split(' ').
                 * Here we are indicating that every word between ' ' is a seperate string in our array. Then, using 
                Array.Sort(array), we will sort the array alphabetically. Now, we can find the first and last word in the
                array by its index.*/
                string[] array = str.Split(' ');
                Array.Sort(array);
                txtAlphabetical.Text = array[0] + " " + array[array.Length - 1];

                /* 3. & 4., Find the longest word and find the word with the most vowels. We achieve this by creating
                 a for loop that will allow us to count the number of letters and number of vowels in the words we have
                stored in our array.*/
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (max_val < array[i].Length)
                    {
                        max_val = array[i].Length;
                        max_index = i;
                    }
                    if (vow_count < VowelNum(array[i]))
                    {
                        vow_count = VowelNum(array[i]);
                        vow_index = i;
                    }
                }

                // Outprint results for 3. and 4. 
                txtLongestWord.Text = array[max_index];
                txtMostVowels.Text = array[vow_index];

                /* Here we write to the new text file which will be saved on our computer in a file we have named statistics.txt.
                We specify we want this file to include the text we have displayed in each of our textboxes.*/
                try
                {
                    StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\statistics.txt");
                    sw.WriteLine("Text from file in lower case: " + txtLowerCase.Text);
                    sw.WriteLine("First and last word alphabetically: " + txtAlphabetical.Text);
                    sw.WriteLine("Longest word in file: " + txtLongestWord.Text);
                    sw.WriteLine("Word with the most vowels: " + txtMostVowels.Text);
                    sw.Close();
                    // Display a message box confirming the text file has been created successfully. 
                    MessageBox.Show("Your file containing statistical information has been created.");
                }
                catch
                {
                    /* Firewalls among other things could pose an issue. In case this fails, we advise users to try
                    running the program as an administrator.*/
                    MessageBox.Show("We could not access this file. Try running this program as administrator.");
                }
            }
        }

        /* VowelNum Method, used to calculate the number of vowels in a word. The following code for this method was
         * inspired by TutorialsPoint. View reference: https://www.tutorialspoint.com/Chash-Program-to-count-vowels-in-a-string */
        public int VowelNum(string word)
            {
                int vowels = 0;
                for (int i = 0; i < word.Length - 1; i++)
                 {
                      if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || 
                     (word[i] == 'A' || word[i] == 'E' || word[i] ==
                     'I' || word[i] == 'O' || word[i] == 'U'))
                     {
                         vowels++;
                     } 

            }
                return vowels;
            }


        }
    }

