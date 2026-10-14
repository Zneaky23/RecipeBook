namespace RecipeBook
{
    partial class frmRecipeBook
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeBook));
            lblRecipeName = new Label();
            lblCategory = new Label();
            lblPrpTme = new Label();
            lblIngrdts = new Label();
            lblSvRcp = new Label();
            lblSlctRcp = new Label();
            txtbxRecipe = new TextBox();
            cmbCategory = new ComboBox();
            txtbxPrpTme = new TextBox();
            lblMinutes = new Label();
            txtbxIngredients = new TextBox();
            lblDirections = new Label();
            txtbxDirections = new TextBox();
            lstbxRecipes = new ListBox();
            btnAddRecipe = new Button();
            btnClear = new Button();
            btnRmvRecipe = new Button();
            btnPckRecipe = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(12, 46);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(68, 21);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe: ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblCategory.Location = new Point(12, 131);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 21);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category: ";
            // 
            // lblPrpTme
            // 
            lblPrpTme.AutoSize = true;
            lblPrpTme.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblPrpTme.Location = new Point(12, 224);
            lblPrpTme.Name = "lblPrpTme";
            lblPrpTme.Size = new Size(94, 21);
            lblPrpTme.TabIndex = 2;
            lblPrpTme.Text = "Prep Time: ";
            // 
            // lblIngrdts
            // 
            lblIngrdts.AutoSize = true;
            lblIngrdts.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblIngrdts.Location = new Point(12, 314);
            lblIngrdts.Name = "lblIngrdts";
            lblIngrdts.Size = new Size(102, 21);
            lblIngrdts.TabIndex = 4;
            lblIngrdts.Text = "Ingredients: ";
            // 
            // lblSvRcp
            // 
            lblSvRcp.AutoSize = true;
            lblSvRcp.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblSvRcp.Location = new Point(12, 857);
            lblSvRcp.Name = "lblSvRcp";
            lblSvRcp.Size = new Size(124, 21);
            lblSvRcp.TabIndex = 5;
            lblSvRcp.Text = "Saved Recipes: ";
            // 
            // lblSlctRcp
            // 
            lblSlctRcp.AutoSize = true;
            lblSlctRcp.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblSlctRcp.Location = new Point(12, 983);
            lblSlctRcp.Name = "lblSlctRcp";
            lblSlctRcp.Size = new Size(133, 21);
            lblSlctRcp.TabIndex = 6;
            lblSlctRcp.Text = "Selected Recipe: ";
            // 
            // txtbxRecipe
            // 
            txtbxRecipe.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxRecipe.Location = new Point(142, 45);
            txtbxRecipe.Name = "txtbxRecipe";
            txtbxRecipe.Size = new Size(100, 22);
            txtbxRecipe.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Breakfast", "Lunch", "Dinner", "Dessert" });
            cmbCategory.Location = new Point(142, 128);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 24);
            cmbCategory.TabIndex = 8;
            // 
            // txtbxPrpTme
            // 
            txtbxPrpTme.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPrpTme.Location = new Point(142, 223);
            txtbxPrpTme.Name = "txtbxPrpTme";
            txtbxPrpTme.Size = new Size(39, 22);
            txtbxPrpTme.TabIndex = 9;
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Location = new Point(190, 228);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(52, 17);
            lblMinutes.TabIndex = 10;
            lblMinutes.Text = "minutes";
            // 
            // txtbxIngredients
            // 
            txtbxIngredients.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxIngredients.Location = new Point(142, 305);
            txtbxIngredients.Multiline = true;
            txtbxIngredients.Name = "txtbxIngredients";
            txtbxIngredients.Size = new Size(408, 259);
            txtbxIngredients.TabIndex = 11;
            // 
            // lblDirections
            // 
            lblDirections.AutoSize = true;
            lblDirections.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            lblDirections.Location = new Point(12, 596);
            lblDirections.Name = "lblDirections";
            lblDirections.Size = new Size(93, 21);
            lblDirections.TabIndex = 12;
            lblDirections.Text = "Directions: ";
            // 
            // txtbxDirections
            // 
            txtbxDirections.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxDirections.Location = new Point(142, 596);
            txtbxDirections.Multiline = true;
            txtbxDirections.Name = "txtbxDirections";
            txtbxDirections.Size = new Size(408, 199);
            txtbxDirections.TabIndex = 13;
            // 
            // lstbxRecipes
            // 
            lstbxRecipes.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstbxRecipes.FormattingEnabled = true;
            lstbxRecipes.Location = new Point(142, 857);
            lstbxRecipes.Name = "lstbxRecipes";
            lstbxRecipes.Size = new Size(211, 84);
            lstbxRecipes.TabIndex = 14;
            lstbxRecipes.SelectedIndexChanged += lstbxRecipes_SelectedIndexChanged;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.BackColor = Color.White;
            btnAddRecipe.Location = new Point(117, 810);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(146, 23);
            btnAddRecipe.TabIndex = 15;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = false;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Location = new Point(440, 810);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 23);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRmvRecipe
            // 
            btnRmvRecipe.BackColor = Color.White;
            btnRmvRecipe.Location = new Point(277, 810);
            btnRmvRecipe.Name = "btnRmvRecipe";
            btnRmvRecipe.Size = new Size(146, 23);
            btnRmvRecipe.TabIndex = 17;
            btnRmvRecipe.Text = "Remove Recipe";
            btnRmvRecipe.UseVisualStyleBackColor = false;
            btnRmvRecipe.Click += btnRmvRecipe_Click;
            // 
            // btnPckRecipe
            // 
            btnPckRecipe.Location = new Point(180, 958);
            btnPckRecipe.Name = "btnPckRecipe";
            btnPckRecipe.Size = new Size(146, 23);
            btnPckRecipe.TabIndex = 18;
            btnPckRecipe.Text = "Pick Recipe";
            btnPckRecipe.UseVisualStyleBackColor = true;
            btnPckRecipe.Click += btnPckRecipe_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Bisque;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // frmRecipeBook
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 1083);
            Controls.Add(pictureBox1);
            Controls.Add(btnPckRecipe);
            Controls.Add(btnRmvRecipe);
            Controls.Add(btnClear);
            Controls.Add(btnAddRecipe);
            Controls.Add(lstbxRecipes);
            Controls.Add(txtbxDirections);
            Controls.Add(lblDirections);
            Controls.Add(txtbxIngredients);
            Controls.Add(lblMinutes);
            Controls.Add(txtbxPrpTme);
            Controls.Add(cmbCategory);
            Controls.Add(txtbxRecipe);
            Controls.Add(lblSlctRcp);
            Controls.Add(lblSvRcp);
            Controls.Add(lblIngrdts);
            Controls.Add(lblPrpTme);
            Controls.Add(lblCategory);
            Controls.Add(lblRecipeName);
            Font = new Font("Book Antiqua", 9F, FontStyle.Bold);
            Name = "frmRecipeBook";
            Text = "My Recipe Book";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipeName;
        private Label lblCategory;
        private Label lblPrpTme;
        private Label label4;
        private Label lblIngrdts;
        private Label lblSvRcp;
        private Label lblSlctRcp;
        private TextBox txtbxRecipe;
        private ComboBox cmbCategory;
        private TextBox txtbxPrpTme;
        private Label lblMinutes;
        private TextBox txtbxIngredients;
        private Label lblDirections;
        private TextBox txtbxDirections;
        private ListBox lstbxRecipes;
        private Button btnAddRecipe;
        private Button btnClear;
        private Button btnRmvRecipe;
        private Button btnPckRecipe;
        private PictureBox pictureBox1;
    }
}
