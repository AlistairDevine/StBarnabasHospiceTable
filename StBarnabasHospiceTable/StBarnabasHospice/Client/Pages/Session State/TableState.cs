using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StBarnabasHospice.Client.Pages.Session_State
{
    public class TableState : ITableState
    {
        private string[] _currentImages = new string[6];

        public event Action StateChanged;

        public string GetCurrentImage(int id)
        {
            switch (id)
            {
                case 1:
                    return _currentImages[0];
                case 2:
                    return _currentImages[1];
                case 3:
                    return _currentImages[2];
                case 4:
                    return _currentImages[3];
                case 5:
                    return _currentImages[4];
                case 6:
                    return _currentImages[5];
            }
            return "Error GetCurrentImage()";
        }

        public void SetCurrentImages(int id, string paramImages)
        {
            switch (id)
            {
                case 1:
                    _currentImages[0] = paramImages;
                    Console.WriteLine("State for image one has been changed.");
                    break;
                case 2:
                    _currentImages[1] = paramImages;
                    Console.WriteLine("State for image two has been changed.");
                    break;
                case 3:
                    _currentImages[2] = paramImages;
                    Console.WriteLine("State for image three has been changed.");
                    break;
                case 4:
                    _currentImages[3] = paramImages;
                    Console.WriteLine("State for image four has been changed.");
                    break;
                case 5:
                    _currentImages[4] = paramImages;
                    Console.WriteLine("State for image five has been changed.");
                    break;
                case 6:
                    _currentImages[5] = paramImages;
                    Console.WriteLine("State for image six has been changed.");
                    break;
            }
            StateHasChanged();
        }

        public void ResetCurrentImages()
        {
            for (int i = 0; i < _currentImages.Length; i++)
            {
                _currentImages[i] = "";
            }
            StateHasChanged();
        }

        private void StateHasChanged() => StateChanged?.Invoke();
    }
}
