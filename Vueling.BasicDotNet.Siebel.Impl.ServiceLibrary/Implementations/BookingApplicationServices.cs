using System.Collections.Generic;
using System.Linq;
using Vueling.Extensions.Library.DI;
using Vueling.XXX.Contracts.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary.DTO;
using Vueling.XXX.Impl.ServiceLibrary.Mapping;
using Vueling.XXX.Library.DomainServicesContracts;
using Vueling.XXX.Library.Entities;

namespace Vueling.XXX.Impl.ServiceLibrary.Implementations
{
    [RegisterServiceAttribute]
    public class BookingApplicationServices : IBookingApplicationServices
    {
        private readonly IBookingDomainServices _bookingDomainServices;
        private readonly ILocalMapper _localMapper;

        public BookingApplicationServices(IBookingDomainServices bookingDomainServices,
            ILocalMapper localMapper)
        {
            _bookingDomainServices = bookingDomainServices;
            _localMapper = localMapper;
        }

        public int CreateBooking(int amount)
        {
            return _bookingDomainServices.CreateSampleBooking(amount);
        }

        public List<BookingDTO> GetActives()
        {
            var bookings = _bookingDomainServices.GetActives().ToList();
            return _localMapper.MapCollection<Booking, BookingDTO>(bookings).ToList();
        }

        public IQueryable<BookingDTO> GetAll()
        {
            var bookings = _bookingDomainServices.GetAll();

            return GetMappedAsQueryable(bookings);
        }

        public int GetActivesCount()
        {
            return _bookingDomainServices.GetActives().Count();
        }

        public List<BookingDTO> GetCanceled()
        {
            var bookings = _bookingDomainServices.GetCanceled().ToList();
            return _localMapper.MapCollection<Booking, BookingDTO>(bookings).ToList();
        }

        public List<BookingDTO> GetActivesByPages(int page, int pageSize)
        {
            var bookings = _bookingDomainServices.GetActives().OrderBy(x => x.Id).Skip(page - 1).Take(page * pageSize).ToList();
            return _localMapper.MapCollection<Booking, BookingDTO>(bookings).ToList();
        }

        public List<BookingDTO> GetCanceledByPages(int page, int pageSize)
        {
            var bookings = _bookingDomainServices.GetCanceled().OrderBy(x => x.Id).Skip(page - 1).Take(page * pageSize).ToList();
            return _localMapper.MapCollection<Booking, BookingDTO>(bookings).ToList();
        }

        public int ChangeFlights()
        {
            return _bookingDomainServices.ChangeFlights();
        }

        public int DividePrices()
        {
            return _bookingDomainServices.DividePrices();
        }

        private IQueryable<BookingDTO> GetMappedAsQueryable(IQueryable<Vueling.XXX.Library.Entities.Booking> entities)
        {
            return new Vueling.XXX.Impl.ServiceLibrary.Mapping.ToDTOAsIQueryable.FromBookingEntity()
                .GetCollection(entities);
        }
    }
}
