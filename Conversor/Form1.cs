using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats;
namespace Conversor
{
    public partial class HesperiaConverter : Form
    {
        private List<string> archivosSeleccionados = new List<string>();
        public HesperiaConverter()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void panelDrop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string archivo in archivos)
            {
                string extension = Path.GetExtension(archivo).ToLower();

                if (extension == ".jpg" ||
                    extension == ".jpeg" ||
                    extension == ".png" ||
                    extension == ".gif" ||
                    extension == ".bmp" ||
                    extension == ".webp" ||
                    extension == ".ico" ||
                    extension == ".tif" ||
                    extension == ".tiff" ||
                    extension == ".avif" ||
                    extension == ".tga")
                {
                    if (!archivosSeleccionados.Contains(archivo))
                    {
                        archivosSeleccionados.Add(archivo);
                        listBox1.Items.Add(Path.GetFileName(archivo));
                    }
                }
            }

            if (archivosSeleccionados.Count == 1)
            {
                lblDrop.Text = "✅ 1 imagen seleccionada";
            }
            else if (archivosSeleccionados.Count > 1)
            {
                lblDrop.Text = $"✅ {archivosSeleccionados.Count} imágenes seleccionadas";
            }
        }

        private void panelDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                lblDrop.Text = "📂 Suelta los archivos aquí";
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (archivosSeleccionados.Count == 0)
            {
                MessageBox.Show("Primero selecciona al menos una imagen.");
                return;
            }
            MessageBox.Show("Hay archivos seleccionados.");
            using (FolderBrowserDialog carpeta = new FolderBrowserDialog())
            {
                carpeta.Description = "Selecciona dónde guardar las imágenes convertidas";

                if (carpeta.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string formato = comboBox1.SelectedItem.ToString();

                foreach (string archivo in archivosSeleccionados)
                {
                    string nombre = Path.GetFileNameWithoutExtension(archivo);
                    string extension = "." + formato.ToLower();
                    string destino = Path.Combine(carpeta.SelectedPath, nombre + extension);

                    using (SixLabors.ImageSharp.Image imagen = SixLabors.ImageSharp.Image.Load(archivo))
                    {
                        if (formato == "PNG")
                        {
                            imagen.SaveAsPng(destino);
                        }
                        else if (formato == "JPG")
                        {
                            imagen.SaveAsJpeg(destino);
                        }
                        else if (formato == "GIF")
                        {
                            imagen.SaveAsGif(destino);
                        }
                        else if (formato == "BMP")
                        {
                            imagen.SaveAsBmp(destino);
                        }
                        else if (formato == "ICO")
                        {
                            GuardarComoIco(imagen, destino);

                        }
                        else if (formato == "WEBP")
                        {
                            imagen.SaveAsWebp(destino);
                        }
                        else if (formato == "TIFF")
                        {
                            imagen.SaveAsTiff(destino);
                        }
                        else if (formato == "TGA")
                        {
                            imagen.SaveAsTga(destino);
                        }
                    }
                }

                MessageBox.Show("✅ Conversión completada.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GuardarComoIco(SixLabors.ImageSharp.Image imagen, string destino)
        {
            using (MemoryStream pngStream = new MemoryStream())
            {
                imagen.SaveAsPng(pngStream);

                byte[] pngBytes = pngStream.ToArray();

                using (FileStream archivo = new FileStream(destino, FileMode.Create))
                using (BinaryWriter writer = new BinaryWriter(archivo))
                {
                    // Cabecera ICO
                    writer.Write((short)0);
                    writer.Write((short)1);
                    writer.Write((short)1);

                    // Entrada de imagen
                    writer.Write((byte)0);
                    writer.Write((byte)0);
                    writer.Write((byte)0);
                    writer.Write((byte)0);
                    writer.Write((short)1);
                    writer.Write((short)32);
                    writer.Write(pngBytes.Length);
                    writer.Write(22);

                    // Imagen PNG
                    writer.Write(pngBytes);
                }
            }
        }
    }
}

