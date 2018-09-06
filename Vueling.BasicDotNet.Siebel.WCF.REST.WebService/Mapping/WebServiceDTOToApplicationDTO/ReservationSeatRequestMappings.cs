using System;
using System.Globalization;
using Vueling.XXX.Contracts.DTO.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary.DTO;
using Vueling.XXX.WCF.REST.WebService.DTO;

namespace Vueling.XXX.WCF.REST.WebService.Mapping
{
    class ReservationSeatRequestMappings
    {

        internal static FlightDTO MapToFlightDTO(ReservationSeatRequestDTO reservationSeatDTO)
        {
            return new FlightDTO(reservationSeatDTO.FlighIdentifier, reservationSeatDTO.DepartureTime);
        }

        internal static SeatDTO MapToSeatDTO(ReservationSeatRequestDTO reservationSeatDTO)
        {
            return new SeatDTO(reservationSeatDTO.SeatRow.ToString(CultureInfo.InvariantCulture), reservationSeatDTO.SeatColum);
        }
    }
}