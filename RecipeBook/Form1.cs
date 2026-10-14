using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBook
{
    public partial class frmRecipeBook : Form
    {
        List<Recipe> recipes = new List<Recipe>();  //creating a list of recipes that will be used to store the recipes that are added to the recipe book
        public frmRecipeBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblMinutes_Click(object sender, EventArgs e)
        {

        }

        private void lblIngrdts_Click(object sender, EventArgs e)
        {

        }


        private void lblSlctRcp_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRecipe_Click(object sender, EventArgs e) //creates a new recipe object and adds it to the list of recipes when the "Add Recipe" button is clicked
        {
            if (txtbxRecipe.Text == "") //if no recipe name is entered, a message box will pop up asking the user to enter a recipe name
            {
                MessageBox.Show("Enter a recipe name.");
                return;
            }

            int prepTime;//if the prep time is not a valid integer, a message box will pop up asking the user to enter a valid prep time
            if (!int.TryParse(txtbxPrpTme.Text, out prepTime))
            {
                MessageBox.Show("Enter a valid preparation time in minutes.");
                return;
            }

            RecipeCategory category = (RecipeCategory)Enum.Parse(typeof(RecipeCategory), cmbCategory.Text); // parses the selected category from the combo box and sets it to the category variable

            Recipe recipe = new Recipe(txtbxRecipe.Text, category, prepTime, txtbxIngredients.Text, txtbxDirections.Text); //creates a new recipe object with the values entered in the text boxes and combo box
            recipes.Add(recipe);
            lstbxRecipes.Items.Add(recipe.Name);
            MessageBox.Show("Recipe added successfully!");
        }

        private void lstbxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxRecipes.SelectedIndex >= 0) //if a recipe is selected from the list box, the details of the recipe will be displayed in the text boxes and combo box
            {
                Recipe selectedRecipe = recipes[lstbxRecipes.SelectedIndex];
                txtbxRecipe.Text = selectedRecipe.Name;
                cmbCategory.Text = selectedRecipe.Category.ToString();
                txtbxPrpTme.Text = selectedRecipe.PrepTime.ToString();
                txtbxIngredients.Text = selectedRecipe.Ingredients;
                txtbxDirections.Text = selectedRecipe.Instructions;
            }
        }

        private void btnRmvRecipe_Click(object sender, EventArgs e)
        {
            int index = lstbxRecipes.SelectedIndex; //removes the selected recipe from the list of recipes and the list box when the "Remove Recipe" button is clicked
            if (index >= 0)
            {
                recipes.RemoveAt(index);
                lstbxRecipes.Items.RemoveAt(index);

                txtbxRecipe.Clear();
                cmbCategory.SelectedIndex = -1;
                txtbxPrpTme.Clear();
                txtbxIngredients.Clear();
                txtbxDirections.Clear();
                MessageBox.Show("Recipe removed successfully!");

            }
            else
            {
                MessageBox.Show("Select a recipe to remove.");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxRecipe.Clear();
            cmbCategory.SelectedIndex = -1;
            txtbxPrpTme.Clear();
            txtbxIngredients.Clear();
            txtbxDirections.Clear();
            lstbxRecipes.ClearSelected(); //clears the text boxes, combo box, and list box when the "Clear" button is clicked
        }
    }
}
