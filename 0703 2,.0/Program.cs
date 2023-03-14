using _0703_2_._0.Models;
Console.WriteLine("Nece kitab isteyirsiz?");
string input = Console.ReadLine();
int number = int.Parse(input);

Book[] books = new Book[number];



for (int i = 0; i < number; i++)
{
    
    Console.WriteLine("Kitabin say 1den bashlayaraq novbenen yazin:");
    input = Console.ReadLine();
    short number2 = short.Parse(input);
    Console.WriteLine("Kitabiniz adini qeyd edin:");
    input = Console.ReadLine();
    string bookname = input;
    Console.WriteLine("Kitabinizin qiymetini qeyd edin:");
    input = Console.ReadLine();
    int priceofbook = int.Parse(input);
    Console.WriteLine("kitabinizin janirini qeyd edin:");
    input = Console.ReadLine();
    string genreofbook = input;
    books[i] = new Book(number2,bookname,priceofbook,genreofbook);

}