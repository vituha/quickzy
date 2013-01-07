using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Editor
{
    public partial class Form2 : Form
    {
        private List<Folder> folders = new List<Folder>();

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

        private void SetNumberOfQuestionsTime()
        {
            string filePath = @"..\Quickzy_Prog\settings.txt";
            using (var file = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                using (var writer = new StreamWriter(file))
                {
                    writer.WriteLine(GetNumberOfQuestions());
                    writer.WriteLine(tbTime.Text);
                }
                file.Close();
            }
        }

        private int GetNumberOfQuestions()
        {
            return int.Parse(tbNumberOfQuestions.Text);
        }

        private void ChooseSubject()
        {
            string sourceFolder = GetSourceFolder();
            string destinationFolder = GetDestinationFolder();
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

        private string GetDestinationFolder()
        {
            return @"..\Quickzy_Prog\" + cbSubject.SelectedValue + @"\";
        }

        private string GetSourceFolder()
        {
            return cbSubject.SelectedValue.ToString() + @"\";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e.Cancel)
            {
                if (Validate())
                {
                    ChooseSubject();
                    SetNumberOfQuestionsTime();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbNumberOfQuestions_Validating(object sender, CancelEventArgs e)
        {
            int fileCount = Directory.EnumerateFiles(GetSourceFolder()).Count();
            int questionCount = GetNumberOfQuestions();
            if (fileCount < questionCount)
            {
                MessageBox.Show("Количество вопросов должно быть не больше количества файлов в папке!");
                e.Cancel = true;
            }
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


