using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using okna;
namespace Zad1
{
    public abstract class Window
    {
        // zawieszone w pewnym punkcie lewy górny róg okna
        protected int top;
        protected int left;
        protected int width;
        protected int length;
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // rysowanie to sprawa konkretnego okna
        public virtual void DrawWindow(){}
        public virtual void MovieWindow(){}
        public virtual void ResizeWindow(){}
    }

    public class Panel : Window
    {
        protected List<Window> okna;
        public Panel(int top, int left)
            : base(top, left)
        {
            okna = new List<Window>();
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Panel at: {0} {1}", top, left);
            foreach (Window w in okna)
                w.DrawWindow();
        }

        public void Dodaj(Window w)
        {
            okna.Add(w);
        }
    }

    public class TextBox : Window
    {
        private string textBoxContents;

        public TextBox(int top, int left, string contents)
            : base(top, left)
        {
            textBoxContents = contents;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("textBox: {0} at {1}, {2}\n", textBoxContents, top, left);
        }

    }

    public class Button : Window
    {
        private string name;
        public Button(int top, int left, string name)
            : base(top, left)
        {
            this.name = name;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("button {0} at {1}, {2}\n", name, top, left);
        }
    }  


    class Program
    {
        static void Main(string[] args)
        {
            Window[] winArray = new Window[4];
            winArray[0] = new TextBox(1, 2, "First Text Box");
            winArray[1] = new TextBox(3, 4, "Second Text Box");
            winArray[2] = new Button(5, 6, "Open");
            winArray[3] = new Button(9, 10, "Close");
            for (int i = 0; i < 4; i++)
            {
                winArray[i].DrawWindow();
            }
            Console.WriteLine();
            Panel panel = new Panel(0, 0);
            panel.Dodaj(winArray[0]);
            panel.Dodaj(winArray[1]);
            panel.Dodaj(winArray[2]);
            panel.Dodaj(winArray[3]);

            panel.DrawWindow();


            Console.ReadKey();
        }
    }
}
