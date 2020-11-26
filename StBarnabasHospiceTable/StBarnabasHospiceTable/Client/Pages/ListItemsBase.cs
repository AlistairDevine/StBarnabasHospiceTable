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
        public List<Item> Items { get; set; } = new List<Item>();
        //Add item values
        public bool ShowPopup = false;
        public string Message { get; set; }
        public Item HRItem { get; set; } = new Item();

        public void AddItem()
        {
            ShowPopup = true;
        }
        public void ClosePopup()
        {
            //Close the Popup
            ShowPopup = false;
        }

        protected override async Task OnInitializedAsync()
        {
            ShowPopup = false;
            Items = (await itemService.GetAllItems()).ToList();
        }
        public async Task HandleValidSubmit()
        {
            //Close the popup from the screen
            ClosePopup();
            //Create a new item
            Item objHRItem = new Item();
            objHRItem.Name = HRItem.Name;
            objHRItem.Description = HRItem.Description;
            objHRItem.Image = HRItem.Image;
            //Save the item to the item list
            var result = await itemService.AddItem(objHRItem);

            if (result !=  null)
            {
                navManager.NavigateTo("/listitem");
            }
            else
            {
                //Update the table

                Message = "HRItem is null. " + HRItem.ToString();
            }
            Items = (await itemService.GetAllItems()).ToList();
        }
    }
}
