﻿namespace RtaAssignment.Infrastructure.UnitOfWork
{
    public class TransactionScopeUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new TransactionScopeUnitOfWork();
        }
    }
}