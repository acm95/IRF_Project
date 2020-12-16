using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Gyerekek
    {
        private string _vezeteknev;
        private string _keresztnev;
        private int _age;
        private string _csoport;
        private bool _betegseg;

        public string Vezeteknev
        {
            get
            {
                return _vezeteknev;
            }
            set
            {
                _vezeteknev = value;
            }

        }



        public string Keresztnev
        {
            get
            {
                return _keresztnev;
            }
            set
            {
                _keresztnev = value;
            }
        }


        public int Kor
        {
            get
            {
                return _age;
            }

            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }


        public string Csoport
        {
            get
            {
                return _csoport;
            }
            set
            {
                _csoport = value;
            }
        }
        public bool Betegseg
        {
            get
            {
                return _betegseg;
            }
            set
            {
                if (_betegseg == true)
                {
                    _betegseg = true;
                }
                _betegseg = false;
            }
        }
    }
}
