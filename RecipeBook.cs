using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace ChompoDex
{
    [Serializable]
    public class RecipeBook
    {
        public BindingList<Recipe> recipeList = new BindingList<Recipe>();
        

        public RecipeBook()
        {
            //configuring the BindingList to allow for manipulation
            recipeList.AllowEdit = true;
            recipeList.AllowNew = true;
            recipeList.AllowRemove = true;
            recipeList.RaiseListChangedEvents = true;
            
        }

        
        public void AddRecipe(Recipe recipe)
        {
            recipeList.Add(recipe);
            
        }
        
        public void DeleteRecipe(int itemToDelete)
        {
            recipeList.RemoveAt(itemToDelete);
        }

        //two methods for sorting recipes by name. They're BindingLists originally so I'm just taking the quick way of copying them into temporary list, sorting, then putting them back in.
        public void SortRecipesAscending()
        {
            List<Recipe> tempList = recipeList.OrderBy(a => a.RecipeName).ToList(); ;
            recipeList.Clear();
            foreach (Recipe recipe in tempList)
            {
                recipeList.Add(recipe);
            }

        }

        public void SortRecipesDescending()
        {
            List<Recipe> tempList = recipeList.OrderByDescending(d => d.RecipeName).ToList(); ;
            recipeList.Clear();
            foreach (Recipe recipe in tempList)
            {
                recipeList.Add(recipe);
            }
        }

        

    }
}
