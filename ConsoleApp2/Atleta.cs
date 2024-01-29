using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Atleta
    {
        private string _nome;
        private string _cognome;
        private int _età;
        private string _sport;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public int Età
        {
            get
            {
                return _età;
            }
            set
            {
                _età = value;
            }
        }

        public string Sport
        {
            get
            {
                return _sport;
            }
            set
            {
                _sport = value;
            }
        }

    }
}
