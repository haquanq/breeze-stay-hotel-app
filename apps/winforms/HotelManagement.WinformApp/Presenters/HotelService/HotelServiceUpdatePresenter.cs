using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Services.HotelService;
using HotelManagement.WinformApp.Views.HotelService;
using System;
using System.Threading.Tasks;
using HotelManagement.Presenters.Main;
using HotelManagement.WinformApp.Enums;

namespace HotelManagement.WinformApp.Presenters.HotelService
{
    public class HotelServiceUpdatePresenter
    {
        private readonly IHotelServiceUpdateView _hotelServiceUpdateView;
        private readonly IHotelServiceService _hotelServiceService;

        public HotelServiceUpdatePresenter(IHotelServiceUpdateView hotelServiceUpdateView, IHotelServiceService hotelServiceService)
        {
            /// injected
            _hotelServiceUpdateView = hotelServiceUpdateView;
            _hotelServiceService = hotelServiceService;

            /// events
            _hotelServiceUpdateView.OnAmenityViewLoad += HandleViewLoad;
            _hotelServiceUpdateView.OnHotelServiceSave += HandleHotelServiceSave;
            _hotelServiceUpdateView.OnHotelServiceDelete += HandleHotelServiceDelete;
            _hotelServiceUpdateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling HotelServiceUpdateView events
        /// </summary>

        private void HandleViewLoad(object sender, EventArgs e)
        {
            ///...
        }

        private void HandleHotelServiceSave(object sender, EventArgs e)
        {
            SaveHotelService();
        }

        private void HandleHotelServiceDelete(object sender, EventArgs e)
        {
            DeleteHotelService();
        }

        private void HandleCancel(object sender, EventArgs e) { _hotelServiceUpdateView.Close(); }

        /// <summary>
        /// Public methods for handling HotelServiceUpdateView logic
        /// </summary>

        public void ShowView(string hotelServiceId)
        {
            LoadHotelServiceById(hotelServiceId);
            _hotelServiceUpdateView.Show();
        }

        public async void LoadHotelServiceById(string hotelServiceId)
        {
            var hotelService = await Task.Run(() => _hotelServiceService.FindByIdAsync(hotelServiceId));

            _hotelServiceUpdateView.HotelServiceId = hotelService.HotelServiceId;
            _hotelServiceUpdateView.HotelServiceDetail = hotelService.Detail;
            _hotelServiceUpdateView.HotelServiceTitle = hotelService.Title;

        }

        public async void SaveHotelService()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to save these changes?");
            if (confirmed == false) return;

            var hotelService = new HotelServiceUpdateDto()
            {
                HotelServiceId = _hotelServiceUpdateView.HotelServiceId,
                Title = _hotelServiceUpdateView.HotelServiceTitle,
                Detail = _hotelServiceUpdateView.HotelServiceDetail,
            };

            try
            {
                await Task.Run(() => _hotelServiceService.UpdateAsync(hotelService));
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "Changes saved successfully!", "Success");
                HotelServicePresenter.Instance.LoadHotelServiceList();
                _hotelServiceUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);
            }
        }

        public async void DeleteHotelService()
        {
            bool confirmed = MainPresenter.Instance.ShowMessage(MessageType.ASK, "Do you want to delete this hotelService?");
            if (confirmed == false) return;

            try
            {
                await _hotelServiceService.DeleteByIdAsync(_hotelServiceUpdateView.HotelServiceId);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "HotelService deleted successfully!");
                _hotelServiceUpdateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.INFO, ex.Message);

            }
        }
    }
}
