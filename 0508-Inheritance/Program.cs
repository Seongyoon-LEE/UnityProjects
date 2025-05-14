namespace _05_08_Inheritance
{
    #region base class and Derived class
    class Base //부모 클래스,기초 클래스,상위 클래스
    {
        protected string Name;
        public Base(string Name) 
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base");
        }
        ~Base()
        {
            Console.WriteLine("소멸자");
        }
        public  void BaseMethod() // 동적 멤버 메쏘드
        {
            Console.WriteLine($"{Name}.BaseMethod");
        }
    }

    class Derived : Base // 자식 클래스, 파생 클래스, 하위 클래스, 유도 클래스
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{Name}.Derived");
        }
        ~Derived()
        {
            Console.WriteLine("Derived 소멸자!");
        }
        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region base and derived
            //Base a = new Base("a");
            //a.BaseMethod();
            ////a.Derived();
            //Derived b = new Derived("b");
            //b.BaseMethod();
            //b.DerivedMethod();
            #endregion
            #region 상속 Dog,Cat
            //Dog dog = new Dog("백구",12,"흰");
            //dog.Bark();
            //dog.Nurse();
            //Cat cat = new Cat("네로",5,"검정");
            //cat.Meow();
            //cat.Nurse();

            //Mammal mammal1_1 = new Dog("백구",12,"흰색");
            //Mammal mammal1_2 = new Cat("네로", 12, "검정");
            //mammal1_1.Nurse();
            //mammal1_2.Nurse();

            //Mammal mammal = new Dog("백구",12,"흰");
            //Dog dog;
            //if(mammal is Dog)
            //{
            //    dog = (Dog)mammal; // 다운 캐스팅
            //    dog.Bark();
            //}
            //Mammal mammal2 = new Cat("네로", 5, "검정");
            //Cat? cat = mammal2 as Cat; // as 연산자 다운캐스팅 참조형
            //if(cat != null)
            //{
            //    cat.Meow();
            //}
            //Cat? cat_2 = mammal as Cat; // as 연산자 다운 캐스팅 참조형
            //if(cat_2 != null)
            //{
            //    cat_2.Meow();
            //}
            //else
            //{
            //    Console.WriteLine("cat_2는 Cat이 아닙니다.");
            //}
            #endregion
            #region 다형성
            //ArmorSuit armorSuit = new ArmorSuit();
            //armorSuit.Initialize();

            //ArmorSuit ironMan = new IronMan();
            //ironMan.Initialize();

            //ArmorSuit warMachine = new WarMachin();
            //warMachine.Initialize();
            #endregion
            //BaseClass baseobj = new BaseClass();
            //baseobj.Method();

            //Derived2 derivedobj = new Derived2();
            //derivedobj.Method();

            //BaseClass baseOrDerived = new Derived2();
            //baseOrDerived.Method(); // Derived2의 Method()가 호출된다
        }
    }
}
