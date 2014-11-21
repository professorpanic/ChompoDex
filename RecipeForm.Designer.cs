namespace ChompoDex
{
    partial class RecipeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.recipeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeCookingTimeTextBox = new System.Windows.Forms.TextBox();
            this.recipeIngredientsListBox = new System.Windows.Forms.ListBox();
            this.recipeSaveButton = new System.Windows.Forms.Button();
            this.recipeClearButton = new System.Windows.Forms.Button();
            this.recipeInstructionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.addtoIngredientsButton = new System.Windows.Forms.Button();
            this.PrintRecipeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name:";
            // 
            // recipeNameTextBox
            // 
            this.recipeNameTextBox.Location = new System.Drawing.Point(136, 73);
            this.recipeNameTextBox.Name = "recipeNameTextBox";
            this.recipeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.recipeNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cooking Time:";
            // 
            // recipeCookingTimeTextBox
            // 
            this.recipeCookingTimeTextBox.Location = new System.Drawing.Point(368, 73);
            this.recipeCookingTimeTextBox.Name = "recipeCookingTimeTextBox";
            this.recipeCookingTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.recipeCookingTimeTextBox.TabIndex = 2;
            // 
            // recipeIngredientsListBox
            // 
            this.recipeIngredientsListBox.FormattingEnabled = true;
            this.recipeIngredientsListBox.Location = new System.Drawing.Point(136, 241);
            this.recipeIngredientsListBox.Name = "recipeIngredientsListBox";
            this.recipeIngredientsListBox.Size = new System.Drawing.Size(268, 82);
            this.recipeIngredientsListBox.TabIndex = 7;
            this.recipeIngredientsListBox.SelectedIndexChanged += new System.EventHandler(this.recipeIngredientsListBox_SelectedIndexChanged);
            // 
            // recipeSaveButton
            // 
            this.recipeSaveButton.Location = new System.Drawing.Point(136, 431);
            this.recipeSaveButton.Name = "recipeSaveButton";
            this.recipeSaveButton.Size = new System.Drawing.Size(75, 23);
            this.recipeSaveButton.TabIndex = 9;
            this.recipeSaveButton.Text = "Save";
            this.recipeSaveButton.UseVisualStyleBackColor = true;
            this.recipeSaveButton.Click += new System.EventHandler(this.recipeSaveButton_Click);
            // 
            // recipeClearButton
            // 
            this.recipeClearButton.Location = new System.Drawing.Point(329, 431);
            this.recipeClearButton.Name = "recipeClearButton";
            this.recipeClearButton.Size = new System.Drawing.Size(75, 23);
            this.recipeClearButton.TabIndex = 11;
            this.recipeClearButton.Text = "Clear All";
            this.recipeClearButton.UseVisualStyleBackColor = true;
            this.recipeClearButton.Click += new System.EventHandler(this.recipeClearButton_Click);
            // 
            // recipeInstructionsRichTextBox
            // 
            this.recipeInstructionsRichTextBox.Location = new System.Drawing.Point(136, 329);
            this.recipeInstructionsRichTextBox.Name = "recipeInstructionsRichTextBox";
            this.recipeInstructionsRichTextBox.Size = new System.Drawing.Size(268, 96);
            this.recipeInstructionsRichTextBox.TabIndex = 8;
            this.recipeInstructionsRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingredients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instructions:";
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.Location = new System.Drawing.Point(410, 241);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(75, 23);
            this.removeIngredientButton.TabIndex = 10;
            this.removeIngredientButton.Text = "Remove";
            this.removeIngredientButton.UseVisualStyleBackColor = true;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(136, 123);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(100, 20);
            this.amountBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unit of Measurement";
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(136, 149);
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(100, 20);
            this.unitBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item";
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(136, 175);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(100, 20);
            this.itemBox.TabIndex = 5;
            // 
            // addtoIngredientsButton
            // 
            this.addtoIngredientsButton.Location = new System.Drawing.Point(136, 202);
            this.addtoIngredientsButton.Name = "addtoIngredientsButton";
            this.addtoIngredientsButton.Size = new System.Drawing.Size(126, 23);
            this.addtoIngredientsButton.TabIndex = 6;
            this.addtoIngredientsButton.Text = "Add to Ingredients List";
            this.addtoIngredientsButton.UseVisualStyleBackColor = true;
            this.addtoIngredientsButton.Click += new System.EventHandler(this.AddtoIngredientsButton_Click);
            // 
            // PrintRecipeButton
            // 
            this.PrintRecipeButton.Location = new System.Drawing.Point(410, 332);
            this.PrintRecipeButton.Name = "PrintRecipeButton";
            this.PrintRecipeButton.Size = new System.Drawing.Size(75, 23);
            this.PrintRecipeButton.TabIndex = 19;
            this.PrintRecipeButton.Text = "Print Recipe";
            this.PrintRecipeButton.UseVisualStyleBackColor = true;
            this.PrintRecipeButton.Click += new System.EventHandler(this.PrintRecipeButton_Click);
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 471);
            this.Controls.Add(this.PrintRecipeButton);
            this.Controls.Add(this.addtoIngredientsButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.removeIngredientButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recipeInstructionsRichTextBox);
            this.Controls.Add(this.recipeClearButton);
            this.Controls.Add(this.recipeSaveButton);
            this.Controls.Add(this.recipeIngredientsListBox);
            this.Controls.Add(this.recipeCookingTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RecipeForm";
            this.Text = "Recipe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recipeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeCookingTimeTextBox;
        private System.Windows.Forms.ListBox recipeIngredientsListBox;
        private System.Windows.Forms.Button recipeSaveButton;
        private System.Windows.Forms.Button recipeClearButton;
        private System.Windows.Forms.RichTextBox recipeInstructionsRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Button addtoIngredientsButton;
        private System.Windows.Forms.Button PrintRecipeButton;
    }
}

