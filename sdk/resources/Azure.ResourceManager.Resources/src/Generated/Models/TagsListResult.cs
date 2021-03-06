// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> List of subscription tags. </summary>
    public partial class TagsListResult
    {
        /// <summary> Initializes a new instance of TagsListResult. </summary>
        internal TagsListResult()
        {
            Value = new ChangeTrackingList<TagDetails>();
        }

        /// <summary> Initializes a new instance of TagsListResult. </summary>
        /// <param name="value"> An array of tags. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal TagsListResult(IReadOnlyList<TagDetails> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of tags. </summary>
        public IReadOnlyList<TagDetails> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
