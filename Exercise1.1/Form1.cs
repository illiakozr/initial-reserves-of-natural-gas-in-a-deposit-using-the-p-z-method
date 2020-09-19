using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Exercise1._1
{
    public partial class Form1 : Form
    {
        //static GasComposition gasComposition = new GasComposition();
        DefinitionOfZ definitionOfZ = new DefinitionOfZ();

        public double Slope { get; set; }
        public double Intercept { get; set; }
        public double InitialGasCapacity { get; set; }
        public double Temperature { get; set; }
        public string FilePath { get; set; }

        public Form1()
        {
            InitializeComponent();

            zedGraphControl1.GraphPane.Title.Text = "p/z method";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Gp (mln Nm3)";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "P/Z (MPa)";

            //dataGridView1.RowCount = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(temperatureBox1.Text == String.Empty)
            {
                MessageBox.Show(
                    "Please, select temperature reservoir",
                     "Warning",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information,
                     MessageBoxDefaultButton.Button1
                    );

                return;
            }

            try
            {
                
                AcceptInputValues();

            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1
                    );

                return;
            }

            definitionOfZ.gazComposition.ComputeAll();
            definitionOfZ.ComputeAll();

            zedGraphControl1.Visible = true;

            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list = new PointPairList();

            //double xmin = InputData.GasExtraction.Min();  // 0
            //double xmax = InputData.GasExtraction.Max() + 100;

            double[] xAxis = InputData.GasExtraction.ToArray();
            double[] yAxis = definitionOfZ.P_z.ToArray();

            // добавим в список точки
            list.Add(xAxis, yAxis);
  
            // Создадим кривую с названием "Sinc",
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            LineItem myCurve = pane.AddCurve("Sinc", list, Color.Blue, SymbolType.Circle);
            myCurve.Line.IsSmooth = true;
            myCurve.Line.SmoothTension = 0.5F;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            // В противном случае на рисунке будет показана только часть графика,
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.GraphPane.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();

            Slope = SlopeDefinition(xAxis, yAxis);
            Intercept = InterceptDefinition(xAxis, yAxis, Slope);
            InitialGasCapacity = InitialGasCapacityDefinition(Intercept, Slope);
           
            slopeBox.Text = Slope.ToString("f3");
            interceptBox.Text = Intercept.ToString("f3");
            initialGasBox.Text = Math.Round(InitialGasCapacity).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            // Обновим график
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            // zedGraphControl1.Visible = false;
            slopeBox.Text = "";
            interceptBox.Text = "";
            initialGasBox.Text = "";
        }

        private double SlopeDefinition(double[] x, double[] y)
        {
            if(x.Length != y.Length)
            {
                throw new ArgumentException("no match in arguments");
            }

            var x_avg = x.Average();
            var y_avg = y.Average();

            double numerator = 0;

            for(int i =0; i < x.Length; i++)
            {
                numerator += ((x[i] - x_avg) * (y[i] - y_avg));
            }

            double denominator = 0;

            for(int i = 0; i < x.Length; i++)
            {
                denominator += Math.Pow((x[i] - x_avg), 2);
            }

            return numerator / denominator;
        }

        private double InterceptDefinition(double[] x, double[] y, double slope)
        {
            var x_avg = x.Average();
            var y_avg = y.Average();
            return y_avg - (slope * x_avg);
        }

        private double InitialGasCapacityDefinition(double intercept, double slope)
        {

            return Math.Abs(intercept) / Math.Abs(slope);
        }


        public void ConvertToKelvin()
        {
            double temp = 0;
            try
            {
                if (temperatureBox1.Text != "")
                {
                    temp = double.Parse(temperatureBox1.Text);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(
                   "Reservoir temperature is not in correct format",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1                   
                   );
                throw new Exception(ex.Message);
            }

            if (KelvinRadioButton.Checked)
            {
                if(temp == 0)
                {
                    MessageBox.Show(
                    "value 0 for Kelvin is not correct",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                   );
                    throw new Exception("value 0 for Kelvin is not correct");
                }
                Temperature = temp;
                return;
            }
            else if (FahrRadioButton.Checked)
            {
                Temperature = (temp + 459.67) * 5 / 9;
                return;
            }
            else if (CelsiusRadioButton.Checked)
            {
                Temperature = temp + 273.15;
                return;
            }
        }

        private void temperatureBox1_KeyPress(object sender, KeyPressEventArgs e)
        {           
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) ||
                ((e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0])
                && (DS_Count(((System.Windows.Forms.TextBox)sender).Text) < 1)));
        }

        private int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        private void AcceptInputValues()
        {
            ConvertToKelvin();
            definitionOfZ.T = Temperature;
            ReadDataGridView();
            ReadCompositionOfGas();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FilePath = openFileDialog1.FileName;
                    FilePathTextBox.Text = FilePath;
                    
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            ImportDataButton.Enabled = true;
        }

        private void ImportDataButton_Click(object sender, EventArgs e)
        {          
            //Создаём приложение.
            var ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            //Открываем книгу.                                                                                                                                                        
            Workbook ObjWorkBook = ObjExcel.Workbooks.Open(FilePath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Выбираем таблицу(лист).
            Worksheet ObjWorkSheet;
            ObjWorkSheet = (Worksheet)ObjWorkBook.Sheets[1];

            // Указываем номер столбца (таблицы Excel) из которого будут считываться данные.
            int numCol1 = 1;
            
            Range usedColumn1 = ObjWorkSheet.UsedRange.Columns[numCol1];
            Array myvalues1 = (Array)usedColumn1.Cells.Value2;
            double[] arrPressure = myvalues1.OfType<object>().Select(o => Convert.ToDouble(o)).ToArray();

            //////////////////////////////////////////////////////////////////////////
            
            int numCol2 = 2;

            Range usedColumn2 = ObjWorkSheet.UsedRange.Columns[numCol2];
            Array myvalues2 = (Array)usedColumn2.Cells.Value2;
            double[] arrExtraction = myvalues2.OfType<object>().Select(o => Convert.ToDouble(o)).ToArray();

            // Выходим из программы Excel.
            ObjExcel.Quit();

            if(arrPressure.Length != arrExtraction.Length)
            {
                MessageBox.Show(
                   "there are mismatch between input values. Please, check file data for correctness",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1
                  );
                return;
            }

            //dataGridView1.Rows.Clear();

            for (int i = 0; i < arrPressure.Length; i++)
            {
                dataGridView1.Rows.Add(arrPressure[i], arrExtraction[i]);
            }

            //for(int i = 0; i < arrPressure.Length; i++)
            //    InputData.Pressure_Extraction.Add(arrPressure[i],arrExtraction[i]);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dataGridView1.EditingControl.KeyPress += temperatureBox1_KeyPress;
        }

        private void ReadDataGridView()
        {
            //DataGridViewColumn pressureCol = dataGridView1.Columns["Pressure"];

            //for(int i =0; i < dataGridView1.Rows.Count; i++)
            //{

            //}
            InputData.Pressure.Clear();
            InputData.GasExtraction.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                try
                {
                    if (row.Cells["Pressure"].Value == null || row.Cells["Pressure"].Value.ToString() == string.Empty) continue;
                    if (row.Cells["Production"].Value == null || row.Cells["Production"].Value.ToString() == string.Empty) continue;
                    InputData.Pressure.Add(Convert.ToDouble(row.Cells["Pressure"].Value));
                    InputData.GasExtraction.Add(Convert.ToDouble(row.Cells["Production"].Value));
                }
                catch(InvalidCastException ex)
                {
                   MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1
                  );
                    return;
                }
            }

            if(InputData.Pressure.Count == 0 || InputData.GasExtraction.Count == 0)
            {
                throw new Exception("Reservoir data is empty. Please input values");
            }

            if(InputData.Pressure.Count != InputData.GasExtraction.Count)
            {
                throw new Exception("there are mismatch between input values. Please, check data for correctness");
                
            }
        }

        private void CH4textBox_Validating(object sender, CancelEventArgs e)
        {  
            try
            {
                double val = 0;

                if (((System.Windows.Forms.TextBox)sender).Text == string.Empty)
                {
                    val = 0;
                    return;
                }

                val = double.Parse(((System.Windows.Forms.TextBox)sender).Text);

                if (val < 0 || val > 100)
                {
                    ((System.Windows.Forms.TextBox)sender).Text = "";
                    e.Cancel = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1
                  );
                return;
            }
        }

        private void ReadCompositionOfGas()
        {           
            InputData.U_data.Clear();

            try
            {
                if (CH4textBox.Text == "")
                {
                    InputData.U_data.Add(0);
                }
                else InputData.U_data.Add(double.Parse(CH4textBox.Text)/100);

                if (C2H6textBox.Text == "")
                {
                    InputData.U_data.Add(0);
                }
                else InputData.U_data.Add(double.Parse(C2H6textBox.Text)/100);

                if (C3H8textBox.Text == "")
                {
                    InputData.U_data.Add(0);
                }
                else InputData.U_data.Add(double.Parse(C3H8textBox.Text)/100);

                if (CO2textBox.Text == "")
                {
                    InputData.U_data.Add(0);
                }
                else InputData.U_data.Add(double.Parse(CO2textBox.Text)/100);

                if (N2textBox.Text == "")
                {
                    InputData.U_data.Add(0);
                }
                else InputData.U_data.Add(double.Parse(N2textBox.Text)/100);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(
                   ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1
                  );
                return;
            }
        }
       
    }
}
