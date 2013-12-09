using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JugProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int maxJug1 = 10;
        private int maxJug2 = 10;
        private int target = 10;
        private const int n = 25;
        private bool[,] visited = new bool[n, n];
        private int[,] minPath = new int[n, n];
        private int[,,] nextPath = new int[n, n, 2];
        private int hmax1;
        private int hmax2;

        public int DieHard(int jug1, int jug2)
        {
            if (visited[jug1, jug2])
                return minPath[jug1, jug2];
            visited[jug1, jug2] = true;
            if (target == jug1 || target == jug2)
            {
                return minPath[jug1, jug2] = 0;
            }
            int temp;
            if (jug1 < maxJug1)
            {
                temp = DieHard(maxJug1, jug2) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = maxJug1;
                    nextPath[jug1, jug2, 1] = jug2;
                }
            }
            if (jug2 < maxJug2)
            {
                temp = DieHard(jug1, maxJug2) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = jug1;
                    nextPath[jug1, jug2, 1] = maxJug2;
                }
            }
            if (jug1 > 0)
            {
                temp = DieHard(0, jug2) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = 0;
                    nextPath[jug1, jug2, 1] = jug2;
                }
            }
            if (jug2 > 0)
            {
                temp = DieHard(jug1, 0) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = jug1;
                    nextPath[jug1, jug2, 1] = 0;
                }
            }
            if (jug1 + jug2 > maxJug1)
            {
                temp = DieHard(maxJug1, jug1 + jug2 - maxJug1) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = maxJug1;
                    nextPath[jug1, jug2, 1] = jug1 + jug2 - maxJug1;
                }
            }
            else
            {
                temp = DieHard(jug1 + jug2, 0) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = jug1 + jug2;
                    nextPath[jug1, jug2, 1] = 0;
                }
            }
            if (jug1 + jug2 > maxJug2)
            {
                temp = DieHard(jug1 + jug2 - maxJug2, maxJug2) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = jug1 + jug2 - maxJug2;
                    nextPath[jug1, jug2, 1] = maxJug2;
                }
            }
            else
            {
                temp = DieHard(0, jug1 + jug2) + 1;
                if (temp < minPath[jug1, jug2])
                {
                    minPath[jug1, jug2] = temp;
                    nextPath[jug1, jug2, 0] = 0;
                    nextPath[jug1, jug2, 1] = jug1 + jug2;
                }
            }
            return minPath[jug1, jug2];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
        }

        private int __gcd(int a, int b)
        {
            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void debug()
        {
            dataGridViewDebug.Rows.Clear();
            dataGridViewDebug.Columns.Clear();
            dataGridViewDebug.ColumnCount = maxJug2 + 2;
            for (int r = 0; r <= maxJug1; r++)
            {
                dataGridViewDebug.Rows.Add();
                dataGridViewDebug.Rows[r].Cells[0].Value = r;
                for (int c = 0; c <= maxJug2; c++)
                {
                    if (r == 0)
                        dataGridViewDebug.Columns[c + 1].HeaderText = c.ToString();
                    dataGridViewDebug.Rows[r].Cells[c + 1].Value = minPath[r, c] + "(" + nextPath[r, c, 0] + "," + nextPath[r, c, 1] + ")";
                }
            }
            dataGridViewDebug.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDebug.Refresh();
        }

        private void buttonFindTheWay_Click(object sender, EventArgs e)
        {
            maxJug1 = Convert.ToInt32(numericUpDownMaxJug1.Value);
            maxJug2 = Convert.ToInt32(numericUpDownMaxJug2.Value);
            target = Convert.ToInt32(numericUpDownTarget.Value);
            if (__gcd(maxJug1, maxJug1) == 1)
            {
                MessageBox.Show("Ukuran ember 1 dan ember 2 tidak relatif prima");
                return;
            }
            if (target > Math.Max(maxJug1, maxJug2))
            {
                MessageBox.Show("Target > dari ukuran ember maksimum");
                return;
            }
            if (maxJug1 > maxJug2)
            {
                hmax1 = (int)Math.Floor(250.0 / maxJug1);
                hmax2 = hmax1 * maxJug2;
                hmax1 *= maxJug1;
            }
            else
            {
                hmax2 = (int)Math.Floor(250.0 / maxJug2);
                hmax1 = hmax2 * maxJug1;
                hmax2 *= maxJug2;
            }
            panelMaxEmber1.Size = new Size(52, hmax1 + 2);
            panelMaxEmber1.Location = new Point(panelMaxEmber1.Location.X, 262 - hmax1);
            panelMaxEmber1.Refresh();
            panelMaxEmber2.Size = new Size(52, hmax2 + 2);
            panelMaxEmber2.Location = new Point(panelMaxEmber2.Location.X, 262 - hmax2);
            panelMaxEmber2.Refresh();
            for (int r = 0; r <= maxJug1; r++)
            {
                for (int c = 0; c <= maxJug2; c++)
                {
                    visited[r, c] = false;
                    minPath[r, c] = 1000000;
                    nextPath[r, c, 0] = -1;
                    nextPath[r, c, 1] = -1;
                }
            }
            numericUpDownMinimumStep.Value = DieHard(0, 0);
            numericUpDownMinimumStep.Refresh();
            debug();
            ShowProcess();
        }

        private void ShowProcess()
        {
            int j1 = 0, j2 = 0;
            int h1, h2;
            dataGridView1.Rows.Clear();
            while (true)
            {
                labelIsiJug1.Text = j1.ToString();
                labelIsiJug2.Text = j2.ToString();
                labelIsiJug1.Refresh();
                labelIsiJug2.Refresh();
                h1 = hmax1 * j1 / maxJug1;
                panelIsiEmber1.Size = new Size(50, h1);
                panelIsiEmber1.Location = new Point(panelIsiEmber1.Location.X, 263 - h1);
                h2 = hmax2 * j2 / maxJug2;
                panelIsiEmber2.Size = new Size(50, h2);
                panelIsiEmber2.Location = new Point(panelIsiEmber2.Location.X, 263 - h2);
                dataGridView1.Rows.Add();
                int idx = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[idx].Cells[0].Value = j1;
                dataGridView1.Rows[idx].Cells[1].Value = j2;
                dataGridView1.Refresh();
                if (target == j1 || target == j2)
                    break;
                h1 = nextPath[j1, j2, 0];
                h2 = nextPath[j1, j2, 1];
                j1 = h1;
                j2 = h2;
                panelIsiEmber2.Refresh();
                panelIsiEmber1.Refresh();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
