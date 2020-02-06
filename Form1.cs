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

namespace Matrices
{
    public partial class MatrizForm : Form
    {
        //Declaramos tres matrices para las operaciones a realizar
        int[,] MatrizUno = new int[10, 10];
        int[,] MatrizDos = new int[10, 10];
        int[,] MatrizResul = new int[10, 10];
        //Declaramos el numero de filas y columnas como globales, para utilizar dentro de los metodos
        int NomFila, NomColumna, i, j;
        //Estas variables seran intermediraro para la imprescion de las matrices
        String MatUno, MatDos, MatResultados;
        //Consutructor de la clase form1
        public MatrizForm()
        {
            InitializeComponent();
        }//MatrizForm

        /*METODOS */
        //Este metodo limpiara todos los campos colocandolas en blanco
        public void limpiar()
        {
            Filastxt.Text = "";
            Columnastxt.Text = "";
            txtMatrisUno.Text = "";
            txtMatrizDos.Text = "";
            txtMatrizResultado.Text = "";
            MatUno = "";
            MatDos = "";
            MatResultados = "";

        }
        //Este metodo lee los datos de dimenciones ingresados a la matriz 
        public void EstablcerDimencion()
        {
            if ( !Filastxt.Text.Equals("") && !Columnastxt.Text.Equals("")) { //validamos los valores
                NomFila = Convert.ToInt32(Filastxt.Text);//colocamos el numero de filas
                NomColumna = Convert.ToInt32(Columnastxt.Text);//capturamos el numero columnas
                MessageBox.Show( "Se configuraron los valores de la matriz" ); //notificamos
            }
            else
            {
                MessageBox.Show("Coloque todos los valores"); //Notificamos
            }
            
        }//EstablcerDimencion

        //Este metodo guardara el contenido de la matris, para mostrarlo dentro del txtbox
        public void MostrarMatrizUno()
        {
            txtMatrisUno.Text = ""; //Limpiamos la caja de texto
            MatUno = "";//Limpiamos nuestra variable, para la captura de los datos

            //Ingresamos valores con ayuda del metodo for de igual forma para la captura de los datos
            for ( i = 0; i < NomFila; i++ )
            {
                for ( j = 0; j < NomColumna; j++)
                {
                    MatrizUno[ i,j ] = Convert.ToInt32( Interaction.InputBox( "Filas" + i + ", Columnas" + j )  ); //Capturamos los datos
                    MatUno += MatrizUno[i, j] + "\t";
                    txtMatrisUno.Text = MatUno;
                }//for
                MatUno += "\n"; 
            }//for

        }//MostrarMatrizUno

        //Este metodo guardara el contenido de la matris, para mostrarlo dentro del txtbox
        public void MostrarMatrizDos()
        {
            txtMatrizDos.Text = ""; //Limpiamos la caja de texto
            MatDos = "";//Limpiamos nuestra variable, para la captura de los datos

            //Ingresamos valores con ayuda del metodo for de igual forma para la captura de los datos
            for (i = 0; i < NomFila; i++)
            {
                for (j = 0; j < NomColumna; j++)
                {
                    MatrizDos[i, j] = Convert.ToInt32(Interaction.InputBox("Filas" + i + ", Columnas" + j)); //Capturamos los datos
                    MatDos += MatrizDos[i, j] + "\t"; //Campturamos el valor de la matriz
                    txtMatrizDos.Text = MatDos; //imprimimos
                }//for
                MatDos += "\n";
            }//for

        }//MostrarMatrizUno

        /*Estos metdos nos ayudan a ralizar las opercaiones con nuestras matrices*/
        public void Sumar()
        {
            txtMatrizResultado.Text = "";
            MatResultados = "";
            //Recorremos las matrices con ciclo for
            for (i = 0; i < NomFila; i++)
            {
                for (j = 0; j < NomColumna; j++)
                {
                    MatrizResul[i, j] = MatrizUno[i, j] + MatrizDos[i, j]; //Realizamos la operacion y almacenamos el resultado
                    MatResultados += MatrizResul[i, j] + "\t"; //Campturamos el valor de la matriz
                    txtMatrizResultado.Text = MatResultados; //imprimimos
                }//for
                MatResultados += "\n";
            }//for
        }//Sumar

        public void Multiplicar()
        {
            int[,] temp = new int[10,10]; //Esta es una matriz temporal para capturar los resultados de la matriz
            txtMatrizResultado.Text = ""; //limpiamos la caja 
            MatResultados = ""; //limpiamos nuestra varible de  captura

            //Recorremos las matrices con ciclo for
            for (i = 0; i < NomFila; i++)
            {
                for (j = 0; j < NomColumna; j++)
                {
                    temp[i, j] = 0;
                    for ( int k = 0; k < NomColumna; k++)
                    {
                        temp[i, j]  += MatrizDos[i, k] * MatrizUno[k, j]; //Realizamos la operacion y almacenamos el resultado
                    }
                    
                    if ( i == j)
                    {
                        MatrizResul[i, j] = temp[i, j];
                        MatResultados += MatrizResul[i, j] + "\t"; //Campturamos el valor de la matriz
                        txtMatrizResultado.Text = MatResultados; //imprimimos
                    }
                    
                }//for
                
            }//for

        }//Multiplicar

