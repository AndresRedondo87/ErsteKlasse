using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsteKlasse
{
    class Box
    {
        //member Variablen
        //int length;
        //int height;
        //int width;        
        //int volume;
        /* JAVA UMWEG
        /// private int length;
        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        */


        private string color = "weiß";//so würden alle Boxen immer weiß sein.
        // vor allem da es wir nie ändern

        // PROPERTIES "code Schnippet prop. Erstell ganz normaler get und set dabei.
        public int Length { get; set; }

        ///////// Das bedeutet sowas wie:
        ////////public int Length
        ////////{
        ////////    get
        ////////    {
        ////////        return length;
        ////////    }
        ////////    set
        ////////    {
        ////////        length = value;
        ////////    }
        ////////}
        /// Und noch kürzer:
        ////////public int Length
        ////////{
        ////////    get => length;
        ////////    set => length = value;
        ////////}
        

        public int Height { get; set; }
        public int Width 
        { get; set; }
        public int Volume { get; set; }

        // Herausforderung Vorderseite
        public int FrontSide 
        {
            get
            {
                return Height* Width;
            }
                
             // set; Dieses wert wird berechnet, darf nicht gesettet werden!
        }

        //Selber hergestellt Konstruktor
        public Box(int length, int height, int width)
        {
            this.Length = length;
            this.Height = height;
            this.Width = width;
            //this.Volume =
        }

        //public Box()    //"Default" Konstruktor, nicht nötig
        //{
        //    this.Length = 1;
        //    this.Height = 1;
        //    this.Width = 1;
        //    //this.Volume =
        //}



        public void DisplayInfo()
        {
            Console.WriteLine( $"Länge ist {Length} und Höhe ist {Height} und Breite ist {Width}. \nSomit ist das Volumen {Volume= Length* Height* Width} cm3 und die Vorderseite ist {FrontSide} cm2.");
            //hier wird es berechnet und gespeichert!!
        }



        ////////// Membervariablen ------------------Lehrer Option....vol nervig
        ////////private string color = "weiß";
        ////////// Länge
        ////////int length;
        ////////// Höhe
        //////////int height;
        ////////// Breite
        ////////int width;
        ////////// Volumen
        ////////int volume;

        ////////// auto - implemented property // prop + 2Mal Tab
        ////////public int Height { get; set; }

        ////////public Box(int length, int height, int width)
        ////////{
        ////////    this.length = length;
        ////////    this.Height = height;
        ////////    this.width = width;
        ////////}

        ////////// write only
        ////////public int Volume
        ////////{
        ////////    get
        ////////    {
        ////////        return Height * Length * Width;
        ////////    }

        ////////    set
        ////////    {
        ////////        volume = value;
        ////////    }
        ////////}

        ////////// Nur lesen - read only
        ////////public int Width
        ////////{
        ////////    get
        ////////    {
        ////////        return width;
        ////////    }
        ////////    /*
        ////////    set
        ////////    {
        ////////        if (value < 0)
        ////////        {
        ////////            value = -value;
        ////////        }
        ////////        width = value;
        ////////    }
        ////////    */
        ////////}

        ////////public int Length
        ////////{
        ////////    get => length;
        ////////    set => length = value;
        ////////}
        /////////*
        ////////public int Length
        ////////{
        ////////    get
        ////////    {
        ////////        return length;
        ////////    }
        ////////    set
        ////////    {
        ////////        length = value;
        ////////    }
        ////////}
        ////////*/
        /////////*
        ////////public void SetLength(int length)
        ////////{
        ////////    this.length = length;
        ////////}

        ////////public int GetLength()
        ////////{
        ////////    return this.length;
        ////////}
        ////////*/

        ////////public int FrontSurface
        ////////{
        ////////    get
        ////////    {
        ////////        return Height * length;
        ////////    }

        ////////}

        ////////public void DisplayInfo()
        ////////{
        ////////    Console.WriteLine("Länge ist {0} und Höhe ist {1} und Breite ist {2} somit ist das Volumen {3}",
        ////////        length, Height, width, volume = length * Height * width);
        ////////}


    }
}
