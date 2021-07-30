using System.Collections.Generic;

namespace Qu.AphabetSoup.Service.Interfaces
{
    public interface IWordFinder
    {
        IEnumerable<string> Find(IEnumerable<string> wordstream);
    }
}
