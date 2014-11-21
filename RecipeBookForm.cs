using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ChompoDex
{
    public partial class RecipeBookForm : Form
    {
        RecipeBook currentRecipeBook = new RecipeBook();
        RecipeForm recForm = new RecipeForm();
        Recipe tempRecipe;
        int recipeToEditIndex;
        

        //for overwriting a selected recipe. Normally called by the RecipeForm object.
        public void SaveEditedRecipeToBook(Recipe recipe)
        {
            int tempIndex = recipeToEditIndex;
            
            currentRecipeBook.recipeList.ElementAt(tempIndex).CopyRecipe(recipe);
            recipeBookListBox.DataSource = null;
            ResetRecipeDataSource();
            
        }

        //adding a new recipe. Also normally called by RecipeForm.
        public void SaveRecipeToBook(Recipe recipe)
        {
            tempRecipe = new Recipe();
            tempRecipe.CopyRecipe(recipe);
            currentRecipeBook.AddRecipe(tempRecipe);
            
        }
        
        public RecipeBookForm()
        {
            //always gives the RecipeForm that it will create a reference to it, for passing data back and forth.
            InitializeComponent();
            recForm.SetParent(this);
            
        }

        private void RecipeBookForm_Load(object sender, EventArgs e)
        {
            //resetting the listbox just in case something changed when the form is loaded.
            ResetRecipeDataSource();
        }

        private void RecipeBookAddButton_Click(object sender, EventArgs e)
        {
            recForm.NewOrEditFlag = true;
            recForm.ShowDialog();
            
        }

        //just uses the selected index property of the list box, stores it in a temp variable, then deletes it from the bindinglist after disconnecting it from the listbox, then reconnecting
        private void RecipeBookDeleteButton_Click(object sender, EventArgs e)
        {
            int tempIndex = recipeToEditIndex;
            recipeBookListBox.DataSource = null;
            currentRecipeBook.DeleteRecipe(tempIndex);
            ResetRecipeDataSource();
            
              
        }

        //flips the boolean value in the RecipeForm to tell it that a recipe is being edited and to populate the fields, then when done it'll send the new recipe back to the calling Form and overwrite a recipe rather than add
        private void RecipeBookEditButton_Click(object sender, EventArgs e)
        {
            int tempIndex = recipeToEditIndex;
            recForm.NewOrEditFlag = false;
            recForm.LoadRecipe(currentRecipeBook.recipeList.ElementAt(tempIndex));
            recForm.ShowDialog();
        }

        //just to keep a variable that stores what item's index value is being clicked on.
        private void recipeBookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            recipeToEditIndex = recipeBookListBox.SelectedIndex;
            
        }

        //populates a secondary listbox, BindingList gets attached, list contains references with recipes that contain a searched string that can be double-clicked and then edited.
        private void recipeNameSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Recipe> searchResults = new BindingList<Recipe>();
            recipeSearchResultsListBox.DisplayMember = "RecipeName";
            
            
            recipeSearchResultsListBox.DataSource = searchResults;

            foreach (Recipe recipe in currentRecipeBook.recipeList)
            {
                
            if (recipe.RecipeName.Contains(recipeSearchNameText.Text))
                {
                    searchResults.Add(recipe);
                    
                }
            }
         }

        //loads a recipe that is double-clicked in the search box.
        private void recipeSearchResultsListBox_MouseDoubleClick(object sender, EventArgs e)
        {
            recForm.NewOrEditFlag = false;
            recForm.LoadRecipe((Recipe)recipeSearchResultsListBox.SelectedItem);
            recForm.ShowDialog();
        }

        

        //same basic logic as the recipe name search, but with an extra foreach loop for checking the ingredients in each recipe.
        private void ingredientSearchButton_Click(object sender, EventArgs e)
        {
            BindingList<Recipe> searchResults = new BindingList<Recipe>();
            recipeSearchResultsListBox.DisplayMember = "RecipeName";


            recipeSearchResultsListBox.DataSource = searchResults;

            foreach (Recipe recipe in currentRecipeBook.recipeList)
            {
                foreach(Ingredient ingredient in recipe.ingredientList)
                if (ingredient.item.Contains(recipeIngredientSearchTextBox.Text))
                {
                    searchResults.Add(recipe);

                }
            }
        }

        //blanks out everything and starts from scratch with a new RecipeBook object and RecipeForm object, to clear references.
        private void newRecipeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recipeBookListBox.DataSource = null;
            recipeSearchResultsListBox.DataSource = null;
            currentRecipeBook = new RecipeBook();
            recForm = new RecipeForm();
        }

        //saves a serialized recipebook to a .txt file
        private void saveRecipeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveRecipeDialog.ShowDialog() == DialogResult.OK)
            {
                string name = saveRecipeDialog.FileName;
                using (Stream output = File.Create(name))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(output, currentRecipeBook);
                }
            }
        }

        //for loading a serialized RecipeBook file and displaying the recipes inside
        private void loadRecipeBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loadRecipeDialog.ShowDialog() == DialogResult.OK)
            {
                string name = loadRecipeDialog.FileName;
                this.Text = name;
                using (Stream input = File.OpenRead(name))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    currentRecipeBook = (RecipeBook)formatter.Deserialize(input);
                }
                ResetRecipeDataSource();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //both buttons do the same thing, just call different methods for the different sort orders. Always firsts disconnects the BindingList as the Listbox's data source, though.
        private void sortAscendButton_Click(object sender, EventArgs e)
        {
            recipeBookListBox.DataSource = null;
            currentRecipeBook.SortRecipesAscending();
            ResetRecipeDataSource();
        }

        private void sortDescendButton_Click(object sender, EventArgs e)
        {
            recipeBookListBox.DataSource = null;
            currentRecipeBook.SortRecipesDescending();
            
        }

        //quick method for freshing a listbox after its datasource has been changed.
        void ResetRecipeDataSource()
        {
            recipeBookListBox.DataSource = currentRecipeBook.recipeList;
            recipeBookListBox.DisplayMember = "RecipeName";
            Update();
        }
    }
}
