using Entity.Dtos.Villa;
using Entity.RequestParameters;
using StoreApp.Models;

namespace Dolunay_Villas.Models
{
    public class ModelForVilla
    {
        public VillaRequestParameters? villaRequestParameters { get; set; } = new();
        public List<VillaDto> villas { get; set; } = new();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => villas.Count;
    }
}
