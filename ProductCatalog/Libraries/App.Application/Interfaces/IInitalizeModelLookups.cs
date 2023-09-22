
using App.Application.Model;
using System.Threading.Tasks;

namespace App.Application.Interfaces
{

    public interface IInitalizeModelLookups
    {
        Task InitModel(AdminPagesModel model, string selectTitle = null);
        Task InitModel(HomePageModel model, string selectTitle = null);
        Task InitModel(GroupModel model, string selectTitle = null);
        Task InitModel(UserModel model, string selectTitle = null);
        Task InitModel(ProductsModel model, string selectTitle = null);
    }
}