using PostSharp.Patterns.Caching;
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
        [Cache(AbsoluteExpiration = 20)]
        public Task<HashSet<string>> GetAllFreeIcons()
        {
            return _repository.GetAllFreeIcons();
        }

        public string GetIconClassFromSvgLink(string svgLink)
        {
            return _repository.GetIconClassFromSvgLink(svgLink);
        }
    }
}
