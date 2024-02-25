using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using System;
using Microsoft.Win32;
namespace FormsC_CSV
{
    public partial class Form1 : Form
    {
        private List<Registro> registros = new List<Registro>();
        private string archivoActual = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {
            try
            {
                using (var reader = new StreamReader("datos.csv"))
                using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    registros = csv.GetRecords<Registro>().ToList();
                }

                ActualizarListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void ActualizarListBox()
        {
            listBoxRegistros.Items.Clear();
            foreach (var registro in registros)
            {
                listBoxRegistros.Items.Add(registro.ToString());
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            registros.Add(new Registro
            {
                Nombre = textBoxNombre.Text,
                Edad = Convert.ToInt32(textBoxEdad.Text),
                Email = textBoxEmail.Text
            });
            ActualizarListBox();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxRegistros.SelectedIndex != -1)
            {
                registros.RemoveAt(listBoxRegistros.SelectedIndex);
                ActualizarListBox();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (archivoActual == "")
                {
                    // Si no se ha seleccionado un archivo previamente, mostrar el diálogo para guardar archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                    saveFileDialog.Title = "Guardar archivo de texto";
                    saveFileDialog.ShowDialog();

                    // Si el usuario presiona OK en el diálogo
                    if (saveFileDialog.FileName != "")
                    {
                        archivoActual = saveFileDialog.FileName;
                    }
                    else
                    {
                        return; // Si el usuario cancela, salir del método sin guardar nada
                    }
                }

                // Escribir los datos en el archivo seleccionado
                using (var writer = new StreamWriter(archivoActual))
                {
                    foreach (var registro in registros)
                    {
                        writer.WriteLine(registro.ToString());
                    }
                }

                MessageBox.Show("Datos guardados correctamente en: " + archivoActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear y configurar el diálogo para abrir archivo
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                openFileDialog.Title = "Abrir archivo de texto";
                openFileDialog.ShowDialog();

                // Si el usuario selecciona un archivo y presiona OK
                if (openFileDialog.FileName != "")
                {
                    // Leer los datos del archivo seleccionado
                    using (var reader = new StreamReader(openFileDialog.FileName))
                    {
                        registros.Clear();
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var parts = line.Split(','); // Suponiendo que los datos están separados por comas
                            registros.Add(new Registro
                            {
                                Nombre = parts[0],
                                Edad = Convert.ToInt32(parts[1]),
                                Email = parts[2]
                            });
                        }
                    }

                    archivoActual = openFileDialog.FileName;

                    ActualizarListBox();
                    MessageBox.Show("Datos cargados correctamente desde: " + archivoActual);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir archivo: " + ex.Message);
            }
        }


    }
}
