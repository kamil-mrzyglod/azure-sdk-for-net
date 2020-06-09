// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourceLinkProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SourceId != null)
            {
                writer.WritePropertyName("sourceId");
                writer.WriteStringValue(SourceId);
            }
            writer.WritePropertyName("targetId");
            writer.WriteStringValue(TargetId);
            if (Notes != null)
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            writer.WriteEndObject();
        }

        internal static ResourceLinkProperties DeserializeResourceLinkProperties(JsonElement element)
        {
            string sourceId = default;
            string targetId = default;
            string notes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetId"))
                {
                    targetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notes = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceLinkProperties(sourceId, targetId, notes);
        }
    }
}