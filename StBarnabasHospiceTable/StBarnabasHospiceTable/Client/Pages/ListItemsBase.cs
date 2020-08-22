using Microsoft.AspNetCore.Components;
using StBarnabasHospiceTable.Client.Services;
using StBarnabasHospiceTable.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Client.Pages
{
    public class ListItemsBase : ComponentBase
    {
        [Inject]
        public IItemDataService itemService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        [Parameter]
        public int Count { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        protected override async Task OnInitializedAsync()
        {
            Items = (await itemService.GetAllItems()).ToList();

            if (Count != 0)
            {
                Items = Items.Take(Count).ToList();
            }
        }
        public void AddItem()
        {
            navManager.NavigateTo("itemedit");
        }
    }
}
