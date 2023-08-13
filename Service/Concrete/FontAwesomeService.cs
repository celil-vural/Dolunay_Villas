using Dolunay_Villas.Core.Aspects.Postsharp.CacheAspects;
using Dolunay_Villas.Core.CrossCuttingConcerns.Caching.Microsoft;
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
        [CacheAspect(typeof(MemoryCacheManager), 60)]
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
