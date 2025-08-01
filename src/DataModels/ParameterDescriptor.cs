using System;

namespace LL.MDE.Components.Qvt.Common.DataModels
{
    public class ParameterDescriptor
    {
        public string Name {  get; set; }

        public string ParameterType 
        {
            get
            {
                string result = "";

                if (DotNetType != null)
                {
                    result = DotNetType.Name;
                }

                return result;
            }
        }
    
        public Type DotNetType { get; set; }

        public string Namespace 
        { 
            get
            {
                return DotNetType?.Namespace;
            }
        }

        public DomainParameterType DomainParameterType { get; set; }

        public object ParameterInstance { get; set; }

        public object RepositoryInstance { get; set; }

        public string SerializationFilename { get; set; }
    }
}
