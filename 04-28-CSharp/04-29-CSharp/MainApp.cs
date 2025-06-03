using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//객체지향 프로그래밍 클래스의 정의
//클래스는 속성을 가진다.
namespace _04_29_CSharp
{
    class Cat
    {
        public string Name; 
        public string Color;
        public void Meow()
        {
            Console.WriteLine($"{Name}가 야옹~");
        }
    }
    class Dog
    {
        // private는 클래스 안에서만 접근 가능
        private string Name; // 멤버 변수
        private string Color; // 멤버 변수
                    //매개변수
        public Dog() // void 생성자
        {
            Name = null!; //멤버변수 초기화
            Color = null!; //멤버변수 초기화
        }
        public Dog(string Name) //생성자
        {
            this.Name = Name ; //멤버변수 초기화
            Color = null!; //멤버변수 초기화
        }
        public Dog(string Name, string Color) // 생성자
        {
            this.Name = Name; // this는 자기 자신을 가리킴
            this.Color = Color; // this는 자기 자신을 가리킴
            
        }
        public void Bark()
        {
            Console.WriteLine($"{Name}가 멍멍~");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Color}"); 
        }
        ~Dog() // 소멸자
        {
            Console.WriteLine($"{Name}가 소멸되었습니다.");
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "망고";
            cat.Color = "회색";
            cat.Meow();
            Console.WriteLine($"{cat.Name} {cat.Color}");
            Dog dog = new Dog("백구","하얀색");
            dog.Bark();
            dog.ShowInfo();
            Dog dog2 = new Dog("흰둥이");
            dog2.ShowInfo();
            Dog dog3 = new Dog(); // 기본 생성자 호출
            dog3.ShowInfo(); // 기본 생성자 호출
        }
    }
}
