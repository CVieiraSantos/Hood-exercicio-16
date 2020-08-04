using System;
using System.Collections.Generic;
using System.Text;

namespace Hood_exercicio16 {
    class Pessoa {
        private string _nome;
        private char _sexo = 'f';
        private int _idade;

        public Pessoa(string nome, char sexo, int idade) {
            _nome = nome;
            _sexo = sexo;
            _idade = idade;
        }

        public string Nome {
            get { return _nome;
            }
            set { 
                if(value != null && value.Length > 1) {
                    _nome = value;
                }
                
            }
        }
        
        public char Sexo {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int Idade {
            get { return _idade; }
            set { _idade = value; }
        }

        

        public bool AceitarOuNaoAceitar() {
            if (_sexo == 'f' && _idade < 25) {
                Console.WriteLine("Aceita");
                Console.WriteLine("Nome " + Nome + "," +  " Sexo " + Sexo + "," +  " Idade " + Idade);
                return true;
            }

            if(_sexo == 'F' && _idade < 25){
                Console.WriteLine("Aceita");
                Console.WriteLine("Nome " + Nome + "," +  " Sexo " + Sexo + "," +  " Idade " + Idade);
                return true;
            }

            else {
                Console.WriteLine("Não aceita");
                Console.WriteLine("Nome " + Nome + "," +  " Sexo " + Sexo + "," +  " Idade " + Idade);
                return false;
            }

        }

       



    }
}
