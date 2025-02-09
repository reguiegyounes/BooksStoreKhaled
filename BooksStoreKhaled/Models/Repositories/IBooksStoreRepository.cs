﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStoreKhaled.Models.Repositories
{
    public interface IBooksStoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void add(TEntity entity);
        void update(int id,TEntity entity);
        void delete(int id);
    }
}
