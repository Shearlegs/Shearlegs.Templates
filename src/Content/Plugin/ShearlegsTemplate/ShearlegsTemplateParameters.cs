using Shearlegs.API.Plugins.Attributes;
using Shearlegs.Core.Plugins;

namespace ShearlegsTemplate
{
    public class ShearlegsTemplateParameters : Parameters
    {
        [Parameter(Description = "This is a text parameter for plugin output", IsRequired = true)]
        public string Text { get; set; }
    }
}
