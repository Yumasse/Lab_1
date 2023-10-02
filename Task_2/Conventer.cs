using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    public class Converter


    {
        double hrn; //HRN
        public void SetHrn(double value)
        {
            hrn = value;
        }
        public double GetHrn()
        {
            return hrn;
        }


        double usd;  //USD
        public void SetUsd(double value)
        {
            usd = value;
        }
        public double GetUsd()
        {
            return usd;
        }


        double eur;  //EUR
        public void SetEur(double value)
        {
            eur = value;
        }
        public double GetEur()
        {
            return eur;
        }


        double pln; //PLN
        public void SetPln(double value)
        {
            pln = value;
        }
        public double GetPln()
        {
            return pln;
        }


        public double MethodUsd(double usd, double hrn, double nUsd) //NewUSD
        {
            nUsd = usd * hrn;
            return nUsd;
        }

        public double MethodEur(double eur, double hrn, double nEur) //NewEUR
        {
            nEur = eur * hrn;
            return nEur;
        }
        public double MethodPln(double pln, double hrn, double nPln) //NewPln
        {
            nPln = pln * hrn;
            return nPln;
        }

        //HRN

        public double MethodToUsd(double usd, double hrn, double nHrn) //NewHRN USD
        {
            nHrn = usd / hrn;
            return nHrn;
        }

        public double MethodToEur(double eur, double hrn, double nHrn) //NewHRN EUR
        {
            nHrn = eur / hrn;
            return nHrn;
        }
        public double MethodToPln(double pln, double hrn, double nHrn) //NewHRN Pln
        {
            nHrn = pln / hrn;
            return nHrn;
        }

        public Converter(double usd, double eur, double pln, double hrn)
        {
            Console.WriteLine("Конвертуємо!!!");
            
        }
    }
}
