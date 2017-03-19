using RKE.BL.Abstract;
using RKE.UIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RKE.BL.Concrete.Mappers;
using RKE.UIModels.RozkladModel;
using RKE.DAL.Concrate.Repositories;
using RKE.DAL.Abstract.Repositories;
using RKE.Entity;
/*
namespace RKE.BL.Concrete.DataBind
{
    public class RozkladDataHandler : IRozkladDataHandler
    {
        private readonly IGroupRepository _groupRepository;
        public RozkladDataHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<RozkladModel> GetByGroup(string groupName)
        { 
            Group res = await _groupRepository.FirstOrDefaultAsync(p => p.NameOfGroup == groupName).ti;
            
            RozkladMapper maper = new RozkladMapper();
           return maper.EntityToModel(res);
        }
        public async Task<List<RozkladModel>> GetByGroup(string groupName)
        {
            using (RepositoryHolder scope = new RepositoryHolder())
            {
                ProductMapper mapper = new ProductMapper();
                List<ProductListItemModel> result =
                    scope.ProductRepository
                    .Fetch()
                    .Select
                        (
                            p =>
                                mapper.EntityToModel(p)
                        )
                   .ToList();
                return result;
            }

        }


        public async Task<RozkladModel> GetByGroup(string groupName,int week)
        {
            return null;
        }
    }
}
*/