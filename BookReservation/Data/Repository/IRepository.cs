﻿using BookReservation.Data.Entities;
using BookReservation.Shared.Dtos;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookReservation.Server.Services.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        public Task<List<D>> GetAll<D>() where D : BaseDto;

        public Task<D> GetSingle<D>(int Id) where D : BaseDto;

        public Task<Res> Create<Req, Res>(Req req);

        public Task<Res> Update<Req, Res>(Req req, int Id);

        public Task<bool> Delete(int id);

        public Task<List<D>> Where<D>(Expression<Func<T, bool>> predicate = null) where D : BaseDto;
    }
}