        public void Diagonal()
        {
            txtMatrisUno.Text = "";
            MatUno = "";
            //Recorremoa la matris
            for ( i = 0; i < NomFila; i++ )
            {
                for ( j = 0; j < NomColumna; j++ )
                {
                    MatrizUno[i, j] = Convert.ToInt32(Interaction.InputBox("Filas" + i + ", Columnas" + j)); //Capturamos los datos
                    
                    if (i == j) //Verificamos que los indices sean iguales
                    {
                        MatUno += MatrizUno[i, j] + "\t"; 
                        txtMatrisUno.Text = MatUno; //imprimimos
                    }//if

                }//for
                
            }//for
        }//Diagonal

        //Este metodo calculara la traspuesta de una matriz
        public void traspuesta()
        {
            txtMatrisUno.Text = "";
            MatResultados = "";
            int[,] temp = new int[10, 10]; //Esta es una matriz temporal para capturar los resultados de la matriz
            //Recorremos la matriz
            for ( i = 0; i < NomFila; i++)
            {
                for ( j = 0; j < NomColumna; j++ )
                {
                    MatrizUno[i, j] = Convert.ToInt32(Interaction.InputBox("Filas" + i + ", Columnas" + j)); //Capturamos los datos
                    MatUno += MatrizUno[i, j] + "\t";
                    txtMatrisUno.Text = MatUno; //imprimimos
                }
                MatUno += "\n";
            }

            //Recorremos la matriz
            for (i = 0; i <  NomColumna; i++)
            {
                for (j = 0; j < NomFila; j++)
                {

                    temp[i,j] = MatrizUno[j, i]; //Almacenamos en una matriz temporal
                    MatResultados += temp[i, j] + "\t"; //dejamos un espacio
                    txtMatrizResultado.Text = MatResultados; //imprimimos
                }
                MatResultados += "\n"; //colocamos un salto de line
            }
        }//traspuesta

        //calculo de matrices  triangulares
        public void MatricesTriangulares()
        {
            //Contadores de ceros 
            int contadorSuperior = 0;
            int contadorInferior = 0;
            //Limpiamos las cajas de texto y nuetra variable de almacen de datos
            txtMatrisUno.Text = "";
            MatResultados = "";

            //Llnamos una matriz con dos ciclos
            for ( i = 0; i < NomFila; i++ )
            {
                for ( j = 0; j < NomColumna; j++ )
                {
                    MatrizUno[i, j] = Convert.ToInt32(Interaction.InputBox("Filas" + i + ", Columnas" + j)); //Capturamos los datos
                    MatUno += MatrizUno[i, j] + "\t"; //Almacenamos en el string para su imprecion
                    txtMatrisUno.Text = MatUno; //imprimimos

                    if ( MatrizUno[i,j] == 0 ) //Comparamos que el nuevo valor sea 0
                    {
                        if ( i < j ) //esta condicion nos ayuda a saber si se encuentra arriva de la diagonal o abajo
                        {
                            contadorInferior++; //incrementamos el contador
                        }
                        else if (i > j)
                        {
                            contadorSuperior++; //incrementamos el contador
                        }
                    }
                }//for
                MatUno += "\n";
            }//for

            //Compraracion de numero de ceros encontrados en la matriz
            if ( contadorSuperior > contadorInferior )
            {
                MessageBox.Show("Matriz triangular superior"); //Notificamos
            }
            else
            {
                MessageBox.Show("Matriz triangular Inferior"); //Notificamos
            }

        }//MatricesTriangulares

        /*INTERFAS GRAFICA*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DiagonalBtn_Click(object sender, EventArgs e)
        {
            Diagonal();
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            traspuesta();
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatricesTriangulares();
        }

        private void PrimeraMatrizBtn_Click(object sender, EventArgs e)
        {
            MostrarMatrizUno();//Traemos el metodo para ingresar y mostrar la matris
        }

        private void SegundaMatrizBtn_Click(object sender, EventArgs e)
        {
            MostrarMatrizDos();//Traemos el metodo para la configuracion de los valores de la matriz
        }

        private void MultiplicacionBtn_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }

        private void SumaBtn_Click(object sender, EventArgs e)
        {
            Sumar();
        }

        private void DimensionBtn_Click(object sender, EventArgs e)
        {
            EstablcerDimencion(); //Traemos el metodo para la configuracion de los valores de la matriz
        }
    }
}
