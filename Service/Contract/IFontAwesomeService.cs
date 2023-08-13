namespace Service.Contract
{
    public interface IFontAwesomeService
    {
        public string GetIconClassFromSvgLink(string svgLink);
        public Task<HashSet<string>> GetAllFreeIcons();
    }
}
