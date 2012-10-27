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
        private readonly List<Item> items = new List<Item>();
        private int[] selectedIndexes = new int[3];
        private int correctItemIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadItemsFromFolder();              // Считываем файлы
            SelectCandidates();                 // Выбираем случайные и правильный из них
            ShowImage();                        // Загружаем картинку
            UpdateRadioButtons();               // Обновляем варианты
        }

        private void LoadItemsFromFolder()
        {
            LoadItems(@"..\..\Images\Машины");
        }

        private void ShowImage()
        {
            pbImage.ImageLocation = items[correctItemIndex].FileName;
        }

        private void UpdateRadioButtons()
        {
            llAnswer1.Text = items[selectedIndexes[0]].Text;
            llAnswer2.Text = items[selectedIndexes[1]].Text;
            llAnswer3.Text = items[selectedIndexes[2]].Text;
        }

        private void SelectCandidates()
        {
            Random random = new Random();
            for (int i = 0; i < selectedIndexes.Length; i++)
            {
                bool alreadyChoosen;
                do
                {
                    alreadyChoosen = false;
                    int choosingRandomCandidate = random.Next(0, items.Count);
                    for (int j = 0; j < i; j++) // Выбирание случайных кандидатов и проверка - не одинаковы ли они
                    {
                        if (selectedIndexes[j] == choosingRandomCandidate)
                        {
                            alreadyChoosen = true;
                            break;
                        }
                    }
                } while (alreadyChoosen);
            }
            int correctIndexInSelectedIndexes = random.Next(0, selectedIndexes.Length);
            correctItemIndex = selectedIndexes[correctIndexInSelectedIndexes];
        }


        private void LoadItems(string imagePath)
        {
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
    }
}
