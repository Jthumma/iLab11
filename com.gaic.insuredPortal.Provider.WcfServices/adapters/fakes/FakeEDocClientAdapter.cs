using System.Collections.Generic;
using com.gaic.insuredPortal.Core.Domain.models;
using com.gaic.insuredPortal.Provider.WcfServices.adapters.interfaces;

namespace com.gaic.insuredPortal.Provider.WcfServices.adapters.fakes
{
    public class FakeEDocClientAdapter : IEDocClientAdapter
    {
        public bool Ping(string token)
        {
            return true;
        }

        public List<PolicyModel> GetPolicies(string policyNumber, UserModel user)
        {
            var policies = new List<PolicyModel>();

            if (user.Roles.Contains(RoleItemModel.Insured))
            {
                policies.Add(new PolicyModel
                {
                    PolicyId = 1,
                    Product = "GTP",
                    Number = "2462102",
                    Mod = 0,
                    Version = 0,
                    Status = "Active",
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "Continuous",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Ted Bitting",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "46 Walnut St",
                                    City = "Pittsboro",
                                    State = "IN",
                                    Zip = "46167"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel {Phone = "5131234567", Email = "brandsins@agency.com"}
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 2,
                    Product = "GTP",
                    Number = "3129484",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "07/15/2014",
                    ExpirationDate = "Continuous",
                    Status = "New Business",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Porter Renfrow",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "422 E 19th Street Rd",
                                    City = "Greeley",
                                    State = "CO",
                                    Zip = "80631"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
            }
            if (user.Roles.Contains(RoleItemModel.Agent))
            {
                policies.Add(new PolicyModel
                {
                    PolicyId = 4,
                    Product = "GTP",
                    Number = "2462104",
                    Mod = 0,
                    Version = 0,
                    Status = "Cancelled",
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "Continuous",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Ricky Walls",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "8616 Ingalls Ln",
                                    City = "Camby",
                                    State = "IN",
                                    Zip = "46113"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 3,
                    Product = "GTP",
                    Number = "3129482",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "07/23/2014",
                    ExpirationDate = "10/31/2014",
                    Status = "Expired",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Johnny Varnell",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "3320 11th Ave",
                                    Line2 = "Apt 714",
                                    City = "Evans",
                                    State = "CO",
                                    Zip = "80620"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
            }
            if (user.Roles.Contains(RoleItemModel.MotorCarrier))
            {
                policies.Add(new PolicyModel
                {
                    PolicyId = 5,
                    Product = "GTP",
                    Number = "2462103",
                    Mod = 0,
                    Version = 0,
                    Status = "Active",
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "Continuous",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Dirk Olsen",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "2449 Gilpin Ave",
                                    City = "Colorado Springs",
                                    State = "CO",
                                    Zip = "80910"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 2,
                    Product = "GTP",
                    Number = "3129484",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "07/15/2014",
                    ExpirationDate = "Continuos",
                    Status = "Active",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Porter Renfrow",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "422 E 19th Street Rd",
                                    City = "Greeley",
                                    State = "CO",
                                    Zip = "80631"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
            }
            if (user.Roles.Contains(RoleItemModel.OwnerCorporate))
            {
                policies.Add(new PolicyModel
                {
                    PolicyId = 3,
                    Product = "GTP",
                    Number = "3129482",
                    Mod = 0,
                    Version = 0,
                    Status = "Renewal",
                    EffectiveDate = "07/23/2014",
                    ExpirationDate = "Continuous",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Johnny Varnell",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "3320 11th Ave",
                                    Line2 = "Apt 714",
                                    City = "Evans",
                                    State = "CO",
                                    Zip = "80620"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 5,
                    Product = "GTP",
                    Number = "2462103",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "Continuous",
                    Status = "Active",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Dirk Olsen",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "2449 Gilpin Ave",
                                    City = "Colorado Springs",
                                    State = "CO",
                                    Zip = "80910"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 2,
                    Product = "GTP",
                    Number = "3129484",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "07/15/2014",
                    ExpirationDate = "Continuous",
                    Status = "Renewal",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Porter Renfrow",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "422 E 19th Street Rd",
                                    City = "Greeley",
                                    State = "CO",
                                    Zip = "80631"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 4,
                    Product = "GTP",
                    Number = "2462104",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "12/31/2014",
                    Status = "Expired",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Ricky Walls",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "8616 Ingalls Ln",
                                    City = "Camby",
                                    State = "IN",
                                    Zip = "46113"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
                policies.Add(new PolicyModel
                {
                    PolicyId = 1,
                    Product = "GTP",
                    Number = "2462102",
                    Mod = 0,
                    Version = 0,
                    EffectiveDate = "11/01/2013",
                    ExpirationDate = "Continuous",
                    Status = "Active",
                    PolicyHolderName = "OO of Team Indy Transport Services LLC",
                    MasterPolicyNumber = "GTP 2407608 00",
                    Insured =
                        new InsuredModel
                        {
                            Name = "Ted Bitting",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "46 Walnut St",
                                    City = "Pittsboro",
                                    State = "IN",
                                    Zip = "46167"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "Brands Insurance Agency",
                            AgentCode = "234737",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "6449 Allen Road",
                                    City = "West Chester",
                                    State = "OH",
                                    Zip = "45069"
                                },
                            Contact = new ContactModel { Phone = "5131234567", Email = "brandsins@agency.com" }
                        }
                });
            }
            if (user.Roles.Contains(RoleItemModel.GaicEmployee))
            {
                policies.Add(new PolicyModel
                {
                    PolicyId = 1,
                    Product = "WC",
                    Number = "1708816",
                    Mod = 0,
                    Version = 1,
                    EffectiveDate = "04/29/2012",
                    ExpirationDate = "04/29/2013",
                    Status = "Active",
                    Insured =
                        new InsuredModel
                        {
                            Name = "CommonWealth Assited Living LLC",
                            Address =
                                new AddressModel
                                {
                                    Line1 = "534 E. Main Street",
                                    Line2 = "Suite B",
                                    City = "Charlottesville",
                                    State = "VA",
                                    Zip = "22902"
                                }
                        },
                    Agent =
                        new AgentModel
                        {
                            AgencyName = "BB&T Webb Insurance",
                            AgentCode = "",
                            Address =
                                new AddressModel
                                {
                                    City = "Statesville",
                                    State = "NC",
                                    Zip = "28687"
                                },
                            Contact = new ContactModel { Phone = "8567891235", Fax = "8567896987", Email = "bbtwebb@insurance.com" }
                        }
                });
            }
            return policies;
        }
    }
}