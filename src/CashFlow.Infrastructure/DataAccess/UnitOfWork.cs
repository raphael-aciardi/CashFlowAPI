﻿using CashFlow.Domain.Repositories;

namespace CashFlow.Infrastructure.DataAccess;

internal class UnitOfWork : IUnitOfWork
{
    private readonly CashFlowDbContext _context;
    public UnitOfWork(CashFlowDbContext context)
    {
        _context = context;
    }

    public void Commit() => _context.SaveChanges();
    
}
