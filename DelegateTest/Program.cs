using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///委托

namespace DelegateTest
{
    class Program
    {
        //定义一个MyDel委托类型，其签名接收两个string类型参数，返回类型也为string
        public delegate string MyDel(string nm,string pwd);

        static void Main(string[] args)
        {
            //声明MyDel类型的md变量
            MyDel md;
            Console.WriteLine("请输入2个参数，并用逗号分隔");
            //将用户输入值赋值给InputValue变量
            string InputValue = Console.ReadLine();
            //获取英文逗号在InputValue变量中书索引值，并赋值给Pos变量
            int Pos = InputValue.IndexOf(",");
            //将英文逗号前面的部分的子字符串赋值给ValueA变量
            string ValueA = InputValue.Substring(0, Pos);
            //将英文逗号后面的部分的子字符串赋值给ValueB变量
            string ValueB = InputValue.Substring(Pos + 1);
            Console.WriteLine("请输入A,B,C,D以确定所调用的方法");
            //将用户输入值转换为大写，并赋值给InputMenthod方法
            string InputMenthod = Console.ReadLine().ToUpper();
            switch (InputMenthod)
            {
                case "A":
                    //如果用户输入A或a，则创建MyDel委托对象，其引用变量为md，指向formatA方法
                    md = new MyDel(formatA);
                    break;
                case "B":
                    //如果用户输入B或b，则创建MyDel委托对象，其引用变量为md，指向formatB方法
                    md = new MyDel(formatB);
                    break;
                case "C":
                    //如果用户输入C或c，则创建MyDel委托对象，其引用变量为md，指向Another类的formatC方法
                    md = new MyDel(Another.formatC);
                    break;
                case "D":
                    //如果用户输入D或d，则创建MyDel委托对象，其引用变量为md，指向Another类的formatD方法
                    Another ano = new Another();
                    md = new MyDel(ano.formatD);
                    break;
                default:
                    md = new MyDel(formatA);
                    break;
            }

            string resule = md(ValueA, ValueB);
            Console.WriteLine("\n\t==============以下为委托方法执行结果==================");
            Console.WriteLine(resule);

        }

        static string formatA(string a, string b)
        {
            string words = "I am the first static method,I belong to Another class.\n My name is " + a + "\n My password is" + b;
            words+= "\n 我的名字是：" + a + "\n我的密码是：" + b;
            return words;
        }

        static string formatB(string a, string b)
        {
            string words = "I am the second static method,I belong to Another class.\n My name is " + a + "\n My password is" + b;
            words += "\n 我的名字是：" + a + "\n我的密码是：" + b;
            return words;
        }
    }

    //定义外部类，其内含静态方法和实例方法符合MyDel委托类型签名
    class Another
    {
        internal static string formatC(string a, string b)
        {
            string words = "I am the third static method,I belong to Another class.\n My name is " + a + "\n My password is" + b;
            return words;
        }

        internal string formatD(string a,string b)
        {
            string words = "\n我是1个实例方法，我所属的对象实例是Another类所构造的。\n 我的名字是：" + a + "\n我的密码是：" + b;
            return words;
        }
    }
}
