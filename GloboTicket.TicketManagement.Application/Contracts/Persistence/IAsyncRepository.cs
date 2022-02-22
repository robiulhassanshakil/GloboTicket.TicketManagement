﻿namespace GloboTicket.TicketManagement.Application.Contracts.Persistence;

public interface IAsyncRepository<T>
    where T : class
{
    Task<T> GetByIdAsync(Guid id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
}