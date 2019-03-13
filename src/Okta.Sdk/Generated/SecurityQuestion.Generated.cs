// <copyright file="SecurityQuestion.Generated.cs" company="Okta, Inc">
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
    public sealed partial class SecurityQuestion : Resource, ISecurityQuestion
    {
        /// <inheritdoc/>
        public string Answer 
        {
            get => GetStringProperty("answer");
            set => this["answer"] = value;
        }
        
        /// <inheritdoc/>
        public string Question 
        {
            get => GetStringProperty("question");
            set => this["question"] = value;
        }
        
        /// <inheritdoc/>
        public string QuestionText 
        {
            get => GetStringProperty("questionText");
            set => this["questionText"] = value;
        }
        
    }
}
