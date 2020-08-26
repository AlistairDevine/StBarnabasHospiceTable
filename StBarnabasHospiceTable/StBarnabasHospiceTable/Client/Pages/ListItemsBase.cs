using Microsoft.AspNetCore.Components;
using StBarnabasHospiceTable.Client.Services;
using StBarnabasHospiceTable.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace StBarnabasHospiceTable.Client.Pages
{
    public class ListItemsBase : ComponentBase
    {
        //Page values
        [Inject]
        public IItemDataService itemService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        [Parameter]
        public int Count { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        //Add item values
        public bool ShowPopup = false;
        public string Message { get; set; }
        public Item HRItem { get; set; } = new Item();
        protected override async Task OnInitializedAsync()
        {
            ShowPopup = false;
            Items = (await itemService.GetAllItems()).ToList();

            if (Count != 0)
            {
                Items = Items.Take(Count).ToList();
            }
        }
        public void AddItem()
        {
            ShowPopup = true;
        }
        public void ClosePopup()
        {
            //Close the Popup
            ShowPopup = false;
        }
        public async Task HandleValidSubmit()
        {
            ClosePopup();
            //Save the item to the item list
            var result = await itemService.AddItem(HRItem);
            if (result != null)
            {
                navManager.NavigateTo("/listitem");
            }
            else
            {
                Message = "An error has occured.";
            }
        }
    }
}
