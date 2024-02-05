using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pyt0_WForms_EjercicioDePintura
{
    public partial class Form1 : Form
    {

        private Graphics g;
        private Pen pen;
        private Rectangle rectangle;

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.DoubleBuffered = true; // Evitar parpadeo
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Obtén el objeto Graphics del formulario
            g = e.Graphics; //Lienzo

            // Suavizar bordes de las figuras
            g.SmoothingMode = SmoothingMode.AntiAlias;

            //Dibuja una línea
            pen = new Pen(Color.FromArgb(100, 34, 87));
            pen.Width = 5;
            g.DrawLine(pen,5,10,200,10);

            // Dibuja un arco
            pen = new Pen(Color.FromArgb(0, 200, 87));
            pen.Width = 3;
            Rectangle rctgl = new Rectangle(5, 10, 50, 60);
            g.DrawArc(pen, rctgl, 0, 90);

            // Dibuja un círculo
            int radioCirculo = 30;
            int xCirculo = 110;
            int yCirculo = 50;
            g.FillEllipse(Brushes.Blue, xCirculo, yCirculo, radioCirculo * 2, radioCirculo * 2);

            // Dibuja un cuadrado
            int ladoCuadrado = 80;
            int xCuadrado = 60;
            int yCuadrado = 150;
            g.FillRectangle(Brushes.Red, xCuadrado, yCuadrado, ladoCuadrado, ladoCuadrado);

            // Dibuja una elipse
            int anchoElipse = 100;
            int altoElipse = 60;
            int xElipse = 300;
            int yElipse = 50;
            g.FillEllipse(Brushes.Green, xElipse, yElipse, anchoElipse, altoElipse);

            //Dibuja un arco
            pen = new Pen(Color.FromArgb(0, 200, 87));
            pen.Width = 3;
            rectangle = new Rectangle(200, 120, 90, 60);
            g.DrawPie(pen, rectangle, 0, 180);

            // Dibuja una curva cerrada 
            Point point1 = new Point(250, 200);
            Point point2 = new Point(300, 230);
            Point point3 = new Point(350, 330);
            Point point4 = new Point(370, 400);
            Point point5 = new Point(250, 350);
            Point[] curvePoints = { point1, point2, point3, point4, point5 };
            g.FillClosedCurve(Brushes.Red, curvePoints);
        
        }

        // Puedes llamar a este método en cualquier lugar donde quieras volver a dibujar las formas
        private void RedibujarFormas()
        {
            // Vuelve a dibujar las formas llamando al método Invalidate()
            this.Invalidate();
        }

    }
}
