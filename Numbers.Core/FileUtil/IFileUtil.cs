using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.Core.FileUtil
{
    public interface IFileUtil
    {
        List<String> Read(String path);
    }
}
