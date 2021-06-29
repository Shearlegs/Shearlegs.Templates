using Shearlegs.API.Plugins.Result;
using Shearlegs.Core.Plugins;
using System.Threading.Tasks;

namespace ShearlegsTemplate
{
    public class ShearlegsTemplatePlugin : Plugin
    {
        private readonly ShearlegsTemplateParameters parameters;

        public ShearlegsTemplatePlugin(ShearlegsTemplateParameters parameters)
        {
            this.parameters = parameters;
        }

        public override Task<IPluginResult> ExecuteAsync()
        {
            return Task.FromResult(Text("Your Text parameter input: " + parameters.Text));
        }
    }
}
