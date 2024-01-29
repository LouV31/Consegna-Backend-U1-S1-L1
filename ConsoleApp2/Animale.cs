using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animale
    {
        private string _famiglia;
        private string _razza;
        private string _nome;
        private int _età;

        public string Famiglia
        {
            get {
                return _famiglia;
            }
            set {
                _famiglia = value;
            }
        }

        public string Razza
        {
            get
            {
                return _razza;
            }
            set
            {
                _razza = value;
            }
        }

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

    }
}
