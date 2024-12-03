using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //士兵的实现类
    public class Soldier
    {
        //定义士兵的枪支
        private AbstractGun gun;
        //给士兵一支枪
        public void setGun(AbstractGun _gun)
        {
            this.gun = _gun;
        }

        //定义killEnemydelegate委托类型，其签名为AbstractGun类型参数
        //public delegate void killEnemydelegate(AbstractGun gun);
        public void killEnemy()
        {
            Console.WriteLine("士兵用手枪，开始杀敌人...\n");
            gun.shoot();
        }


        //public void killEnemy(Handgun nandgun)
        //{
        //    gun.shoot();
        //    Console.WriteLine("士兵用手枪，开始杀敌人...\n");
        //}

        //public void killEnemy(Rifle rifle)
        //{
        //    gun.shoot();
        //    Console.WriteLine("士兵用步枪，开始杀敌人...\n");
        //}

        //public void killEnemy(MachineGun machineGun)
        //{
        //    gun.shoot();
        //    Console.WriteLine("士兵用机枪，开始杀敌人...\n");
        //}

        //public void killEnemy(AUG aug)
        //{
        //    //首先看看敌人的情况，别杀死敌人，自己也被人干掉
        //    aug.zoomOut();
        //    //开始射击
        //    aug.shoot();
        //    Console.WriteLine("士兵用AUG，开始杀敌人...\n");
        //}

        //public void killEnemy(ToyGun toyGun)
        //{
        //    gun.shoot();
        //    Console.WriteLine("玩具枪不能杀人...\n");
        //}
    }
}
