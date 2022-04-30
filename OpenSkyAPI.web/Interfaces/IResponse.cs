using System.Net;

namespace OpenSkyAPI.Web;

/// <summary>
///   This Interface defines the default Response
/// </summary>
public interface IResponse
{
  object? Body { get; }

  IReadOnlyDictionary<string, string> Headers { get; }

  HttpStatusCode StatusCode { get; }

  string? ContentType { get; }
}