using System;
using System.Data;
using System.Windows.Forms;

namespace Extended_Euclideanean_Algorithm
{
    public partial class Form1 : Form
    {
        private const string result_format = "НОД({0}, {1}) = {2}; {3}Решение для {0}x + {1}y = {2}{3}Если НОД \"< 0\", уравнение домножается на -1 {3}x = {4}, y = {5}";
        public string[] headers = { "A", "B", "A mod B", "[A/B]", "x", "y" };
        public DataTable Euclidean_table = new DataTable();

        public Form1()
        {
            InitializeComponent();

            Euclidean_datagrid.DataSource = Euclidean_table;
            foreach (string header in headers)
            {
                Euclidean_table.Columns.Add(header);
                Euclidean_datagrid.Columns[header].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Euclidean_run_Click(object sender, EventArgs e)
        {
            Euclidean_table.Rows.Clear();
            result_text.Clear();

            if (!long.TryParse(A_textbox.Text, out long A) || 
                !long.TryParse(B_textbox.Text, out long B) ||
                (A == 0 && B == 0))
            {
                MessageBox.Show("Wrong input, not null at one time integers, less than 2^63, please");
                return;
            }
            long[] equation_cofficients = new long[] { A, B }; 
            long x = 0, y = 1;
            if (A == 0 || B == 0)
            {       // В качестве исключения
                Euclidean_table.Rows.Add(A, B, "", "", x, y);
                if (A != 0)
                    (A, B) = (B, A);
                long GCD = B < 0 ? B * (y = -1) : B;
                result_text.Text = string.Format(
                    result_format, A, B, GCD, Environment.NewLine, x, y);
                return;
            }
            Euclidean_table.Rows.Add(A, B, A % B, A / B);
            while (A % B != 0)
            {
                long old_A = A;
                A = B;
                B = old_A % B;
                Euclidean_table.Rows.Add(A, B, A % B, A / B);
            }

            int Rows_number = Euclidean_table.Rows.Count;
            Euclidean_table.Rows[Rows_number - 1]["x"] = x;
            Euclidean_table.Rows[Rows_number - 1]["y"] = y;

            for (int i = Rows_number - 2; i >= 0; i--)
            {
                long old_x = x;
                x = y;
                y = old_x - y * long.Parse(Euclidean_table.Rows[i]["[A/B]"].ToString());
                (Euclidean_table.Rows[i]["x"], Euclidean_table.Rows[i]["y"]) = (x, y);
            }
            // B = GCD после преобразований
            if (B < 0)
            {   // Фактически GCD > 0
                x *= -1;
                y *= -1;
                B *= -1;
            }
            result_text.Text = string.Format(result_format, 
                equation_cofficients[0], equation_cofficients[1], B, 
                Environment.NewLine, x, y);
        }
    }
}