using HtmlAgilityPack;
using System.IO;
using System.Linq;
using Xunit;

namespace Client.Tests
{
    public class AddSplitPanelComponentTests
    {
        [Fact(DisplayName = "Split pane library component page")]
        public void AddPanelComponentTest()
        {
            //Arrange
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";
            //Assertion
            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the `Pages` folder.");
        }
        [Fact(DisplayName = "Split tag and three SplitPane child elements")]
        public void AddSplitPanelComponentTest()
        {
            //Arrange
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the `Pages` folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);
            //Act
            var splitTag = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();
            //Assertion
            Assert.True(splitTag != null && splitTag.Descendants("SplitPane") != null,
                "`StBarnabas.razor` should contain a `Split` element with three child `SplitPane` elements.");
        }
        [Fact(DisplayName = "Split direction child element of Split tag")]
        public void AddSplitDirectionOfPaneComponentTest()
        {
            //Arrange
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the `Pages` folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);
            //Act
            var splitTag = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();
            splitTag = splitTag.Descendants("SplitPane")?.FirstOrDefault();
            //Assertion
            Assert.True(splitTag != null && splitTag.Descendants("Split") != null,
                "`StBarnabas.razor` `SplitPane` element should contain another `Split` element for direction purposes.");
        }
    }
}
