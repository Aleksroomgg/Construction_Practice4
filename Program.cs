using Construction_practice_REFORGER.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Car car = new Car();
                    car.Drive();
                    Bicycle bicycle = new Bicycle();
                    bicycle.Drive();
                    break;
                case 2:
                    Circle circle = new Circle();
                    circle.GetArea();
                    Rectangle rectangle = new Rectangle();
                    rectangle.GetArea();
                    Triangle triangle = new Triangle();
                    triangle.GetArea();
                    break;
                case 3:
                    Cat cat = new Cat();
                    cat.MakeSound();
                    Dog dog = new Dog();
                    dog.MakeSound();
                    break;
                case 4:
                    FullTimeEmployee fulltimeEmployee = new FullTimeEmployee();
                    fulltimeEmployee.CalculateSalary();
                    PartTimeEmployee parttimeEmployee = new PartTimeEmployee();
                    parttimeEmployee.CalculateSalary();
                    break;
                case 5:
                    Person person = new Person(15);
                    person.CompareTo(person);
                    break;
                case 6:
                    Circle2 circle2 = new Circle2();
                    circle2.Draw();
                    Triangle2 triangle2 = new Triangle2();
                    triangle2.Draw();
                    Square square = new Square();
                    square.Draw();
                    break;
                case 7:
                    InMemoryRepository inMemoryRepository = new InMemoryRepository();
                    inMemoryRepository.Add(1);
                    inMemoryRepository.Remove(2);
                    inMemoryRepository.GetAll();
                    break;
            }
        }
    }
}
