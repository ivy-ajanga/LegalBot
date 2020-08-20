// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Schema;

namespace Microsoft.BotBuilderSamples
{
    /// <summary>
    /// This is our application state. Just a regular serializable .NET class.
    /// </summary>
    public class UserProfile
    {
        public string Language { get; set; }

        public string Name { get; set; }

        public string County { get; set; }

        public string Subcounty { get; set; }
       

        public string Ward { get; set; }
    }
}
