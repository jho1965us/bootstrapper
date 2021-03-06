﻿//-------------------------------------------------------------------------------
// <copyright file="ConsumeConfiguration.cs" company="Appccelerate">
//   Copyright (c) 2008-2014
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.Bootstrapper.Configuration.Internals
{
    using System.Collections.Generic;

    /// <summary>
    /// Default IConsumeConfiguration
    /// </summary>
    public class ConsumeConfiguration : IConsumeConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumeConfiguration"/> class.
        /// </summary>
        /// <param name="extension">The extension.</param>
        public ConsumeConfiguration(IExtension extension)
        {
            var consumeConfiguration = extension as IConsumeConfiguration;

            this.Configuration = consumeConfiguration != null
                ? consumeConfiguration.Configuration
                : new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the configuration dictionary which is filled by the producer.
        /// </summary>
        public IDictionary<string, string> Configuration { get; private set; }
    }
}