//A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter name of company:");
        string nameCompany = Console.ReadLine();

        Console.WriteLine("Please enter address of company:");
        string addressCompany = Console.ReadLine();

        // I use string because if I use integer type the 0 in the biggining of number does not print to the console
        Console.WriteLine("Please enter phone number of company:");
        string numberCompany = Console.ReadLine();

        Console.WriteLine("Please enter fax number of company:");
        string faxCompany = Console.ReadLine();

        Console.WriteLine("Please enter web site of company:");
        string webSite = Console.ReadLine();

        Console.WriteLine("Please enter manager first name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter manager last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Please enter manager age:");
        byte age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a manager phone number:");
        string managerNumber = Console.ReadLine();

        Console.WriteLine("Information: Company name:{0}\n Address:{1}\n Phone number:{2}\n Fax:{3}\n Web site:{4}\n Manager: {5} {6}\n ", nameCompany, addressCompany, numberCompany, faxCompany, webSite, firstName, lastName);
        Console.WriteLine("Manager age: {0}\n Manager phone number: {1}\n",age,managerNumber);

    }
}
