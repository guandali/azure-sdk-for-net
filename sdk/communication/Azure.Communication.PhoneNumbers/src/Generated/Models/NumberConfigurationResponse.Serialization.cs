// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    public partial class NumberConfigurationResponse
    {
        internal static NumberConfigurationResponse DeserializeNumberConfigurationResponse(JsonElement element)
        {
            PstnConfiguration pstnConfiguration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pstnConfiguration"))
                {
                    pstnConfiguration = PstnConfiguration.DeserializePstnConfiguration(property.Value);
                    continue;
                }
            }
            return new NumberConfigurationResponse(pstnConfiguration);
        }
    }
}
