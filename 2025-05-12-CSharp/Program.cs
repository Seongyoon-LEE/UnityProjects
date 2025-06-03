//namespace _2025_05_12_CSharp
//{
//    #region readonly
//    //    private readonly int min;
//    //    private readonly int max;
//    //    public Configuration(int min, int max) 
//    //    {
//    //        this.min = min;
//    //        this.max = max;

//    //    }
//    //    public void ChangMax(int newMax)
//    //    {
//    //        // max = newMax; why?
//    //    }
//    //}
//    #endregion

//    #region 중첩클래스 설명
//    //중첩 클래스 : 클래스 안에 클래스가 있는것
//    //중첩 클래스를 쓰는 이유
//    //1. 클래스를 외부에 공개 하고 싶지 않을때 (은닉성)
//    //2. 현재클래스의 일부분 처럼 표현 하는 클래스를 만들고자 할때
//    //다른 클래스의 private 멤버에도 마구 접근 할 수 있는
//    //중첩클래스는 은닉성을 무너뜨리기도 하지만
//    //보다 유연한 표현력을 프로그러머에게 제공하는 장점이 있다.
//    #endregion

//    class Configuration // private 선언 했기에 Configuration 클래스 밖에는 보이지 않음
//    {
//        //배열 
//        List<ItemValue> listConfig = new List<ItemValue>();
//        public void SetConfig(string item, string value)
//        {
//            ItemValue iv = new ItemValue();
//            iv.SetVelue(this, item, value);
//        }
//        public string GetConfig(string item)
//        {
//            foreach (ItemValue iv in listConfig)
//            {
//                if (iv.GetItem() == item)
//                {
//                    return iv.GetValue();
//                }
//            }
//            return "";
//        }
//        class ItemValue
//        {
//            private string? item;
//            private string? value;
//            public void SetVelue(Configuration config, string item, string value)
//            {
//                this.item = item;
//                this.value = value;
//                bool found = false;
//                //중첩 클래스는 상위 클래스에 자유롭게 접근 가능 
//                for (int i = 0; i < config.listConfig.Count; i++)
//                {
//                    config.listConfig[i] = this;
//                    found = true;
//                    break;
//                }
//                if (found == false)
//                {
//                    config.listConfig.Add(this);
//                }
//            }
//            public string GetItem()
//            {
//                return item;
//            }
//            public string GetValue()
//            {
//                return value;
//            }
//        }
//    }






//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Configuration c = new Configuration(1, 10);
//            Configuration config = new Configuration();
//            config.SetConfig("Version", "V 5.0");
//            config.SetConfig("Size", "655,324 KB");
//            Console.WriteLine(config.GetConfig("Version"));
//            Console.WriteLine(config.GetConfig("Size"));

//            config.SetConfig("Version", "V 5.0.1");
//            Console.WriteLine(config.GetConfig("Version"));
//        }
//    }
//}


