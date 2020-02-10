using System;

public class Ingresso
    {
        // Recebe um array de inteiro com o valor da nota de cada pessoa ❯ Ex: [25, 50, 25]
        public static string Vender(int[] pessoasNaFila)
        { 
            //Seu código aqui
        }
    }

/*
EXEMPLOS:

Vender([25, 25, 50]) => TRUE.

Vender([25, 100]) // => FALSE. Rogério não terá dinheiro o suficiente 
para dar de troco para 100 reais.

Vender([25, 25, 50, 50, 100]) // => FALSE. Rogério não irá ter notas para dar 
de troco 75 reais para a nota de 100 reais. (Ele possuirá duas notas de 50 reais,
não podendo dar o troco para 100 reais).
*/