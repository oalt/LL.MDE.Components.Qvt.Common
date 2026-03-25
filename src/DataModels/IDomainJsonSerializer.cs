using System;

namespace LL.MDE.Components.Qvt.Common.DataModels
{
    public interface IDomainJsonSerializer
    {
        void SerializeToJsonFile(string path, Type type, object data);
    }
}
