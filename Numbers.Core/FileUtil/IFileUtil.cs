using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAXperts.Core.FileUtil
{
    public interface IFileUtil
    {
        List<String> Read(String path);
    }
}
