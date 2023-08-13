namespace Repository.Contracts
{
    public interface IFontAwesomeRepository
    {
        public string GetIconClassFromSvgLink(string svgLink);
        public Task<HashSet<string>> GetAllFreeIcons();
    }
}
