using ProjectDemo.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Migrations.Seed.Host
{
    public class InitialPeopleAndPhoneCreator
    {
        private readonly ProjectDemoDbContext   _context;

        public InitialPeopleAndPhoneCreator(ProjectDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "prastuti.agarwal@fortytwo.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Prastuti",
                        Surname = "bansal",
                        EmailAddress = "prastuti.agarwal@fortytwo.com",
                        Phones = new List<Phone>
                                {
                                    new Phone {Type = PhoneType.Home, Number = "9363628733"},
                                    new Phone {Type = PhoneType.Mobile, Number = "8362683673"}
                                }

                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "prem.chopra@foundation.org");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Prem",
                        Surname = "Chopra",
                        EmailAddress = "prem.chopra@foundation.org",
                         Phones = new List<Phone>
                                {
                                    new Phone {Type = PhoneType.Home, Number = "8263563838"}
                                }
                    });
            }
        }
    }
}
