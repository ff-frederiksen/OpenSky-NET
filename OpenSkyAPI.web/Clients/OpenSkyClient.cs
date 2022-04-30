using NodaTime;
using OpenSkyAPI.Web.Models;

namespace OpenSkyAPI.web;

public class OpenSkyClient : IOpenSkyClient
{
  private OpenSkyClient()
  {
  }

  private OpenSkyClient(string username, string password)
  {
  }

  public StateVectors GetStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses,
    BoundingBox boundingBox)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetOwnStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetOwnStateVectors(LocalDateTime time, List<string> icao24TransponderAddresses,
    List<int> receiverSerials)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetFlightsInTimeInterval(LocalDateTime timeBegin, LocalDateTime timeEnd)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetFlightsByAircraft(List<string> icao24TransponderAddresses, LocalDateTime timeBegin,
    LocalDateTime timeEnd)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetArrivalsByAirport(string airportIcao24, LocalDateTime timeBegin, LocalDateTime timeEnd)
  {
    throw new NotImplementedException();
  }

  public StateVectors GetDeparturesByAirport(string airportIcao24, LocalDateTime timeBegin, LocalDateTime timeEnd)
  {
    throw new NotImplementedException();
  }
}