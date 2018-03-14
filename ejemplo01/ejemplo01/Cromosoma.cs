using System;
/*
    Universidad Autonoma Del Estado de Mexico
    C.U. UAEM Zumpango 
    Ingenieria en Computacion
    Algoritmos Geneticos
    Juan Carlos Angeles Vazquez
    18/Febrero/2018

*/
public class Cromosoma
{
    int BITS_PER_GENE;//numero de bits por gene 
    int[] gene;//arreglo que almacena los genes
    public Cromosoma(int bits)//numero de bits con los que contara el gen del cromosoma 
    {
        BITS_PER_GENE = bits;
        gene = new int[BITS_PER_GENE];//se reserva memoria para e gen

    }

    public double GetValue()
    {
        double value = 0;
        for (int i = 0; i < BITS_PER_GENE - 1; i++)//se recorren todos los elementos de el gene -1 
        {
            value += gene[BITS_PER_GENE - i - 1] * Math.Pow(2, i);//en la penultima posicion de el arreglo se encuentra 2^0
        }
        if (gene[0] == 1)//si el primer bit de izquiera a derecha en el gen es 1 , entonces el fenotipo es negativo
        {
            value = -value;
        }
        return value;
    }
    public string GetValueGrey()//Funcion para obtener un fenotipo interpretado en codigo fray 
    {
        string resultado = "";//cadena para almacenar la respuesta 
        resultado = gene[0]+"";//se concatena el primer bit de izquierda a derecha a el resultado 
        for (int i = 0; i < BITS_PER_GENE - 1; i++)//se analiza el tamaño de bits -1 para no caer en un indice inexistente
        {
            resultado += (gene[i] != gene[i + 1]) ? 1 : 0;//se comprueba que solo uno de los bits que se comparan es igual a 1 , para otorgar al resultado un valor de 1 

        }
        return resultado;//se retorna el resultado

    }
    public void inicializa(Random r)//inicializa el gen de manera aleatoria 
    {
        for (int i = 0; i < BITS_PER_GENE; i++)//se recorre cada posicion del gen
        {
            if (r.Next(1, 3) == 2)//solo en caso de que de manera pseudo aleatoria se encuentre un dos
            {
                gene[i] = 1;//se le colocara 1 a la posicion actual del gen
            }
        }
    }
    public int[] getGene()
    {
        return gene;
    }
    public int getBits()
    {
        return BITS_PER_GENE;
    }
}
