using AutoMapper;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.eDocMtomService;
using com.gaic.insuredPortal.Provider.WcfServices.FdwInquiryService;

namespace com.gaic.insuredPortal.Provider.WcfServices
{
    public class WcfServiceMapper
    {
        public static void Initialize()
        {
            MapEDocMTomDocument();
            Map_SearchModel_FdwSearchCriteria();
            Map_FdwpolicyClaimLookup_PolicyModel();
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
                .ForMember(d => d.Producer, opt => opt.Ignore())
                .ForMember(d => d.Insured, opt => opt.Ignore())
                .ForMember(d => d.IsSubPolicy, opt => opt.Ignore())
                .ForMember(d => d.MasterPolicyNumber, opt => opt.Ignore())
                .ForMember(d => d.PolicyHolderName, opt => opt.Ignore());
        }

        private static void Map_SearchModel_FdwSearchCriteria()
        {
            Mapper.CreateMap<SearchModel, serviceSearchCriteria>()
                .ForMember(d => d.additionalInsured, opt => opt.Ignore())
                .ForMember(d => d.auditFreq, opt => opt.Ignore())
                .ForMember(d => d.autoFastInd, opt => opt.Ignore())
                .ForMember(d => d.businessUnitCode, opt => opt.Ignore())
                .ForMember(d => d.bypassLdapSearch, opt => opt.Ignore())
                .ForMember(d => d.canNr, opt => opt.Ignore())
                .ForMember(d => d.claimNumber, opt => opt.Ignore())
                .ForMember(d => d.claimantName, opt => opt.Ignore())
                .ForMember(d => d.claimantSsn, opt => opt.Ignore())
                .ForMember(d => d.claimsExist, opt => opt.Ignore())
                .ForMember(d => d.currentProfitCenters, opt => opt.Ignore())
                .ForMember(d => d.customerNumbers, opt => opt.Ignore())
                .ForMember(d => d.dateOfLoss, opt => opt.Ignore())
                .ForMember(d => d.distinctPolicies, opt => opt.Ignore())
                .ForMember(d => d.dateOfLoss, opt => opt.Ignore())
                .ForMember(d => d.divId, opt => opt.Ignore())
                .ForMember(d => d.endCancellationDate, opt => opt.Ignore())
                .ForMember(d => d.endCancellationDateSpecified, opt => opt.Ignore())
                .ForMember(d => d.endExpirationDate, opt => opt.Ignore())
                .ForMember(d => d.endExpirationDateSpecified, opt => opt.Ignore())
                .ForMember(d => d.endExpiringPremium, opt => opt.Ignore())
                .ForMember(d => d.endIncurredAmount, opt => opt.Ignore())
                .ForMember(d => d.endLossRatio, opt => opt.Ignore())
                .ForMember(d => d.equineClaims, opt => opt.Ignore())
                .ForMember(d => d.excludeCanceledPolicyMoreThanAYear, opt => opt.Ignore())
                .ForMember(d => d.excludeExpiredPolicyMoreThanAYear, opt => opt.Ignore())
                .ForMember(d => d.excludeFlatCancels, opt => opt.Ignore())
                .ForMember(d => d.excludePolicySymbol, opt => opt.Ignore())
                .ForMember(d => d.facRe, opt => opt.Ignore())
                .ForMember(d => d.fieldCode, opt => opt.Ignore())
                .ForMember(d => d.fuzzySearch, opt => opt.Ignore())
                .ForMember(d => d.insuredCity, opt => opt.MapFrom(s => s.InsuredAddress.City))
                .ForMember(d => d.insuredCityState, opt => opt.Ignore())
                .ForMember(d => d.insuredName, opt => opt.MapFrom(s => s.InsuredName))
                .ForMember(d => d.insuredNameCont, opt => opt.Ignore())
                .ForMember(d => d.insuredNameOperator, opt => opt.Ignore())
                .ForMember(d => d.insuredNameOperatorSpecified, opt => opt.Ignore())
                .ForMember(d => d.insuredState, opt => opt.MapFrom(s => s.InsuredAddress.State))
                .ForMember(d => d.maxSearchRows, opt => opt.Ignore())
                .ForMember(d => d.offset, opt => opt.Ignore())
                .ForMember(d => d.orders, opt => opt.Ignore())
                .ForMember(d => d.policyEffectiveDate, opt => opt.Ignore())
                .ForMember(d => d.policyExpirationDate, opt => opt.Ignore())
                .ForMember(d => d.policyId, opt => opt.Ignore())
                .ForMember(d => d.policyIdSpecified, opt => opt.Ignore())
                .ForMember(d => d.policyModule, opt => opt.Ignore())
                .ForMember(d => d.policyNumber, opt => opt.Ignore())
                .ForMember(d => d.policyState, opt => opt.Ignore())
                .ForMember(d => d.policyStatuses, opt => opt.Ignore())
                .ForMember(d => d.policySymbols, opt => opt.Ignore())
                .ForMember(d => d.policyVersionCd, opt => opt.Ignore())
                .ForMember(d => d.producerADesc, opt => opt.Ignore())
                .ForMember(d => d.producerNumbers, opt => opt.Ignore())
                .ForMember(d => d.propertyName, opt => opt.Ignore())
                .ForMember(d => d.sbuCode, opt => opt.Ignore())
                .ForMember(d => d.searchInsuredLastFirst, opt => opt.Ignore())
                .ForMember(d => d.searchUniqueClaimNumber, opt => opt.Ignore())
                .ForMember(d => d.sicCode, opt => opt.Ignore())
                .ForMember(d => d.startCancellationDate, opt => opt.Ignore())
                .ForMember(d => d.startCancellationDateSpecified, opt => opt.Ignore())
                .ForMember(d => d.startExpirationDate, opt => opt.Ignore())
                .ForMember(d => d.startExpirationDateSpecified, opt => opt.Ignore())
                .ForMember(d => d.startExpiringPremium, opt => opt.Ignore())
                .ForMember(d => d.startIncurredAmount, opt => opt.Ignore())
                .ForMember(d => d.startLossRatio, opt => opt.Ignore())
                .ForMember(d => d.territoryCode, opt => opt.Ignore());
        }

