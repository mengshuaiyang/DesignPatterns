using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoD
{
    public class Teacher
    {
        //老师对学生发布命令，清一下女生
        public void Commond(GroupLeader groupLeader)
        {
            //告诉体育委员开始执行清查任务
            groupLeader.CountGirls();
        }
    }
}
