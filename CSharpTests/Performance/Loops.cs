using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace CSharpTests.Performance
{
    public partial class Loops : Form
    {
        private readonly List<ComplexObject> _complexList1 = new List<ComplexObject>();
        private readonly List<ComplexObject> _complexList2 = new List<ComplexObject>();
        private int _executeTimes;

        public Loops()
        {
            InitializeComponent();
        }

        private void Loops_Load(object sender, EventArgs e)
        {
            Left = (Parent.ClientRectangle.Width - Width - 90) / 2;
            Top = (Parent.ClientRectangle.Height - Height - 50) / 2;

            FillLists();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _executeTimes = Convert.ToInt32(tbExecute.Text);
            tbWhileResult.Text = TestWhile() + @" ticks";
            tbForResult.Text = TestFor() + @" ticks";
            tbForeachResult.Text = TestForeach() + @" ticks";
            tbLambdaResult.Text = TestLambda() + @" ticks";
        }

     private void FillLists()
     {
         var rnd = new Random();
         for (int i = 0; i < 100000; i++)
         {
             _complexList1.Add(new ComplexObject
             {
                 Number = rnd.Next(5000),
                 Character = (char)rnd.Next(50)
             });
         }
         for (int i = 0; i < 1000; i++)
         {
             _complexList2.Add(new ComplexObject
             {
                 Number = rnd.Next(5000),
                 Character = (char)rnd.Next(50)
             });
         }
     }

        public void ExecuteWhile()
        {
            var result = new List<ComplexObject>();
            int countList2 = 0;
            while (countList2 < _complexList2.Count)
            {
                bool found = false;
                var countList1 = 0;
                while (countList1 < _complexList1.Count)
                {
                    if (_complexList2[countList2].Number == _complexList1[countList1].Number &&
                        _complexList2[countList2].Character == _complexList1[countList1].Character)
                    {
                        found = true;
                        break;
                    }
                    countList1++;
                }

                if(!found)
                    result.Add(_complexList2[countList2]);

                countList2++;
            }
        }

        public decimal TestWhile()
        {
            long whileSum = 0;
            for (var i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteWhile();

                sw.Stop();
                whileSum += sw.Elapsed.Ticks;
            }

            return whileSum / _executeTimes;
        }

        public void ExecuteFor()
        {
            var result = new List<ComplexObject>();
            for (int countList2 = 0; countList2 < _complexList2.Count; countList2++)
            {
                bool found = false;
                for (int countList1 = 0; countList1 < _complexList1.Count; countList1++)
                {
                    if (_complexList2[countList2].Number == _complexList1[countList1].Number &&
                        _complexList2[countList2].Character == _complexList1[countList1].Character)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    result.Add(_complexList2[countList2]);
            }
        }

        public decimal TestFor()
        {
            long forSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteFor();

                sw.Stop();
                forSum += sw.Elapsed.Ticks;
            }

            return forSum / _executeTimes;
        }

        public void ExecuteForeach()
        {
            var result = new List<ComplexObject>();
            foreach (ComplexObject object2 in _complexList2)
            {
                bool found = false;
                foreach (ComplexObject object1 in _complexList1)
                {
                    if (object2.Number == object1.Number &&
                        object2.Character == object1.Character)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    result.Add(object2);
            }
        }

        public decimal TestForeach()
        {
            long foreachSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteForeach();

                sw.Stop();
                foreachSum += sw.Elapsed.Ticks;
            }

            return foreachSum / _executeTimes;
        }

    public void ExecuteLambda()
    {
        var result =
            _complexList2.Count(
                l2 => _complexList1.All(l1 => l2.Number != l1.Number || l2.Character != l1.Character));
    }

        public decimal TestLambda()
        {
            long LINQSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteLambda();

                sw.Stop();
                LINQSum += sw.Elapsed.Ticks;
            }

            return LINQSum / _executeTimes;
        }

        private void Loops_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1),
                DisplayRectangle.X, DisplayRectangle.Y,
                DisplayRectangle.Width - 1, DisplayRectangle.Height - 1);
        }
    }

    public class ComplexObject
    {
        public int Number { get; set; }
        public char Character { get; set; }
    }
}
