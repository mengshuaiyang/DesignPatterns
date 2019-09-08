using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1587
/// <summary>
/// 迪米特法则：迪米特法则的核心观念就是类间解耦，弱耦合，只有弱耦合了以后，类的复用率才可以提高。
/// 1.一个对象应该对其他对象有最少的了解。
/// 2.迪米特法则要求类“羞涩”一点，尽量不要对外公布太多的public方法和非静态的public变量，尽量内敛，多使用private、package-private、protected等访问权限。
/// 3. 是自己的就是自己的：如果一个方法放在本类中，既不增加类间关系，也对本类不产生负面影响，那就放置在本类中。
/// 4. 谨慎使用Serializable
/// </summary>
#pragma warning restore 1587

namespace LoD
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生一个女生群体
            ArrayList<Girl> listGirls = new ArrayList<Girl>();
            //初始化女生
            for (int i = 0; i < 20; i++)
            {
                listGirls.Add(new Girl());
            }
            Teacher teacher = new Teacher();
            //老师发布命令
            teacher.Commond(new GroupLeader(listGirls));
        }
    }
}
