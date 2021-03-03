using System.Threading.Tasks;
using HuyWebStore.Models.TokenAuth;
using HuyWebStore.Web.Controllers;
using Shouldly;
using Xunit;

namespace HuyWebStore.Web.Tests.Controllers
{
    public class HomeController_Tests: HuyWebStoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}