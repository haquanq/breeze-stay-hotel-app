using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Services.Amenity;
using HotelManagement.WinformApp.Views.Amenity;
using HotelManagement.WinformApp.Enums;
using System;
using System.Data;
using HotelManagement.Presenters.Main;
using System.Windows.Forms;
using HotelManagement.WinformApp.Configs;

namespace HotelManagement.WinformApp.Presenters.Amenity
{
    public class AmenityAddPresenter
    {
        private DataTable _dtbAmenityStatus;

        public readonly IAmenityAddView _amenityAddView;
        private readonly IAmenityService _amenityService;
        public AmenityAddPresenter(IAmenityAddView view, IAmenityService amenityService)
        {
            _amenityAddView = view;
            _amenityService = amenityService;

            _amenityAddView.OnAmenityAdd += HandleAmenityCreateEvent;
            _amenityAddView.OnCancel += HandleCancel;

            LoadAmenityStatus();
        }

        private void HandleAmenityCreateEvent(object sender, EventArgs e)
        {
            AddAmenity();
        }

        private void HandleCancel(object sender, EventArgs e)
        {
            _amenityAddView.Close();
        }

        public void ShowView()
        {
            _amenityAddView.Show();
        }

        public void LoadAmenityStatus()
        {
            var bindingSource = new BindingSource(AmenityViewConfig.StatusDescription, null);
            _amenityAddView.SetupAmenityStatusComboBox(bindingSource, "Value", "Key");
        }

        public async void AddAmenity()
        {
            var amenity = new AmenityCreateDto()
            {
                Title = _amenityAddView.AmenityTitle,
                Detail = _amenityAddView.AmenityDetail,
                Price = _amenityAddView.AmenityPrice,
                Status = _amenityAddView.AmenityStatus
            };

            try
            {
                await _amenityService.CreateAsync(amenity);
                AmenityPresenter.Instance.LoadAmenityList();
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Amenity created successfully!");
                _amenityAddView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
