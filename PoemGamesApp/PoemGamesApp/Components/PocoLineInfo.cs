using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoemGamesApp.Components
{
    public class PocoLineInfo
    {
        /// <summary>
        /// 行id
        /// </summary>
        public int PeomLineId { get; set; }
        /// <summary>
        /// 唐诗id
        /// </summary>
        public int PeomId { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string LineContent { get; set; }
        /// <summary>
        /// 诗中的顺序
        /// </summary>
        public int Order { get; set; }
    }
}
