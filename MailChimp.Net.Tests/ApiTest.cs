﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;
using Xunit;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The api test.
    /// </summary>
    public class ApiTest : MailChimpTest
    {
        /// <summary>
        /// The should_ return_ ap i_ information.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task Should_Return_API_Information()
        {
            var apiInfo = await this.MailChimpManager.Api.GetInfoAsync();
            Assert.NotNull(apiInfo);
        }
    }
}