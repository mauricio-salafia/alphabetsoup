using System.Collections.Generic;
using System.Linq;

namespace Qu.AlphabetSoup.Domain.Entities
{
    public class OperationResult
    {
        public OperationResult()
        {
            Messages = Enumerable.Empty<string>();
        }

        public StatusEnum Status { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
