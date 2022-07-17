// Task
// Application uses a Dictionary<string, decimal> to keep track of the menu of items.  You can code it with literals
// Use a List<string> for the shopping list and store the name of the items the customer ordered.
// Application takes item name input and
// 1. Responds if that item doesn’t exist
// 2. Adds its name and price to the relevant List if it does
// Application asks user if they want to quit or continue, and loops appropriately
// Application displays list of items with their prices 
// Application displays the correct total predict for the list
// To determine the sum: Loop through the shopping list’s List collection, obtain the name, and look up the name’s price in the Menu Dictionary.
// Implement a menu system so the user can enter just a letter or number for the item.
// Display the most and least expensive item ordered.
// Display the items ordered in order of price

//Collections
Dictionary<string, decimal> goodsNPrice = new Dictionary<string, decimal>();
goodsNPrice.Add("Bannana", 0.77m);
goodsNPrice.Add("Cantelope", 1.99m);
goodsNPrice.Add("Ice cream", 2.50m);
goodsNPrice.Add("Bread", 1.09m);
goodsNPrice.Add("Cereal", 2.07m);
goodsNPrice.Add("Milk", 4.49m);
goodsNPrice.Add("Ground beef", 5.10m);
goodsNPrice.Add("Red grapes", 2.00m);
goodsNPrice.Add("Green grapes", 2.10m);

Dictionary<string, decimal> goodsNPriceMenu = new Dictionary<string, decimal>();
goodsNPriceMenu.Add("1", 0.77m);
goodsNPriceMenu.Add("2", 1.99m);
goodsNPriceMenu.Add("3", 2.50m);
goodsNPriceMenu.Add("4", 1.09m);
goodsNPriceMenu.Add("5", 2.07m);
goodsNPriceMenu.Add("6", 4.49m);
goodsNPriceMenu.Add("7", 5.10m);
goodsNPriceMenu.Add("8", 2.00m);
goodsNPriceMenu.Add("9", 2.10m);

Dictionary<string, string> menuGoods = new Dictionary<string, string>();
menuGoods.Add("1", "Bannana");
menuGoods.Add("2", "Cantelope");
menuGoods.Add("3", "Ice cream");
menuGoods.Add("4", "Bread");
menuGoods.Add("5", "Cereal");
menuGoods.Add("6", "Milk");
menuGoods.Add("7", "Ground beef");
menuGoods.Add("8", "Red grapes");
menuGoods.Add("9", "Green grapes");

Dictionary<string, decimal> goodsNPriceDisplay = new Dictionary<string, decimal>();
goodsNPriceDisplay.Add("1. Bannana(s) ", 0.77m);
goodsNPriceDisplay.Add("2. Cantelope(s) ", 1.99m);
goodsNPriceDisplay.Add("3. Ice cream ", 2.50m);
goodsNPriceDisplay.Add("4. Bread ", 1.09m);
goodsNPriceDisplay.Add("5. Cereal ", 2.07m);
goodsNPriceDisplay.Add("6. Milk ", 4.49m);
goodsNPriceDisplay.Add("7. Ground beef ", 5.10m);
goodsNPriceDisplay.Add("8. Red grapes ", 2.00m);
goodsNPriceDisplay.Add("9. Green grapes ", 2.10m);

List<decimal> priceList = new List<decimal>();

List<string> shoppingList = new List<string>();

// variables
string userInput = "";
string repeatInput = "";
string repeatInputFinal = "";

//Methods
string UpperInput(string input)
{
    string remainingInput = input.Substring(1, input.Length - 1);
    return $"{char.ToUpper(input[0])}{remainingInput}";
}

void AddToCart()
{
    do
    {
        userInput = Console.ReadLine();
        bool isAvailable = (goodsNPrice.ContainsKey(UpperInput(userInput)));
        bool isAvailableNum = (goodsNPriceMenu.ContainsKey(userInput));
        if (isAvailable)
        {
            shoppingList.Add((UpperInput(userInput)));
            Console.WriteLine($"Adding {UpperInput(userInput)} to the cart at {goodsNPrice[UpperInput(userInput)]}");
        }
        else if (isAvailableNum)
        {
            shoppingList.Add(menuGoods[userInput]);
            Console.WriteLine($"Adding {menuGoods[userInput]} to the cart at {goodsNPriceMenu[userInput]}");
        }
        else
        {
            Console.WriteLine("I'm sorry, that is not a valid selection.");
        }
        Console.WriteLine("Would you like to add another item? y/n:");
        repeatInput = Console.ReadLine();
        if (repeatInput.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("");
            foreach (KeyValuePair<string, decimal> display in goodsNPriceDisplay)
            {
                Console.WriteLine(String.Format("{0,-20}{1,20}", $"{display.Key}", $"${display.Value}"));
            }
            Console.WriteLine("");
            Console.WriteLine("********************************************");
            Console.WriteLine("");
            Console.WriteLine("Please enter which item you would like to add to your cart:");
        }
    } while (repeatInput.ToLower() == "y");
}

