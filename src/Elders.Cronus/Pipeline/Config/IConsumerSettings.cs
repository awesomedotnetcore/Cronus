using System;
using System.Reflection;
using Elders.Cronus.Messaging.MessageHandleScope;
using Elders.Cronus.Pipeline.Hosts;

namespace Elders.Cronus.Pipeline.Config
{
    public interface IConsumerSettings<TTransport> where TTransport : TransportSettings
    {
        CronusGlobalSettings GlobalSettings { get; set; }

        Assembly[] MessagesAssemblies { get; set; }

        TTransport Transport { get; set; }

        IEndpointConsumable Build();

        string BoundedContext { get; set; }

        ScopeFactory ScopeFactory { get; set; }

        int NumberOfWorkers { get; set; }

        void UseTransport<T>(Action<T> configure) where T : TTransport;

        void AddRegistration(Type messageType, Type messageHandlerType, Func<Type, Context, object> messageHandlerFactory);
    }
}