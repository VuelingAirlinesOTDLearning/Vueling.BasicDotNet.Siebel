using System;
using Vueling.Extensions.Library.DI;
using Vueling.XXX.Contracts.DTO.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary;
using Vueling.XXX.Contracts.ServiceLibrary.DTO;
using Vueling.XXX.Impl.ServiceLibrary.Mapping;
using Vueling.XXX.Library.DomainServicesContracts;
using Vueling.XXX.Library.Entities;

namespace Vueling.XXX.Impl.ServiceLibrary
{
    [RegisterService]
    public class SeatAssignmentApplicationService : ISeatAssignmentApplicationService
    {
        private readonly ISeatAssignment _seatAssignment;
        private readonly ILocalMapper _localMapper;

        public SeatAssignmentApplicationService(ISeatAssignment seatAssignment,
            ILocalMapper localMapper)
        {
            _seatAssignment = seatAssignment;
            _localMapper = localMapper;
        }

        public bool AssignSeatWithValidation(FlightDTO flight, SeatDTO seatDTO)
        {
            var result = false;

            ValidateDTOsProperties(flight, seatDTO);

            var aircraft = new Aircraft(flight.Identifier, flight.DepartureTime);

            if (_seatAssignment.ValidateTimeLimitBeforeFlightForAssignment(aircraft))
            {
                Seat seat = _localMapper.Map<SeatDTO, Seat>(seatDTO);
                result = _seatAssignment.Assign(aircraft, seat);
            }
            
            return result;
        }

        private void ValidateDTOsProperties(FlightDTO flight, SeatDTO seatDTO)
        {
            if (flight.Identifier != null && flight.Identifier.Length == 0) throw new ArgumentException("Empty flightNumber");
            if (flight.DepartureTime == null) throw new ArgumentNullException("Null departureDate");
            if (seatDTO == default(SeatDTO)) throw new ArgumentNullException("Null seatDTO");
        }


        public bool UnassignSeatWithValidation(FlightDTO flight, SeatDTO seatDTO)
        {
            var result = false;

            ValidateDTOsProperties(flight, seatDTO);

            var aircraft = new Aircraft(flight.Identifier, flight.DepartureTime);

            if (_seatAssignment.ValidateTimeLimitBeforeFlightForAssignment(aircraft))
            {
                var seat = _localMapper.Map<SeatDTO, Seat>(seatDTO);
                result = _seatAssignment.Unassign(aircraft, seat);
            }

            return result;
        }

        public bool ChangeSeatWithValidation(FlightDTO flight, SeatDTO oldSeatDTO, SeatDTO newSeatDTO)
        {
            var result = this.UnassignSeatWithValidation(flight, oldSeatDTO) && this.AssignSeatWithValidation(flight, newSeatDTO);
            return result;
        }
    }
}
