using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MattNedrich.RedditAccessLibrary.JsonObjects
{
    public class ThingConverter : Newtonsoft.Json.Converters.CustomCreationConverter<Thing>
    {
        private string nextType = null;
        public override Thing Create(Type objectType)
        {
            throw new NotImplementedException();
        }

        public Thing Create(Type objectType, JObject jObject)
        {
            string type = (string)jObject.Property("kind");
            if (nextType == null)
            {
                nextType = type;
                return new Thing();
            }
            else
            {
                if (nextType == "t3")
                {
                    nextType = type;
                    return new Post();
                }
                if (nextType == "Listing")
                {
                    nextType = type;
                    return new Listing();
                }
                else
                    return new Thing();
            }
            throw new ArgumentException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            var target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }
    }
}
