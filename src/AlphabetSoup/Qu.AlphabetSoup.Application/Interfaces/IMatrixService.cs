using System.Collections.Generic;
using System.Threading.Tasks;

namespace Qu.AlphabetSoup.Application.Interfaces
{
    public interface IMatrixService
    {
        Task CreateMatrixAsync(IEnumerable<string> matrix);
    }
}
