using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Quickzy
{

    public partial class Form1 : Form
    {
        const int numberOfAltenativeAnswers = 5;

        int nTotal = 0;
        int nCorrect = 0;
        private List<Folder> folders = new List<Folder>();
        private readonly List<Item> items = new List<Item>();
        private readonly List<Item> selectedItems = new List<Item>();
        int nOfQuestions;
        

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFolders();
            SettingsApply();
        }

        private void SettingsApply()
        {
            TimeSpan maxDuration;

            string settingsPath = Environment.CurrentDirectory + @"\settings.txt";
            using (var file = File.Open(settingsPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(file))
            {
                nOfQuestions = int.Parse(reader.ReadLine());
                maxDuration = TimeSpan.FromSeconds(int.Parse(reader.ReadLine()));
                file.Close();
            }
            lblTime.Text = maxDuration.TotalSeconds.ToString();
            timerQuestions.Interval = 1000;
            timerQuestions.Enabled = true;
        }
        private void LoadFolders()
        {
            string FoldersDirectory = Environment.CurrentDirectory + @"\Images";
            string folderPath = Directory.EnumerateDirectories(FoldersDirectory).First();
            Folder folder = new Folder
            {
                FolderPath = folderPath,
                FolderName = Path.GetFileName(folderPath)
            };
            folders.Add(folder);
            cbFolder.DisplayMember = "FolderName";
            cbFolder.ValueMember = "FolderPath";
            cbFolder.DataSource = folders;
            LoadItems(folderPath);
            ShuffleItems();
            SelectCandidates();
            ShowImage();
            UpdateAnswerButtons();
        }

        private void ShuffleItems()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int index = rnd.Next(items.Count);
                if (index > 0)
                {
                    Item tmp = items[0];
                    items[0] = items[index];
                    items[index] = tmp;
                }
            }
        }

        private void ShowImage()
        {
            pbImage.ImageLocation = items[nTotal].FileName;
        }

        private void UpdateAnswerButtons()
        {
            bAnswer1.Text = selectedItems[0].Text;
            bAnswer2.Text = selectedItems[1].Text;
            bAnswer3.Text = selectedItems[2].Text;
            bAnswer4.Text = selectedItems[3].Text;
            bAnswer5.Text = selectedItems[4].Text;
        }

        private void SelectCandidates()
        {
            selectedItems.Clear();
            selectedItems.Add(items[nTotal]);
            for (int i = 1; i < numberOfAltenativeAnswers; i++)
            {
                int candidateItemIndex = random.Next(0, items.Count);
                while (selectedItems.Contains(items[candidateItemIndex])) 
                {
                    candidateItemIndex = random.Next(0, items.Count);
                }
                selectedItems.Add(items[candidateItemIndex]);
            }

            for (int i = 0; i < 100; i++)
            {
                int first = random.Next(0, selectedItems.Count);
                int second = random.Next(0, selectedItems.Count);
                Item temp = selectedItems[first];
                selectedItems[first] = selectedItems[second];
                selectedItems[second] = temp;
            }
        }

        private void LoadItems(string folderPath)
        {
            items.Clear();
            foreach (string fileName in Directory.EnumerateFiles(folderPath))
            {
                Item item = new Item
                {
                    FileName = fileName,
                    Text = GetTextFromFileName(fileName)
                };
                items.Add(item);

            }
        }

        private string GetTextFromFileName(string fileName)
        {
            return Path.GetFileNameWithoutExtension(fileName);
        }

        private void bAnswer1_Click(object sender, EventArgs e)
        {
            CompleteAnswer(selectedItems[0]);
        }

        private void bAnswer2_Click(object sender, EventArgs e)
        {
            CompleteAnswer(selectedItems[1]);
        }

        private void bAnswer3_Click(object sender, EventArgs e)
        {
            CompleteAnswer(selectedItems[2]);
        }

        private void bAnswer4_Click(object sender, EventArgs e)
        {
            CompleteAnswer(selectedItems[3]);
        }

        private void bAnswer5_Click(object sender, EventArgs e)
        {
            CompleteAnswer(selectedItems[4]);
        }

        private void CompleteAnswer(Item answer)
        {
            if (items[nTotal].Text == answer.Text)
            {
                nCorrect++;
                lblCorrectAnswers.Text = nCorrect.ToString();
            }
            nTotal++;
            lblTotalAnswers.Text = nTotal.ToString();

            if (nOfQuestions == nTotal)
            {
                lblResultCorrect.Text = lblCorrectAnswers.Text;
                lblResultTotal.Text = lblTotalAnswers.Text;
                pnlQuestions.Visible = false;
            }
            else 
            {
                SelectCandidates();
                ShowImage();
                UpdateAnswerButtons();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string tempFolder = Environment.CurrentDirectory + @"\Images";
            string tempFile = Environment.CurrentDirectory + @"\settings.txt";
            foreach (string folder in Directory.EnumerateDirectories(tempFolder))
            {
                Directory.Delete(folder, true);
                File.Delete(tempFile);
            }
        }

        private void timerQuestions_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = TimeSpan.FromSeconds(int.Parse(lblTime.Text));
            TimeSpan interval = TimeSpan.FromMilliseconds(timerQuestions.Interval);
            remainingTime = remainingTime - interval;
            if (remainingTime.TotalSeconds == 0)
            {
                lblResultCorrect.Text = lblCorrectAnswers.Text;
                lblResultTotal.Text = lblTotalAnswers.Text;
                pnlQuestions.Visible = false;
            }
            else
            {
                timerQuestions.Enabled = true;
                lblTime.Text = remainingTime.TotalSeconds.ToString();
            }
        }
    }
}



