using ConsoleApp1;

Console.WriteLine("Demo on Interfaces");
// IAdd m1=new MathClass();//Alok- Add
// IAddSub m2=new MathClass();//Riya- Add,Sub
// IAll m3=new MathClass();//Rajat- Add,Sub,Prod,Div
// m1.AddMe(10,20);

//Approach 1
Product p=new Product();
p.ProdId=101;

p.Name="Borosil Flask";
p.Price=850;
//Approach 2
//Object Initializer Syntax
Product p2=new Product()
{
    ProdId=102,
    Name="iPhone 14 Pro",
    Price=129900
};

List<Product> prodList=new List<Product>()
{
    new Product(){ProdId=103,Name="Samsung Galaxy S23",Price=99999},
    new Product(){ProdId=104,Name="OnePlus 11R",Price=46999},
    new Product(){ProdId=105,Name="Sony WH-1000XM5",Price=29990},
    new Product(){ProdId=106,Name="Dell XPS 13",Price=119990},
    new Product(){ProdId=107,Name="HP Spectre x360",Price=139990}
};
foreach(var item in prodList)
{
    Console.WriteLine($"Product Id: {item.ProdId}, Name: {item.Name}, Price: {item.Price}");
}