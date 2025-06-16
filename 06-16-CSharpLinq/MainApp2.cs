using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _06_16_CSharp_Linq
{
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }
    class Product
    {
        public string? Title { get; set; }
        public string? Star { get; set; }
    }
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    internal class MainApp2
    {
        static void Main(string[] args)
        {
            Car[] cars =
                    {
                        new Car() {Cost = 56, MaxSpeed = 120},
                        new Car() {Cost = 70, MaxSpeed = 150},
                        new Car() {Cost = 45, MaxSpeed = 180},
                        new Car() {Cost = 32, MaxSpeed = 200},
                        new Car() {Cost = 82, MaxSpeed = 280},
                    };
            var selected = from car in cars
                           where car.Cost >= 50 && car.MaxSpeed >= 150
                           select new { 
                                         car.Cost,
                                         car.MaxSpeed,
                                         
                                         Max = cars.Max(car => car.MaxSpeed),
                                         Min = cars.Min(car => car.MaxSpeed),
                                         Average = cars.Average(profile => profile.MaxSpeed)
                           };

            Console.WriteLine($"avg : {cars.Average}");
            Console.WriteLine($"Min : {car.Min} : Max : {car.Max}");

            //Profile[] arrProfile =
            //{
            //    new Profile() {Name="정우성", Height=186},
            //    new Profile() {Name="김신영", Height=158},
            //    new Profile() {Name="박은빈", Height=172},
            //    new Profile() {Name="이정재", Height=178},
            //    new Profile() {Name="하하", Height=171}
            //};
            ////조인 Join 내부조인 외부조인
            //Product[] arrProduct =
            //{
            //    new Product(){Title = "서울의 봄", Star="정우성"},
            //    new Product(){Title = "cf 다수", Star="박은빈"},
            //    new Product(){Title = "이상한 변호사 우영우", Star="박은빈"},
            //    new Product(){Title = "코미디 빅리그", Star="김신영"},
            //    new Product(){Title = "오징어 게임", Star="이정재"}
            //};
            //var listProfile =
            //    from profile in arrProfile
            //    join product in arrProduct on profile.Name equals product.Star
            //    select new
            //    {
            //        Name = profile.Name,
            //        work = product.Title,
            //        Height = profile.Height
            //    };
            //Console.WriteLine("----------내부조인 결과---------");
            //foreach (var profile in listProfile)
            //{
            //    Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.work}, 키 : {profile.Height}cm");
            //}
            //listProfile =
            //    from profile in arrProfile
            //    join product in arrProduct on profile.Name equals product.Star into ps
            //    from product in ps.DefaultIfEmpty(new Product() { Title = "그런것 없음" }) // 외부조인
            //    select new
            //    {
            //        Name = profile.Name,
            //        work = product.Title,
            //        Height = profile.Height
            //    };
            //Console.WriteLine("----------외부조인 결과---------");
            //foreach (var profile in listProfile)
            //{
            //    Console.WriteLine($"이름 : {profile.Name}, 작품 : {profile.work}, 키 : {profile.Height}cm");
            //}
            //var heightStat = from profile in arrProfile
            //                 group profile by profile.Height < 175 into g
            //                 select new
            //                 {
            //                     Group = g.Key == true ? "175cm 미만" : "175cm 이상",
            //                     Count = g.Count(),
            //                     Max = g.Max(profile => profile.Height),
            //                     Min = g.Min(profile => profile.Height),
            //                     Average = g.Average(profile => profile.Height)
            //                 };
            //foreach (var stat in heightStat)
            //{
            //    Console.WriteLine($"Max : {stat.Max} : Count : {stat.Count}");
            //    Console.WriteLine($"Min : {stat.Min} : Max : {stat.Max}");
        }
        }
    }

