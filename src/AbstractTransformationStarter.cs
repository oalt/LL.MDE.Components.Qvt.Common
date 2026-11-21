using LL.MDE.Components.Qvt.Common.DataModels;
using System.Collections.Generic;

namespace LL.MDE.Components.Qvt.Common
{
    public abstract class AbstractTransformationStarter : ITransformationStarter
    {
        protected ITransformationDescriptor TransformationDescriptor { get; set; }

        public AbstractTransformationStarter(ITransformationDescriptor descriptor)
        {
            TransformationDescriptor = descriptor;
        }

        protected List<object> CallParameters
        {
            get
            {
                List<object> result = new List<object>();

                foreach(ParameterDescriptor parameter in TransformationDescriptor.Parameters)
                {
                    result.Add(parameter.ParameterInstance);
                }

                return result;
            }
        }

        public abstract void StartTransformation();
    }
}
