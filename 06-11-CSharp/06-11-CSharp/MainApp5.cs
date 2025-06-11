using System;

namespace Ex13_2
{
    //delegate void MyDelegate(int a);

    //class Market
    //{
    //    public event MyDelegate CustomerEvent;

    //    public void BuySomething(int CustomerNo)
    //    {
    //        if (CustomerNo == 30)
    //            CustomerEvent(CustomerNo); // 이벤트 발생
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Market market = new Market();

    //        // 이벤트 처리기 연결
    //        market.CustomerEvent += new MyDelegate(
    //            delegate (int customerNo)
    //            {
    //                Console.WriteLine("축하합니다! {0}번째 고객 이벤트에 당첨되셨습니다.", customerNo);
    //            });

    //        for (int customerNo = 0; customerNo < 100; customerNo += 10)
    //            market.BuySomething(customerNo);
    //    }
    //}
    delegate int MyDelegate(int a, int b);

     class  MainApp
    {
     static void Main(string[] args)
        {
            MyDelegate Callback;

            //익명 메서드 선언 1: 덧셈
            Callback = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(Callback(3,4)); // 출력 7

            //익명 메서드 선언 2: 뺼셈
            Callback = delegate (int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(Callback(7,5)); // 출력: 2
        }
    }
}