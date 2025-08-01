using System.Collections.Generic;

namespace LL.MDE.Components.Qvt.Common.DataModels
{
    public interface ITransformationDescriptor
    {
        string TransformationName { get; set; }

        string TopRelationName { get; set; }

        List<ParameterDescriptor> Parameters { get; set; }

        ITransformationStarter TransformationStarter { get; set; }
    }
}
