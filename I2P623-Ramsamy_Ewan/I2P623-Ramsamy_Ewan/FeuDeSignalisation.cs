using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_Ramsamy_Ewan
{
    internal class FeuDeSignalisation
    {
        private uint _couleur;
        private string _identifiant;
        private bool _allume;

        public FeuDeSignalisation(string identifiant, uint couleur, bool allume)
        {
            _identifiant = identifiant;
            _couleur = couleur;
            _allume = allume;
        }

        public string Identifiant
        {
            get { return _identifiant; }
        }
        public uint Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public bool Allume
        {
            get { return _allume; }
            set { _allume = !value; }
        }

        public int Change(uint couleur, string identifiant)
        {
            if (couleur > 3) 
            { 
                couleur = couleur - 3;
            }
            if (couleur == 1)
            {
                Console.WriteLine("Le feu de singalisation " + identifiant + " est vert");
                couleur = 2;
            }
            else if (couleur == 2)
            {
                Console.WriteLine("Le feu de singalisation " + identifiant + " est orange");
                couleur = 3;
            }
            else
            {
                Console.WriteLine("Le feu de singalisation " + identifiant + " est rouge");
                couleur = 1;
            }
            return couleur;
        }
        public bool Clignote(string identifiant, bool allume) 
        {
            if (allume == true)
            {
                Console.WriteLine("Le feu de singalisation " + identifiant + " est allumé");
            }
            else
            {
                Console.WriteLine("Le feu de singalisation " + identifiant + " est éteint");
            }
            allume = !allume;
            return allume;
        } //pas fini
        public string AfficherCara()
        {
            string etat;
            string eclairage;

            if (_allume == true)
            {
                etat = "allumé";
            }
            else
            {
                etat = "éteint";
            }
            if (_couleur == 1)
            {
                eclairage = "vert";
            }
            else if (_couleur == 2)
            {
                eclairage = "rouge";
            }
            else
            {
                eclairage = "orange";
            }

            string chaine = "Etat des feux : \n --------------- \n Le feu de signalisation " + _identifiant + " est " + etat + " et de couleur " + eclairage + " \n \n Changement d'état : \n ---------------";
            Change(couleur, identifiant);

            return chaine;
        }
    }
}
