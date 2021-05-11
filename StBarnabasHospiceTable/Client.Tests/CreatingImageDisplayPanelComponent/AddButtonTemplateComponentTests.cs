using HtmlAgilityPack;
using System.IO;
using System.Linq;
using Xunit;

namespace Client.Tests.CreatingImageDisplayPanelComponent
{
    public class AddButtonTemplateComponentTests
    {
        [Fact(DisplayName = "Button templated component should be place inside `Split` second element")]
        public void PaneShouldIncludeButtonComponentTest()
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
            splitTag = splitTag.Descendants("Split")?.FirstOrDefault();
            //Assertion
            Assert.True(splitTag != null && splitTag.Descendants("ButtonTemplate") != null,
                "`StBarnabas.razor` should contain a secondary `Split` element with a button templated component to display the button function.");
        }
        //Test for behaviour, not code structure
        [Fact(DisplayName = "If function to display the button template component in the pane")]
        public void DisplayButtonTemplateBehaviour()
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
            string file;
            using (var streamReader = new StreamReader(filePath))
            {
                file = streamReader.ReadToEnd();
            }
            //Assertion
            //If statement assertion check
            Assert.True(file.Contains("@if (displayButton == true)"), "The `StBarnabas` component does not contain a if statement for button pane display options.");
        }
    }
}
