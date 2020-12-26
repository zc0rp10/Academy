using System;
using System.Collections.Generic;
using System.Linq;

namespace PreAssignmentNbrTwo
{
    class ShoppingList
    {
        private List<Ingredient> ingredients;
        public List<Ingredient> Ingredients
        {
            get
            {
                switch (ListOrder)
                {
                    case Order.Price:
                        {
                            ingredients = ingredients.OrderBy(i => i.Price).ToList(); break;
                        }
                    case Order.Name:
                        {
                            ingredients = ingredients.OrderBy(i => i.Name).ToList(); break;
                        }
                }
                return ingredients;
            }
            set { ingredients = value; }
            // Note: Learning point, wasted a lot of time here by not realizing that .OrderBy.ToList() returns a new IEnumerable/List and therefore
            //       has to be assigned again (ingredients = ing...), rather then mutating/resorting the original List directly.
        }

        public Order ListOrder;
        public enum Order
        {
            Price,
            Name
        }

        public ShoppingList()
        {
            Ingredients = new List<Ingredient>();
            // Note: Recieved an "Object reference not set to an instance of an object" when trying to use the
            // Add() method untill I realized I needed to instantiate the List in a constructor before I use it.
        }

        public void Add()
        {
            try
            {
                Console.Write("Enter new ingredient name: ");
                string ingredientName = Console.ReadLine();

                if (ingredientName.Length == 0)
                {
                    Console.WriteLine("> ERROR: The ingredient name needs to contain at least one character, please try again...");
                    Add();
                }

                Console.Write("Enter ingredient price: ");
                int price = int.Parse(Console.ReadLine());

                Ingredient ingredient = new Ingredient(ingredientName, price);
                Ingredients.Add(ingredient);
            }
            catch (FormatException)
            {
                Console.WriteLine("> ERROR: The entered price must be a number i.e \"12\", please try adding the ingredient again.");
                Add();
            }
            catch (Exception e)
            {
                Console.WriteLine("> ERROR: Oops, something went wrong...");
                Console.WriteLine("> ERROR: " + e.Message);
            }

            // Note: Point to discuss with teacher. What's the "best practice" way of imprementing adding, removing etc. to a class that's basicly
            // just a List like this one. By using the getters/setters from the property, or like I've done above with an Add() method. Also if using
            // an Add() method like this, does the logic on lines 22-25 belong here, or is that too single case specific and should have been
            // keept in a seperate AddIngredientToShoppinglist(Ingredient newIngredient) function in Program.cs that then interacted with the instance 
            // of the shoppingList objects getters and setters.
        }

        public void Remove()
        {
            // TODO: Add an escape or check to make sure shoppingList.Ingredients is not empty. Otherwise used can get stuck in an infinite
            //       loop with catch block calling Remove(), and they need to hard exit the app.
            try
            {
                Console.Write("Enter the Id of the ingredient you want to remove: ");
                int ingredientId = int.Parse(Console.ReadLine()) - 1;
                Ingredients.RemoveAt(ingredientId);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("> ERROR: You entered an Id that does not exist, please try again.");
                Remove();
            }
            catch (FormatException)
            {
                Console.WriteLine("> ERROR: The entered Id must be a number, please try again.");
                Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine("> ERROR: Oops, something went wrong...");
                Console.WriteLine("> ERROR: " + e.Message);
            }
        }

        public void Remove(int id)
        {
            Ingredients.RemoveAt(id);
        }

        public void Edit()
        {
            // TODO: If possible, refactor function to print out the current values for the user to then edit and confirm to console.
            try
            {
                Console.Write("Enter the Id of the ingredient you want to edit: ");
                int ingredientId = int.Parse(Console.ReadLine()) - 1;

                Remove(ingredientId);
                Add();

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("> ERROR: You entered an Id that does not exist, please try again.");
                Remove();
            }
            catch (FormatException)
            {
                Console.WriteLine("> ERROR: The entered Id must be a number, please try again.");
                Remove();
            }
            catch (Exception e)
            {
                Console.WriteLine("> ERROR: Oops, something went wrong...");
                Console.WriteLine("> ERROR: " + e.Message);
            }
        }
    }
}
