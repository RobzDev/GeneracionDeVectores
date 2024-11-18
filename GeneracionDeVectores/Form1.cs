using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GeneracionDeVectores
{
    public partial class Form1 : Form
    {
        private int[] vector; // Vector dinámico
        private int currentIndex = 0; // Índice actual para agregar valores

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamanio.Text, out int size) && size > 0)
            {
                Stopwatch stopwatch = Stopwatch.StartNew(); // Inicia el cronómetro
                vector = new int[size];
                stopwatch.Stop(); // Detiene el cronómetro

                currentIndex = 0;
                listBoxVector.Items.Clear();

                MessageBox.Show($"Vector size: {size} generated.\nCreation time: {stopwatch.Elapsed.TotalMilliseconds} ms.");
            }
            else
            {
                MessageBox.Show("Please enter a valid size (greater than 0).");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                MessageBox.Show("Primero genera un vector.");
                return;
            }

            if (currentIndex >= vector.Length)
            {
                MessageBox.Show("El vector está lleno.");
                return;
            }

            if (int.TryParse(txtValor.Text, out int valor))
            {
                vector[currentIndex] = valor;
                listBoxVector.Items.Add($"[{currentIndex}] = {valor}");
                currentIndex++;
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the whole vector and clear the listbox
            vector = null;
            listBoxVector.Items.Clear();
            //reset the current index
            currentIndex = 0;
            //clear both textboxs
            txtTamanio.Clear();
            txtValor.Clear();



        }
    }
}
