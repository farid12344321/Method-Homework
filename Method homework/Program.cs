
#region calculator




//using Method_homework;

//Calculate();


//static void Calculate()
//{
//    Calculator calculator = new();

//    Console.WriteLine("add first number");
//number1: string number1 = (Console.ReadLine());

//    int checkednum1;
//    bool IsParseNum1 = int.TryParse(number1, out checkednum1);


//    if (!IsParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please add correct format number 1");
//        Console.ResetColor();
//        goto number1;
//    }


//    Console.WriteLine("add operation :");
//    string operation = (Console.ReadLine());



//    Console.WriteLine("add second number 2");


//number2: string number2 = (Console.ReadLine());

//    int checkednum2;
//    bool IsParseNum2 = int.TryParse(number2, out checkednum2);


//    if (!IsParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please add correct format number 2");
//        Console.ResetColor();
//        goto number2;
//    }

//    if (checkednum2 == 0 && operation == "/") 
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("please dont add 0");
//        Console.ResetColor();
//        goto number2;
//    }

//    var result = calculator.Calculation(checkednum1, checkednum2, operation);

//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();
//}

#endregion


#region Doctor


//using Method_homework;

//static Doctor[] GetDoctors()
//{
//    Doctor doctor1 = new Doctor
//    {
//        Name ="XX1",
//        Surname="YY1",
//        Address="AA1",
//        Brithday=new DateTime (1994,10,05)
//    };

//    Doctor doctor2 = new Doctor
//    {
//        Name = "XX2",
//        Surname = "YY2",
//        Address = "AA2",
//        Brithday = new DateTime(2000, 10, 05)
//    };

//    Doctor doctor3 = new Doctor
//    {
//        Name = "XX3",
//        Surname = "YY3",
//        Address = "AA3",
//        Brithday = new DateTime(2003, 10, 05)
//    };

//    Doctor doctor4 = new Doctor
//    {
//        Name = "XX4",
//        Surname = "YY4",
//        Address = "AA4",
//        Brithday = new DateTime(2003, 10, 05)
//    };

//    Doctor doctor5 = new Doctor
//    {
//        Name = "XX5",
//        Surname = "YY5",
//        Address = "AA5",
//        Brithday = new DateTime(2005, 10, 05)
//    };
//    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };
//    return doctors;

//}
//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 15);

//GetDoctorByBrithday( startDate, endDate);
//static void GetDoctorByBrithday(DateTime start,DateTime end)
//{
//    var doctors = GetDoctors();

//    foreach (var item in doctors)
//    {
//        if (item.Brithday > start && item.Brithday < end)
//        {
//            Console.WriteLine($"{item.Name} - {item.Surname} - {item.Address} - {item.Brithday}");
//        }
//    }
//}

#endregion


#region order


//using Method_homework;


//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order(new DateTime(2022, 12, 19), 250);
//    var order4 = new Order(new DateTime(2022, 12, 20), 1500);
//    var order5 = new Order(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order(new DateTime(2022, 12, 28), 500);

//    return new Order[] { order1, order2, order3, order4, order5, order6 };
//}

//DateTime filteredDate = DateTime.Now.AddDays(1);
//double filteredPrice = 200;
//GetFiltEiredOrders(filteredDate, filteredPrice);
//static void GetFiltEiredOrders(DateTime date,double price)

//{
//    var orders = GetOrders();


//    foreach (var item in orders)
//    {
//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date + ":" + item.Date);
//        }
//    }
//}


#endregion


#region Person


//using Method_homework;

//Person person1 = new Person
//{
//    Name = "Konul",
//    Surname = "Ibrahimova",
//    Age = 26,
//    İsMarried = true
//};


//Person person2 = new Person
//{
//    Name = "Roya",
//    Surname = "Meheremmova",
//    Age = 26,
//    İsMarried = true

//};


//Person person3 = new Person
//{
//    Name = "Cavid",
//    Surname = "Ismayilzade",
//    Age = 26,
//    İsMarried = false

//};


//Person person4 = new Person
//{
//    Name = "Shaiq",
//    Surname = "Kazimov",
//    Age = 25,
//    İsMarried = false

//};

//Person[] persons = { person1, person2, person3, person4 };

//PersonPerson(persons,20);
//static void PersonPerson(Person[] persons ,int age)
//{
//    int count = 0;
//    foreach (var item in persons)
//    {
//        if (item.Age > age && item.İsMarried == true)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);

//}

#endregion








