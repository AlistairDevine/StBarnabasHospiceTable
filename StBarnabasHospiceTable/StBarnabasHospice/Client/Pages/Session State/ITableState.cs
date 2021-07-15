using System;

namespace StBarnabasHospice.Client.Pages.Session_State
{
    public interface ITableState
    {
        event Action StateChanged;

        string GetCurrentImage(int id);
        void ResetCurrentImages();
        void SetCurrentImages(int id, string paramImages);
    }
}