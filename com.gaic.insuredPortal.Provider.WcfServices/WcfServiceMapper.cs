using AutoMapper;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.eDocMtomService;

namespace com.gaic.insuredPortal.Provider.WcfServices
{
    public class WcfServiceMapper
    {
        public static void Initialize()
        {
            MapEDocMTomDocument();
            Mapper.AssertConfigurationIsValid();
        }

        private static void MapEDocMTomDocument()
        {
            Mapper.CreateMap<Document, PolicyModel>()
                .ForMember(d => d.EffDate, opt => opt.Ignore())
                .ForMember(d => d.Mod, opt => opt.Ignore())
                .ForMember(d => d.Number, opt => opt.Ignore())
                .ForMember(d => d.PolicyId, opt => opt.Ignore())
                .ForMember(d => d.Product, opt => opt.Ignore())
                .ForMember(d => d.Symbol, opt => opt.Ignore())
                .ForMember(d => d.Version, opt => opt.Ignore());
        }
    }
}