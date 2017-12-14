using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    public class Network
    {
        private List<FuzzificationIncomePercept> IncomePecept;
        private List<FuzzificationSpendPercept> SpendPercept;
        private List<FuzzificationCarSpendPercept> CarPercept;
        private List<KnowledgePercept> Knowledge;
        private DefuzzificationPercept DefuzPercept;

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
        private void SpendPerceptInit_1()
        {
            FuzzificationSpendPercept item = new FuzzificationSpendPercept(0, 3000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(2500, 8000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(7500, 15000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(14500, 30000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(29000, 41000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(40000, 80000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(78000, Int32.MaxValue);
            SpendPercept.Add(item);
        }
        private void IncomePerceptInit_2()
        {
            //  Init Income percept
            FuzzificationIncomePercept item = new FuzzificationIncomePercept(0.0, 5000.0, 0.1);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(4900, 10000, 0.15);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(9000, 22000, 0.25);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(20000, 70000, 0.18);
            IncomePecept.Add(item);
            item = new FuzzificationIncomePercept(69000, Int32.MaxValue, 0.1);
            IncomePecept.Add(item);
        }
        private void SpendPerceptInit_2()
        {
            FuzzificationSpendPercept item = new FuzzificationSpendPercept(0, 5000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(4000, 10000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(9000, 20000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(18000, 55000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(50000, 84000);
            SpendPercept.Add(item);
            item = new FuzzificationSpendPercept(80000, Int32.MaxValue);
            SpendPercept.Add(item);
        }
        private void KnowledgeInit1()
        {
            KnowledgePercept item = new KnowledgePercept(0, KnowledgePercept.Or, KnowledgePercept.And, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(0.5, KnowledgePercept.And, KnowledgePercept.And, 0.4, 0.8, 0.6);
            Knowledge.Add(item);
            item = new KnowledgePercept(12, KnowledgePercept.Or, KnowledgePercept.And, 0.6, 1, 0.9);
            Knowledge.Add(item);
            item = new KnowledgePercept(45, KnowledgePercept.And, KnowledgePercept.Or, 0.1, 0.2, 0.19);
            Knowledge.Add(item);
            item = new KnowledgePercept(123, KnowledgePercept.And, KnowledgePercept.And, 0.1, 0.8, 0.3);
            Knowledge.Add(item);
            item = new KnowledgePercept(23423, KnowledgePercept.Or, KnowledgePercept.Or, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(1238734, KnowledgePercept.Or, KnowledgePercept.And, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(9232, KnowledgePercept.And, KnowledgePercept.Or, 0.321, 0.652, 0.36);
            Knowledge.Add(item);
            item = new KnowledgePercept(87123, KnowledgePercept.Or, KnowledgePercept.And, 0.8, 1, 1);
            Knowledge.Add(item);
            item = new KnowledgePercept(127321, KnowledgePercept.And, KnowledgePercept.Or, 0, 1, 0);
            Knowledge.Add(item);
            item = new KnowledgePercept(123873912, KnowledgePercept.Or, KnowledgePercept.Or, 0, 1, 1);
            Knowledge.Add(item);
            item = new KnowledgePercept(26374862384, KnowledgePercept.And, KnowledgePercept.Or, 0.1, 0.365, 0.21);
            Knowledge.Add(item);
            item = new KnowledgePercept(902193, KnowledgePercept.Or, KnowledgePercept.And, 0.1, 0.7, 0.41);
            Knowledge.Add(item);
        }
        private void KnowledgeInit2()
        {
            KnowledgePercept item = new KnowledgePercept(0, KnowledgePercept.Or, KnowledgePercept.And, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(0.5, KnowledgePercept.And, KnowledgePercept.And, 0.4, 0.8, 0.6);
            Knowledge.Add(item);
            item = new KnowledgePercept(12, KnowledgePercept.Or, KnowledgePercept.And, 0.6, 1, 0.9);
            Knowledge.Add(item);
            item = new KnowledgePercept(45, KnowledgePercept.And, KnowledgePercept.Or, 0.1, 0.2, 0.19);
            Knowledge.Add(item);
            item = new KnowledgePercept(123, KnowledgePercept.And, KnowledgePercept.And, 0.1, 0.8, 0.3);
            Knowledge.Add(item);
            item = new KnowledgePercept(23423, KnowledgePercept.Or, KnowledgePercept.Or, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(1238734, KnowledgePercept.Or, KnowledgePercept.And, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(9232, KnowledgePercept.And, KnowledgePercept.Or, 0.321, 0.652, 0.36);
            Knowledge.Add(item);
            item = new KnowledgePercept(87123, KnowledgePercept.Or, KnowledgePercept.And, 0.8, 1, 1);
        }
        private void DefuzzificationInit()
        {
            DefuzPercept = new DefuzzificationPercept();
        }
        private void CarPerceptInit_1()
        {
            FuzzificationCarSpendPercept item = new FuzzificationCarSpendPercept(500, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(5000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(10000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(20000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(30000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(40000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(50000, 500);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(100000, 1500);
            CarPercept.Add(item);
        }

        private void CarPerceptInit_2()
        {
            FuzzificationCarSpendPercept item = new FuzzificationCarSpendPercept(8, 10);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(132, 12736);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(1, 4);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(6, 9);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(3, 7);
            CarPercept.Add(item);
            item = new FuzzificationCarSpendPercept(9, 13);
            CarPercept.Add(item);
        }
        public Network()
        {
            IncomePecept = new List<FuzzificationIncomePercept>();
            SpendPercept = new List<FuzzificationSpendPercept>();
            CarPercept = new List<FuzzificationCarSpendPercept>();
            Knowledge = new List<KnowledgePercept>();
            IncomePerceptInit_1();
            //IncomePerceptInit_2();
            SpendPerceptInit_1();
            //SpendPerceptInit_2();
            CarPerceptInit_1();
            //CarPerceptInit_2();
            KnowledgeInit1();
            //KnowledgeInit2();
            DefuzzificationInit();
        }

        public double findSolution(double income, double spend, double spendToCar)
        {
            double res = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            List<double> z = new List<double>();
            List<double> u = new List<double>();
            for (int I = 0; I < IncomePecept.Count; I++)
            {
                x.Add(IncomePecept[I].Transform(income));
            }
            for (int J = 0; J < SpendPercept.Count; J++)
            {
                y.Add(SpendPercept[J].Transform(spend));
            }
            for (int I = 0; I < CarPercept.Count; I++)
            {
                z.Add(CarPercept[I].Transform(spendToCar));
                Console.WriteLine(z[z.Count - 1]);
            }
            /*for (int I = 0; I < x.Count; I++)
                for(int J = 0; J < y.Count; J++)
                {
                    u.Add(Knowledge.checkRule(x, y));
                }
            for (int J = 0; J < DefuzPercept.Count; J++)
                res += DefuzPercept[J].Transform(u);*/
            return res;
        }
    }
}
