using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Qu.AlphabetSoup.Contract
{
    [ExcludeFromCodeCoverage]
    public class WordStreamRequest
    {
        public IEnumerable<string> WordStream { get; set; }
    }
}
