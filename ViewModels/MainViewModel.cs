using OmatkoboskaNotatnik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmatkoboskaNotatnik.ViewModels
{
    public class MainViewModel
    {
        private DokumentModel _dokument;
        public EditorViewModel Editor { get; set; }
        public FileViewModel File { get; set; }
        public HelpViewModel Help { get; set; }

        public MainViewModel()
        {
            _dokument = new DokumentModel();
            Help = new HelpViewModel();
            Editor = new EditorViewModel(_dokument);
            File = new FileViewModel(_dokument);

        }
    }
}
