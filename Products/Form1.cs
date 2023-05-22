using iTextSharp.text;
using iTextSharp.text.pdf;
using Products.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            { "Labial Maybelline", 1.99m },
            { "Sérum concentrado Loreal Paris", 198.99m },
            { "Sheglam Blush líquido", 250.99m },
            { "Polvo Maybelline", 50.99m },
            { "L'óreal paris Máscara telescópica", 11.99m },
            { "Product 6", 12.99m },
            { "Product 7", 13.50m },
            { "Product 8", 14.50m },
            { "Product 9", 16.50m },
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
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

            button1.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\source\repos\Kyushu21\Products\Products\Resources\maybelline_labial.jpg");
            button1.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\maybelline_labial.jpg");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Serúm concentrado.jpg");
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button3.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Sheglam Blush líquido.jpg");
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button4.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Polvo Maybelline.jpg");
            button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button5.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\L'oreal paris Máscara telescópica eyelashes.jpg");
            button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button6.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\CeraVe crema reparadora.jpg");
            button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button7.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Paleta para rostro Look-CYZONE.jpg");
            button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button8.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Esmalte de uñas eternal (5).jpg");
            button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button9.BackgroundImage = System.Drawing.Image.FromFile(@"C:\Users\Baamgo\Source\Repos\Kyushu21\Products\Products\Resources\Delineador NYX PROFESSIONAL MAKEUP.jpg");

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

        private void button5_Click(object sender, EventArgs e)
        {
            string productName = "Product 5";
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
            string productName = "Product 6";
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
            string productName = "Product 7";
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
            string productName = "Product 8";
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
            string productName = "Product 9";
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
            ticketBuilder.AppendLine("------ Ticket ------");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Product"].Value != null)
                {
                    string productName = row.Cells["Product"].Value.ToString();
                    decimal productPrice = (decimal)row.Cells["Price"].Value;
                    int quantity = (int)row.Cells["Quantity"].Value;
                    decimal subtotal = (decimal)row.Cells["Subtotal"].Value;

                    ticketBuilder.AppendLine($"Product: {productName}  Price: {productPrice:C}  Quantity: {quantity}  Subtotal: {subtotal:C}");
                }
            }

            ticketBuilder.AppendLine("--------------------");
            ticketBuilder.AppendLine($"Subtotal: {totalCost:C}");
            ticketBuilder.AppendLine($"IVA ({ivaPercentage:P0}): {ivaAmount:C}");
            ticketBuilder.AppendLine($"Total (MEX): {totalAmount:C}");
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
                string repositoryPath = @"C:\Users\Baamgo\Documents\GitHub\Products";
                string directoryPath = Path.Combine(repositoryPath, "Reporte PDF");
                string fileName = "ticket.pdf";
                string filePath = Path.Combine(directoryPath, fileName);
                string imagePath = @"C:\Users\Baamgo\source\repos\Products\Products\Resources\LarissaBeauty.JPG";

                // Verificar si el directorio existe, si no, crearlo
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Verificar si el archivo ya existe, si sí, generar un nombre único
                int counter = 1;
                while (File.Exists(filePath))
                {
                    fileName = $"ticket_{counter}.pdf";
                    filePath = Path.Combine(directoryPath, fileName);
                    counter++;
                }

                using (Document document = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                    // Establecer el color de fondo del documento
                    iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(document.PageSize);
                    rect.BackgroundColor = new iTextSharp.text.BaseColor(242, 216, 223);
                    document.SetPageSize(rect);
                    document.Open();

                    // Configuración de la fuente y estilo del texto
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                    // Obtener el texto del RichTextBox
                    string text = richTextBox1.Text;

                    // Agregar la imagen al documento
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);
                    image.ScaleToFit(300, 200); // Ajusta el tamaño de la imagen según tus necesidades
                    document.Add(image);

                    // Crear el párrafo con el contenido del RichTextBox
                    Paragraph paragraph = new Paragraph(text, font);
                    document.Add(paragraph);

                    document.Close();

                    MessageBox.Show($"PDF created successfully: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating PDF: {ex.Message}");
            }

        }

}
}
