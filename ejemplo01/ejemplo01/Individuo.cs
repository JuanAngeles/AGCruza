using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Universidad Autonoma Del Estado de Mexico
    C.U. UAEM Zumpango 
    Ingenieria en Computacion
    Algoritmos Geneticos
    Juan Carlos Angeles Vazquez
    18/Febrero/2018

*/
namespace ejemplo01
{
    public class Individuo
    {
        Cromosoma cromosoma;//un individuo tiene un cromosoma
        bool isgray = false;//variable para saber si se quiere obtener un fenotipo en codigo gray
        public Individuo(int longitgen)//se recibe la longitud del gen del individuo para inicializar su cromosoma
        {
            cromosoma = new Cromosoma(longitgen);//se instancia el cromosoma 
            cromosoma.inicializa(new Random(Guid.NewGuid().GetHashCode()));//se llama a inicializar el cromosoma
        }
        public void setIsGray(bool valor)//funcion para setear el valor de isgray desde otra clase  sin problemas
        {
            isgray = valor;
        }
        public override string ToString()
        {
            string result = "";//se prepara la cadena a regresar
            for (int i = 0; i < cromosoma.getBits(); i++)//se recorre cada uno de los bits del gene 
                result += cromosoma.getGene()[i] + " ";//se concatena cada elemento de el gen a el resultado para hacer la comparacion con su fenotipo
            result += ": " + "" + ((isgray)?cromosoma.GetValueGrey():""+cromosoma.GetValue());//se le concatena el valor de el fenotipo interpretado en gray o decimal segun se haya decidido
            return result;
        }

        public Individuo [] Cross1P(Individuo madre)
        {
            Console.WriteLine(madre);
            Individuo[] hijos = new Individuo[2];
            hijos[0] = new Individuo(madre.cromosoma.getBits());

            hijos[1] = new Individuo(madre.cromosoma.getBits());
            //padre es el que llama al metodo
            int crosspoint = new Random(Guid.NewGuid().GetHashCode()).Next(3, 5);
            Console.WriteLine("\nPunto: "+crosspoint+"\n");
            for(int i =0;i<madre.cromosoma.getBits();i++)
            {
                hijos[0].cromosoma.getGene()[i] = (i <= crosspoint) ? this.cromosoma.getGene()[i] : madre.cromosoma.getGene()[i];

                hijos[1].cromosoma.getGene()[i] = (i <= crosspoint) ? madre.cromosoma.getGene()[i] : this.cromosoma.getGene()[i];
            }
            
            return hijos;
        }
    }
}
