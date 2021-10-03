using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Circle circle = new Circle();

            circle.radius = 5.55;
            circle.shapeColor = "azul";
            circle.shapeCoord = true;


            MessageBox.Show(circle.draw("círculo", "lápiz"), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.draw(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.setColor(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.getInfo(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.rotate(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circle.computeArea(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void lbCircle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
