using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseGenerica.Entidades
{
    public partial class FormABM<T> : Form where T : class
    {
        public FormABM(T obj)
        {
            InitializeComponent();

            int posicionY = 20;

            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                this.Text = typeof(T).Name;

                if (item.CanRead)
                {
                    Label labelDinamico = new Label();
                    TextBox textBox = new TextBox();
                    labelDinamico.Text = item.Name;
                    textBox.Text = item.GetValue(obj).ToString();

                    //labelDinamico.Text = "label" + labelDinamico.Name;
                    //textBox.Text = "textBox" + textBox.Name;

                    labelDinamico.Location = new Point(20, posicionY);
                    textBox.Location = new Point(220, posicionY);

                    posicionY += 60;

                    this.Controls.Add(labelDinamico);
                    this.Controls.Add(textBox);
                }

            }
        }
    }
}
