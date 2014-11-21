namespace ChompoDex
{
    partial class RecipeBookForm
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
            this.components = new System.ComponentModel.Container();
            this.recipeBookListBox = new System.Windows.Forms.ListBox();
            this.yourRecipesLabel = new System.Windows.Forms.Label();
            this.recipeBookAddButton = new System.Windows.Forms.Button();
            this.recipeBookEditButton = new System.Windows.Forms.Button();
            this.recipeBookDeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeSearchNameText = new System.Windows.Forms.TextBox();
            this.recipeNameSearchButton = new System.Windows.Forms.Button();
            this.recipeIngredientSearchTextBox = new System.Windows.Forms.TextBox();
            this.ingredientSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.recipeSearchResultsListBox = new System.Windows.Forms.ListBox();
            this.catalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecipeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRecipeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecipeBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecipeDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRecipeDialog = new System.Windows.Forms.SaveFileDialog();
            this.sortAscendButton = new System.Windows.Forms.Button();
            this.sortDescendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipeBookListBox
            // 
            this.recipeBookListBox.FormattingEnabled = true;
            this.recipeBookListBox.Location = new System.Drawing.Point(85, 70);
            this.recipeBookListBox.Name = "recipeBookListBox";
            this.recipeBookListBox.Size = new System.Drawing.Size(316, 225);
            this.recipeBookListBox.TabIndex = 0;
            this.recipeBookListBox.SelectedIndexChanged += new System.EventHandler(this.recipeBookListBox_SelectedIndexChanged);
            // 
            // yourRecipesLabel
            // 
            this.yourRecipesLabel.AutoSize = true;
            this.yourRecipesLabel.Location = new System.Drawing.Point(82, 54);
            this.yourRecipesLabel.Name = "yourRecipesLabel";
            this.yourRecipesLabel.Size = new System.Drawing.Size(74, 13);
            this.yourRecipesLabel.TabIndex = 1;
            this.yourRecipesLabel.Text = "Your Recipes:";
            // 
            // recipeBookAddButton
            // 
            this.recipeBookAddButton.Location = new System.Drawing.Point(408, 70);
            this.recipeBookAddButton.Name = "recipeBookAddButton";
            this.recipeBookAddButton.Size = new System.Drawing.Size(75, 23);
            this.recipeBookAddButton.TabIndex = 2;
            this.recipeBookAddButton.Text = "Add";
            this.recipeBookAddButton.UseVisualStyleBackColor = true;
            this.recipeBookAddButton.Click += new System.EventHandler(this.RecipeBookAddButton_Click);
            // 
            // recipeBookEditButton
            // 
            this.recipeBookEditButton.Location = new System.Drawing.Point(408, 100);
            this.recipeBookEditButton.Name = "recipeBookEditButton";
            this.recipeBookEditButton.Size = new System.Drawing.Size(75, 23);
            this.recipeBookEditButton.TabIndex = 3;
            this.recipeBookEditButton.Text = "Edit";
            this.recipeBookEditButton.UseVisualStyleBackColor = true;
            this.recipeBookEditButton.Click += new System.EventHandler(this.RecipeBookEditButton_Click);
            // 
            // recipeBookDeleteButton
            // 
            this.recipeBookDeleteButton.Location = new System.Drawing.Point(408, 130);
            this.recipeBookDeleteButton.Name = "recipeBookDeleteButton";
            this.recipeBookDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.recipeBookDeleteButton.TabIndex = 4;
            this.recipeBookDeleteButton.Text = "Delete";
            this.recipeBookDeleteButton.UseVisualStyleBackColor = true;
            this.recipeBookDeleteButton.Click += new System.EventHandler(this.RecipeBookDeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Your Recipes:";
            // 
            // recipeSearchNameText
            // 
            this.recipeSearchNameText.Location = new System.Drawing.Point(85, 345);
            this.recipeSearchNameText.Name = "recipeSearchNameText";
            this.recipeSearchNameText.Size = new System.Drawing.Size(100, 20);
            this.recipeSearchNameText.TabIndex = 6;
            // 
            // recipeNameSearchButton
            // 
            this.recipeNameSearchButton.Location = new System.Drawing.Point(191, 342);
            this.recipeNameSearchButton.Name = "recipeNameSearchButton";
            this.recipeNameSearchButton.Size = new System.Drawing.Size(75, 23);
            this.recipeNameSearchButton.TabIndex = 7;
            this.recipeNameSearchButton.Text = "By Name";
            this.recipeNameSearchButton.UseVisualStyleBackColor = true;
            this.recipeNameSearchButton.Click += new System.EventHandler(this.recipeNameSearchButton_Click);
            // 
            // recipeIngredientSearchTextBox
            // 
            this.recipeIngredientSearchTextBox.Location = new System.Drawing.Point(85, 372);
            this.recipeIngredientSearchTextBox.Name = "recipeIngredientSearchTextBox";
            this.recipeIngredientSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.recipeIngredientSearchTextBox.TabIndex = 8;
            // 
            // ingredientSearchButton
            // 
            this.ingredientSearchButton.Location = new System.Drawing.Point(191, 369);
            this.ingredientSearchButton.Name = "ingredientSearchButton";
            this.ingredientSearchButton.Size = new System.Drawing.Size(91, 23);
            this.ingredientSearchButton.TabIndex = 9;
            this.ingredientSearchButton.Text = "By Ingredient";
            this.ingredientSearchButton.UseVisualStyleBackColor = true;
            this.ingredientSearchButton.Click += new System.EventHandler(this.ingredientSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Results:";
            // 
            // recipeSearchResultsListBox
            // 
            this.recipeSearchResultsListBox.FormattingEnabled = true;
            this.recipeSearchResultsListBox.Location = new System.Drawing.Point(88, 428);
            this.recipeSearchResultsListBox.Name = "recipeSearchResultsListBox";
            this.recipeSearchResultsListBox.Size = new System.Drawing.Size(313, 69);
            this.recipeSearchResultsListBox.TabIndex = 11;
            this.recipeSearchResultsListBox.SelectedIndexChanged += new System.EventHandler(this.recipeSearchResultsListBox_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecipeBookToolStripMenuItem,
            this.saveRecipeBookToolStripMenuItem,
            this.loadRecipeBookToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newRecipeBookToolStripMenuItem
            // 
            this.newRecipeBookToolStripMenuItem.Name = "newRecipeBookToolStripMenuItem";
            this.newRecipeBookToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newRecipeBookToolStripMenuItem.Text = "New Recipe Book";
            this.newRecipeBookToolStripMenuItem.Click += new System.EventHandler(this.newRecipeBookToolStripMenuItem_Click);
            // 
            // saveRecipeBookToolStripMenuItem
            // 
            this.saveRecipeBookToolStripMenuItem.Name = "saveRecipeBookToolStripMenuItem";
            this.saveRecipeBookToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveRecipeBookToolStripMenuItem.Text = "Save Recipe Book";
            this.saveRecipeBookToolStripMenuItem.Click += new System.EventHandler(this.saveRecipeBookToolStripMenuItem_Click);
            // 
            // loadRecipeBookToolStripMenuItem1
            // 
            this.loadRecipeBookToolStripMenuItem1.Name = "loadRecipeBookToolStripMenuItem1";
            this.loadRecipeBookToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.loadRecipeBookToolStripMenuItem1.Text = "Load Recipe Book";
            this.loadRecipeBookToolStripMenuItem1.Click += new System.EventHandler(this.loadRecipeBookToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadRecipeDialog
            // 
            this.loadRecipeDialog.DefaultExt = "txt";
            this.loadRecipeDialog.FileName = "MyRecipeBook.txt";
            this.loadRecipeDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveRecipeDialog
            // 
            this.saveRecipeDialog.DefaultExt = "txt";
            this.saveRecipeDialog.FileName = "MyRecipeBook.txt";
            this.saveRecipeDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // sortAscendButton
            // 
            this.sortAscendButton.Location = new System.Drawing.Point(4, 70);
            this.sortAscendButton.Name = "sortAscendButton";
            this.sortAscendButton.Size = new System.Drawing.Size(75, 23);
            this.sortAscendButton.TabIndex = 13;
            this.sortAscendButton.Text = "Sort A-Z";
            this.sortAscendButton.UseVisualStyleBackColor = true;
            this.sortAscendButton.Click += new System.EventHandler(this.sortAscendButton_Click);
            // 
            // sortDescendButton
            // 
            this.sortDescendButton.Location = new System.Drawing.Point(4, 99);
            this.sortDescendButton.Name = "sortDescendButton";
            this.sortDescendButton.Size = new System.Drawing.Size(75, 23);
            this.sortDescendButton.TabIndex = 14;
            this.sortDescendButton.Text = "Sort Z-A";
            this.sortDescendButton.UseVisualStyleBackColor = true;
            this.sortDescendButton.Click += new System.EventHandler(this.sortDescendButton_Click);
            // 
            // RecipeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 585);
            this.Controls.Add(this.sortDescendButton);
            this.Controls.Add(this.sortAscendButton);
            this.Controls.Add(this.recipeSearchResultsListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingredientSearchButton);
            this.Controls.Add(this.recipeIngredientSearchTextBox);
            this.Controls.Add(this.recipeNameSearchButton);
            this.Controls.Add(this.recipeSearchNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeBookDeleteButton);
            this.Controls.Add(this.recipeBookEditButton);
            this.Controls.Add(this.recipeBookAddButton);
            this.Controls.Add(this.yourRecipesLabel);
            this.Controls.Add(this.recipeBookListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RecipeBookForm";
            this.Text = "RecipeBookForm";
            this.Load += new System.EventHandler(this.RecipeBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catalogBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox recipeBookListBox;
        private System.Windows.Forms.Label yourRecipesLabel;
        private System.Windows.Forms.Button recipeBookAddButton;
        private System.Windows.Forms.Button recipeBookEditButton;
        private System.Windows.Forms.Button recipeBookDeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeSearchNameText;
        private System.Windows.Forms.Button recipeNameSearchButton;
        private System.Windows.Forms.TextBox recipeIngredientSearchTextBox;
        private System.Windows.Forms.Button ingredientSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox recipeSearchResultsListBox;
        private System.Windows.Forms.BindingSource catalogBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRecipeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRecipeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecipeBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog loadRecipeDialog;
        private System.Windows.Forms.SaveFileDialog saveRecipeDialog;
        private System.Windows.Forms.Button sortAscendButton;
        private System.Windows.Forms.Button sortDescendButton;
    }
}