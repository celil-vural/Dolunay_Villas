
using Entity.Dtos.Villa;
using Entity.RequestParameters;

namespace Service.Contract
{
    public interface IVillaService
    {
        IEnumerable<VillaDto> GetAll();
        IEnumerable<VillaDto> GetAllWithParameters(VillaRequestParameters v = null);
        VillaDto GetByName(string name);
    }
}
