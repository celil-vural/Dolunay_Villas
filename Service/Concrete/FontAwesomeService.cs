using Repository.Contracts;
using Service.Contract;

namespace Service.Concrete
{
    public class FontAwesomeService : IFontAwesomeService
    {
        private readonly IFontAwesomeRepository _repository;

        public FontAwesomeService(IFontAwesomeRepository repository)
        {
            _repository = repository;
        }

        public Task<List<string>> GetAllFreeIcons()
        {
            return _repository.GetAllFreeIcons();
        }

        public string GetIconClassFromSvgLink(string svgLink)
        {
            return _repository.GetIconClassFromSvgLink(svgLink);
        }
    }
}
