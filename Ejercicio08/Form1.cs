using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                //BaseLine v 2.0



        const int KNUMEROS = 6; // Tanto el sorteo como los números del jugador serán 6.
        List<int> numerosSorteo = new List<int>();
        List<int> numerosJugador = new List<int>();

        private void realizarSorteo(List<int> numerosSorteo)
        {
            int cont, num;
            Random r = new Random();

            cont = 0;
            while(cont < KNUMEROS)
            {
                num = r.Next(1, 50);    // Obtenemos un número aleatorio entre 1 y 49

                // Si no ha salido ya el número. Si ha salido no aumentamos el contador
                if (numerosSorteo.Contains(num) == false)    
                {
                    numerosSorteo.Add(num);
                    cont++;
                }
            }
        }


        // Devuelve un string con una lista
        private string mostrarLista(List<int> lista)
        {
            string texto;

            texto = "";
            for (int i = 0; i < lista.Count; i++)
                texto = texto + lista[i] + ", ";

            texto = texto + "\n";

            return texto;
        }

        private void bSorteo_Click(object sender, EventArgs e)
        {
            numerosSorteo.Clear();
            realizarSorteo(numerosSorteo);

            MessageBox.Show(mostrarLista(numerosSorteo));
        }


        private List<int> leerNumerosLoteria(List<int>lista ) //La función lee los numeros del jugador verificando que esten en rango y no repetidos
        {
            int valor;
            int cont = 0;

           while (lista.Count<KNUMEROS)
            {
                valor = int.Parse(Interaction.InputBox("Introduzca un valor: "));
                if (valor > 0 && valor < 50)
                {
                    if (lista.Contains(valor) == false)
                    {
                        lista.Add(valor);
                        cont++;
                    }
                    else
                    {
                        MessageBox.Show("El numero esta repetido");
                    }
                }
                else 
                {
                    MessageBox.Show("El numero debe estar comprendido entre 1 y 49");
                }
            } 

            return lista;
        }


        string comprobarNumerosSorteo(List<int> lista1, List<int> lista2) { // La funcion recorre una de las listas y en caso de contener algun numero en la otra lista, suma 1 el contador de aciertos y guarda el numero en otra variable.
            string TextoAciertos = "";
            int contadorAciertos = 0;
            string Texto="";
            foreach (int num in lista1) {
                if (lista2.Contains(num)) {
                    contadorAciertos++;
                    TextoAciertos = TextoAciertos + " ," + num;
                }            
             }
            if (contadorAciertos == 0) //En caso de no haber aciertos, la función devuelve el texto que no ha habido aciertos
            {
                Texto = "No hay ningun acierto";
            }
            else { //En caso que existan aciertos, la funcion devuleve texto con el numero de aciertos y los numeros acertados
                Texto = "Han habido " + contadorAciertos+" aciertos" + ". Los numeros acertados son:" + TextoAciertos;
            }

            return Texto;
        }


        private void bJugar_Click(object sender, EventArgs e)
        {
            leerNumerosLoteria(numerosJugador);
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comprobarNumerosSorteo(numerosSorteo, numerosJugador));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
