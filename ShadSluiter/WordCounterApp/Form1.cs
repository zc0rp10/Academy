using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_createWordList_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArray = allWords.Split(' ', ',', '.', '!', '-');

            foreach (var word in wordsArray)
            {
                // Only add word if not already in the list.
                if (!listBox1.Items.Contains(word))
                {
                    listBox1.Items.Add(word);
                }
            }
        }

        private void btn_sortWordList_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btn_countWords_Click(object sender, EventArgs e)
        {
            string allWords = textBox1.Text;
            string[] wordsArr = allWords.Split(' ', ',', '.', '!', '-');

            // Create new EMPTY list to hold all our WORD objects.
            List<Word> words = new List<Word>();

            // Look through each word in the wordsArr...
            foreach (var item in wordsArr)
            {
                // ..and checks it against the words list..
                Word foundWord = words.Find(word => word.Value == item);

                if (foundWord == null)
                {
                    // .. IF the word is not in the list. Add it, and set frequency to 1.
                    words.Add(new Word(item, 1));
                }
                else
                {
                    //.. ELSE the word is found in the list and then Increment frequency instead.
                    foundWord.Frequency++;
                }
            }

            // Set up th view and columns for the list view.
            listView1.Columns.Add("Frequency", 130);
            listView1.Columns.Add("Word", 130);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;

            foreach (Word word in words)
            {
                string[] rowItem = new string[] { word.Frequency.ToString("D5"), word.Value };
                listView1.Items.Add(new ListViewItem(rowItem));
            }
        }
    }
}
