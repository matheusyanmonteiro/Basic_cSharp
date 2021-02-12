using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento_basic
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome)
        {
            _nome = nome;
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // method get and set
        //nome  os get e set foram substituidos pela função props uma ferramenta do c#.
        /*public string GetNome()
        {
            return _nome;
        }
        
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }*/
        //preco
        public double GetPreco()
        {
            return _preco;
        }

        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        //Quantidade
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        //props in c#

        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }



    }
}
