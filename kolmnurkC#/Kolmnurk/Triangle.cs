using System;
using System.Windows.Forms;

namespace Kolmnurk
{
    public class Triangle
    {
        public double A;
        public double B;
        public double C;
        public double S;
        public double H;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(double s, double h) 
        { 
            S = s;
            H = h;
        }

        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (A==B && B==C && A==C)
                    {
                        return "võrdkülgne kolmnurk";

                    }
                    else if(A==B || B==C || A==C)
                    {
                        return "võrdhaarne kolmnurk";

                    }
                    else
                    {
                        return "erikülgne kolmnurk";

                    }
                }
                else {
                    return "tundmatu tüüp";
                     }
            }
                
        }

        public bool ExistTriangle
        {
            get
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public double Bisector()
        {
            if (ExistTriangle)
            {
                double p = Perimeter() / 2;
                double bisector = (2 * Math.Sqrt(A * B * p * (p - C))) / (A + B);
                bisector = Math.Round(bisector, 2);
                return bisector;
            }
            else
            {
                return 0;
            }
        }

        //    метод для определения типа треугольника и изменения  картинки
        public void ImageTriangleType(PictureBox pictureBox)
        {
            string triangleType = TriangleType.ToLower(); 
            switch (triangleType)
            {
                case "võrdkülgne kolmnurk":
                    // картинки для равностороннего треугольника
                    pictureBox.Image = Properties.Resources.ravnostr1; 
                    break;
                case "võrdhaarne kolmnurk":
                    // картинки для võrdhaarne kolmnurkренного треугольника
                    pictureBox.Image = Properties.Resources.ravnobedr1; 
                    break;
                case "erikülgne kolmnurk":
                    // картинки для разностороннего треугольника
                    pictureBox.Image = Properties.Resources.razno1; 
                    break;
                default:
                    Console.WriteLine("Tundmatu tüüp");
                    break;
            }
        }

        public double GetSetA
        {
            get { return A; }
            set { A = value; }
        }

        public double GetSetB
        {
            get { return B; }
            set { B = value; }
        }

        public double GetSetC
        {
            get { return C; }
            set { C = value; }
        }

        public double GetSetS
        {
            get { return S; }
            set { S = value; }
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double PerimentrL()
        { return (A + B + C)/2;}

        public double Area()
        {
            double s = 0;
            if (ExistTriangle)
            {
                double p = (A + B + C) / 2;
                s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            return s;
        }


        public string OutputA()
        {
            return A.ToString();
        }

        public string OutputB()
        {
            return B.ToString();
        }

        public string OutputC()
        {
            return C.ToString();
        }
    }
}



