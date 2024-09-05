namespace ShoppingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                string[] peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (var personData in peopleInfo)
                {
                    string[] personTokens = personData.Split('=');
                    string personName = personTokens[0];
                    decimal personMoney = decimal.Parse(personTokens[1]);

                    if (string.IsNullOrWhiteSpace(personName) || personMoney < 0)
                    {
                        throw new Exception("Invalid input");
                    }

                    people.Add(new Person(personName, personMoney));
                }

                foreach (var productData in productsInfo)
                {
                    string[] productTokens = productData.Split('=');
                    string productName = productTokens[0];
                    decimal productCost = decimal.Parse(productTokens[1]);

                    if (string.IsNullOrWhiteSpace(productName) || productCost < 0)
                    {
                        throw new Exception("Invalid input");
                    }

                    products.Add(new Product(productName, productCost));
                }

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] purchaseInfo = input.Split();
                    string personName = purchaseInfo[0];
                    string productName = purchaseInfo[1];

                    Person person = people.FirstOrDefault(p => p.Name == personName);
                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                    }
                }

                foreach (var person in people)
                {
                    Console.Write($"{person.Name} - ");
                    if (person.Bag.Count == 0)
                    {
                        Console.WriteLine("Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", person.Bag));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}