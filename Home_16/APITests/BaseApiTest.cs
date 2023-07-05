using Allure.Net.Commons;
using Home_16.Services;
using NUnit.Allure.Core;

namespace Home_16.APITests
{
    [AllureNUnit]
    internal class BaseApiTest
    {
        protected ProjectService projectService;
        protected TestCaseService testCaseService;
        private AllureLifecycle allure;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            projectService = new ProjectService();
            testCaseService = new TestCaseService();
            allure = AllureLifecycle.Instance;
        }
    }
}
