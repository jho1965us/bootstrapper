//-------------------------------------------------------------------------------
// <copyright file="LoadConfigurationSectionTest.cs" company="Appccelerate">
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

namespace Appccelerate.Bootstrapper.Configuration
{
    using Appccelerate.Bootstrapper.Configuration.Internals;
    using FakeItEasy;
    using Xunit;

    public class LoadConfigurationSectionTest
    {
        private const string AnyName = "AnyName";

        [Fact]
        public void GetSection_ExtensionIsILoadExtensionConfigurationSection_ShouldDelegateLoadingToExtension()
        {
            var extension = A.Fake<IExtension>(builder => builder.Implements(typeof(ILoadConfigurationSection)));
            var loader = extension as ILoadConfigurationSection;

            var testee = new LoadConfigurationSection(extension);
            testee.GetSection(AnyName);

            A.CallTo(() => loader.GetSection(AnyName)).MustHaveHappened();
        }
    }
}