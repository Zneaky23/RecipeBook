using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace RecipeBook
{
    public partial class frmRecipeBook : Form
    {
        List<Recipe> recipes = new List<Recipe>();  //creating a list of recipes that will be used to store the recipes that are added to the recipe book

        string fileName = "recipes.txt"; //txt file will be used to store the recipes that are added to the recipe book. The file will be created in the same directory as the executable file.

        public frmRecipeBook()
        {
            InitializeComponent();
            LoadRecipesFromFile(); //loads the recipes from the txt file when the application is opened
        }

        private void SaveRecipesToFile() //saves the recipes to the txt file when the application is closed
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Recipe recipe in recipes)
                {
                    writer.WriteLine(recipe.Name);
                    writer.WriteLine(recipe.Category);
                    writer.WriteLine(recipe.PrepTime);
                    writer.WriteLine(recipe.Ingredients);
                    writer.WriteLine(recipe.Instructions);
                    writer.WriteLine("---"); //blank line to separate recipes
                }
            }
        }

        private void LoadRecipesFromFile() //loads the recipes from the txt file when the application is opened
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                for (int i = 0; i < lines.Length; i += 6) //each recipe is separated by a blank line, so the loop increments by 6 to get to the next recipe
                {
                    string name = lines[i];
                    RecipeCategory category = (RecipeCategory)Enum.Parse(typeof(RecipeCategory), lines[i + 1]);
                    int prepTime = int.Parse(lines[i + 2]);
                    string ingredients = lines[i + 3];
                    string instructions = lines[i + 4];

                    Recipe recipe = new Recipe(name, category, prepTime, ingredients, instructions);

                    recipes.Add(recipe);
                    lstbxRecipes.Items.Add(recipe.Name); //adds the recipe name to the list box
                }
            }
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
            SaveRecipesToFile(); //saves the recipes to the txt file when a new recipe is added
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

        private void btnPckRecipe_Click(object sender, EventArgs e)
        {
            if (recipes.Count > 0) //selects a random recipe from the list of recipes and displays the details of the recipe in the text boxes and combo box when the "Pick Recipe" button is clicked
            {
                Random random = new Random();
                int index = random.Next(recipes.Count);
                lstbxRecipes.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("No recipes available to pick.");
            }
        }
    }
}
