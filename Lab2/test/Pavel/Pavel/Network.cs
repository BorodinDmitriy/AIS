using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    class Network
    {
        private List<FuzzificationIncomePercept> IncomePecept;
        private List<FuzzificationSpendPercept> SpendPercept;
        private List<KnowledgePercept> Knowledge;
        private List<DefuzzificationPercept> DefuzPercept;

        private void IncomePerceptInit_1()
        {
            //  Init Income percept
            FuzzificationIncomePercept item = new FuzzificationIncomePercept(0.0, 1000.0, 0.1);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(900, 5000, 0.15);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(4800, 12000, 0.25);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(10000, 21000, 0.18);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(20000, 41000, 0.08);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(40000, 62000, 0.1);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(60000, 101000, 0.2);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(101000, Int32.MaxValue, 0.2);
            IncomePecept.Add(item);
        }
        Network()
        {
            IncomePerceptInit_1();
        }
    }
}
