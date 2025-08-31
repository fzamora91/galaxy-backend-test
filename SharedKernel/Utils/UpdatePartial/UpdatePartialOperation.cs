using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Utils.UpdatePartial
{
    public class UpdatePartialOperation
    {
        public string Op { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public object? Value { get; set; } = null;

        public UpdatePartialOperation(
            string op,
            string path,
            object? value = null
        )
        {
            Op = op;
            Path = path;
            Value = value;
        }
    }
}
