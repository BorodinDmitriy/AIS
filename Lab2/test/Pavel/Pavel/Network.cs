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
            KnowledgePercept item = new KnowledgePercept(0, Math.Max, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
            item = new KnowledgePercept(0, KnowledgePercept.And, 0.1, 0.3, 0.11);
            Knowledge.Add(item);
        }
        private void KnowledgeInit2()
        {

        }
        private void DefuzzificationInit1()
        {

        }
        private void DefuzzificationInit2()
        {

        }
        public Network()
        {
            IncomePecept = new List<FuzzificationIncomePercept>();
            SpendPercept = new List<FuzzificationSpendPercept>();
            Knowledge = new List<KnowledgePercept>();
            DefuzPercept = new List<DefuzzificationPercept>();
            IncomePerceptInit_1();
            //IncomePerceptInit_2();
            SpendPerceptInit_1();
            //SpendPerceptInit_2();
            KnowledgeInit1();
            //KnowledgeInit2();
            DefuzzificationInit1();
            //DefuzzificationInit2();
        }

        public double findSolution(double income, double spend)
        {
            double res = 0;/*
            List<double> x = new List<double>();
            List<double> y = new List<double>();
            List<double> u = new List<double>();
            for (int I = 0; I < IncomePecept.Count; I++)
            {
                x.Add(IncomePecept[I].Transform(income));
            }
            for (int J = 0; J < SpendPercept.Count; J++)
            {
                y.Add(SpendPercept[J].Transform(spend));
            }
            for (int I = 0; I < x.Count; I++)
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
