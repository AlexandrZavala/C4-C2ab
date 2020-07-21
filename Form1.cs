using System;
using System.Windows.Forms;

namespace C4
{
    public partial class CsLab3 : Form
    {
        Rectangles_GUI arrayOfRectangles = new Rectangles_GUI();
        Parallelepipeds_GUI arrayOfParallelepipeds = new Parallelepipeds_GUI();

        public CsLab3()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        //Rectangles:

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Byte.Parse(SizeBox.Text) == 0)
                {
                    MessageBox.Show("Size of array must be positive and less than 256");
                }
                else
                {
                    arrayOfRectangles = new Rectangles_GUI(Byte.Parse(SizeBox.Text));

                    Side1ValueBox.Enabled = true;
                    Side2ValueBox.Enabled = true;
                    SetValueButton.Enabled = true;
                    GenerateButton.Enabled = true;

                    ShowValuesButton.Enabled = false;

                    CounterBox.Text = arrayOfRectangles.Counter();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SaveValueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(Side1ValueBox.Text) <= 0 || Double.Parse(Side2ValueBox.Text) <= 0)
                    MessageBox.Show("Values of sides must be positive");
                else if (arrayOfRectangles.SetElement(Double.Parse(Side1ValueBox.Text), Double.Parse(Side2ValueBox.Text)))
                {
                    ShowValuesButton.Enabled = true;
                    CounterBox.Text = arrayOfRectangles.Counter();
                }
                else MessageBox.Show("Out of array length");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (arrayOfRectangles.GenerateElement())
            {
                CounterBox.Text = arrayOfRectangles.Counter();

                if (!ShowValuesButton.Enabled)
                    ShowValuesButton.Enabled = true;
            }
            else MessageBox.Show("Out of array length");
        }

        private void DispInfo_Click(object sender, EventArgs e)
        {
            RectanglesInfTextBox.Text = arrayOfRectangles.ToString();
        }

        //Parallelepipeds:

        private void CreateButtonPar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Byte.Parse(SizeBoxPar.Text) == 0)
                    MessageBox.Show("Size of array must be positive and less than 256");
                else
                {
                    arrayOfParallelepipeds = new Parallelepipeds_GUI(Byte.Parse(SizeBoxPar.Text));

                    Side1ValueBoxPar.Enabled = true;
                    Side2ValueBoxPar.Enabled = true;
                    HeightBox.Enabled = true;
                    SetValuesPar.Enabled = true;
                    GenerateValuesPar.Enabled = true;

                    ShowValuesPar.Enabled = false;

                    ParCounterBox.Text = arrayOfParallelepipeds.Counter();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void SetValuesPar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(Side1ValueBoxPar.Text) <= 0 ||
                    Double.Parse(Side2ValueBoxPar.Text) <= 0 ||
                    Double.Parse(HeightBox.Text) <= 0)
                    MessageBox.Show("Values of sides must be positive");
                else if (arrayOfParallelepipeds.SetElement(Double.Parse(Side1ValueBoxPar.Text),
                         Double.Parse(Side2ValueBoxPar.Text), Double.Parse(HeightBox.Text))) 
                {
                    ShowValuesPar.Enabled = true;
                    ParCounterBox.Text = arrayOfParallelepipeds.Counter();
                }
                else MessageBox.Show("Out of array length");

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void GenerateValuesPar_Click(object sender, EventArgs e)
        {
            if (arrayOfParallelepipeds.GenerateElement())
            { 
                ShowValuesPar.Enabled = true;
                ParCounterBox.Text = arrayOfParallelepipeds.Counter();
            }
            else MessageBox.Show("Out of array length");
        }

        private void ShowValuesPar_Click(object sender, EventArgs e)
        {
            ParInfTextBox.Text = arrayOfParallelepipeds.ToString();
        }

        private void CsLab3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить значения прямоугольников в файл?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string path = saveFileDialog1.FileName;

                arrayOfRectangles.Save(path);

                MessageBox.Show("Значения сохранены");
            }

            DialogResult result1 = MessageBox.Show("Сохранить значения параллелепипедов в файл?", "", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string path = saveFileDialog1.FileName;

                arrayOfParallelepipeds.Save(path);

                MessageBox.Show("Значения сохранены");
            }
        }

        private void CsLab3_Shown(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Загрузить значения для прямоугольников из файла?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string path = openFileDialog1.FileName;

                arrayOfRectangles.Load(path);

                ShowValuesButton.Enabled = true;

                MessageBox.Show("Значения загружены");
            }

            DialogResult result1 = MessageBox.Show("Загрузить значения для параллелепипедов из файла?", "", MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string path = openFileDialog1.FileName;

                arrayOfParallelepipeds.Load(path);

                ShowValuesPar.Enabled = true;

                MessageBox.Show("Значения загружены");
            }
        }
    }
}