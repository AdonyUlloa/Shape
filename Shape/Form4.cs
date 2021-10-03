using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form4 : Form1
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ////Crear instancia de la clase Triangle
            Triangle triangle = new Triangle();

            triangle.angle = 60;
            triangle.shapeColor = "gris";
            triangle.shapeCoord = true;

            MessageBox.Show(triangle.draw("triángulo", "pincel"), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.draw(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.setColor(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.getInfo(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangle.computeArea(), "Información del triángulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
