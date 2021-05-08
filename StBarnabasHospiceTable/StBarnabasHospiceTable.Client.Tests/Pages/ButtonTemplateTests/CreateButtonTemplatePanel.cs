using Xunit;
using System.IO;
using HtmlAgilityPack;
using System.Linq;

namespace StBarnabasHospiceTable.Client.Tests
{
    /// <summary>
    /// Red tests
    /// Green tests
    /// Refactor tests
    /// </summary>
    public class CreateButtonTemplatePanel
    {
        public CreateButtonTemplatePanel()
        {
            //TODO : Refactor
        }

        [Fact(DisplayName = "Create a Panel display for the St Barnabas component")]
        public void CreateSplitDisplay()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();

            Assert.True(split != null && split.Descendants("SplitPane") != null, 
                "`ButtonTemplate.razor` should contain a `SplitPane` element.");
        }
        [Fact(DisplayName = "Create panels that will split the display into sections.'")]
        public void CreateSplitPaneDisplay()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`ButtonTemplate.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();

            Assert.True(split != null && split.Descendants("SplitPane") != null && split.Descendants("SplitPane").Count() == 9,
                "`ButtonTemplate.razor` should split panes nine different times to form a six pane display.");
        }
        [Fact(DisplayName = "Create buttons to be placed inside display pane sections.")]
        public void CreatePaneButton()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "ButtonTemplate.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            Assert.True(doc.DocumentNode.Descendants("ButtonTemplate") != null,
                "`StBarnabas.razor` should contain a ButtonTemplate component.");
        }
    }
}
