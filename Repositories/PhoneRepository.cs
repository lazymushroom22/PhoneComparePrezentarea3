using Microsoft.EntityFrameworkCore;
using PhoneCompare.Models;
using PhoneCompare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly PhoneCompareDbContext context;

        public PhoneRepository(PhoneCompareDbContext context)
        {
            this.context = context;
        }

        public Phone AddPhone(Phone phone)
        {
            context.Phones.Add(phone);
            context.SaveChanges();
            return phone;
        }

        public void DeletePhone(int id)
        {
            throw new NotImplementedException();
        }

        /*private List<Phone> DummyPhoneData()
        {
            return new List<Phone>
            {
                new Phone {
                    ID = 1,
                    Brand = "Apple",
                    Model = "Iphone X",
                    Battery = "2000mAh",
                    DisplayResolution = "1024x768",
                    Width = 10,
                    Height = 20,
                    Length = 30,
                    OperatingSystem = "ios Bengos"
                },
                new Phone
                {
                    ID = 2,
                    Brand = "Samsung",
                    Model = "Galaxy S10",
                    Battery = "3000mAh",
                    DisplayResolution = "1440x900",
                    Width = 50,
                    Height = 70,
                    Length = 20,
                    OperatingSystem = "Android 8.1"
                }
            };
        }
        */

        public IEnumerable<Phone> GetAllPhones()
        {
            IEnumerable<Phone> list = context.Phones.OrderBy(p => p.Brand);
            return context.Phones.OrderBy(p => p.Brand).ToList();
        }

        public Phone GetPhoneById(int id)
        {
            return context.Phones.FirstOrDefault(p => p.ID == id);
            //var phoneLst = DummyPhoneData();
           // return phoneLst.FirstOrDefault(p => p.ID == id);
        }

        public async Task<IEnumerable<Phone>> Search(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return await context.Phones.ToListAsync();
            }
            return context.Phones.Where(p => p.Brand.Contains(searchTerm) || p.Model.Contains(searchTerm));
        }

        public Phone UpdatePhone(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
