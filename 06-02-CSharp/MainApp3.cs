using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//추상 클래스 abstract class는 인터페이스와 달리 구현부를 포함할 수 있습니다. 
//추상 클래스는 인스턴스를 생성할수 없다. 자식 클래스에서 상속 받아 인스턴스 생성
//추상클래스는 부모 상위 기초 클래스인 경우가 많다.
namespace _06_02_CSharp
{
    abstract class AbstractBase // 추상 클래스는 선언부 구현부를 다가진다.
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA");
        }
        public abstract void AbstractMethodA(); // 추상 메서드 선언
        // 추상 메서드는 구현부가 없고, 자식 클래스에서 반드시 구현해야 한다.
        // 추상 메서드가 하나이상 있으면 클래스도 추상 클래스가 되어야 한다.
    }
    class Derived : AbstractBase // 추상 클래스 상속
    {
        public override void AbstractMethodA()
        {
            {
                Console.WriteLine("Derived.AbstractMethodA");
            }
        }
    }
    internal class MainApp3
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived(); // 추상 클래스의 인스턴스(동적할당) 생성할 수 없지만, 자식 클래스의 인스턴스를 생성할 수 있따.
            obj.PublicMethodA(); // 부모 클래스의 메서드 호출
            obj.AbstractMethodA(); // 자식 클래스에서 구현한 추상 메서드 호출
        }
    }
}
