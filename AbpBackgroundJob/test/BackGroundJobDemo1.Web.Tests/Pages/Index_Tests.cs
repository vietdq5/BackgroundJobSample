using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace BackGroundJobDemo1.Pages;

public class Index_Tests : BackGroundJobDemo1WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
