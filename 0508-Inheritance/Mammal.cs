



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _05_08_Inheritance
{
    internal class Mammal // 포유류
    {
        
        protected string? Name;
        public string? Color;
        protected int Age;
        public void Nurse()
        {
            Console.WriteLine("젖을 먹인다.");
        }
    }
    class Dog : Mammal
    {
        public Dog(string name,int age,string color) // 생성자
        {
            
            Name = name;
            Age = age;
            Color = color;
            Console.WriteLine($"{Name}.Dog");
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} 멍멍 {Age}살 {Color}색");
        }
    }
    class Cat : Mammal
    {
        public Cat(string name, int age, string color) // 생성자
        {
            Name = name;
            Age = age;
            Color = color;
            Console.WriteLine($"{Name}.Cat");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name}야옹 {Age}살 { Color}색");
        }
    }

}
