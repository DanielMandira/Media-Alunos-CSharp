using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Media_Aluno
{
    
    internal class Class_Calculos
    {
        private double NumAula;
        private double NumFalta;
        
        

        public void setNumAula(double NumAula)
        {
            
            this.NumAula = NumAula;
        }
        public double getNumAula()
        {
            return this.NumAula;
        }
        public void setNumFalta (double NumFalta)
        {
            this.NumFalta = NumFalta;
        }
        public double getNumFalta()
        {
            return this.NumFalta;
        }

        public double calcFreqBi()
        {
            double NAula=getNumAula();
            double NFalta=getNumFalta();
            double freq = (NFalta / NAula) * 100;
            freq = 100 - freq;
            return freq;
        }

        private double NumAula1;
        private double NumAula2;
        private double NumAula3;
        private double NumAula4;

        public void setNumAula1(double NumAula1)
        {
            this.NumAula1 = NumAula1;
        }
        public double getNumAula1()
        {
            return this.NumAula1;
        }
        public void setNumAula2(double NumAula2)
        {
            this.NumAula2 = NumAula2;
        }
        public double getNumAula2()
        {
            return this.NumAula2;
        }
        public void setNumAula3(double NumAula3)
        {
            this.NumAula3 = NumAula3;
        }
        public double getNumAula3()
        {
            return this.NumAula3;
        }
        public void setNumAula4(double NumAula4)
        {
            this.NumAula4 = NumAula4;
        }
        public double getNumAula4()
        {
            return this.NumAula4;
        }

        public double calcTotalAula()
        {

            double NumAula1 = getNumAula1();
            double NumAula2 = getNumAula2();
            double NumAula3 = getNumAula3();    
            double NumAula4 = getNumAula4();
            double TotalAula = NumAula1 + NumAula2 + NumAula3 + NumAula4;
            return TotalAula;

        }

        private double NumFalta1;
        private double NumFalta2;
        private double NumFalta3;
        private double NumFalta4;

        public void setNumFalta1(double NumFalta1)
        {
            this.NumFalta1 = NumFalta1;
        }
        public double getNumFalta1()
        {
            return this.NumFalta1;
        }
        public void setNumFalta2(double NumFalta2)
        {
            this.NumFalta2 = NumFalta2;
        }
        public double getNumFalta2()
        {
            return this.NumFalta2;
        }
        public void setNumFalta3(double NumFalta3)
        {
            this.NumFalta3 = NumFalta3;
        }
        public double getNumFalta3()
        {
            return this.NumFalta3;
        }
        public void setNumFalta4(double NumFalta4)
        {
            this.NumFalta4 = NumFalta4;
        }
        public double getNumFalta4()
        {
            return this.NumFalta4;
        }

        public double calcTotalFalta()
        {
            double NumFalta1 = getNumFalta1();
            double NumFalta2 = getNumFalta2();
            double NumFalta3 = getNumFalta3();
            double NumFalta4 = getNumFalta4();
            double TotalFalta = NumFalta1 + NumFalta2 + NumFalta3 + NumFalta4;
            return TotalFalta;

        }


        private double Nota1;
        private double Nota2;
        private double Nota3;
        private double Nota4;

        public void setNota1(double Nota1)
        {
            this.Nota1 = Nota1;
        }
        public double getNota1()
        {
            return this.Nota1;
        }
        public void setNota2(double Nota2)
        {
            this.Nota2 = Nota2;
        }
        public double getNota2()
        {
            return this.Nota2;
        }
        public void setNota3(double Nota3)
        {
            this.Nota3 = Nota3;
        }
        public double getNota3()
        {
            return this.Nota3;
        }
        public void setNota4(double Nota4)
        {
            this.Nota4 = Nota4;
        }
        public double getNota4()
        {
            return this.Nota4;
        }

        public double calcMediaParc()
        {
            double Nota1 = getNota1();
            double Nota2 = getNota2();
            double Nota3 = getNota3();
            double Nota4 = getNota4();
            double TotalMediaParc= (Nota1 + Nota2 + Nota3 + Nota4)/4;
            return TotalMediaParc;
        }
        double TotalFalta;
        double TotalAula;
        public void setTotalFalta(double TotalFalta)
        {
            this.TotalFalta = TotalFalta;
        }
        public double getTotalFalta()
        {
            return this.TotalFalta;
        }
        public void setTotalAula(double TotalAula)
        {
            this.TotalAula = TotalAula;
        }
        public double getTotalAula()
        {
            return this.TotalAula;
        }
        public double calcFreqTot()
        {
            double totalAula = getTotalAula();
            double totalFalta = getTotalFalta();
            double FreqMed = (totalFalta / totalAula) * 100;
            FreqMed = 100 - FreqMed;
            return FreqMed;
        }
        double TotalMedParc1;
        double TotalMedParc2;
        double TotalMedParc3;

        public void setTotalMedParc1(double TotalMedParc1)
        {
            this.TotalMedParc1 = TotalMedParc1;
        }
        public double getTotalMedParc1()
        {
            return this.TotalMedParc1;
        }
        public void setTotalMedParc2(double TotalMedParc2)
        {
            this.TotalMedParc2 = TotalMedParc2;
        }
        public double getTotalMedParc2()
        {
            return this.TotalMedParc2;
        }
        public void setTotalMedParc3(double TotalMedParc3)
        {
            this.TotalMedParc3 = TotalMedParc3;
        }
        public double getTotalMedParc3()
        {
            return this.TotalMedParc3;
        }
        public double calcMedFim()
        {
            double TotalMedParc1 = getTotalMedParc1();
            double TotalMedParc2 = getTotalMedParc2();
            double TotalMedParc3 = getTotalMedParc3();
            double TotalMedFim=(TotalMedParc1 + TotalMedParc2 + TotalMedParc3) / 3;
            return TotalMedFim;
        }

        double freqMed1;
        double freqMed2;
        double freqMed3;

        public void setFreqMed1(double freqMed1)
        {
            this.freqMed1 = freqMed1;
        }
        public double getFreqMed1()
        {
            return this.freqMed1;
        }
        public void setFreqMed2(double freqMed2)
        {
            this.freqMed2 = freqMed2;
        }
        public double getFreqMed2()
        {
            return this.freqMed2;
        }
        public void setFreqMed3(double freqMed3)
        {
            this.freqMed3 = freqMed3;
        }
        public double getFreqMed3()
        {
            return this.freqMed3;
        }
        public double calcFrecFim()
        {
            double freqMed1 = getFreqMed1();
            double freqMed2 = getFreqMed2();
            double freqMed3 = getFreqMed3();
            double freqFim = (freqMed1 + freqMed2 + freqMed3) / 3;
            return freqFim;
        }
        private double TotalMedFim;
        private double FreqFim;

        public void setTotalMedFim(double TotalMedFim)
        {
            this.TotalMedFim = TotalMedFim;
        }
        public double getTotalMedFim()
        {
            return this.TotalMedFim;
        }
        public void setFreqFim(double FreqFim)
        {
            this.FreqFim = FreqFim;
        }
        public double getFreqFim()
        {
            return this.FreqFim;
        }
    }
}
