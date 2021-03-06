// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Static sites user roles invitation resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StaticSiteUserInvitationRequestResource : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteUserInvitationRequestResource class.
        /// </summary>
        public StaticSiteUserInvitationRequestResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StaticSiteUserInvitationRequestResource class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="domain">The domain name for the static site custom
        /// domain.</param>
        /// <param name="provider">The identity provider for the static site
        /// user.</param>
        /// <param name="userDetails">The user id for the static site
        /// user.</param>
        /// <param name="roles">The roles for the static site user, in
        /// free-form string format</param>
        /// <param name="numHoursToExpiration">The number of hours the sas
        /// token stays valid</param>
        public StaticSiteUserInvitationRequestResource(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string domain = default(string), string provider = default(string), string userDetails = default(string), string roles = default(string), int? numHoursToExpiration = default(int?))
            : base(id, name, kind, type)
        {
            Domain = domain;
            Provider = provider;
            UserDetails = userDetails;
            Roles = roles;
            NumHoursToExpiration = numHoursToExpiration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain name for the static site custom domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the identity provider for the static site user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets the user id for the static site user.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userDetails")]
        public string UserDetails { get; set; }

        /// <summary>
        /// Gets or sets the roles for the static site user, in free-form
        /// string format
        /// </summary>
        [JsonProperty(PropertyName = "properties.roles")]
        public string Roles { get; set; }

        /// <summary>
        /// Gets or sets the number of hours the sas token stays valid
        /// </summary>
        [JsonProperty(PropertyName = "properties.numHoursToExpiration")]
        public int? NumHoursToExpiration { get; set; }

    }
}
