//using System;

//namespace _06_16_CSharpLinq;


//    class Profile
//    {
//        public string Name { get; set; }
//        public int Height { get; set; } 
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Profile[] arrProfile =
//            {
//                new Profile() {Name = "정우성", Height = 186},
//                new Profile() {Name = "이정재", Height = 178},
//                new Profile() {Name = "김혜수", Height = 170},
//                new Profile() {Name = "이병헌", Height = 175},
//                new Profile() {Name = "하하", Height = 171},
//            };
       #region List 메서드를 이용해서 데이터 정렬
//        //List<Profile> profiles = new List<Profile>();
//        //    foreach (Profile profile in arrProfile)
//        //    {
//        //        if (profile.Height >= 175)
//        //        {
//        //            profiles.Add(profile);
//        //        }
//        //    }

//        //        profiles.Sort(
//        //            (profile1, profile2) =>
//        //            {
//        //                return profile1.Height - profile2.Height;
//        //            });
//        //        foreach(Profile profile in profiles)
//        //            Console.WriteLine($"{profile.Name}:{profile.Height}");

//        //LINQ를 사용해서 간편하게 써보자
        #endregion

       #region LINQ 메서드를 이용해서 데이터 추출 및 정렬
//        //var profiles = from profile in arrProfile // arrProfile 안에 있는 각데이터로부터 
//        //               where profile.Height < 175 // 조건: 신장 175cm 미만인 데이터
//        //               orderby profile.Height // 정렬: 신장 오름차순
//        //               select profile; // profile 객체 추출     
//        //foreach(Profile profile in profiles)
//        //{
//        //    Console.WriteLine($"{profile.Name}:{profile.Height}");
//        //}
        #endregion

//        // int[] numbers = new int[] { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
//        // LinQ를 이용해서 데이터를 가공후 추출
//        //var profiles = from profile in arrProfile // numbers 안에 있는 각 데이터로부터
//        //             where profile.Height >= 175 // 조건: 짝수인 데이터
//        //             orderby profile.Height// 정렬: 내림차순
//        //             select new // Cm를 Inch로 수정
//        //             {
//        //                 Name = profile.Name,
//        //                 InchHeight = profile.Height * 0.393701 // cm를 inch로 변환
//        //             };// in 객체 추출
//        //foreach (var profile in profiles)
//        //    Console.WriteLine($"{profile.Name} {profile.InchHeight}");
//    }
//}

