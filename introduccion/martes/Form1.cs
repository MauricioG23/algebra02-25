using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace martes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num11 = Convert.ToInt32(tb11.Text);
            int num21 = Convert.ToInt32(tb12.Text);
            int num31 = Convert.ToInt32(tb13.Text);


            int num12 = Convert.ToInt32(tb21.Text);
            int num22 = Convert.ToInt32(tb22.Text);
            int num32 = Convert.ToInt32(tb23.Text);


            int num13 = Convert.ToInt32(tb31.Text);
            int num23 = Convert.ToInt32(tb32.Text);
            int num33 = Convert.ToInt32(tb33.Text);

            int numi1 = Convert.ToInt32(s_1.Text);
            int numi2 = Convert.ToInt32(s_2.Text);
            int numi3 = Convert.ToInt32(s_3.Text);

            //int ds = (num11 * num22 * num33) + (num21 * num32 * num13) + (num31 * num12 * num23);
            //int di= (num13 * num22 * num31) + (num23 * num32 * num11) + (num33 * num12 * num21);
            //diagonal superior
            int d1 = CalcDiagonal(num11, num22, num33);
            int d2 = CalcDiagonal(num21, num32, num13);
            int d3 = CalcDiagonal(num31, num12, num23);
            //sumatoria diagonal superior
            int ds = CalcSumatoria(d1,d2, d3);
            //sumatoria diagonal inferior
            int d4 = CalcDiagonal(num13, num22, num31);
            int d5 = CalcDiagonal(num23, num32, num11);
            int d6 = CalcDiagonal(num33, num12, num21);
            //sumatoria diagonal inferior
            int di = CalcSumatoria(d4, d5, d6);
            //determinante genral
            int detG = ds - di;
            lb_det.Text = detG.ToString();
            
            //calcular x

            d1 = CalcDiagonal(numi1, num22, num33);
            d2 = CalcDiagonal(numi2, num32, num13);
            d3 = CalcDiagonal(numi3, num12, num23);
            ds= CalcSumatoria(d1, d2, d3);

             d4 = CalcDiagonal(num13, num22, numi3);
             d5 = CalcDiagonal(num23, num32, numi1);
             d6 = CalcDiagonal(num33, num12, numi2);
             di = CalcSumatoria(d4, d5, d6);
            int detx =ds - di;
            decimal x = detx / detG;
            lb_x.Text = x.ToString();

            // calcular y
            d1 = CalcDiagonal(num11, numi2, num33);
            d2 = CalcDiagonal(num21, numi3, num13);
            d3 = CalcDiagonal(num31, numi1, num23);
            ds = CalcSumatoria(d1,d2,d3);

            d4 = CalcDiagonal(num13, numi2, num31);
            d5 = CalcDiagonal(num23, numi3, num11);
            d6 = CalcDiagonal(num33, numi1, num21);
            di = CalcSumatoria(d4, d5, d6);
            int dety = ds - di;
            decimal y = dety / detG;
            lb_y.Text = y.ToString();

            //calcular z

            d1 = CalcDiagonal(num11, num22, numi3);
            d2 = CalcDiagonal(num21, num32, numi1);
            d3 = CalcDiagonal(num31, num12, numi2);
            ds = CalcSumatoria(d1, d2, d3);

            d4 = CalcDiagonal(numi1, num22, num31);
            d5 = CalcDiagonal(numi2, num32, num11);
            d6 = CalcDiagonal(numi3, num12, num21);
            di = CalcSumatoria(d4, d5, d6);
            int detz = ds - di;
            decimal z = detz / detG;
            lb_z.Text = z.ToString();






        }
        //diagonal 
        private int CalcDiagonal(int num1, int num2, int num3)
        {
            int diagonal = num1 * num2 * num3;
            return diagonal;
        
        
        }
        private int CalcSumatoria(int diagonal1, int diagonal2, int diagonal3)
        {

            int sumatoria = diagonal1 + diagonal2 + diagonal3;
            return sumatoria; 
        }

    }
}
