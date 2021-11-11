using System;
using System.Collections.Generic;
using System.Text;

namespace Practic5
{
    class Pair
    {
        
        public Pair()
        {
            First = 0;
            Second = 0;

        }
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        public int First { get; set; }
        public int Second { get; set; }
        public void Sum(Pair firstPair, Pair anotherPair)
        {
            new Pair(firstPair.First + anotherPair.First, firstPair.Second + anotherPair.Second);
        }
        public void Sum(Pair firstPair, Pair secondPair, Pair thirdPair)
        {
            new Pair(firstPair.First + secondPair.First + thirdPair.First, firstPair.Second + secondPair.Second + thirdPair.Second);
        }
        public Pair Add()
        {
            
            return  new Pair(First+1, Second+1);
        }
        public Pair Add(int number)
        {
            Pair pair = new Pair();
            pair.First += number;
            pair.Second += number;
            return pair;
        }
        //Sum(pair, pair1);
        //pair.sum(anotherPair)
    }
}
