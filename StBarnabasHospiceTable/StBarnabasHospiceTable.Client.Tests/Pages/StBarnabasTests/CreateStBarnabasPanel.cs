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
    public class CreateStBarnabasPanel
    {
        public CreateStBarnabasPanel()
        {
            //TODO : Refactor
        }

        [Fact(DisplayName = "Create a Panel display for the St Barnabas component")]
        public void CreateSplitDisplay()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();

            Assert.True(split != null && split.Descendants("SplitPane") != null, "`StBarnabas.razor` should contain a `SplitPane` element.");
        }
        [Fact(DisplayName = "Create panels that will split the display into sections.'")]
        public void CreateSplitPaneDisplay()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();

            Assert.True(split != null && split.Descendants("SplitPane") != null && split.Descendants("SplitPane").Count() == 7,
                "`StBarnabas.razor` should split panes seven different times to form a six pane display.");
        }
        [Fact(DisplayName = "Create buttons to be placed inside display pane sections.")]
        public void CreatePaneButton()
        {
            var filePath = TestHelpers.GetRootString() + "StBarnabasHospiceTable"
                + Path.DirectorySeparatorChar + "Client"
                + Path.DirectorySeparatorChar + "Pages"
                + Path.DirectorySeparatorChar + "StBarnabas.razor";

            Assert.True(File.Exists(filePath), "`StBarnabas.razor` should exist in the Pages folder.");

            var doc = new HtmlDocument();
            doc.Load(filePath);

            var split = doc.DocumentNode.Descendants("Split")?.FirstOrDefault();
            var splitPane = split.Descendants("SplitPane").FirstOrDefault();

            Assert.True(splitPane != null && splitPane.Descendants("ButtonTemplate") != null,
                "`StBarnabas.razor` should contain mutliple SplitPane elements which in turn contains a ButtonTemplate component.");
        }
    }
}
