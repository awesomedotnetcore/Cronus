﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NMSD.Cronus.Eventing;

namespace NMSD.Cronus.DomainModelling
{
    /// <summary>
    /// Indicates the ability to store and retreive a stream of events.
    /// </summary>
    /// <remarks>
    /// Instances of this class must be designed to be multi-thread safe such that they can be shared between threads.
    /// </remarks>
    public interface IAggregateRepository
    {
        AR Update<AR>(IAggregateRootId aggregateId, Action<AR> update, Action<IAggregateRoot> save = null) where AR : IAggregateRoot;

        void Save(IAggregateRoot aggregateRoot);


    }

}