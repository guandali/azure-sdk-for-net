// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Routing rules to apply to an endpoint
    /// </summary>
    public partial class RoutingRuleUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RoutingRuleUpdateParameters
        /// class.
        /// </summary>
        public RoutingRuleUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingRuleUpdateParameters
        /// class.
        /// </summary>
        /// <param name="frontendEndpoints">Frontend endpoints associated with
        /// this rule</param>
        /// <param name="acceptedProtocols">Protocol schemes to match for this
        /// rule</param>
        /// <param name="patternsToMatch">The route patterns of the
        /// rule.</param>
        /// <param name="enabledState">Whether to enable use of this rule.
        /// Permitted values are 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="routeConfiguration">A reference to the routing
        /// configuration.</param>
        /// <param name="rulesEngine">A reference to a specific Rules Engine
        /// Configuration to apply to this route.</param>
        /// <param name="webApplicationFirewallPolicyLink">Defines the Web
        /// Application Firewall policy for each routing rule (if
        /// applicable)</param>
        public RoutingRuleUpdateParameters(IList<SubResource> frontendEndpoints = default(IList<SubResource>), IList<string> acceptedProtocols = default(IList<string>), IList<string> patternsToMatch = default(IList<string>), string enabledState = default(string), RouteConfiguration routeConfiguration = default(RouteConfiguration), SubResource rulesEngine = default(SubResource), RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink = default(RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink))
        {
            FrontendEndpoints = frontendEndpoints;
            AcceptedProtocols = acceptedProtocols;
            PatternsToMatch = patternsToMatch;
            EnabledState = enabledState;
            RouteConfiguration = routeConfiguration;
            RulesEngine = rulesEngine;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frontend endpoints associated with this rule
        /// </summary>
        [JsonProperty(PropertyName = "frontendEndpoints")]
        public IList<SubResource> FrontendEndpoints { get; set; }

        /// <summary>
        /// Gets or sets protocol schemes to match for this rule
        /// </summary>
        [JsonProperty(PropertyName = "acceptedProtocols")]
        public IList<string> AcceptedProtocols { get; set; }

        /// <summary>
        /// Gets or sets the route patterns of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "patternsToMatch")]
        public IList<string> PatternsToMatch { get; set; }

        /// <summary>
        /// Gets or sets whether to enable use of this rule. Permitted values
        /// are 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets a reference to the routing configuration.
        /// </summary>
        [JsonProperty(PropertyName = "routeConfiguration")]
        public RouteConfiguration RouteConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a reference to a specific Rules Engine Configuration
        /// to apply to this route.
        /// </summary>
        [JsonProperty(PropertyName = "rulesEngine")]
        public SubResource RulesEngine { get; set; }

        /// <summary>
        /// Gets or sets defines the Web Application Firewall policy for each
        /// routing rule (if applicable)
        /// </summary>
        [JsonProperty(PropertyName = "webApplicationFirewallPolicyLink")]
        public RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get; set; }

    }
}
