using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DealOrNODeal
{
    public partial class Form1 : Form
    {
        GameEngine ge = new GameEngine();
        Stack<Case> cases = new Stack<Case>();
        Stack<Case> cases2 = new Stack<Case>();
        Stack<Case> cases3 = new Stack<Case>();
        Case winningcase;
        int openedcases = 0;
        int bid;
        int winnings;
       
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            DealButton.Enabled = false;
            NoDealButton.Enabled = false;
         
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        private void StartButton_Click(object sender, EventArgs e)
        {
            BankBidLabel.ResetText(); 

            WinLabel.ResetText();
            LogLabel.ResetText();
            CaseList.Items.Clear();
            ValueLabel.ResetText();
            
            LogLabel.Text = "Välj bort väskor";
            
           cases= ge.CreateCases();
          

            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                    

                }
               

            }
            cases3 =new Stack<Case>(new Stack<Case>(cases));
            cases2 = ge.ShuffleCases(cases3);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            StartButton.Enabled = false;

            

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button2.Enabled = false;
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button1.Enabled = false;



            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }

                button3.Enabled = false;
            }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }

                button4.Enabled = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }

                button5.Enabled = false;
            }
       

        private void NoDealButton_Click(object sender, EventArgs e)
        {
           
            BankBidLabel.Text = "No Deal!";
            DealButton.Enabled = false;
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            winner(bid);
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button8.Enabled = false;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button9.Enabled = false;          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button10.Enabled = false;
            }
        
        private void button11_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button11.Enabled = false;
            }
        

        private void button12_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button12.Enabled = false;
            }
        

        private void button13_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button13.Enabled = false;
            }
        

        private void button14_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button14.Enabled = false;
            }
        

        private void button15_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button15.Enabled = false;
            }
        

        private void button16_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button16.Enabled = false;
            }
        

        private void button17_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button17.Enabled = false;
            }
        
        private void button18_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button18.Enabled = false;
            }
        

        private void button19_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button19.Enabled = false;
            }
        
        private void button20_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button20.Enabled = false;
            }
        
        private void button21_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button21.Enabled = false;
            }
        

        private void button22_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button22.Enabled = false;
            }
        

        private void button23_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button23.Enabled = false;
            }
        
        private void button24_Click(object sender, EventArgs e)
        {
            Case vald = cases2.Pop();
            ValueLabel.Text = vald.ToString();
            vald.Status = false;
            CaseList.Items.Clear();
            foreach (Case c in cases)
            {
                if (c.Status == true)
                {
                    CaseList.Items.Add(c);
                }
            }
            //fix combobox to sort by int
            openedcases += 1; 
            if (openedcases == 5 || openedcases == 8 || openedcases == 11 || openedcases == 14 || openedcases == 16 || openedcases == 18 || openedcases == 20 || openedcases == 21 || openedcases == 22)
            {
                bid = ge.BankBid(cases2, openedcases);
                string d = bid.ToString();
                BankBidLabel.Text = d;
                DealButton.Enabled = true;
                NoDealButton.Enabled = true;
            }

           else if (openedcases == 23)
                {
                    winner(ge.win(cases2.Pop()));
                }
            else
            {
                DealButton.Enabled = false;
                NoDealButton.Enabled = false;
            }
                button24.Enabled = false;
            }
        
        
        public void winner(int nr)
        {
            winnings = nr;
            if (winnings < 1000)
            {
                WinLabel.Text = "Du vann " + String.Format("{0:###}", winnings) + " kr";


            }
            else if (winnings < 1000000)
            {
                WinLabel.Text = "Du vann " + String.Format("{0:# ###}", winnings) + " kr";

            }
            else
            {
                WinLabel.Text = "Du vann " + String.Format("{00:# ### ###}", winnings) + " kr";
            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            DealButton.Enabled = false;
            NoDealButton.Enabled = false;
            CaseList.Items.Clear();
            bid = 0;
            openedcases = 0;
            winnings = 0;
            cases.Clear();
            cases2.Clear();
            cases3.Clear();
            StartButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    
    
    }
}
