/*შექმენით enum სახელწოდებით "DaysOfWeek", რომელიც წარმოადგენს კვირის დღეებს
	(კვირა, ორშაბათი, სამშაბათი და ა.შ.). დაწერეთ პროგრამა, რომელიც სთხოვს 
	მომხმარებელს შეიყვანოს რიცხვი 1-დან 7-მდე და აჩვენებს კვირის შესაბამის დღეს ნომრის გამოყენებით.
შექმენით enum სახელწოდებით "Status", რომელშიც გექნებათ შემდეგი კონსტანტები :
	"Sent, Delivered, Deleted", Program.cs ში შექმენით ცვლადი და მიანიჭეთ
	რომელიმე სტატუსი, switch statement ში, შეადერეთ ეს ცვლადი enum ის 
	თითოეულ ელემენტს და გამოიტანეთ შესაბამისი შეტყობინებები.
შექმენით Person კლასი, რომელსაც ექნება Name და სტატიკური წევრი count
, Person კლასის ახალი ინსტანსის შექმნის დროს უნდა ხდებოდეს count ის 1 ით გაზრდა,
დაბეჭდეთ count ის მნიშვნელობა.
*/

using Enum;
using System;
using System.Xml.Linq;

Console.Write("Enter a number from 1 - 7: ");
int day = int.Parse(Console.ReadLine());

switch(day)
{
	case 1:
		Console.WriteLine(Days.monday);
		break;
	case 2:
		Console.WriteLine(Days.tuesday);
		break;
	case 3:
		Console.WriteLine(Days.wednesday);
		break;
	case 4:
		Console.WriteLine(Days.thursday);
		break;
	case 5:
		Console.WriteLine(Days.friday);
		break;
	case 6:
		Console.WriteLine(Days.saturday);
		break;
	case 7:
		Console.WriteLine(Days.sunday);
		break;
	default:
		Console.WriteLine("Invalid number!");
		break;

}


int status = 0;

switch (status)
{
	case 0:
		Console.WriteLine("sent");
		break;
	case 1:
		Console.WriteLine("delivered");
		break;
	case 2:
		Console.WriteLine("deleted");
		break;
	default:
		Console.WriteLine("invalid");
		break;
}



Person person1 = new Person();
Person person2 = new Person();

Console.WriteLine($"Person count: {Person.Count}");