using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Veicolo
    {
        private string _tipoVeicolo;
        private string _marca;
        private int _immatricolazione;

        public string TipoVeicolo {
            get {
                return _tipoVeicolo;
            }
            set {
                _tipoVeicolo = value;
            }
        }

        public string Marca
        {
            get {
                return _marca;
            }
            set {
                _marca = value;
            }
        }

        public int Immatricolazione
        {
            get {
                return _immatricolazione;
            }
            set {
                _immatricolazione = value;
            }
        }
    }
}
