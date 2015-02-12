using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChompoDex
    {
    [Serializable]
    public class Ingredient
        {
        //all are these of strings, since users have a lot of ways to enter in info. Kept them as seperate variables for later possibly putting into a db file.
        public string amount { get; private set; }
        public string unitOfMeasure { get; private set; }
        public string item { get; private set; }

        public Ingredient(string amt, string measure, string thing)
            {
            amount = amt;
            unitOfMeasure = measure;
            item = thing;
            }


        public override string ToString()
            {
            return amount + " " + unitOfMeasure + " " + item;
            }
        }
    }
