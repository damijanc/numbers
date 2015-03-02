using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAXperts.Core.ParseUtil
{
    public interface IParseUtil
    {
        List<int> Parse(List<String> lines);
    }
}
