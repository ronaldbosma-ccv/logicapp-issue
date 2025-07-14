using System.Net;
using LogicAppUnit;

namespace MyLogicAppTests
{
    [TestClass]
    public sealed class MyWorkflowTests : WorkflowTestBase
    {
        [TestMethod]
        public void MyWorkflow_Should_Return_200_OK()
        {
            // Arrange
            Initialize("../../../../../src/MyWorkspace/MyLogicApp", "MyWorkflow");
            using var testRunner = CreateTestRunner();

            // Act
            var result = testRunner.TriggerWorkflow(HttpMethod.Post);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(WorkflowRunStatus.Succeeded, testRunner.WorkflowRunStatus);
        }
    }
}
