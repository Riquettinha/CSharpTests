using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpTests.Performance
{
    public partial class Enumerables : Form
    {
        private int _executeTimes;

        public Enumerables()
        {
            InitializeComponent();
        }

        private void Loops_Load(object sender, EventArgs e)
        {
            Left = (Parent.ClientRectangle.Width - Width - 90) / 2;
            Top = (Parent.ClientRectangle.Height - Height - 50) / 2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _executeTimes = Convert.ToInt32(tbExecute.Text);
            tbListResult.Text = TestList() + @" ticks";
            tbHashSetResult.Text = TestHashSet() + @" ticks";
            tbEnumerableResult.Text = TestEnumerable() + @" ticks";
        }

        public void ExecuteList(List<ComplexObject> complexList1, List<ComplexObject> complexList2)
        {
            var result = new List<ComplexObject>();
            foreach (ComplexObject object2 in complexList2)
            {
                bool found = false;
                foreach (ComplexObject object1 in complexList1)
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

        public decimal TestList()
        {
            List<ComplexObject> complexList1 = new List<ComplexObject>();
            List<ComplexObject> complexList2 = new List<ComplexObject>();
            var rnd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                complexList1.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }
            for (int i = 0; i < 1000; i++)
            {
                complexList2.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }

            long listSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteList(complexList1, complexList2);

                sw.Stop();
                listSum += sw.Elapsed.Ticks;
            }

            return listSum / _executeTimes;
        }

        public void ExecuteEnumerable(IEnumerable<ComplexObject> complexList1, IEnumerable<ComplexObject> complexList2)
        {
            var result = new List<ComplexObject>();
            foreach (ComplexObject object2 in complexList2)
            {
                bool found = false;
                foreach (ComplexObject object1 in complexList1)
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

        public decimal TestEnumerable()
        {
            HashSet<ComplexObject> complexList1 = new HashSet<ComplexObject>();
            HashSet<ComplexObject> complexList2 = new HashSet<ComplexObject>();
            var rnd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                complexList1.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }
            for (int i = 0; i < 1000; i++)
            {
                complexList2.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }

            long hashSetSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteEnumerable(complexList1, complexList2);

                sw.Stop();
                hashSetSum += sw.Elapsed.Ticks;
            }

            return hashSetSum / _executeTimes;
        }

        public void ExecuteHashSet(HashSet<ComplexObject> complexList1, HashSet<ComplexObject> complexList2)
        {
            var result = new HashSet<ComplexObject>();
            foreach (ComplexObject object2 in complexList2)
            {
                bool found = false;
                foreach (ComplexObject object1 in complexList1)
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

        public decimal TestHashSet()
        {
            HashSet<ComplexObject> complexList1 = new HashSet<ComplexObject>();
            HashSet<ComplexObject> complexList2 = new HashSet<ComplexObject>();
            var rnd = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                complexList1.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }
            for (int i = 0; i < 1000; i++)
            {
                complexList2.Add(new ComplexObject
                {
                    Number = rnd.Next(5000),
                    Character = (char)rnd.Next(50)
                });
            }

            long hashSetSum = 0;
            for (int i = 0; i < _executeTimes; i++)
            {
                GC.Collect();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                ExecuteHashSet(complexList1, complexList2);

                sw.Stop();
                hashSetSum += sw.Elapsed.Ticks;
            }

            return hashSetSum / _executeTimes;
        }

        private void Loops_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 1),
                DisplayRectangle.X, DisplayRectangle.Y,
                DisplayRectangle.Width - 1, DisplayRectangle.Height - 1);
        }
    }
}
