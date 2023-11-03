using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraInpl
    {

        private List<String> listaHistorico;

        public CalculadoraInpl()
        {
            listaHistorico = new List<String>();

        }





        public int somar(int x, int y)
        {

            int resultado = x + y;
            listaHistorico.Insert(0, "Resultado = " + resultado ); // Insert() insere uma string no início de uma lista

            return resultado;
           
        }

        public int subtrair(int x, int y){
            int resultado = x - y;
            listaHistorico.Insert(0, "Resultado = " + resultado); // Insert() insere uma string no início de uma lista
            return resultado;
        }

        public int multiplicar(int x, int y){
            int resultado = x * y;
            listaHistorico.Insert(0, "Resultado = " + resultado);// Insert() insere uma string no início de uma lista
            return resultado;
        
        }

        public int dividir(int x, int y){
            int resultado = x / y;
            listaHistorico.Insert(0, "Resultado = " + resultado);// Insert() insere uma string no início de uma lista
            return resultado;
     
    }

    public List<String> historico(){
        listaHistorico.RemoveRange(3,listaHistorico.Count -3); // Vai começar Excluir da posição 3 e vai remover 
       //o taamanho da lista menos 3
        return listaHistorico;
    }


}}
