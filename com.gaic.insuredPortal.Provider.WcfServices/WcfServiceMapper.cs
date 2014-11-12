﻿using AutoMapper;
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
                .ForMember(d => d.EffectiveDate, opt => opt.Ignore())
                .ForMember(d => d.ExpirationDate, opt => opt.Ignore())
                .ForMember(d => d.Mod, opt => opt.Ignore())
                .ForMember(d => d.Number, opt => opt.Ignore())
                .ForMember(d => d.PolicyId, opt => opt.Ignore())
                .ForMember(d => d.Product, opt => opt.Ignore())
                .ForMember(d => d.Symbol, opt => opt.Ignore())
                .ForMember(d => d.Version, opt => opt.Ignore())
                .ForMember(d => d.Status, opt => opt.Ignore())
                .ForMember(d => d.Agent, opt => opt.Ignore())
                .ForMember(d => d.Insured, opt => opt.Ignore())
                .ForMember(d => d.IsSubPolicy, opt => opt.Ignore())
                .ForMember(d => d.MasterPolicyNumber, opt => opt.Ignore())
                .ForMember(d => d.PolicyHolderName, opt => opt.Ignore());
        }
    }
}