using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _05_08_Inheritance
{
    internal class ArmorSuit
    {
        // 물려줄땐 virtual 상속 받을땐 override -> 중요) 다형성
        // 자식 클래스에게 메서드를 물려줄때 virtual을 사용한다.
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuit");
        }
    }
     class IronMan : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");

        }

    }
    class WarMachin : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Doble-Barrel Cannon Armed");
            Console.WriteLine("Micro -Rocket Launcher");

        }
    }
}
