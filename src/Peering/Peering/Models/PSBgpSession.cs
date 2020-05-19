// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties that define a BGP session.
    /// </summary>
    public partial class PSBgpSession
    {
        /// <summary>
        /// Initializes a new instance of the PSBgpSession class.
        /// </summary>
        public PSBgpSession()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSBgpSession class.
        /// </summary>
        /// <param name="sessionPrefixV4">The IPv4 prefix that contains both
        /// ends' IPv4 addresses.</param>
        /// <param name="sessionPrefixV6">The IPv6 prefix that contains both
        /// ends' IPv6 addresses.</param>
        /// <param name="microsoftSessionIPv4Address">The IPv4 session address
        /// on Microsoft's end.</param>
        /// <param name="microsoftSessionIPv6Address">The IPv6 session address
        /// on Microsoft's end.</param>
        /// <param name="peerSessionIPv4Address">The IPv4 session address on
        /// peer's end.</param>
        /// <param name="peerSessionIPv6Address">The IPv6 session address on
        /// peer's end.</param>
        /// <param name="sessionStateV4">The state of the IPv4 session.
        /// Possible values include: 'None', 'Idle', 'Connect', 'Active',
        /// 'OpenSent', 'OpenConfirm', 'OpenReceived', 'Established',
        /// 'PendingAdd', 'PendingUpdate', 'PendingRemove'</param>
        /// <param name="sessionStateV6">The state of the IPv6 session.
        /// Possible values include: 'None', 'Idle', 'Connect', 'Active',
        /// 'OpenSent', 'OpenConfirm', 'OpenReceived', 'Established',
        /// 'PendingAdd', 'PendingUpdate', 'PendingRemove'</param>
        /// <param name="maxPrefixesAdvertisedV4">The maximum number of
        /// prefixes advertised over the IPv4 session.</param>
        /// <param name="maxPrefixesAdvertisedV6">The maximum number of
        /// prefixes advertised over the IPv6 session.</param>
        /// <param name="md5AuthenticationKey">The MD5 authentication key of
        /// the session.</param>
        public PSBgpSession(string sessionPrefixV4 = default(string), string sessionPrefixV6 = default(string), string microsoftSessionIPv4Address = default(string), string microsoftSessionIPv6Address = default(string), string peerSessionIPv4Address = default(string), string peerSessionIPv6Address = default(string), string sessionStateV4 = default(string), string sessionStateV6 = default(string), int? maxPrefixesAdvertisedV4 = default(int?), int? maxPrefixesAdvertisedV6 = default(int?), string md5AuthenticationKey = default(string))
        {
            SessionPrefixV4 = sessionPrefixV4;
            SessionPrefixV6 = sessionPrefixV6;
            MicrosoftSessionIPv4Address = microsoftSessionIPv4Address;
            MicrosoftSessionIPv6Address = microsoftSessionIPv6Address;
            PeerSessionIPv4Address = peerSessionIPv4Address;
            PeerSessionIPv6Address = peerSessionIPv6Address;
            SessionStateV4 = sessionStateV4;
            SessionStateV6 = sessionStateV6;
            MaxPrefixesAdvertisedV4 = maxPrefixesAdvertisedV4;
            MaxPrefixesAdvertisedV6 = maxPrefixesAdvertisedV6;
            Md5AuthenticationKey = md5AuthenticationKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IPv4 prefix that contains both ends' IPv4
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "sessionPrefixV4")]
        public string SessionPrefixV4 { get; set; }

        /// <summary>
        /// Gets or sets the IPv6 prefix that contains both ends' IPv6
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "sessionPrefixV6")]
        public string SessionPrefixV6 { get; set; }

        /// <summary>
        /// Gets or sets the IPv4 session address on Microsoft's end.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftSessionIPv4Address")]
        public string MicrosoftSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the IPv6 session address on Microsoft's end.
        /// </summary>
        [JsonProperty(PropertyName = "microsoftSessionIPv6Address")]
        public string MicrosoftSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets or sets the IPv4 session address on peer's end.
        /// </summary>
        [JsonProperty(PropertyName = "peerSessionIPv4Address")]
        public string PeerSessionIPv4Address { get; set; }

        /// <summary>
        /// Gets or sets the IPv6 session address on peer's end.
        /// </summary>
        [JsonProperty(PropertyName = "peerSessionIPv6Address")]
        public string PeerSessionIPv6Address { get; set; }

        /// <summary>
        /// Gets the state of the IPv4 session. Possible values include:
        /// 'None', 'Idle', 'Connect', 'Active', 'OpenSent', 'OpenConfirm',
        /// 'OpenReceived', 'Established', 'PendingAdd', 'PendingUpdate',
        /// 'PendingRemove'
        /// </summary>
        [JsonProperty(PropertyName = "sessionStateV4")]
        public string SessionStateV4 { get; private set; }

        /// <summary>
        /// Gets the state of the IPv6 session. Possible values include:
        /// 'None', 'Idle', 'Connect', 'Active', 'OpenSent', 'OpenConfirm',
        /// 'OpenReceived', 'Established', 'PendingAdd', 'PendingUpdate',
        /// 'PendingRemove'
        /// </summary>
        [JsonProperty(PropertyName = "sessionStateV6")]
        public string SessionStateV6 { get; private set; }

        /// <summary>
        /// Gets or sets the maximum number of prefixes advertised over the
        /// IPv4 session.
        /// </summary>
        [JsonProperty(PropertyName = "maxPrefixesAdvertisedV4")]
        public int? MaxPrefixesAdvertisedV4 { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of prefixes advertised over the
        /// IPv6 session.
        /// </summary>
        [JsonProperty(PropertyName = "maxPrefixesAdvertisedV6")]
        public int? MaxPrefixesAdvertisedV6 { get; set; }

        /// <summary>
        /// Gets or sets the MD5 authentication key of the session.
        /// </summary>
        [JsonProperty(PropertyName = "md5AuthenticationKey")]
        public string Md5AuthenticationKey { get; set; }

    }
}
