using System;
using System.Collections.Generic;
using System.Text;

namespace LL.MDE.Components.Qvt.Common.DataModels
{
    public interface ITransformationConfiguration
    {
        IDomainJsonSerializer JsonSerializer { get; set; }
    }
}
