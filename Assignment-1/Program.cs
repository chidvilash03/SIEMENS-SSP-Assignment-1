using BankAccountNameSpace;
using BookClass;
using CarNameSpace;
using EmployeeClass;
using RecatangleClass;
using NumberClass;
using SumOFNumbersClass;
using FibonacciClass;
using GradeClassificationClass;
class Program
{


    public void CreateCarObject()
    {
        //getting input the required attributes
        Console.WriteLine("Enter the car Manfacturer : ");
        string carMake = Console.ReadLine();
        Console.WriteLine("Enter the car model : ");
        string carModel = Console.ReadLine();
        Console.WriteLine("Enter the year the car was manfactured : ");
        int carYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the mileage of the car : ");
        int carMileage = Convert.ToInt32(Console.ReadLine());


        //creating car object
        Car myCar = new Car(carMake,carModel,carYear,carMileage);
        //displaying car info
        myCar.DisplayInfo();
    }

    public void CreateBankObject()
    {
        //getting input the required attributes
        Console.WriteLine("Enter the bank account number : ");
        string bankAccountNumber = Console.ReadLine();
        Console.WriteLine("Enter the name of the account holder : ");
        string accountHolder = Console.ReadLine();
        Console.WriteLine("Enter the available balance : ");
        int bankBalance = Convert.ToInt32(Console.ReadLine());

        BankAccount account = new BankAccount(bankAccountNumber,accountHolder,bankBalance);
        account.DisplayAccountInfo();

        Console.WriteLine("Enter 1 for Deposit and 2 for Withdraw and 0 for Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter amount to Deposit : ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                account.Deposit(depositAmount);
                break;
            case 2:
                Console.WriteLine("Enter amount to Withdraw : ");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                account.WithDraw(withdrawAmount);
                break;
            case 0:
                Console.WriteLine("Logged Out");
                break;
        }
    }

    public void CreateBookObject()
    {
        //getting input the required attributes
        Console.WriteLine("Enter the title of the book : ");
        string BookTitle = Console.ReadLine();
        Console.WriteLine("Enter the author of the book : ");
        string BookAuthor = Console.ReadLine();
        Console.WriteLine("Enter the publication year of the book : ");
        int BookYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the genre of the book : ");
        string BookGenre = Console.ReadLine();

        Book myBook = new Book(BookTitle,BookAuthor,BookYear,BookGenre);
        myBook.GetSummary();

    }

    public void CreateEmployeeObject()
    {

        //getting input the required attributes
        Console.WriteLine("Enter the name of the employee : ");
        string EmployeeName = Console.ReadLine();
        Console.WriteLine("Enter the id of the employee : ");
        int EmployeeId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the position of the employee : ");
        string EmployeePosition = (Console.ReadLine());
        Console.WriteLine("Enter the Salary of the employee : ");
        double EmployeeSalary = Convert.ToDouble(Console.ReadLine());

        Employee myEmployee = new Employee(EmployeeName,EmployeeId,EmployeePosition,EmployeeSalary);
        myEmployee.GetSalaryDetails();
    }

    public void CreateRectangleObject()
    {
        //getting input the required attributes

        Console.WriteLine("Enter the Rectangle width : ");
        double inputWidth = Convert.ToDouble(Console.ReadLine());

        //to input the height of the rectangle
        Console.WriteLine("Enter the Rectangle height : ");
        double inputHeight = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(inputWidth, inputHeight);

        //displaying perimeter of the rectangle
        Console.WriteLine("The Perimeter of the rectangle is : " + rectangle.GetPerimeter());
        //displaying area of the rectangle
        Console.WriteLine("The Area of the rectangle is : " + rectangle.GetArea());
    }


    public void CreateNumberObject()
    {
        Console.WriteLine("Enter a number : ");
        //to input a number 
        double number = Convert.ToDouble(Console.ReadLine());

        Number myNum = new Number(number);
        myNum.CheckNumber();
    }

    public void CreateSumOfNumbersObject()
    {
        SumOfNumbers total = new SumOfNumbers();
        total.CalculateSumOfNumbers();
    }

    public void CreateFibanocciObject()
    {
        Console.WriteLine("Enter the limit for Fibonacci series:");
        int limit = Convert.ToInt32(Console.ReadLine());
        Fibonacci fibonacci = new Fibonacci(limit);
        fibonacci.DisplaySeries();
    }

    public void CreateGradeClassificationObject()
    {

        Console.WriteLine("Enter the student's grade:");
        //input the marks
        int marks = Convert.ToInt32(Console.ReadLine());

        GradeClassification grade = new GradeClassification(marks);

        //calling GetGradeClassification method to get the grade
        string classification = grade.GetGradeClassification();

        //displaying the grade
        Console.WriteLine("Grade Classification: " + classification);
    }


    static void Main()
    {

        //To create Car objects uncomment the below lines <= Exercise 1 and 2
        //Program exercise1_2 = new Program();
        //exercise1_2.CreateCarObject();


        //To create Bank objects uncomment the below lines <== Exercise 3
        //Program exercise3 = new Program();
        //exercise3.CreateBankObject();

        //To create Book objects uncomment the below lines <== Exrecise 4
        //Program exercise4 = new Program();
        //exercise4.CreateBookObject();

        //To create employee objects uncomment the below lines <== Exercise 5
        //Program exercise5 = new Program();
        //exercise5.CreateEmployeeObject();


        //To create Rectangle objects uncomment the below lines <== Exercise 6
        //Program exercise6 = new Program();
        //exercise6.CreateRectangleObject();


        //To create Number objects uncomment the below lines <== Exercise 7
        //Program exercise7 = new Program();
        //exercise7.CreateNumberObject();


        //To create SumOFNumbers objects uncomment the below lines <== Exercise 8
        //Program exercise8 = new Program();
        //exercise8.CreateSumOfNumbersObject();

        //To create Fibanocci objects uncomment the below lines <== Exercise 9
        //Program exercise9 = new Program();
        //exercise9.CreateFibanocciObject();


        //To create employee objects uncomment the below lines <== Exercise 10
        //Program exercise10 = new Program();
        //exercise10.CreateGradeClassificationObject();
    }
}