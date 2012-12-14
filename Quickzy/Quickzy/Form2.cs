using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quickzy
{
    public partial class Form2 : Form
    {
        private List<Folder> folders = new List<Folder>();
        private readonly List<Item> items = new List<Item>();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadFolders();
        }
        
        private void LoadFolders()
        {
            string FoldersDirectory = @"Images";
            foreach (string folderPath in Directory.EnumerateDirectories(FoldersDirectory))
            {
                Folder folder = new Folder
                {
                    FolderPath = folderPath,
                    FolderName = Path.GetFileName(folderPath)
                };
                folders.Add(folder);
            }
            cbSubject.DisplayMember = "FolderName";
            cbSubject.ValueMember = "FolderPath";
            cbSubject.DataSource = folders;
        }

        private void bOK_Click(object sender, EventArgs e)
        {

            ChooseSubject();
            SetNumberOfQuestionsTime();

        }

        private void SetNumberOfQuestionsTime()
        {
            string filePath = @"..\Quickzy_Prog\settings.txt";
            using (var file = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.WriteLine(tbNumberOfQuestions.Text);
                    writer.WriteLine(tbTime.Text);
                }
                file.Close();
            }
        }

        private void ChooseSubject()
        {
            string sourceFolder = cbSubject.SelectedValue.ToString() + @"\";
            string destinationFolder = @"..\Quickzy_Prog\" + cbSubject.SelectedValue + @"\";
            if (Directory.Exists(destinationFolder))
            {
                Directory.Delete(destinationFolder, true);
            }
            Directory.CreateDirectory(destinationFolder);
            foreach (string file in Directory.EnumerateFiles(sourceFolder))
            {
                string fileName = Path.GetFileName(file);
                File.Copy(sourceFolder + fileName, destinationFolder + fileName);
            }
        }

    }
}


