// <copyright file="OpenIdConnectApplication.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Abstractions;

namespace Okta.Sdk
{
    /// <inheritdoc/>
    public sealed partial class OpenIdConnectApplication : Application, IOpenIdConnectApplication
    {
        /// <inheritdoc/>
        public new IOAuthApplicationCredentials Credentials 
        {
            get => GetResourceProperty<OAuthApplicationCredentials>("credentials");
            set => this["credentials"] = value;
        }
        
        /// <inheritdoc/>
        public new string Name 
        {
            get => GetStringProperty("name");
            set => this["name"] = value;
        }
        
        /// <inheritdoc/>
        public new IOpenIdConnectApplicationSettings Settings 
        {
            get => GetResourceProperty<OpenIdConnectApplicationSettings>("settings");
            set => this["settings"] = value;
        }
        
    }
}
