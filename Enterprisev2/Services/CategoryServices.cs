using Enterprisev2.Models;
using Enterprisev2.Data;
using Enterprisev2.Base;

namespace Enterprisev2.Services
{
    public class CategoryServices : BaseEntityRepository<Category>,ICategoryServices
    {
        public CategoryServices(ApplicationDbContext context):base(context) 
        { 
        }
    }
}
