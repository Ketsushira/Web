using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Otobus_Bileti_Rezervasyon_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kayıtlı_Kişiler.accdb");
        private void panel1_Resize(object sender, EventArgs e)
        {
            RoundPanelCorners();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Resize += panel1_Resize;
            RoundPanelCorners();
        }
        private void RoundPanelCorners()
        {
            int radius = 19; // Köşe yarıçapı
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);

            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new Region(path);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand selectsorgu = new OleDbCommand("select * from");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = panel1.ClientRectangle;
            rect.Inflate(-1, -1);
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush,
                    new Rectangle(rect.X + 10, rect.Y + 10, rect.Width, rect.Height));
            }
            e.Graphics.FillRectangle(new SolidBrush(panel1.BackColor), rect);
        }
    }
}
