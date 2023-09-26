using AutoMapper.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Common.Exceptions
{
    public class NotFoundExcrption : Exception
    {
        public NotFoundExcrption() : base()
        {
            
        }
        public NotFoundExcrption(string message) : base(message)
        {
            
        }

        public NotFoundExcrption(string message, Exception innerException) : base(message)
        {

        }

        public NotFoundExcrption(string name, object key) : base($"Enity \"{name}\" ({key}) was not found.")
        {

        }

        public NotFoundExcrption(string name, object key, string message) : base(JsonSerializer.Serialize(new 
        { 
            DebugMessage = $"Enity {name} with Id: ({key}) was not found.",
            Message = message
        }, new JsonSerializerOptions { Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping}))
        {

        }
    }
}
