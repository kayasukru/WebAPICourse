using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    //[Serializable]
    public record ProjectDto
    {
        public Guid Id { get; init; }
        public string name { get; init; }
        public string description { get; init; }
        public string Field { get; init; }
    };
}
