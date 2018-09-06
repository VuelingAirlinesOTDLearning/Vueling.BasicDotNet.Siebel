using Vueling.Extensions.Library.DI;
using Vueling.XXX.Contracts.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary.DTO;
using Vueling.XXX.Impl.ServiceLibrary.Mapping;
using Vueling.XXX.Library.DomainServicesContracts;
using Vueling.XXX.Library.Entities;

namespace Vueling.XXX.Impl.ServiceLibrary.Implementations
{
    [RegisterService]
    public class BookingValidationApplicationServices : IBookingValidationApplicationServices
    {
        private readonly IBookingFeaturesDomainServices _bookingValidationDomainServices;
        private readonly ILocalMapper _localMapper;

        public BookingValidationApplicationServices(IBookingFeaturesDomainServices bookingValidationDomainServices,
            ILocalMapper localMapper)
        {
            _bookingValidationDomainServices = bookingValidationDomainServices;
            _localMapper = localMapper;
        }

        public bool IsAgency(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return _bookingValidationDomainServices.IsAgency(booking);
        }

        public bool IsCorporate(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return _bookingValidationDomainServices.IsCorporate(booking);
        }

        public bool IsEnabledToAddNewJourneys(BookingDTO bookingDto)
        {
            var booking = _localMapper.Map<BookingDTO, Booking>(bookingDto);

            return _bookingValidationDomainServices.IsEnabledToAddNewJourneys(booking);
        }
    }
}
