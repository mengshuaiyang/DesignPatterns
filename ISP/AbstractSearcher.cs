using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //抽象类星探
    public abstract class AbstractSearcher
    {
        #region 身材型美女
        protected IGoodBodyGirl goodBodyGirl;

        public AbstractSearcher(IGoodBodyGirl _goodBodyGirl)
        {
            this.goodBodyGirl = _goodBodyGirl;
        }
        #endregion

        #region 气质型美女
        protected IGreatTemperamentGirl greatTemperamentGirl;

        public AbstractSearcher(IGreatTemperamentGirl _greatTemperamentGirll)
        {
            this.greatTemperamentGirl = _greatTemperamentGirll;
        }
        #endregion

        //搜索美女，列出美女信息
        public abstract void show(IGoodBodyGirl goodBodyGirl);
        public abstract void show(IGreatTemperamentGirl goodBodyGirl);
    }
}
