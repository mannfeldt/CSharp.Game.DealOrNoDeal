using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNODeal
{
    class GameEngine
    {

        Stack<Case> stack = new Stack<Case>();

    public Stack<Case> CreateCases(){

            stack.Push(new Case(1, true));
            stack.Push(new Case(5, true));
            stack.Push(new Case(10, true));
            stack.Push(new Case(20, true));
            stack.Push(new Case(50, true));
            stack.Push(new Case(100, true));
            stack.Push(new Case(200, true));
            stack.Push(new Case(500, true));
            stack.Push(new Case(1000, true));
            stack.Push(new Case(2500, true));
            stack.Push(new Case(5000, true));
            stack.Push(new Case(10000, true));
            stack.Push(new Case(25000, true));
            stack.Push(new Case(50000, true));
            stack.Push(new Case(100000, true));
            stack.Push(new Case(200000, true));
            stack.Push(new Case(300000, true));
            stack.Push(new Case(500000, true));
            stack.Push(new Case(750000, true));
            stack.Push(new Case(1000000, true));
            stack.Push(new Case(2500000, true));
            stack.Push(new Case(5000000, true));
            stack.Push(new Case(7500000, true));
            stack.Push(new Case(10000000, true));
            return (stack);

           
       


    }
    public Stack<Case> ShuffleCases(Stack<Case> list)
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        Case[] deck = list.ToArray();

        for (int n = deck.Length - 1; n > 0; --n)
        {
            int k = rnd.Next(n + 1);
            Case temp = deck[n];
            deck[n] = deck[k];
            deck[k] = temp;
        }
        list.Clear();
        list = new Stack<Case>(deck);

        return (list);


    }
        public int BankBid(Stack<Case> c, int opened)
    {
            int bid=0;
            int sum=0;
            foreach (Case d in c)
            {
                sum += d.Value;
            }

         
                bid = sum / c.Count;
                if (opened == 5)
                {
                    return bid-sum/22;
                }
                if (opened == 8)
                {
                    return bid - sum / 26;
                }
                if (opened == 11)
                {
                    return bid - sum / 34;
                }
                if (opened == 14)
                {
                    return bid - sum / 43;
                }
                if (opened == 16)
                {
                    return bid - sum / 58;
                }
                if (opened == 18)
                {
                    return bid - sum / 80;
                }
                if (opened == 20)
                {
                    return bid;

                }
                if (opened == 21)
                {
                    return bid + sum /28;
                }
                if (opened == 22)
                {
                    return bid + sum / 17;
                }
            
                else
                {
                    return 0;
                }
           
    }
        public Boolean Dealcheck(int nr)
        {
            int openedcases = nr;
            if (openedcases.Equals(5) || openedcases.Equals(8) || openedcases.Equals(11) || openedcases.Equals(14) || openedcases.Equals(16) || openedcases.Equals(18) || openedcases.Equals(20) || openedcases.Equals(21) || openedcases.Equals(22) || openedcases.Equals(23))
            {
                return true;
                
            }
            return false;
        }
        public int win(Case c)
        {


            return c.Value;
        }
      


}
}
