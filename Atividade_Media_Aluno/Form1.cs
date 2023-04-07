namespace Atividade_Media_Aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Class_Calculos calc = new Class_Calculos();
        
        private void TXT_NotaBD1_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(TXT_NumAulaBD1.Text))
            {
                TXT_NumAulaBD1.Text = "0"; 
                TXT_NumAulaBD1.Hide();
               
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasBD1.Text))
            {
                TXT_NumFaltasBD1.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaBD1.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasBD1.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqBD1.Text = freq.ToString() + "%";
            

        }

        private void TXT_NotaC1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaC1.Text))
            {
                TXT_NumAulaC1.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasC1.Text))
            {
                TXT_NumFaltasC1.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaC1.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasC1.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqC1.Text = freq.ToString() + "%";

        }



        private void TXT_NotaSE1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaSE1.Text))
            {
                TXT_NumAulaSE1.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasSE1.Text))
            {
                TXT_NumFaltasSE1.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaSE1.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasSE1.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqSE1.Text = freq.ToString() + "%";
        }

        private void TXT_NotaBD2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaBD2.Text))
            {
                TXT_NumAulaBD2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasBD2.Text))
            {
                TXT_NumFaltasBD2.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaBD2.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasBD2.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqBD2.Text = freq.ToString() + "%";
        }

        private void TXT_NotaC2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaC2.Text))
            {
                TXT_NumAulaC2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasC2.Text))
            {
                TXT_NumFaltasC2.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaC2.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasC2.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqC2.Text = freq.ToString() + "%";
        }

        private void TXT_NotaSE2_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaSE2.Text))
            {
                TXT_NumAulaSE2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasSE2.Text))
            {
                TXT_NumFaltasSE2.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaSE2.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasSE2.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqSE2.Text = freq.ToString() + "%";
        }

        private void TXT_NotaBD3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaBD3.Text))
            {
                TXT_NumAulaBD3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasBD3.Text))
            {
                TXT_NumFaltasBD3.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaBD3.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasBD3.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqBD3.Text = freq.ToString() + "%";
        }

        private void TXT_NotaC3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaC3.Text))
            {
                TXT_NumAulaC3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasC3.Text))
            {
                TXT_NumFaltasC3.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaC3.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasC3.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqC3.Text = freq.ToString() + "%";
        }

        private void TXT_NotaSE3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaSE3.Text))
            {
                TXT_NumAulaSE3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasSE3.Text))
            {
                TXT_NumFaltasSE3.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaSE3.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasSE3.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqSE3.Text = freq.ToString() + "%";
        }

        private void TXT_NotaBD4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaBD4.Text))
            {
                TXT_NumAulaBD4.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasBD4.Text))
            {
                TXT_NumFaltasBD4.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaBD4.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasBD4.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqBD4.Text = freq.ToString() + "%";
        }

        private void TXT_NotaC4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaC4.Text))
            {
                TXT_NumAulaC4.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasC4.Text))
            {
                TXT_NumFaltasC4.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaC4.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasC4.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqC4.Text = freq.ToString() + "%";
        }

        private void TXT_NotaSE4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXT_NumAulaSE4.Text))
            {
                TXT_NumAulaSE4.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NumFaltasSE4.Text))
            {
                TXT_NumFaltasSE4.Text = "0";
            }
            double naula = Convert.ToDouble(TXT_NumAulaSE4.Text);
            double nfalta = Convert.ToDouble(TXT_NumFaltasSE4.Text);
            calc.setNumAula(naula);
            calc.setNumFalta(nfalta);
            double freq = calc.calcFreqBi();
            LBL_FreqSE4.Text = freq.ToString() + "%";
        }

        private void BTN_MediaParc_Click(object sender, EventArgs e)
        {
            double aulaBD1 = Convert.ToDouble(TXT_NumAulaBD1.Text);
            double aulaBD2 = Convert.ToDouble(TXT_NumAulaBD2.Text);
            double aulaBD3 = Convert.ToDouble(TXT_NumAulaBD3.Text);
            double aulaBD4 = Convert.ToDouble(TXT_NumAulaBD4.Text);
            calc.setNumAula1(aulaBD1);
            calc.setNumAula2(aulaBD2);
            calc.setNumAula3(aulaBD3);
            calc.setNumAula4(aulaBD4);
            double TotalAulaBD = calc.calcTotalAula();
            LBL_TotalAulaBD.Text = TotalAulaBD.ToString();
            double aulaC1 = Convert.ToDouble(TXT_NumAulaC1.Text);
            double aulaC2 = Convert.ToDouble(TXT_NumAulaC2.Text);
            double aulaC3 = Convert.ToDouble(TXT_NumAulaC3.Text);
            double aulaC4 = Convert.ToDouble(TXT_NumAulaC4.Text);
            calc.setNumAula1(aulaC1);
            calc.setNumAula2(aulaC2);
            calc.setNumAula3(aulaC3);
            calc.setNumAula4(aulaC4);
            double TotalAulaC = calc.calcTotalAula();
            LBL_TotalAulaC.Text = TotalAulaC.ToString();
            double aulaSE1 = Convert.ToDouble(TXT_NumAulaSE1.Text);
            double aulaSE2 = Convert.ToDouble(TXT_NumAulaSE2.Text);
            double aulaSE3 = Convert.ToDouble(TXT_NumAulaSE3.Text);
            double aulaSE4 = Convert.ToDouble(TXT_NumAulaSE4.Text);
            calc.setNumAula1(aulaSE1);
            calc.setNumAula2(aulaSE2);
            calc.setNumAula3(aulaSE3);
            calc.setNumAula4(aulaSE4);
            double TotalAulaSE = calc.calcTotalAula();
            LBL_TotalAulaSE.Text = TotalAulaSE.ToString();

            double faltaBD1 = Convert.ToDouble(TXT_NumFaltasBD1.Text);
            double faltaBD2 = Convert.ToDouble(TXT_NumFaltasBD2.Text);
            double faltaBD3 = Convert.ToDouble(TXT_NumFaltasBD3.Text);
            double faltaBD4 = Convert.ToDouble(TXT_NumFaltasBD4.Text);
            calc.setNumFalta1(faltaBD1);
            calc.setNumFalta2(faltaBD2);
            calc.setNumFalta3(faltaBD3);
            calc.setNumFalta4(faltaBD4);
            double TotalFaltaBD = calc.calcTotalFalta();
            LBL_TotalFaltaBD.Text = TotalFaltaBD.ToString();
            double faltaC1 = Convert.ToDouble(TXT_NumFaltasC1.Text);
            double faltaC2 = Convert.ToDouble(TXT_NumFaltasC2.Text);
            double faltaC3 = Convert.ToDouble(TXT_NumFaltasC3.Text);
            double faltaC4 = Convert.ToDouble(TXT_NumFaltasC4.Text);
            calc.setNumFalta1(faltaC1);
            calc.setNumFalta2(faltaC2);
            calc.setNumFalta3(faltaC3);
            calc.setNumFalta4(faltaC4);
            double TotalFaltaC = calc.calcTotalFalta();
            LBL_TotalFaltaC.Text = TotalFaltaC.ToString();
            double faltaSE1 = Convert.ToDouble(TXT_NumFaltasSE1.Text);
            double faltaSE2 = Convert.ToDouble(TXT_NumFaltasSE2.Text);
            double faltaSE3 = Convert.ToDouble(TXT_NumFaltasSE3.Text);
            double faltaSE4 = Convert.ToDouble(TXT_NumFaltasSE4.Text);
            calc.setNumFalta1(faltaSE1);
            calc.setNumFalta2(faltaSE2);
            calc.setNumFalta3(faltaSE3);
            calc.setNumFalta4(faltaSE4);
            double TotalFaltaSE = calc.calcTotalFalta();
            LBL_TotalFaltaSE.Text = TotalFaltaSE.ToString();

            if (string.IsNullOrEmpty(TXT_NotaBD1.Text))
            {
                TXT_NotaBD1.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaBD2.Text))
            {
                TXT_NotaBD2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaBD3.Text))
            {
                TXT_NotaBD3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaBD4.Text))
            {
                TXT_NotaBD4.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaC1.Text))
            {
                TXT_NotaC1.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaC2.Text))
            {
                TXT_NotaC2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaC3.Text))
            {
                TXT_NotaC3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaC4.Text))
            {
                TXT_NotaC4.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaSE1.Text))
            {
                TXT_NotaSE1.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaSE2.Text))
            {
                TXT_NotaSE2.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaSE3.Text))
            {
                TXT_NotaSE3.Text = "0";
            }
            if (string.IsNullOrEmpty(TXT_NotaSE4.Text))
            {
                TXT_NotaSE4.Text = "0";
            }
            double NotaBD1 = Convert.ToDouble(TXT_NotaBD1.Text);
            double NotaBD2 = Convert.ToDouble(TXT_NotaBD2.Text);
            double NotaBD3 = Convert.ToDouble(TXT_NotaBD3.Text);
            double NotaBD4 = Convert.ToDouble(TXT_NotaBD4.Text);
            calc.setNota1(NotaBD1);
            calc.setNota2(NotaBD2);
            calc.setNota3(NotaBD3);
            calc.setNota4(NotaBD4);
            double TotalMediaParcBD = calc.calcMediaParc();
            LBL_MediaParcBD.Text = TotalMediaParcBD.ToString();
            calc.setTotalMedParc1(TotalMediaParcBD);
            double NotaC1 = Convert.ToDouble(TXT_NotaC1.Text);
            double NotaC2 = Convert.ToDouble(TXT_NotaC2.Text);
            double NotaC3 = Convert.ToDouble(TXT_NotaC3.Text);
            double NotaC4 = Convert.ToDouble(TXT_NotaC4.Text);
            calc.setNota1(NotaC1);
            calc.setNota2(NotaC2);
            calc.setNota3(NotaC3);
            calc.setNota4(NotaC4);
            double TotalMediaParcC = calc.calcMediaParc();
            LBL_MediaParcC.Text = TotalMediaParcC.ToString();
            calc.setTotalMedParc2(TotalMediaParcC);
            double NotaSE1 = Convert.ToDouble(TXT_NotaSE1.Text);
            double NotaSE2 = Convert.ToDouble(TXT_NotaSE2.Text);
            double NotaSE3 = Convert.ToDouble(TXT_NotaSE3.Text);
            double NotaSE4 = Convert.ToDouble(TXT_NotaSE4.Text);
            calc.setNota1(NotaSE1);
            calc.setNota2(NotaSE2);
            calc.setNota3(NotaSE3);
            calc.setNota4(NotaSE4);
            double TotalMediaParcSE = calc.calcMediaParc();
            LBL_MediaParcSE.Text = TotalMediaParcSE.ToString();
            calc.setTotalMedParc3(TotalMediaParcSE);

            calc.setTotalAula(TotalAulaBD);
            calc.setTotalFalta(TotalFaltaBD);
            double FreqTotalBD = calc.calcFreqTot();
            LBL_FreqTotalBD.Text = FreqTotalBD.ToString() + "%";
            calc.setFreqMed1(FreqTotalBD);
            calc.setTotalAula(TotalAulaC);
            calc.setTotalFalta(TotalFaltaC);
            double FreqTotalC = calc.calcFreqTot();
            LBL_FreqTotalC.Text = FreqTotalC.ToString() + "%";
            calc.setFreqMed2(FreqTotalC);
            calc.setTotalAula(TotalAulaSE);
            calc.setTotalFalta(TotalFaltaSE);
            double FreqTotalSE = calc.calcFreqTot();
            LBL_FreqTotalSE.Text = FreqTotalSE.ToString() + "%";
            calc.setFreqMed3(FreqTotalSE);


        }

        private void BTN_Fechamento_Click(object sender, EventArgs e)
        {
            string nome = TXT_NomeAluno.Text;
            double TotalMedFim = calc.calcMedFim();
            LBL_MediaFinal.Text = TotalMedFim.ToString();
            double FreqFim = calc.calcFrecFim();
            LBL_FreqFinal.Text = FreqFim.ToString() + "%";
            calc.setFreqFim(FreqFim);
            calc.setTotalMedFim(TotalMedFim);
            if (TotalMedFim < 5)
            {
                if (FreqFim >= 75)
                {
                    LBL_SituacaoAluno.Text = nome + " Foi Reprovado por Nota";

                }
                else
                {
                    LBL_SituacaoAluno.Text = nome + " Foi Reprovado por Nota e Frequencia";


                }


            }
            else if (TotalMedFim >= 5 && TotalMedFim <= 7)
            {
                if (FreqFim < 75)
                {
                    LBL_SituacaoAluno.Text = nome + " Foi Reprovado por Frequencia";

                }
                else
                {
                    LBL_SituacaoAluno.Text = nome + " Devera Ficar de Recuperação";

                }

            }
            else if (TotalMedFim > 7)
            {
                if (FreqFim < 75)
                {
                    LBL_SituacaoAluno.Text = nome + " Foi Reprovado por Frequencia";

                }
                else
                {
                    LBL_SituacaoAluno.Text = nome + " Foi Aprovado";

                }

            }
        }
    }
}