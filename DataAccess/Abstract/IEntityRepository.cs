﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constrait
    // class : referans tip anlamında kullandık bir alt satırdakini
    // IEntity --> T ya IEntity olabilir ya da IEntity'den implemente edilmiş bir şey olabilir anlamında kullandık
    // new() --> new'lenebilir olmalı (IEntity interface olduğundan newlenemez)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        // filtre yoksa tüm datayı istiyor demektir (filter)
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
