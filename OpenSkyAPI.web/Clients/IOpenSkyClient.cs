using NodaTime;
using OpenSkyAPI.Web.Models;

namespace OpenSkyAPI.web;

public interface IOpenSkyClient
{
  StateVectors GetStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses);
  StateVectors GetStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses, BoundingBox boundingBox);
  StateVectors GetOwnStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses);

  StateVectors GetOwnStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses,
    List<int> receiverSerials);

  StateVectors GetFlightsInTimeInterval(LocalDateTime timeBegin, LocalDateTime timeEnd);

  StateVectors GetFlightsByAircraft(List<string> icao24TransponderAddresses, LocalDateTime timeBegin,
    LocalDateTime timeEnd);

  StateVectors GetArrivalsByAirport(string airportIcao24, LocalDateTime timeBegin, LocalDateTime timeEnd);
  StateVectors GetDeparturesByAirport(string airportIcao24, LocalDateTime timeBegin, LocalDateTime timeEnd);
}