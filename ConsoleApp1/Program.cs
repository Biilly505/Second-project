//Arash Imani
//Github address: Biilly505
Console.Clear();
Console.Write("How many hours have you worked? ");
var hour=Convert.ToInt32(Console.ReadLine());
var salary=hour*3.0;
Console.WriteLine($"\nYour salary is {salary} dollars");
var tax=(salary/100)*5;
Console.WriteLine($"You have to pay {tax} dollars for taxes");
var sub=salary-tax;
Console.WriteLine($"Your salary after subtracting taxes is {sub} dollars");