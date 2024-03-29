﻿using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posicao {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao+1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando capacidade da lista");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
            for(int i = 0; i< _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens = novoArray;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i=0; i<_proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if(contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = 0; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public ContaCorrente VerificarMaiorSaldo()
        {
            ContaCorrente conta = null;
            double maiorValor = 0;
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    if (maiorValor < _itens[i].Saldo)
                    {
                        maiorValor = _itens[i].Saldo;
                        conta = _itens[i];
                    }
                }

            }
            //foreach (var item in _itens)
            //{
            //    Console.WriteLine(item);
            //    if (item.Saldo > maiorConta.Saldo)
            //    {
            //        maiorConta = item;
            //    }
            //}
            return conta;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)  Console.WriteLine($"Indice{i} = Conta: {_itens[i].Conta} - AG: {_itens[i].Numero_agencia}");
            }
        }

        public ContaCorrente RecuperarContaNoIndex(int indice)
        {
            if(indice<0 || indice>= Tamanho)
            {
                throw new ArgumentException("Indice precisa ser maior que 0 ", nameof(indice));
            }
            else
            {
                return _itens[indice];
            }
        }

        public int Tamanho { get { return _proximaPosicao; } }

        public ContaCorrente this[int indice] { get { return RecuperarContaNoIndex(indice); } }
    }
}
