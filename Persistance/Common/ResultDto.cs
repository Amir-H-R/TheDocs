using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.  Common
{
    public class ResultDto
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
    public class ResultDto<TData>
    {
        public TData Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
