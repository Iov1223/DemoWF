using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DemoWF
{
    internal class FileIO
    {
        string name, path;

        public FileIO(string path, string name = "Документ")
        {
            this.name = name;
            this.path = path;
        }
        public static string Browse()
        {
            var openFile = new OpenFileDialog();
            //OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = myDoc();
            openFile.Filter = "rtf files (*.rtf)|*.rtf";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                return openFile.FileName;
            }
            throw new Exception("Не удалось выбрать файл");
        }
        public static string SaveAs()
        {
            var saveAsFile = new SaveFileDialog();
            saveAsFile.InitialDirectory = myDoc();
            saveAsFile.Filter = "rtf files (*.rtf)|*.rtf";
            DialogResult result = saveAsFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                return saveAsFile.FileName;
            }
            throw new Exception("Не удалось сохранить файл");
        }
        public static string myDoc()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
