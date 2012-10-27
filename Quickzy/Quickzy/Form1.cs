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
        private readonly List<Item> items = new List<Item>();
        private int[] selectedIndexes = new int[3];
        private int correctItemIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadItems(@"..\..\Images\Машины");
            SelectCandidates();
            ShowImage();
            UpdateRadioButtons();
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
                selectedIndexes[i] = random.Next(0, items.Count);
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
