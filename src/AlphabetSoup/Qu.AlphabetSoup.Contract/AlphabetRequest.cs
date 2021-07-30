using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Qu.AlphabetSoup.Contract
{
    [ExcludeFromCodeCoverage]
    public class AlphabetRequest
    {
        public IEnumerable<string> Matrix { get; set; }
        public WordStreamRequest WordStream { get; set; }
    }
}
