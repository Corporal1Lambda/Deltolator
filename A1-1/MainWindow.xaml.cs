using System;
using System.Windows;

namespace QuadraticEquationSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(LabelA.Text, out double a) &&
                double.TryParse(LabelB.Text, out double b) &&
                double.TryParse(LabelC.Text, out double c))
            {
                double delta = b * b - 4 * a * c;
                double sqrtDelta = Math.Sqrt(delta);

                if (delta > 0)
                {
                    double x1 = (-b + sqrtDelta) / (2 * a);
                    double x2 = (-b - sqrtDelta) / (2 * a);
                    ResultText.Text = $"Delta = {delta}\nPierwiastek z delty = {sqrtDelta}\nx1 = {x1}\nx2 = {x2}";
                }
                else if (delta == 0)
                {
                    double x0 = -b / (2 * a);
                    ResultText.Text = $"Delta = {delta}\nPierwiastek z delty = {sqrtDelta}\nx0 = {x0}";
                }
                else
                {
                    ResultText.Text = "Delta < 0 - równanie sprzeczne.";
                }
            }
            else
            {
                ResultText.Text = "Błąd, podana wartość nie jest liczbą!";
            }
        }
    }
}
