﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace Routescan.Core.Converters
{
    public class StringToLongConvertor : JsonConverter<long>
    {
        public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                _ = long.TryParse(reader.GetString(), out long result);
                return result;
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt64();
            }
            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
            //throw new InvalidOperationException($"Unable to parse {value} to long");
        }
    }
}
