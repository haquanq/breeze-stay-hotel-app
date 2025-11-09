using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Services.HotelService;
using HotelManagement.WinformApp.Views.HotelService;
using System;
using HotelManagement.WinformApp.Enums;
using HotelManagement.Presenters.Main;

namespace HotelManagement.WinformApp.Presenters.HotelService
{
    public class HotelServiceCreatePresenter
    {

        private readonly IHotelServiceAddView _hotelServiceCreateView;
        private readonly IHotelServiceService _hotelServiceService;
        public HotelServiceCreatePresenter(IHotelServiceAddView view, IHotelServiceService hotelServiceService)
        {
            /// inejcted
            _hotelServiceCreateView = view;
            _hotelServiceService = hotelServiceService;

            /// events
            _hotelServiceCreateView.OnAmenityViewLoad += HandleViewLoadEvent;
            _hotelServiceCreateView.OnHotelServiceAdd += HandleHotelServiceCreateEvent;
            _hotelServiceCreateView.OnCancel += HandleCancel;
        }

        /// <summary>
        /// Private methods for handling HotelServiceCreateView events
        /// </summary>

        private void HandleViewLoadEvent(object sender, EventArgs e)
        {
            ///....
        }

        private void HandleHotelServiceCreateEvent(object sender, EventArgs e)
        {
            CreateHotelService();
        }

        private void HandleCancel(object sender, EventArgs e) { _hotelServiceCreateView.Close(); }

        /// <summary>
        /// Public methods for handling HotelServiceCreateView logic
        /// </summary>

        public void ShowView() => _hotelServiceCreateView.Show();


        public async void CreateHotelService()
        {
            var hotelService = new HotelServiceCreateDto()
            {
                Title = _hotelServiceCreateView.HotelServiceTitle,
                Detail = _hotelServiceCreateView.HotelServiceDetail,
            };

            try
            {
                await _hotelServiceService.CreateAsync(hotelService);
                MainPresenter.Instance.ShowMessage(MessageType.INFO, "HotelService created successfully!");
                _hotelServiceCreateView.Close();
            }
            catch (Exception ex)
            {
                MainPresenter.Instance.ShowMessage(MessageType.ERROR, ex.Message);
            }
        }
    }
}
