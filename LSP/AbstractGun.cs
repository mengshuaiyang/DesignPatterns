using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //枪支的抽象类（抽象类是一个不完全的类，是对对象的抽象，而接口是一种行为规范。）
    public abstract class AbstractGun
    {
        //枪用来干什么的？杀敌！
        public abstract void shoot();
    }

    //手枪
    public class Handgun : AbstractGun
    {
        //手枪的特点是携带方便，射程短
        public override void shoot()
        {
            Console.WriteLine("手枪射击...");
        }
    }

    //步枪
    public class Rifle : AbstractGun
    {
        //步枪的特点是射程远，威力大
        public override void shoot()
        {
            Console.WriteLine("手枪射击...");
        }
    }

    public class AUG : Rifle
    {
        //狙击枪都携带一个精准的望远镜
        public void zoomOut()
        {
            Console.WriteLine("通过望远镜察看敌人...");
        }

        public override void shoot()
        {
            Console.WriteLine("AUG射击...");
        }
    }

    //机枪
    public class MachineGun : AbstractGun
    {
        //机枪的特点是连发射击
        public override void shoot()
        {
            Console.WriteLine("机枪扫射...");
        }
    }

    //玩具枪
    public class ToyGun : AbstractGun
    {
        //玩具枪是不能射击的，但是编译器又要求实现这个方法，怎么办？虚构一个呗！
        public override void shoot()
        {
            //玩具枪不能射击，这个方法就不实现了
            Console.WriteLine("玩具枪不能射击...");
        }
    }
}