        private static void Map_FdwpolicyClaimLookup_PolicyModel()
        {
            Mapper.CreateMap<policyClaimLookupFDW, PolicyModel>()
                .ForMember(d => d.EffectiveDate, opt => opt.MapFrom(s => s.policyEffectiveDate))
                .ForMember(d => d.ExpirationDate, opt => opt.MapFrom(s => s.policyExpirationDate))
                .ForMember(d => d.Mod, opt => opt.MapFrom(s => s.policyModule))
                .ForMember(d => d.Number, opt => opt.MapFrom(s => s.policyNumber))
                .ForMember(d => d.PolicyId, opt => opt.MapFrom(s => s.policyId))
                .ForMember(d => d.Product, opt => opt.MapFrom(s => s.policySymbol))
                .ForMember(d => d.Symbol, opt => opt.MapFrom(s => s.policySymbol))
                .ForMember(d => d.Version, opt => opt.MapFrom(s => s.policyVersion))
                .ForMember(d => d.Status, opt => opt.MapFrom(s => s.policyStatus))
                .ForMember(d => d.Producer, opt => opt.ResolveUsing<PolicyClaimLookupFdwProducerTypeResolver>())
                .ForMember(d => d.Insured, opt => opt.ResolveUsing<PolicyClaimLookupFdwInsuredTypeResolver>())
                .ForMember(d => d.IsSubPolicy, opt => opt.Ignore())
                .ForMember(d => d.MasterPolicyNumber, opt => opt.Ignore())
                .ForMember(d => d.PolicyHolderName, opt => opt.Ignore());
        }
    }

    public class PolicyClaimLookupFdwInsuredTypeResolver :
        ValueResolver<policyClaimLookupFDW, InsuredModel>
    {
        protected override InsuredModel ResolveCore(policyClaimLookupFDW source)
        {
            return new InsuredModel
            {
                Name = source.insuredName,
                Address =
                    new AddressModel
                    {
                        City = source.insuredCity,
                        State = source.insuredState,
                        Zip = source.insuredZip,
                        Line1 = source.insuredStreet
                    }
            };
        }
    }

    public class PolicyClaimLookupFdwProducerTypeResolver :
        ValueResolver<policyClaimLookupFDW, ProducerModel>
    {
        protected override ProducerModel ResolveCore(policyClaimLookupFDW source)
        {
            return new ProducerModel {Number = source.producerNumber, ProfitCenter = source.profitCenter};
        }
    }
}