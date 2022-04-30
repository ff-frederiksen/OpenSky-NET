﻿namespace OpenSkyAPI.Web;

/// <summary>
///   This interface defines the basic Request
/// </summary>
public interface IRequest
{
  Uri BaseAddress { get; }

  Uri Endpoint { get; }

  IDictionary<string, string> Headers { get; }

  IDictionary<string, string> Parameters { get; }

  HttpMethod Method { get; }

  object? Body { get; set; }
}