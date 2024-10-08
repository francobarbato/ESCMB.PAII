﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.application.bus.query
{
        public class QueryRequest<TResponse> : IRequestQuery<TResponse>
             where TResponse : class
        {
            public uint PageIndex { get; set; }
            public uint PageSize { get; set; }
        }
    
}
