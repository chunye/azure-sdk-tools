﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ManagedCache
{
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.New, "AzureManagedCache")]
    public class NewAzureManagedCache : ManagedCacheCmdletBase
    {
        private string cacheServiceName;

        [Parameter(Position = 0, Mandatory=true )]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Location { get; set;}

        [Parameter(Position = 2, Mandatory = false)]
        [ValidateSet("Basic", "Standard", "Premium", IgnoreCase = true)]
        public string Sku { get; set; }

        [Parameter(Position = 3, Mandatory = false)]
        public string Memory { get; set; }

        public override void ExecuteCmdlet()
        {
            //TODO, validate the Name, length much be between 6~20;
            //Only lower case letter and number, and start with letter
            cacheServiceName = Name.ToLower();

            WriteVerbose(string.Format(Properties.Resources.CreatingCacheServiceStarted, cacheServiceName));
            
            WriteObject(CacheClient.CreateCacheService(
                CurrentSubscription.SubscriptionId,
                cacheServiceName,
                Location,
                Sku,
                Memory));
        }
    }
}