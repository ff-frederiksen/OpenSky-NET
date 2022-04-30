namespace OpenSkyAPI.Web.Http;

public class NetHttpClient : IHTTPClient
{
  private readonly HttpClient _httpClient;

  public NetHttpClient()
  {
    _httpClient = new HttpClient();
  }

  public NetHttpClient(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }

  public void Dispose()
  {
    throw new NotImplementedException();
  }

  public Task<IResponse> DoRequest(IRequest request)
  {
    throw new NotImplementedException();
  }

  public void SetRequestTimeout(TimeSpan timeout)
  {
    throw new NotImplementedException();
  }
}