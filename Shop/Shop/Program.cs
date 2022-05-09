//using Shop;
//var obj = new Castomer();

//Console.WriteLine("enter your Id:");
//obj.CustomerId = int.Parse(Console.ReadLine());


//Console.WriteLine("enter your Name:");
//obj.CustomerName = Console.ReadLine();

//Console.WriteLine("enter your Address:");
//obj.Address = Console.ReadLine();

//Console.WriteLine("enter your mobail:");
//obj.mobail = int.Parse(Console.ReadLine());

//Console.WriteLine("enter your age:");
//obj.age = int.Parse(Console.ReadLine());

//Console.WriteLine("enter your ddi:");
//obj.ddi = (Console.ReadLine());

//Console.WriteLine("enter your mame:");
//obj.mame = (Console.ReadLine());

//Console.WriteLine("enter your codemeli:");
//obj.codemeli = (Console.ReadLine());

//var z = $"Address is {obj.Address} " +
//    $"Name is {obj.CustomerName} " +
//    $"Id is {obj.CustomerId} " +
//    $"age is {obj.age} " +
//    $"ddi is {obj.ddi} " +
//    $"mame is {obj.mame} " +
//    $"codemeli is {obj.codemeli}  " +
//    $"Gensit is {obj.Gensit}";


//Console.WriteLine(z);







//using Shop;

//Customer[] customers = new Customer[3];

//for (int i = 0; i < customers.Length; i++)
//{
//    var obj = new Customer();


//    Console.WriteLine("enter your Id:");
//    obj.CustomerId = int.Parse(Console.ReadLine());


//    Console.WriteLine("enter your Name:");
//    obj.CustomerName = Console.ReadLine();


//    Console.WriteLine("enter your Address:");
//    obj.Address = Console.ReadLine();

//    customers[i] = obj;
//}
//for (int j = 0; j < customers.Length; j++)
//{
//    var info = $"customer id: {customers[j].CustomerId}  customer name is: {customers[j].CustomerName}  customer address is: {customers[j].Address}";

//    Console.WriteLine(info);

//    Console.WriteLine("===================");


//}





//  لیست


using Shop;

//Customer[] customers = new Customer[3];

Console.WriteLine("enter number of customer");
var count = int.Parse(Console.ReadLine());  


var customers = new List<Customer>(count);

for (int i = 0; i < count; i++)
{
    var obj = new Customer();


    Console.WriteLine("enter your Id:");
    obj.CustomerId = int.Parse(Console.ReadLine());


    Console.WriteLine("enter your Name:");
    obj.CustomerName = Console.ReadLine();


    Console.WriteLine("enter your Address:");
    obj.Address = Console.ReadLine();


    Console.WriteLine("enter your Mobile:");
    obj.Mobile = int.Parse(Console.ReadLine());

    //customers[i] = obj;
    customers.Add(obj);
}
foreach(var obj in customers) 
{
    var info = $"customer id: {obj.CustomerId}  customer name is: {obj.CustomerName}  customer address is: {obj.Address}  Mobile is: {obj.Mobile}";

    Console.WriteLine(info);

    Console.WriteLine("===================");


}

using Shop;

var customers = new List<Customer>();

var obj = new Customer();

Console.WriteLine("enre yor Id");
obj.CustomerId = int.Parse(Console.ReadLine());

Console.WriteLine("enre yor Name");
obj.Name = (Console.ReadLine());


Console.WriteLine("enre yor Addres");
obj.Address = (Console.ReadLine());

customers.Add(obj); // اضافه کردن به لیست 
customers.Remove(obj); //برای حذف از لیست 

bool isExist = customers.Contains(obj); // برای این که معلوم کند شیع وخود دارد یا خیر



Console.WriteLine(customers.Count); // تعداد شیع را مشخص میکند 










