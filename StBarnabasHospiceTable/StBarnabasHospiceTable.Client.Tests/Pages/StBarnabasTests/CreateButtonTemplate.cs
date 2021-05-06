using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StBarnabasHospiceTable.Client.Tests.Pages.StBarnabasTests
{
    public class CreateButtonTemplate
    {
        [Fact(DisplayName = "Ensure that a razor component exists within the Pages folder.")]
        public void CreateButtonTemplateComponent()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");
        }

        [Fact(DisplayName = "Create the SplitPane element for the button to be placed in.")]
        public void CreateSplitPaneButtonDisplay()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("SplitPane")?.FirstOrDefault();

            Assert.True(split != null && split.Attributes["MinSize"]?.Value == "0",
                "ButtonTemplate should have a Split element with the attribute of MinSize set to the value of 0.");
        }

        [Fact(DisplayName = "Selection option via If statement to display the pane button or not.")]
        public void DisplayButtonStatement()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("SplitPane")?.FirstOrDefault();

            Assert.True(split != null && split.InnerText.Contains("@if (displayButton == true)"),
                "`ButtonTemplate.razor` should contain an if statement to display the button icon.");
        }

        [Fact(DisplayName = "Actual button html div and link tags inside the pane.")]
        public void ButtonHtmlMarkup()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("SplitPane")?.FirstOrDefault();
            var div = split.Descendants("div")?.FirstOrDefault();

            Assert.True(div != null && div.Descendants("a") != null,
                "`ButtonTemplate` within the SplitPane element should contain a `div` element and in the div should contain a `a` element.");
        }
    }
}
