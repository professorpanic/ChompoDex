using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChompoDex
    {
    [Serializable]
    public class Recipe
        {
        //properties are simple strings, ingredientList will be a Binding List to make it easier to use as a Data Source for a Listbox
        public BindingList<Ingredient> ingredientList = new BindingList<Ingredient>();
        public string RecipeName { get; private set; }
        public string CookingTime { get; private set; }
        public string RecipeProcedure { get; private set; }



        public Recipe(string procedure, string time, string name)
            {
            RecipeName = name;
            RecipeProcedure = procedure;
            CookingTime = time;
            //keeping the list prepared to be manipulated
            ingredientList.AllowEdit = true;
            ingredientList.AllowNew = true;
            ingredientList.AllowRemove = true;
            ingredientList.RaiseListChangedEvents = true;

            }

        public Recipe()
            {
            //setting defaults ahead of time to prevent null issues
            RecipeProcedure = "";
            CookingTime = "0 minutes";
            RecipeName = "";
            ingredientList.AllowEdit = true;
            ingredientList.AllowNew = true;
            ingredientList.AllowRemove = true;
            ingredientList.RaiseListChangedEvents = true;
            }
        public Recipe GetRecipe()
            {
            return this;
            }
        
        public void SetRecipe(string procedure, string time, string name)
            {
            RecipeProcedure = procedure;
            RecipeName = name;
            CookingTime = time;
            }

        public void CopyRecipe(Recipe incomingRecipe)
            {
            //created this in order to copy a recipe back and forth between forms for when a recipe is edited and re-saved.
            RecipeProcedure = incomingRecipe.RecipeProcedure;
            CookingTime = incomingRecipe.CookingTime;
            RecipeName = incomingRecipe.RecipeName;
            this.ingredientList = new BindingList<Ingredient>(incomingRecipe.ingredientList.ToList());
            }

        //for making a printer-friendly string to send a single recipe to a printer of the user's choice.
        public string RecipeForPrinterOutput(string name, string time, Recipe recipe, string procedure)
            {
            StringBuilder output = new StringBuilder();
            output.Append(name + Environment.NewLine
                + "Cooking Time: " + time + Environment.NewLine
                + recipe.IngredientListStringOutput() + "Instructions: " + Environment.NewLine
                + procedure);
            return output.ToString();

            }
        //creating a stringbuilder so that the assembled string has the ingredients listed line by line
        public StringBuilder IngredientListStringOutput()
            {
            StringBuilder completeList = new StringBuilder();

            foreach (Ingredient ingredient in ingredientList)
                {
                completeList.Append(ingredient.ToString() + Environment.NewLine);
                }
            return completeList;
            }
        }
    }
