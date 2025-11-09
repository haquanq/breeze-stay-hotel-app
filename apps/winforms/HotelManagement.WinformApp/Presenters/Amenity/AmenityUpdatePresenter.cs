using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Services.Amenity;
using HotelManagement.WinformApp.Views.Amenity;
using HotelManagement.WinformApp.Enums;
using System;
using System.Threading.Tasks;
using HotelManagement.Presenters.Main;
using System.Windows.Forms;
using HotelManagement.WinformApp.Configs;

namespace HotelManagement.WinformApp.Presenters.Amenity
{
    public class AmenityUpdatePresenter
    {
        private readonly IAmenityUpdateView _amenityUpdateView;
        private readonly IAmenityService _amenityService;

        public AmenityUpdatePresenter(IAmenityUpdateView amenityUpdateView, IAmenityService amenityService)
        {
            /// injected
            _amenityUpdateView = amenityUpdateView;
            _amenityService = amenityService;

            /// events
            _amenityUpdateView.OnAmenityViewLoad += HandleViewLoad;
            _amenityUpdateView.OnAmenitySave += HandleAmenitySave;
            _amenityUpdateView.OnAmenityDelete += HandleAmenityDelete;
            _amenityUpdateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling AmenityUpdateView events
        /// </summary>

        private void HandleViewLoad(object sender, EventArgs e)
        {
            LoadAmenityChargableSelectMenu();
        }

        private void HandleAmenitySave(object sender, EventArgs e)
        {
            SaveAmenity();
        }

        private void HandleAmenityDelete(object sender, EventArgs e)
        {
            DeleteAmenity();
        }

        private void HandleCancel(object sender, EventArgs e) { _amenityUpdateView.Close(); }

        /// <----->
        /// Public methods for handling AmenityUpdateView logic

        public void ShowView(string amenityId)
        {
            LoadAmenityById(amenityId);
            _amenityUpdateView.Show();
        }

        public void LoadAmenityChargableSelectMenu()
        {
            var source = new BindingSource(AmenityViewConfig.StatusDescription, null);
            _amenityUpdateView.SetupAmenityStatusComboBox(source, "Value", "Key");
        }

        public async void LoadAmenityById(string amenityId)
        {
            var amenity = await Task.Run(() => _amenityService.FindByIdAsync(amenityId));

            _amenityUpdateView.AmenityId = amenity.AmenityId;
            _amenityUpdateView.AmenityDetail = amenity.Detail;
            _amenityUpdateView.AmenityPrice = amenity.Price;
            _amenityUpdateView.AmenityTitle = amenity.Title;
            _amenityUpdateView.AmenityStatus = amenity.Status;

        }

        public async void SaveAmenity()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (confirmed == false) return;

            var amenity = new AmenityUpdateDto()
            {
                AmenityId = _amenityUpdateView.AmenityId,
                Title = _amenityUpdateView.AmenityTitle,
                Detail = _amenityUpdateView.AmenityDetail,
                Price = _amenityUpdateView.AmenityPrice,
                Status = _amenityUpdateView.AmenityStatus,
            };

            try
            {
                await Task.Run(() => _amenityService.UpdateAsync(amenity));
                AmenityPresenter.Instance.LoadAmenityList();
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Changes saved successfully!");
                _amenityUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }

        public async void DeleteAmenity()
        {
            var confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this amenity?");
            if (!confirmed) return;

            try
            {
                await _amenityService.DeleteByIdAsync(_amenityUpdateView.AmenityId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Amenity deleted successfully!");
                _amenityUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
