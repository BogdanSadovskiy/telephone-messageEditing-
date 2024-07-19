
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace telephone_messageWriting_
{
    public partial class Form1 : Form
    {
        StringUtils stringUtils = new StringUtils();
        bool possibleNewWord = false;
        public Form1()
        {
            InitializeComponent();
            this.predictedLabel1.Text = "";
            this.predictedLabel2.Text = "";
            this.predictedLabel3.Text = "";
            this.predictedLabel1.Click += PredictedLabel_Click;
            this.predictedLabel2.Click += PredictedLabel_Click;
            this.predictedLabel3.Click += PredictedLabel_Click;
            this.TScreen.TextChanged += TScreen_TextChanged;
     
            
        }

        private void PredictedLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (possibleNewWord)
            {
                stringUtils.AddNewWord(label.Text);
                possibleNewWord = false;
                return;
            }
            
            TScreen.Text = stringUtils.ReplaceLastWord(TScreen.Text, label.Text);  
            TScreen.SelectionStart = TScreen.Text.Length;
            TScreen.SelectionLength = 0;
            TScreen.Focus();
        }

        private void TScreen_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TScreen.Text))
            {
                string lastWord = stringUtils.GetLastWord(TScreen.Text);
                List<string> predictedWords = stringUtils.PredictWords(lastWord.ToLower());
                predictedWords = stringUtils.ChangeStringLetterIfInputLetterUppercased(lastWord, predictedWords);
                if (predictedWords == null || predictedWords.Count == 0)
                {
                    predictedLabel2.Visible = false;
                    predictedLabel3.Visible = false;
                    if (TScreen.Text.Trim().Length == 0)
                        predictedLabel1.Visible = false;
                    else
                    {
                        predictedLabel1.Text = lastWord;
                        possibleNewWord = true;
                    }
                    return;
                }
                SetPredictedWordsToLabels(predictedWords);
                possibleNewWord = false;
            }
        }

        private void SetPredictedWordsToLabels(List<string> predictedWords)
        {
            if(predictedWords.Count == 1)
            {
                predictedLabel2.Visible = false;
                predictedLabel3.Visible = false;
                predictedLabel1.Visible = true;
                predictedLabel1.Text = predictedWords[0];
            }
            else if (predictedWords.Count == 2)
            {
                predictedLabel2.Visible = true;
                predictedLabel3.Visible = false;
                predictedLabel1.Visible = true;
                predictedLabel1.Text = predictedWords[0];
                predictedLabel2.Text = predictedWords[1];
            }
            else if (predictedWords.Count == 3)
            {
                predictedLabel2.Visible = true;
                predictedLabel3.Visible = true;
                predictedLabel1.Visible = true;
                predictedLabel1.Text = predictedWords[0];
                predictedLabel2.Text = predictedWords[1];
                predictedLabel3.Text = predictedWords[2];
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
      
        }

        private void predictedLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

