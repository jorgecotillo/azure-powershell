﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSAzureFirewallPolicyApplicationRuleProtocol
    {
        public string protocolType { get; set; }
        public uint port { get; set; }

        public static PSAzureFirewallPolicyApplicationRuleProtocol MapUserInputToApplicationRuleProtocol(string userInput)
        {
            var protocolRegEx = new Regex("^[hH][tT][tT][pP][sS]?(:[1-9][0-9]*)?$");

            var supportedProtocolsAndTheirDefaultPorts = new List<PSAzureFirewallPolicyApplicationRuleProtocol>
            {
                new PSAzureFirewallPolicyApplicationRuleProtocol { protocolType = MNM.AzureFirewallApplicationRuleProtocolType.Http, port = 80 },
                new PSAzureFirewallPolicyApplicationRuleProtocol { protocolType = MNM.AzureFirewallApplicationRuleProtocolType.Https, port = 443 }
            };

            //The actual validation is performed in NRP. Here we are just trying to map user info to our model
            if (!protocolRegEx.IsMatch(userInput))
            {
                throw new ArgumentException($"Invalid protocol {userInput}");
            }

            var userParts = userInput.Split(':');
            var userProtocolText = userParts[0];
            var userPortText = userParts.Length == 2 ? userParts[1] : null;

            PSAzureFirewallPolicyApplicationRuleProtocol supportedProtocol;
            try
            {
                supportedProtocol = supportedProtocolsAndTheirDefaultPorts.Single(protocol => protocol.protocolType.Equals(userProtocolText, StringComparison.InvariantCultureIgnoreCase));
            }
            catch
            {
                throw new ArgumentException($"Unsupported protocol {userProtocolText}. Supported protocols are {string.Join(", ", supportedProtocolsAndTheirDefaultPorts.Select(proto => proto.protocolType))}");
            }

            uint port;
            if (userPortText == null)
            {
                // Use default port for this protocol
                port = supportedProtocol.port;
            }
            else if (!uint.TryParse(userPortText, out port))
            {
                throw new ArgumentException($"Invalid port {userPortText}");
            }

            return new PSAzureFirewallPolicyApplicationRuleProtocol
            {
                protocolType = supportedProtocol.protocolType,
                port = port
            };
        }
    }
}
