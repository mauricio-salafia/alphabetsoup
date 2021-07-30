using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qu.AlphabetSoup.Contract
{
    public class OperationResponse
    {
        public OperationResponse()
        {
            Messages = Enumerable.Empty<string>();
        }

        public StatusResponseEnum Status { get; set; }
        public IEnumerable<string> Messages { get; set; }
    }
}
