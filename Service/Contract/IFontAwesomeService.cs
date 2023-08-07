namespace Service.Contract
{
    public interface IFontAwesomeService
    {
        public string GetIconClassFromSvgLink(string svgLink);
        public Task<List<string>> GetAllFreeIcons();
    }
}
