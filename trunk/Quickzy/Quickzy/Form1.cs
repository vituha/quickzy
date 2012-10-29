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
        private List<Folder> folders = new List<Folder>();
        private readonly List<Item> items = new List<Item>();
        private int[] selectedIndexes = new int[3];
        private int correctItemIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFolders();                      // Cчитываем папки
        }

        private void LoadFolders()
        {
            string FoldersDirectory = @"..\..\Images";
            foreach (string folderPath in Directory.EnumerateDirectories(FoldersDirectory))
	        {
                Folder folder = new Folder
                {
                    FolderPath = folderPath,
                    FolderName = Path.GetFileName(folderPath)
                };
                folders.Add(folder);
            }
            cbFolder.DisplayMember = "FolderName";
            cbFolder.ValueMember = "FolderPath";
            cbFolder.DataSource = folders;
        }

        private void ShowImage()
        {
            pbImage.ImageLocation = items[correctItemIndex].FileName;
        }

        private void UpdateAnswerButtons()
        {
            bAnswer1.Text = items[selectedIndexes[0]].Text;
            bAnswer2.Text = items[selectedIndexes[1]].Text;
            bAnswer3.Text = items[selectedIndexes[2]].Text;
        }

        private void SelectCandidates()
        {
            Random random = new Random();
            for (int i = 0; i < selectedIndexes.Length; i++)
            {
                selectedIndexes[i] = FindNextSelectedIndex(random, i);
            }
            int correctIndexInSelectedIndexes = random.Next(0, selectedIndexes.Length);
            correctItemIndex = selectedIndexes[correctIndexInSelectedIndexes];
        }

        private int FindNextSelectedIndex(Random random, int i)
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
                        alreadyChoosen = true;
                        break;
                    }
                }
            } while (alreadyChoosen);
            return choosingRandomCandidate;
        }

        /* Типо Папино
        private int FindNextSelectedIndex2(Random random, int i)
        {
            int choosingRandomCandidate;
            do
            {
                choosingRandomCandidate = random.Next(0, items.Count);
            } while (selectedIndexes.Take(i).Contains(choosingRandomCandidate));
            return choosingRandomCandidate;
        }
         */

        private void LoadItems(string imagePath)
        {
            items.Clear();
            foreach (string fileName in Directory.EnumerateFiles(imagePath))
            {
                Item item = new Item
                {
                    FileName = imagePath + @"\" + fileName,
                    Text = GetTextFromFileName(fileName)
                };
                items.Add(item);
            }
        }

        private string GetTextFromFileName(string fileName)
        {
            return Path.GetFileNameWithoutExtension(fileName);
        }

        private void cbFolder_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedFolderPath = (string)cbFolder.SelectedValue;
            if (selectedFolderPath == null)
            {
                return;
            }
            LoadItems(selectedFolderPath);
            SelectCandidates();
            ShowImage();
            UpdateAnswerButtons();
        }
    }
}
