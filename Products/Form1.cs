using iTextSharp.text;
using iTextSharp.text.pdf;
using Products.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Products
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>()
        {
            { "Labial Maybelline", 109.99m },
            { "Sérum concentrado Loreal Paris", 198.99m },
            { "Sheglam Blush líquido", 250.99m },
            { "Polvo Maybelline", 50.99m },
            { "L'oreal paris Máscara telescópica eyelashes", 239.99m },
            { "CeraVe crema reparadora", 249.99m },
            { "Paleta para rostro Look-CYZONE", 229.99m },
            { "Esmalte de uñas eternal (5)", 444.99m },
            { "Delineador NYX PROFESSIONAL MAKEUP", 122.99m },
            
            // Agrega más productos y sus precios aquí
        };

        private decimal totalCost = 0m;
        private int productId = 1;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Product", "Product");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Subtotal", "Subtotal");      
        }

        private void button1_Click(object sender, EventArgs e)
        {
        string productName = "Labial Maybelline";
        decimal productPrice = productPrices[productName];
        int quantity;

        if (int.TryParse(textBox1.Text, out quantity))
        {
            decimal subtotal = productPrice * quantity;
            totalCost += subtotal;

            MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

            // Verificar si el producto ya está en el DataGridView
            bool productExists = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                {
                    // Actualizar la cantidad y el subtotal en la fila existente
                    row.Cells["Quantity"].Value = quantity;
                    row.Cells["Subtotal"].Value = subtotal;
                    productExists = true;
                    break;
                }
            }

            // Si el producto no está en el DataGridView, agregar una nueva fila
            if (!productExists)
            {
                dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                productId++; // Incrementar el Id para el próximo producto
            }
        }
        else
        {
            MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
        }
    }

    private void button2_Click(object sender, EventArgs e)
        {
            string productName = "Sérum concentrado Loreal Paris";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = "Sheglam Blush líquido";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string productName = "Polvo Maybelline";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string productName = "L'oreal paris Máscara telescópica eyelashes";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string productName = "CeraVe crema reparadora";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string productName = "Paleta para rostro Look-CYZONE";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string productName = "Esmalte de uñas eternal (5)";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string productName = "Delineador NYX PROFESSIONAL MAKEUP";
            decimal productPrice = productPrices[productName];
            int quantity;

            if (int.TryParse(textBox1.Text, out quantity))
            {
                decimal subtotal = productPrice * quantity;
                totalCost += subtotal;

                MessageBox.Show($"Product: {productName}\nQuantity: {quantity}\nSubtotal: {subtotal:C}");

                // Verificar si el producto ya está en el DataGridView
                bool productExists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Product"].Value != null && row.Cells["Product"].Value.ToString() == productName)
                    {
                        // Actualizar la cantidad y el subtotal en la fila existente
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["Subtotal"].Value = subtotal;
                        productExists = true;
                        break;
                    }
                }

                // Si el producto no está en el DataGridView, agregar una nueva fila
                if (!productExists)
                {
                    dataGridView1.Rows.Add(productId, productName, productPrice, quantity, subtotal);
                    productId++; // Incrementar el Id para el próximo producto
                }
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid integer value.");
            }
        }

        // Agrega más métodos para los otros botones (button4, button5, etc.) según la cantidad de productos que tengas

        private void ticket_Click(object sender, EventArgs e)
        {
            decimal ivaPercentage = 0.16m; // Porcentaje de IVA (16% en este ejemplo)
            decimal ivaAmount = totalCost * ivaPercentage; // Cálculo del monto de IVA
            decimal totalAmount = totalCost + ivaAmount; // Cálculo del monto total

            // Conversión a pesos y dólares (utilizando una tasa de cambio de 17 pesos por dólar)
            decimal totalAmountInDollars = totalAmount / 17;
            decimal totalAmountInPesos = totalAmount * 17;


            StringBuilder ticketBuilder = new StringBuilder();
            ticketBuilder.AppendLine("-------- Ticket ---------");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Product"].Value != null)
                {
                    string productName = row.Cells["Product"].Value.ToString();
                    decimal productPrice = (decimal)row.Cells["Price"].Value;
                    int quantity = (int)row.Cells["Quantity"].Value;
                    decimal subtotal = (decimal)row.Cells["Subtotal"].Value;

                    ticketBuilder.AppendLine($"Product: {productName}  Price: {productPrice:C}  Quantity: {quantity}  ");
                }
            }

            ticketBuilder.AppendLine("--------------------");
            ticketBuilder.AppendLine($"Subtotal: {totalCost:C}");
            ticketBuilder.AppendLine($"IVA ({ivaPercentage:P0}): {ivaAmount:C}");

            // Mostrar el monto total antes del descuento
            ticketBuilder.AppendLine($"Total antes de descuento (MEX): {totalAmount:C}");

            // Aplicar descuento del 15% si la compra supera los 800 pesos
            if (totalCost > 800m)
            {
                decimal discount = totalCost * 0.15m;
                totalAmount -= discount;
            }

            // Mostrar el monto total después del descuento
            ticketBuilder.AppendLine($"Total después de descuento (MEX): {totalAmount:C}");

            ticketBuilder.AppendLine($"Total (USD): {totalAmountInDollars:N2}");
            string ticketText = ticketBuilder.ToString();

            richTextBox1.Text = ticketText;

            totalCost = 0m; // Reinicia el costo total para una nueva venta

            dataGridView1.Rows.Clear();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                int idToDelete;
                if (int.TryParse(textBox2.Text, out idToDelete))
                {
                    bool found = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == idToDelete)
                        {
                            dataGridView1.Rows.RemoveAt(row.Index);
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        MessageBox.Show($"Product with Id {idToDelete} has been removed.");
                    }
                    else
                    {
                        MessageBox.Show($"Product with Id {idToDelete} not found.");
                    }

                    textBox2.Text = string.Empty;
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid Id. Please enter a valid integer value.");
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar el cuadro de diálogo de Guardar archivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "ticket.pdf";

                // Verificar si el usuario ha seleccionado una ubicación de archivo válida
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Obtener el directorio del archivo seleccionado
                    string directoryPath = Path.GetDirectoryName(filePath);

                    // Verificar si el directorio existe, si no, crearlo
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Verificar si el archivo ya existe, si sí, generar un nombre único
                    int counter = 1;
                    while (File.Exists(filePath))
                    {
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                        string fileExtension = Path.GetExtension(filePath);
                        filePath = Path.Combine(directoryPath, $"{fileNameWithoutExtension}_{counter}{fileExtension}");
                        counter++;
                    }

                    using (Document document = new Document(new iTextSharp.text.Rectangle(iTextSharp.text.PageSize.A7.Width, 500)))
                    {
                        // Establecer márgenes más grandes
                        document.SetMargins(10f, 10f, 20f, 20f);

                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                        // Establecer el color de fondo del documento
                        iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(document.PageSize);
                        rect.BackgroundColor = new iTextSharp.text.BaseColor(242, 216, 223);
                        document.SetPageSize(rect);
                        document.Open();

                        // Configuración del estilo del texto
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        iTextSharp.text.Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);

                        // Obtener el texto del RichTextBox
                        string text = richTextBox1.Text;

                        // Crear una celda para el contenido
                        PdfPCell cell = new PdfPCell(new Phrase(text, contentFont));
                        cell.Border = PdfPCell.NO_BORDER;
                        cell.PaddingBottom = 20f;

                        // Crear una tabla y agregar la celda
                        PdfPTable table = new PdfPTable(1);
                        table.WidthPercentage = 100;
                        table.AddCell(cell);

                        // Agregar la tabla al documento
                        document.Add(table);

                        document.Close();

                        MessageBox.Show($"PDF created successfully: {filePath}");

                        // Abrir el archivo PDF con la aplicación predeterminada
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating PDF: {ex.Message}");
            }
        }


    }

}
