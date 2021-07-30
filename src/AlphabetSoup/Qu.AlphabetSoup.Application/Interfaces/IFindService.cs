using System.Collections.Generic;
using System.Threading.Tasks;

namespace Qu.AlphabetSoup.Application.Interfaces
{
    public interface IFindService
    {
        Task<IEnumerable<string>> FindAsync(IEnumerable<string> wordstream);
    }
}
