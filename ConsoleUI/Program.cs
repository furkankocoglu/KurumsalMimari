using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
       
        Car car1 = new Car();
       
        car1.Name = "Tesla";
        car1.Plaque = "34A37";
        car1.RentPrice = 1000;
        car1.ModelYear = "2020";
      

        Car car2 = new Car();

        car2.Name = "Hyundai";
        car2.Plaque = "35A37";
        car2.RentPrice = 800;
        car2.ModelYear = "2020";
        

        Car car3 = new Car();

        car3.Name = "Mercedes";
        car3.Plaque = "34A40";
        car3.RentPrice = 1300;
        car3.ModelYear = "2018";
        


        Customer customer1 = new Customer();
        customer1.Name = "Ersin";
        customer1.BirthYear = 1980;
        customer1.Phone = "1235678";
        customer1.City = "Ankara";
        
       
       
        Customer customer2 = new Customer();
        customer2.Name = "Fatma";
        customer2.BirthYear = 1985;
        customer2.Phone = "1235658";
        customer2.City = "İstanbul";

        Customer customer3 = new Customer();
        customer3.Name = "Emre";
        customer3.BirthYear = 1980;
        customer3.Phone = "1235458";
        customer3.City = "İstanbul";


        Employee employee1 = new Employee();
        employee1.Name = "Büşra";
        employee1.Phone = "1235678";

        Employee employee2 = new Employee();
        employee2.Name = "Emel";
        employee2.Phone = "1235947";

        RentCar rentcar1 = new RentCar();
        rentcar1.CarId = 1;
        rentcar1.CustomerId = 2;
        rentcar1.EmployeeId = 1;
        rentcar1.RentDate = new DateTime(2023,11,15);

        RentCar rentcar2 = new RentCar();
        rentcar2.CarId = 1;
        rentcar2.CustomerId = 1;
        rentcar2.EmployeeId = 1;
        rentcar2.RentDate = new DateTime(2023, 10, 25);

        RentCar rentcar3 = new RentCar();
        rentcar3.CarId = 2;
        rentcar3.CustomerId = 2;
        rentcar3.EmployeeId = 2;
        rentcar3.RentDate = new DateTime(2022, 7, 8);

        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //customerManager.Add(customer1);
        //customerManager.Add(customer2);
        //customerManager.Add(customer3);

        CarManager carManager = new CarManager(new EfCarDal());
        //carManager.Add(car1);
        //carManager.Add(car2);
        //carManager.Add(car3);

        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        //employeeManager.Add(employee1);
        //employeeManager.Add(employee2);

        RentCarManager rentCarManager = new RentCarManager(new EfRentCarDal());
		//rentCarManager.Add(rentcar1);
		//rentCarManager.Add(rentcar2);
		//rentCarManager.Add(rentcar3);

		//Console.WriteLine("------Cars------");
		//foreach (var item in carManager.GetAll())
		//{
		//    Console.WriteLine(item.Name);

		//}

		//Console.Write("-------Kiralanan Araba/lar------");
		//foreach (var item in rentCarManager.GetDetails().Data)
		//{
		//    Console.WriteLine( "\nModeli: "+item.CarName +
		//       "\nMüşteri:"+item.CustomerName+"\nSatıcı:"+item.EmployeeName+"\n-----");
		//}
		Console.WriteLine(carManager.Add(car1).Message);
        car1.Plaque = "34abc034";//Geçersiz veri girişi olmaması için 6 karakterden fazla giriş yapıyoruz.
		Console.WriteLine(carManager.Add(car1).Message);
		//silmek istediğimiz veri girişini yaparken id sini de girmeliyiz.
		Car deleteCar = carManager.Get(c=>c.Plaque== "34abc034").Data; //veritabanından plakasına göre arama yapıp silmek istediğimiz veriyi alıyoruz, çünkü bize idsi gerekli.
		Console.WriteLine(carManager.Delete(car1).Message);        
	}
}