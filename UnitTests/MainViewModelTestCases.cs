using Microsoft.Extensions.Logging;
using Moq;
using TechnicalAxos_CarlosLuevano.Services;
using TechnicalAxos_CarlosLuevano.ViewModels;

namespace UnitTests
{
    [TestClass]
    public class MainViewModelTestCases
    {
        private Mock<ILogger<MainViewModel>> _mockLogger = null!;
        private Mock<IToastService> _mockToast = null!;
        private Mock<IAppInfo> _mockAppInfo = null!;

        [TestInitialize]
        public void Initialize()
        {
            _mockLogger = new Mock<ILogger<MainViewModel>>();
            _mockToast = new Mock<IToastService>();
            _mockToast.Setup(t => t.DisplayErrorToastAsync(It.IsAny<string>())).Returns(Task.CompletedTask);
            _mockToast.Setup(t => t.DisplaySuccessToastAsync(It.IsAny<string>())).Returns(Task.CompletedTask);
            _mockAppInfo = new Mock<IAppInfo>();
            _mockAppInfo.SetupGet(a => a.PackageName).Returns("UnitTest.App");
        }

        [TestMethod]
        public async Task LoadCountriesListUsingNewtosoft_ReturnPopulatedList()
        {
            // Arrange
            var countryService = new CountryService();
            var mainViewModel = 
                new MainViewModel(_mockLogger.Object, _mockToast.Object, _mockAppInfo.Object, countryService);

            // Act
            await mainViewModel.GetCountriesNewtonsoftAsync();

            // Assert
            Assert.IsNotNull(mainViewModel.CountriesNS);
            Assert.IsTrue(mainViewModel.CountriesNS.Any());
        }

        [TestMethod]
        public async Task LoadCountriesListUsingTextJson_ReturnPopulatedList()
        {
            // Arrange
            var countryService = new CountryService();
            var mainViewModel = 
                new MainViewModel(_mockLogger.Object, _mockToast.Object, _mockAppInfo.Object, countryService);

            // Act
            await mainViewModel.GetCountriesNewtonsoftAsync();

            // Assert
            Assert.IsNotNull(mainViewModel.CountriesTJ);
            Assert.IsTrue(mainViewModel.CountriesTJ.Any());
        }

        [TestMethod]
        public void CheckPropertyBundleIdIsValid_ReturnsTruNotNullOrEmpty()
        {
            // Arrange
            var countryService = new CountryService();
            var mainViewModel =
                new MainViewModel(_mockLogger.Object, _mockToast.Object, _mockAppInfo.Object, countryService);

            // Act
            var bundleId = mainViewModel.BundleId;

            // Assert
            Assert.IsTrue(!string.IsNullOrEmpty(bundleId));
        }
    }
}