﻿using System;
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
        int nTotal = 0;
        int nCorrect = 0;
        private List<Folder> folders = new List<Folder>();
        private readonly List<Item> items = new List<Item>();
        private int[] selectedIndexes = new int[5];
        private int correctItemIndex;
        int nOfQuestions;
        int num = 0;

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var settingForm = new Form2())
            {
                if (DialogResult.Cancel == settingForm.ShowDialog())
                {
                    Close();
                    return;
                }
            }

            LoadFolders();
            SettingsApply();
        }

        private void SettingsApply()
        {
            TimeSpan maxDuration;

            string settingsPath = @"..\Quickzy_Prog\settings.txt";
            using (var file = File.Open(settingsPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new StreamReader(file))
            {
                nOfQuestions = int.Parse(reader.ReadLine());
                maxDuration = TimeSpan.FromSeconds(int.Parse(reader.ReadLine()));
                file.Close();
            }
            timerQuestions.Interval = (int)maxDuration.TotalMilliseconds;
            timerQuestions.Enabled = true;
        }

        private void LoadFolders()
        {
            string FoldersDirectory = @"..\Quickzy_Prog\Images";
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
            ShuffleCandidates();
            ShowImage();
            UpdateAnswerButtons();
        }

        private void ShuffleCandidates()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int index = rnd.Next(selectedIndexes.Length);
                if (index >= 0 && index < 6)
                {
                    int tmp = selectedIndexes[0];
                    selectedIndexes[0] = selectedIndexes[index];
                    selectedIndexes[index] = tmp;

                }
            }
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
            pbImage.ImageLocation = items[num].FileName;
        }

        private void UpdateAnswerButtons()
        {
            ShuffleCandidates();
            bAnswer1.Text = items[selectedIndexes[0]].Text;
            bAnswer2.Text = items[selectedIndexes[1]].Text;
            bAnswer3.Text = items[selectedIndexes[2]].Text;
            bAnswer4.Text = items[selectedIndexes[3]].Text;
            bAnswer5.Text = items[selectedIndexes[4]].Text;
        }

        private void SelectCandidates()
        {
            for (int i = 0; i < selectedIndexes.Length - 1; i++)
            {
                selectedIndexes[i] = FindNextSelectedIndex(i);
            }
            int correctIndexInSelectedIndexes = random.Next(0, selectedIndexes.Length);
            correctItemIndex = selectedIndexes[correctIndexInSelectedIndexes];
            selectedIndexes[4] = num;
        }

        private int FindNextSelectedIndex(int i)
        {
            int choosingRandomCandidate;
            bool alreadyChoosen;
            do
            {
                alreadyChoosen = false;
                choosingRandomCandidate = random.Next(0, items.Count);
                for (int j = 0; j < i; j++)         // Выбирание случайных кандидатов и проверка - не одинаковы ли они
                {
                    if (selectedIndexes[j] == choosingRandomCandidate)
                    {
                        if (items[num].Text != items[choosingRandomCandidate].Text)
                        {
                            alreadyChoosen = true;
                            break;
                        }
                    }
                }
            } while (alreadyChoosen);
            return choosingRandomCandidate;
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
            Refreshing(0);
        }

        private void bAnswer2_Click(object sender, EventArgs e)
        {
            Refreshing(1);
        }

        private void bAnswer3_Click(object sender, EventArgs e)
        {
            Refreshing(2);
        }

        private void Refreshing(int answer)
        {
            if (items[num].Text == items[selectedIndexes[answer]].Text)
            {
                num++;
                if (num == 5)
                {
                    num = 0;
                    ShuffleItems();
                }
                nTotal++;
                nCorrect++;
                SelectCandidates();
                ShowImage();
                UpdateAnswerButtons();

            }
            else
            {
                num++;
                if (num == 5)
                {
                    num = 0;
                    ShuffleItems();
                }
                nTotal++;
                SelectCandidates();
                ShowImage();
                UpdateAnswerButtons();
            }
            lblCorrectAnswers.Text = nCorrect.ToString();
            lblTotalAnswers.Text = nTotal.ToString();

            if (nOfQuestions == nTotal)
            {
                lblResultCorrect.Text = lblCorrectAnswers.Text;
                lblResultTotal.Text = lblTotalAnswers.Text;
                pnlQuestions.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string tempFolder = @"..\Quickzy_Prog\Images";
            string tempFile = @"..\Quickzy_Prog\settings.txt";
            foreach (string folder in Directory.EnumerateDirectories(tempFolder))
            {
                Directory.Delete(folder, true);
                File.Delete(tempFile);
            }
        }

        private void timerQuestions_Tick(object sender, EventArgs e)
        {
            lblResultCorrect.Text = lblCorrectAnswers.Text;
            lblResultTotal.Text = lblTotalAnswers.Text;
            pnlQuestions.Visible = false;
        }

        private void bAnswer4_Click(object sender, EventArgs e)
        {
            Refreshing(3);
        }

        private void bAnswer5_Click(object sender, EventArgs e)
        {
            Refreshing(4);
        }




    }
}