void SortByPriceLH()
{
    Console.Clear();
    Console.WriteLine($"Receipt:");
    Console.WriteLine("");
    Console.WriteLine(String.Format("{0, -20}{1,20}", $"Product", $"Price"));
    Console.WriteLine("");
    foreach (string product in shoppingList)
    {
        if (product == "Bannana")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Bread")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Cantelope")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Red grapes")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Cereal")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Green grapes")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Ice cream")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Milk")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
    foreach (string product in shoppingList)
    {
        if (product == "Ground beef")
        {
            Console.WriteLine(String.Format("{0, -20}{1,20}", $"{product}", $"${goodsNPrice[product]}"));
        }
    }
}

void DisplayHigh()
{
    while (shoppingList.Count > 0)
    {
        if ((shoppingList.Contains("Ground beef")))
        {
            Console.WriteLine($"Your most expensive item is Ground beef at $5.10 per lb");
            break;
        }
        else if ((shoppingList.Contains("Milk")))
        {
            Console.WriteLine($"Your most expensive item is Milk at $4.49 per Gallon");
            break;
        }
        else if ((shoppingList.Contains("Ice cream")))
        {
            Console.WriteLine($"Your most expensive item is Ice cream at $2.50 per Quart");
            break;
        }
        else if ((shoppingList.Contains("Green grapes")))
        {
            Console.WriteLine($"Your most expensive item is Green grapes at $2.10 per Bunch");
            break;
        }
        else if ((shoppingList.Contains("Cereal")))
        {
            Console.WriteLine($"Your most expensive item is Cereal at $2.07 per Box");
            break;
        }
        else if ((shoppingList.Contains("Red grapes")))
        {
            Console.WriteLine($"Your most expensive item is Red grapes at $2.00 per Bunch");
            break;
        }
        else if ((shoppingList.Contains("Cantelope")))
        {
            Console.WriteLine($"Your most expensive item is Cantelope at $1.99 each");
            break;
        }
        else if ((shoppingList.Contains("Bread")))
        {
            Console.WriteLine($"Your most expensive item is Bread at $1.09 per loaf");
            break;
        }
        else if ((shoppingList.Contains("Bannana")))
        {
            Console.WriteLine($"Your most expensive item is a Bannana at $0.77 each");
            break;
        }
    }
}

void DisplayLow()
{
    while (shoppingList.Count > 0)
    {
        if ((shoppingList.Contains("Bannana")))
        {
            Console.WriteLine($"Your least expensive item is a Bannana at $0.77 each");
            break;
        }
        else if ((shoppingList.Contains("Bread")))
        {
            Console.WriteLine($"Your least expensive item is Bread at $1.09 per loaf");
            break;
        }
        else if ((shoppingList.Contains("Cantelope")))
        {
            Console.WriteLine($"Your least expensive item is Cantelope at $1.99 each");
            break;
        }
        else if ((shoppingList.Contains("Red grapes")))
        {
            Console.WriteLine($"Your least expensive item is Red grapes at $2.00 per Bunch");
            break;
        }
        else if ((shoppingList.Contains("Cereal")))
        {
            Console.WriteLine($"Your least expensive item is Cereal at $2.07 per Box");
            break;
        }
        else if ((shoppingList.Contains("Green grapes")))
        {
            Console.WriteLine($"Your least expensive item is Green grapes at $2.10 per Bunch");
            break;
        }
        else if ((shoppingList.Contains("Ice cream")))
        {
            Console.WriteLine($"Your least expensive item is Ice cream at $2.50 per Quart");
            break;
        }
        else if ((shoppingList.Contains("Milk")))
        {
            Console.WriteLine($"Your least expensive item is Milk at $4.49 per Gallon");
            break;
        }
        else if ((shoppingList.Contains("Ground beef")))
        {
            Console.WriteLine($"Your least expensive item is Ground beef at $5.10 per lb");
            break;
        }
    }
}

void TotalCartPrice()
{
    decimal total = 0m;
    SortByPriceLH();
    foreach (string product in shoppingList)
    {
        total = total += goodsNPrice[product];
    }
    Console.WriteLine("");
    Console.WriteLine(String.Format("{0, -20}{1,20}", $"Total", $"${total}"));
    Console.WriteLine("");
}

//Program
do
{
    Console.WriteLine("Welcome to Farmer Jack! Please see our goods and prices below:");
    Console.WriteLine("********************************************");
    Console.WriteLine("");
    foreach (KeyValuePair<string, decimal> display in goodsNPriceDisplay)
    {
        Console.WriteLine(String.Format("{0,-20}{1,20}", $"{display.Key}", $"${display.Value}"));
    }
    Console.WriteLine("");
    Console.WriteLine("********************************************");
    Console.WriteLine("");
    Console.WriteLine("Please enter which item you would like to add to your cart:");
    AddToCart();
    TotalCartPrice();
    DisplayHigh();
    DisplayLow();
    Console.WriteLine("");
    Console.WriteLine("Would you like to place another order? y/n:");
    repeatInputFinal = Console.ReadLine();
    shoppingList.Clear();
    Console.Clear();
} while (repeatInputFinal.ToLower() == "y");
Console.Write("Goodbye! Press the <Enter> key to close the program.");
while (Console.ReadKey().Key != ConsoleKey.Enter) { }

