// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Response from a List Datasources request. If successful, it includes the full definitions of all datasources. </summary>
    internal partial class ListDataSourcesResult
    {
        /// <summary> Initializes a new instance of ListDataSourcesResult. </summary>
        internal ListDataSourcesResult()
        {
        }

        /// <summary> Initializes a new instance of ListDataSourcesResult. </summary>
        /// <param name="dataSources"> The datasources in the Search service. </param>
        internal ListDataSourcesResult(IList<DataSource> dataSources)
        {
            DataSources = dataSources;
        }

        /// <summary> The datasources in the Search service. </summary>
        public IList<DataSource> DataSources { get; internal set; } = new List<DataSource>();
    }
}