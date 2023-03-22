using OmatkoboskaNotatnik.Models;
using System;
using System.Windows.Input;

namespace OmatkoboskaNotatnik.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format {get; set;}
        public DokumentModel Dokument { get; set;}

        public EditorViewModel(DokumentModel dokument)
        {
            Dokument = dokument;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
            
        }

        private void OpenStyleDialog()
        {
            //otwieramy tu wybór stylow 
            throw new NotImplementedException();
        }

        private void ToggleWrap()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            else
                Format.Wrap = System.Windows.TextWrapping.Wrap;

        }

    }
}
