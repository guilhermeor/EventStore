using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Domain.Entities;
using Domain.Events;
using Domain.Interfaces;
using EventStore.ClientAPI;
using Newtonsoft.Json;

namespace EventStoreExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var guid = Guid.NewGuid();
            var conn = EventStoreConnection.Create(new IPEndPoint(IPAddress.Loopback, 1113));
            conn.ConnectAsync();

            var subjects = new List<Subject>
            {
                Subject.Create("Mathmatics", 9.9),
                Subject.Create("English", 8.5),
                Subject.Create("Biological Sciences", 1.4)
            };

            var events = new List<IEvent>
            {
                new StudentCreatedEvent(guid,"Adalberto", 25, "00206784", subjects)
            };

            foreach (var e in events)
                conn.AppendToStreamAsync
                (
                    $"Student -{guid.ToString()}", ExpectedVersion.Any,
                    new EventData(Guid.NewGuid(), e.GetType().Name, true, Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(e)), null)
                );
            Console.ReadKey();
        }
    }
}