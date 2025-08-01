using System.Collections.Generic;

namespace LL.MDE.Components.Qvt.Common.DataModels
{
    public class AbstractTransformationDescriptor : ITransformationDescriptor
    {
        public string TransformationName { get; set; } = "<Unnamed Transformation>";

        public string TopRelationName { get; set; } = "<Unnamed top relation>";
        
        public List<ParameterDescriptor> Parameters { get; set; } = new List<ParameterDescriptor>();
        
        public ITransformationStarter TransformationStarter { get; set; }
    }
}
