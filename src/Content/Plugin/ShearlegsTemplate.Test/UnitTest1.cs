using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using Shearlegs.API.Plugins;
using Shearlegs.API.Plugins.Result;
using Shearlegs.Core.Plugins.Result;
using Shearlegs.Runtime;
using Shearlegs.Testing;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ShearlegsTemplate.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            object parameters = new
            {
                Text = "Hello World!"
            };

            PluginTextResult result = await ShearlegsTest.ExecutePluginAsync<ShearlegsTemplatePlugin, PluginTextResult>(parameters);
            ShearlegsTest.Results.Print(result);
        }
    }
}
