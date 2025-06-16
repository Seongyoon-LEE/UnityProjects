//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace _06_16_CSharpLinq
//{
//    class Class
//    {
//        public string? Name { get; set; }
//        public int[]? Score { get; set; }

//    }
//    class Profile
//    {
//        public string Name { get; set; }
//        public int Height { get; set; }
//    }
//    class Car
//    {
//        public int Cost { get; set; }
//        public int MaxSpeed { get; set; }  
//    }

//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            //Car[] cars =
//            //{
//            //    new Car() {Cost = 56, MaxSpeed = 120},
//            //    new Car() {Cost = 70, MaxSpeed = 150},
//            //    new Car() {Cost = 45, MaxSpeed = 180},
//            //    new Car() {Cost = 32, MaxSpeed = 200},
//            //    new Car() {Cost = 82, MaxSpeed = 280},
//            //};
//            //var selected = from car in cars
//            //               where car.Cost >= 50 && car.MaxSpeed >= 150
//            //               select new { car.Cost, car.MaxSpeed };
//            //foreach (var car in selected)
//            //{
//            //    Console.WriteLine($"가격: {car.Cost}, 최고속도: {car.MaxSpeed}");
//            //}


//            #region 학급의 성적 출력
//            Class[] arrClass =
//            {
//                new Class(){Name = "연두반",Score = new int[]{99,80,70,24 } },
//                new Class(){Name = "분홍반",Score = new int[]{60,45,87,72 } },
//                new Class(){Name = "파랑반",Score = new int[]{92,30,85,94 } },
//                new Class(){Name = "노랑반",Score = new int[]{90,88,0,17 } },
//            };
//            var scoresByClass = from c in arrClass
//                                select new
//                                {
//                                    ClassName = c.Name,
//                                    PassedScores = from s in c.Score where s >= 60 select s,
//                                    FailedScores = from s in c.Score where s < 60 select s
//                                };
             
//            foreach (var c in scoresByClass)
//            {
//                Console.WriteLine($"학급명 : {c.ClassName}");
//                Console.WriteLine($"합격 60점 이상 : {string.Join(",", c.PassedScores)}");
//                Console.WriteLine($"낙제 60점 미만 : {string.Join(",",c.FailedScores)}");
//                Console.WriteLine();
//            }

//            #endregion
//            //Profile[] arrProfile =
//            //{
//            //    new Profile() {Name = "정우성", Height = 186},
//            //    new Profile() {Name = "이정재", Height = 178},
//            //    new Profile() {Name = "김혜수", Height = 170},
//            //    new Profile() {Name = "이병헌", Height = 175},
//            //    new Profile() {Name = "하하", Height = 171},
//            //};
//            ////175미만을 추출해서 출력하고 175 이상도 추출해서 출력하기
//            //var listProfile = from profile in arrProfile
//            //                  orderby profile.Height
//            //                  group profile by profile.Height < 175 into g
//            //                  select new { GroupKey = g.Key, Profiles = g };
//            //foreach (var Group in listProfile)
//            //{
//            //    Console.WriteLine($"--175cm 미만 ? :{Group.GroupKey}");
//            //    foreach (var profile in Group.Profiles)
//            //    {
//            //        Console.WriteLine($">>> {profile.Name},{profile.Height}");
//            //    }
//            //}
//            //그룹변수 g에는 Height값이 175미만인 객체의 컬렉션 175이상인 객체의 컬렉션이 입력되고
//            // select 문이 추출하는 새로운 무명형식은 컬렉션의 컬렉션이 된다.
//        }
//    }
//}
