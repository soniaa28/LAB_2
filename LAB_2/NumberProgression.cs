using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
     public class NumberProgression
    {
        private double m1;// початковий член
        private double increment;
        protected static int n =10 ;

        public NumberProgression()
        {
            m1=1 ;
            increment = 1;
            
          
        }
        public NumberProgression(double _m1 , double i = 1)
        {
            m1 = _m1;
            increment = i; 
           
        }

        //property 
        public double FirstMember
        {
            get
            {
                return m1;
            }
            set
            {
                m1 = value;
            }
        }

        public static void setN(int value)
        {
            n = value;
        }
        public override string ToString()

        {
            string progression = "";
            for (int i = 0; i < n; i++)
            {
                progression += string.Format("{0} ", this.getN(i));
            }
            return progression;
        }

        public double getN(int _n )
        {
           if (_n == 0) { return m1; }
           else
            {
                return m1 + _n; //оскільки для базового класу використовуємо інкремент 1, для арифметичної і геометричної прогресії перевизначу 
            }
        }

        public double getSumOfN(int _n )
        {
            double sum = 0;
            for (int i = 0; i < _n; i++)
            {
                sum += this.getN(i);
            }
            return sum;
        }
        public double getSumOfAll()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += this.getN(i);
            }
            return sum;
        }
        public string getProgression()
        {
            string progression = "";
            for (int i = 0; i < n; i++)
            {
                progression += string.Format("{0} ", this.getN(i));
            }
            return progression;
        }
        public static bool operator <(NumberProgression left, NumberProgression right)
        {
            return left.getSumOfAll() < right.getSumOfAll();
        }

        public static bool operator >(NumberProgression left, NumberProgression right)
        {
            return left.getSumOfAll() > right.getSumOfAll();
        }

        public static NumberProgression operator +(NumberProgression left, NumberProgression right)
        {
            double newFirstMember = left.m1 + right.m1;
            double newIncrement = 1;//напркилад згодом для арифметичної можна зробити так : left.increment + right.increment , а для геометричної множити 
            return new NumberProgression(newFirstMember, newIncrement);
        }
    }

    }

