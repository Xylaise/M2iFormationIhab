using System;
using System.Collections.Generic;
using System.Text;

namespace PileGenerique
{
    class Mangas
    {
        string titre;
        int numeroTome;

        public Mangas(string titre, int nbTome)
        {
            this.Titre = titre;
            this.numeroTome= nbTome;
        }

        public string Titre { get => titre; set => titre = value; }
        public int NbTome { get => numeroTome; set => numeroTome = value; }
    }
}
