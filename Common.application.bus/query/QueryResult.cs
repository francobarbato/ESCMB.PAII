﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.application.bus.query
{
    public class QueryResult<TEntity>
    where TEntity : class
    {
        public long Count { get; private set; }
        public IEnumerable<TEntity> Items { get; private set; }
        public uint PageIndex { get; private set; }
        public uint PageSize { get; private set; }

        public QueryResult(IEnumerable<TEntity> items, long count, uint pageSize, uint pageIndex)
        {
            Items = items;
            Count = count;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
    }
}
