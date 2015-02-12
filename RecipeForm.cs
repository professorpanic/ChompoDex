using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChompoDex
    {
    public partial class RecipeForm : Form
        {
        Recipe newRecipe = new Recipe();
        RecipeBookForm catalogFormParentRef;
        int tempIndex;
        //true for when form is loaded to add a new recipe, false for when editing one
        public bool NewOrEditFlag { get; set; }

        //this method is to give a way to give this form a reference for sending data back to the RecipeBookForm.
        public void SetParent(RecipeBookForm parent)
            {
            catalogFormParentRef = parent;
            }

        public RecipeForm()
            {
            InitializeComponent();
            }

        private void MainForm_Load(object sender, EventArgs e)
            {
            //this is used to check if the form is being loaded because of the Edit or New Recipe buttons from RecipeBookForm.
            //If it's new, we'll blank out the newRecipe object and then use its ingredient list as the listbox's data source.
            //If it's not called, then the recipe will be loaded before this form's ShowDialog() is called.
            if (NewOrEditFlag)
                {
                newRecipe = new Recipe();
                recipeIngredientsListBox.DataSource = newRecipe.ingredientList;
                }
            }

        private void AddtoIngredientsButton_Click(object sender, EventArgs e)
            {
            //create new ingredient object, stick it into the list. Listbox will update automatically.
            newRecipe.ingredientList.Add(new Ingredient(amountBox.Text, unitBox.Text, itemBox.Text));
            }

        private void recipeSaveButton_Click(object sender, EventArgs e)
            {
            //inserts text in textboxes into newRecipe object before checking the NewOrEditFlag
            newRecipe.SetRecipe(recipeInstructionsRichTextBox.Text, recipeCookingTimeTextBox.Text, recipeNameTextBox.Text);

            //checking flag to see if this form was called to edit an old recipe or save a new one. 
            //Depending on bool, will call two different methods in the parent and then blank out the form to prevent any data sticking around
            if (NewOrEditFlag)
                {
                catalogFormParentRef.SaveRecipeToBook(newRecipe);
                this.Close();
                }

            else
                {
                catalogFormParentRef.SaveEditedRecipeToBook(newRecipe);
                this.Close();
                }
            catalogFormParentRef.Refresh();
            ClearAllFields();
            }

        //clears all fields as well as the ingredient ListBox
        public void ClearAllFields()
            {
            foreach (Control c in this.Controls)
                {
                if (c is TextBox || c is RichTextBox)
                    {
                    c.ResetText();
                    }
                }
            recipeIngredientsListBox.DataSource = null;
            newRecipe.ingredientList.Clear();
            recipeIngredientsListBox.DataSource = newRecipe.ingredientList;
            }

        private void removeIngredientButton_Click(object sender, EventArgs e)
            {
            try
                {
                //hold the currently selected index in a variable, unbind the datasource so that we can manipulate the List, then rebind it when done.
                int indexToRemove = tempIndex;
                recipeIngredientsListBox.DataSource = null;
                newRecipe.ingredientList.RemoveAt(indexToRemove);
                recipeIngredientsListBox.DataSource = newRecipe.ingredientList;
                }

            //in case a user gets click-happy with the remove ingredient button
            catch (ArgumentOutOfRangeException ex)
                {
                Debug.Print(ex.StackTrace);
                }
            }

        private void recipeClearButton_Click(object sender, EventArgs e)
            {
            ClearAllFields();
            }

        //this is is called by the RecipeBookForm normally, to preload a recipe before the ShowDialog method is called. Pulls all info out of a recipe and populates the text fields with it.
        public void LoadRecipe(Recipe recipeToEdit)
            {
            newRecipe = new Recipe();
            newRecipe.CopyRecipe(recipeToEdit);
            recipeIngredientsListBox.DataSource = newRecipe.ingredientList;
            recipeNameTextBox.Text = newRecipe.RecipeName;
            recipeCookingTimeTextBox.Text = newRecipe.GetRecipe().CookingTime;
            recipeInstructionsRichTextBox.Text = newRecipe.GetRecipe().RecipeProcedure;
            }

        //for storing the index of a recipe that's clicked on, to prevent any loss of place when bouncing between forms.
        private void recipeIngredientsListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
            tempIndex = recipeIngredientsListBox.SelectedIndex;
            }

        //a bare essentials method for sending a string to the printer, already formatted via method in Recipe specifically for doing this.
        private void PrintRecipeButton_Click(object sender, EventArgs e)
            {
            string output = newRecipe.RecipeForPrinterOutput(recipeNameTextBox.Text, recipeCookingTimeTextBox.Text, newRecipe, recipeInstructionsRichTextBox.Text);

            PrintDocument document = new PrintDocument();
            document.PrintPage += delegate(object sender1, PrintPageEventArgs args1)
            {
                args1.Graphics.DrawString(output,
                    new Font("Times New Roman", 14),
                    new SolidBrush(Color.Black),
                    new RectangleF(0, 0, document.DefaultPageSettings.PrintableArea.Width, document.DefaultPageSettings.PrintableArea.Height));
            };

            try
                {
                document.Print();
                }

            catch (Exception ex)
                {
                throw new Exception("Error Occured While Printing", ex);
                }
            }
        }
    }
