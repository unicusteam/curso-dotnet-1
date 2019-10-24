using DevMaker.WF.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevMaker.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(Especie.Canina);
            comboBox1.Items.Add(Especie.Felina);
            comboBox1.Items.Add(Especie.Equina);

            IList<Animal> animais = new List<Animal>();

            animais.AddRange(new List<Animal>
            {
                new Animal("Totó", 2, Especie.Canina),
                new Animal("Mocotó", 2, Especie.Felina),
                new Animal("Pocotó", 2, Especie.Equina)
            });

            animaisBindingSource.DataSource = animais;
            animalBindingSource.DataSource = new Animal("Outro totó", 3, Especie.Canina);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Animal animal = animalBindingSource.DataSource as Animal;

            if (animal == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(animal.Nome))
            {
                MessageBox.Show("Nome é obrigatório.");
                return;
            }

            if (animal.Idade <= 0)
            {
                MessageBox.Show("Idade inválida.");
                return;
            }

            if (animal.Especie == default(Especie))
            {
                MessageBox.Show("Espécie é obrigatório.");
                return;
            }

            (animaisBindingSource.DataSource as IList<Animal>)?.Add(animal);
            animalBindingSource.DataSource = new Animal();
            animaisBindingSource.ResetBindings(false);
            animalBindingSource.ResetBindings(false);
        }

        private void ApagarButton_Click(object sender, EventArgs e)
        {
            Animal animal = gridView1.GetFocusedRow() as Animal;

            if (animal == null)
            {
                return;
            }

            (animaisBindingSource.DataSource as IList<Animal>)?.Remove(animal);
            animaisBindingSource.ResetBindings(false);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Animal animal = gridView1.GetFocusedRow() as Animal;

            if (animal == null)
            {
                return;
            }

            animalBindingSource.DataSource = animal;
        }
    }

    public static class ListExtension
    {
        public static void AddRange<T>(this IList<T> list, IList<T> values)
        {
            foreach (var value in values)
            {
                list.Add(value);
            }
        }
    }
}
