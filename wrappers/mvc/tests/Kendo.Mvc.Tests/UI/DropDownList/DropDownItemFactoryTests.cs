namespace Kendo.Mvc.UI.Tests
{
    using Kendo.Mvc.UI.Fluent;
    using Xunit;
    using System.Collections.Generic;

    public class DropDownItemFactoryTests
    {
        private readonly DropDownListItemFactory factory;
        private IList<DropDownListItem> collection;

        public DropDownItemFactoryTests()
        {
            collection = new List<DropDownListItem>();
            factory = new DropDownListItemFactory(collection);
        }

        [Fact]
        public void Add_should_add_enabled_item_before_action() 
        {
            factory.Add();
            Assert.False(collection[0].Selected);
        }

        [Fact]
        public void Add_should_return_new_builder_with_new_item()
        {
            var builder = factory.Add();
            Assert.NotNull(builder);
        }
    }
}
