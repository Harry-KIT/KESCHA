namespace KESCHA.Classes
{
    class Book
    {
        public string BookName {get; set;}
        public string BookAuthor {get; set;}
        public float BookPrice {get; set;}

        public Book()
        {
            BookName = "Unknown";
            BookAuthor = "Unknown";
            BookPrice = 0;

        }

        public Book(string book_name, string book_author, float book_price)
        {
            BookName = book_name;
            BookAuthor = book_author;
            BookPrice = book_price;

        }
        public void PrintBookDetails()
        {
            Console.WriteLine($"The Name of The Book: {BookName}");
            Console.WriteLine($"The Name of The Author: {BookAuthor}");
            Console.WriteLine($"The Price of The Book: {BookPrice} USD");

            double sbs = SpecialSale();
            Console.WriteLine($"Book Sale (if you buy the same 3 books, We will give you 10% discount) Total Price: {sbs} USD");
        }


        private double SpecialSale()
        {
            double discount = 3 * BookPrice * 0.9;
            return discount;
        }
        
    }
}