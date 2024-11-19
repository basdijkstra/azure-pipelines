using NUnit.Framework;
using static RestAssured.Dsl;

namespace AzurePipelines.IntegrationTests
{
    [TestFixture]
    public class ZipcodeTests
    {
        [Test]
        public void TestZipcode()
        {
            Given()
                .When()
                .Get("https://api.zippopotam.us/us/90210")
                .Then()
                .StatusCode(200)
                .Body("$.places[0]['place name']", NHamcrest.Is.EqualTo("Los Angeles"));
        }
    }
}
