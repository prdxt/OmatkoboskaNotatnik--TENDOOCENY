using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmatkoboskaNotatnik.Models
{
    public class DokumentModel : ObservableObject
    {
        private string _text;
        public string Text
        {
            get 
            {
                return _text; 
            }
            set 
            { 
                OnPropertyChanged(ref _text, value);


            }

        }

        private string _fileSciezka;
        public string FileSciezka
        {
            get
            {
                return _fileSciezka;
            }
            set
            {
                OnPropertyChanged(ref _fileSciezka, value);


            }

        }

        private string _nazwaPliku;
        public string NazwaPliku
        {
            get
            {
                return _nazwaPliku;
            }
            set
            {
                OnPropertyChanged(ref _nazwaPliku, value);


            }

        }
        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(NazwaPliku) || string.IsNullOrEmpty(FileSciezka))
                    return true;
                return false;
            }
        }

    }
}
