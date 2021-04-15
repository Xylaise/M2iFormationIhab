using System;
using System.Collections.Generic;
using System.Text;

namespace PileGenerique
{
    class Pile <T>
    {
        private T[] pilesObjets;
        private int length;

        public Pile(int taille)
        {
            this.pilesObjets = new T[taille];
            this.length = taille;
        }

        public void Empiler(T objet)
        {
            for (int i = 0; i < pilesObjets.Length; i++)
            {
                if (pilesObjets[i].Equals(default(T)))
                {
                    pilesObjets[i] = objet;
                    break;
                }
            }
        }

        public void Depiler(T objet)
        {
            T[] objetTampon = new T[pilesObjets.Length];

            for (int i = pilesObjets.Length; i >= 0; i--)
            {
                for (int j = 0; j < objetTampon.Length; j++)
                {
                    while (pilesObjets[i]!= objet)
                    {
                        objetTampon[j] = pilesObjets[i];
                    }                 
                }
            }

            for (int ii = 0; ii < pilesObjets.Length; ii--)
            {
                for (int jj = objetTampon.Length; jj >= 0 ; jj--)
                {
                    if (!objetTampon[jj].Equals(default(T)) && pilesObjets[ii].Equals(objet))
                    {
                        pilesObjets[ii] = objetTampon[jj];
                    }
                }
            }
        }

        public T AfficherElement(int index)
        {
            if (pilesObjets[index] != null)
            {
                return pilesObjets[index];
            }
            else
                return default(T);
        }
    }
}
