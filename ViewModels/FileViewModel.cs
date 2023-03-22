using Microsoft.Win32;
using OmatkoboskaNotatnik.Models;
using System.IO;
using System.Windows.Input;

namespace OmatkoboskaNotatnik.ViewModels
{
    public class FileViewModel
    {
        public DokumentModel Dokument { get; private set; }

        public ICommand NewCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand SaveAsCommand { get; }
        public ICommand OpenCommand { get; }

        public FileViewModel(DokumentModel dokument)
        {
            Dokument = dokument;
            NewCommand = new RelayCommand(NewFile);
            SaveCommand = new RelayCommand(SaveFile, () => !Dokument.isEmpty);
            SaveAsCommand = new RelayCommand(SaveFileAs);
            OpenCommand = new RelayCommand(OpenFile);

        }
        // nowy plik 
        public void NewFile()
        {
            Dokument.NazwaPliku = string.Empty;
            Dokument.FileSciezka = string.Empty;
            Dokument.Text = string.Empty;
        }

       // Zapisywanie pliku gdy juz jest on zapisywany na komputerze
       // "aktualizacja" pliku
        private void SaveFile()
        {
            File.WriteAllText(Dokument.FileSciezka, Dokument.Text);

        }

        //Zapisywanie nowego pliku na komputer
        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Dokument.Text);
            }
        }
        //otwieranie pliku z komputera
        private void OpenFile() 
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Dokument.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void DockFile<T>(T dialog)where T : FileDialog
        {
            Dokument.FileSciezka = dialog.FileName;
            Dokument.NazwaPliku = dialog.SafeFileName;
        }

    }
}
