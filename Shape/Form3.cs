using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form3 : Form1
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            ////Crear instancia de la clase Line
            Line line = new Line();

            line.length = 10.5;
            line.shapeColor = "verde";
            line.shapeCoord = false;

            MessageBox.Show(line.draw("línea", "lapicero"), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.draw(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.setColor(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(line.getInfo(), "Información de la línea", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            this.Hide();
            formMenu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
