using CollectionViewChallenge.Models;
using System.Collections.ObjectModel;

namespace CollectionViewChallenge.ViewModels
{
    public class WorldViewModel
    {
        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get => countries;
            set
            {
                countries = value;
            }
        }
        public WorldViewModel()
        {
            countries = new ObservableCollection<Country>()
                {
                    new Country(){Name = "Pakistan", ISO="pk", Capital="Islamabad"  },
                    new Country(){Name = "Spain", ISO="es", Capital="Madrid"  },
                    new Country(){Name = "Afghanistan", ISO="af", Capital="Kabul"  },
                    new Country(){Name = "Bangladesh", ISO="bd", Capital="Dhaka"  },
                    new Country(){Name = "Austria", ISO="at", Capital="Viena"  },
                    new Country(){Name = "Belgium", ISO="be", Capital="Brussels"  },
                    new Country(){Name = "Germany", ISO="de", Capital="Berlin"   },
                     new Country(){Name = "Ghana", ISO="gh", Capital="Accra"   },
                    new Country(){Name = "Kenya", ISO="ke" , Capital="Nairobi"  },
                    new Country(){Name = "Nigeria", ISO="bg", Capital="Abuja"   },
                    new Country(){Name = "Mali", ISO="ml", Capital="Bamako"   },
                     new Country(){Name = "Malaysia", ISO="my", Capital="Kuala Lumpur" },
                    new Country(){Name = "Egypt", ISO="eg", Capital="Cairo"   },
                     new Country(){Name = "New Zealand", ISO="nz", Capital="Wellington"   },
                    new Country(){Name = "Hong Kong", ISO="hk", Capital="Central"   },
                     new Country(){Name = "China", ISO="cn", Capital="Beijing" },
                    new Country(){Name = "USA ", ISO="us", Capital="Washington, D.C"   },
                    new Country(){Name = "United Kingdom", ISO="gb", Capital="London"   }
                };
        }

    }
}
