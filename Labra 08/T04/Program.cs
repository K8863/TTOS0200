/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). 
 *          Laadi erillinen abstrakti Shape-luokka, josta muut kuviot periytyvät. 
 *          Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja Circumference-metodit (pinta-ala ja ympärysmitta). 
 *          Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit. 
 *          Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. 
 *          Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. 
 *          Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne ja tulosta kaikki sen sisältämät kuviot.
 *          
 *          Esimerkkitulostus:
 *          
 *              Circle Radius=1 Area=3,14 Circumference=7,28
 *              Circle Radius=2 Area=12,57 Circumference=12,56
 *              Circle Radius=3 Area=28,27 Circumference=18,84
 *              Rectangle Width=10 Height=20 Area=200,00 Circumference=60,00
 *              Rectangle Width=20 Height=30 Area=600,00 Circumference=100,00
 *              Rectangle Width=40 Height=50 Area=2000,00 Circumference=180,00
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04
{
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract void Area();
        public abstract void Circumference();
        public Shape(string name) { Name = name; }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override string ToString()
        {
            return Name + " Radius=" + Radius;
        }
        public Circle(string name, double radius)
            : base(name) { Radius = radius; }
        public override void Area()
        {
            Console.Write(" Area=" + (3.14 * Radius * Radius));
        }
        public override void Circumference()
        {
            Console.Write(" Circumference=" + (2 * 3.14 * Radius));
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string ToString()
        {
            return Name + " Width=" + Width + " Height=" + Height;
        }
        public Rectangle(string name, double width, double height)
            : base(name) { Width = width; Height = height; }
        public override void Area()
        {
            Console.Write(" Area=" + (Width * Height));
        }
        public override void Circumference()
        {
            Console.Write(" Circumference=" + ((2 * Width) + (2 * Height)));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShapeTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ShapeTest()
        {
            try
            {
                List<Shape> shapes = new List<Shape>();
                shapes.Add(new Circle("Circle", 1));
                shapes.Add(new Circle("Circle", 2));
                shapes.Add(new Circle("Circle", 3));
                shapes.Add(new Rectangle("Rectangle", 10, 20));
                shapes.Add(new Rectangle("Rectangle", 20, 30));

                foreach (Shape shape in shapes)
                {
                    Console.Write(shape.ToString());
                    shape.Area();
                    shape.Circumference();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
