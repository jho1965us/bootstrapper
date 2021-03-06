//-------------------------------------------------------------------------------
// <copyright file="CustomFunqlet.cs" company="Appccelerate">
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

namespace Appccelerate.Bootstrapper.Sample.Complex
{
    using System.Reflection;

    using Appccelerate.Bootstrapper.Sample.Complex.Behaviors;

    using Funq;

    using log4net;

    /// <summary>
    /// Custom funqlet implementation.
    /// </summary>
    public class CustomFunqlet : IFunqlet
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <inheritdoc />
        public void Configure(Container container)
        {
            Log.Info(" - Registering dependency in CustomFunqlet");

            container.Register<IDependency>(new Dependency());
            container.Register<IBehavior<IComplexExtension>>(ctx => new DependencyUsingBehavior(ctx.Resolve<IDependency>()));
        }
    }
}