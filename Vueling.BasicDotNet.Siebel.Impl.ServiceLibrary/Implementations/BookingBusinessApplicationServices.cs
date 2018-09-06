using Vueling.Extensions.Library.DI;
using Vueling.XXX.Contracts.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary.DTO;
using Vueling.XXX.Impl.ServiceLibrary.Mapping;
using Vueling.XXX.Library.Entities;

namespace Vueling.XXX.Impl.ServiceLibrary.Implementations
{
    [RegisterService]
    public class BookingBusinessApplicationServices : IBookingBusinessApplicationServices
    {
        private readonly ILocalMapper _localMapper;

        public BookingBusinessApplicationServices(ILocalMapper localMapper)
        {
            _localMapper = localMapper;
        }

        public bool IsAlreadyFlew(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return booking.IsAlreadyFlew();
        }

        public decimal GetTotalPrice(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return booking.GetTotalPrice();
        }

        public string GetRoute(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return booking.GetRoute();
        }
    }
}
