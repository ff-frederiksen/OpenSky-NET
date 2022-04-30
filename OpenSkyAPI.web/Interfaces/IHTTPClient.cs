namespace OpenSkyAPI.Web;

public interface IHTTPClient : IDisposable
{
  Task<IResponse> DoRequest(IRequest request);
  void SetRequestTimeout(TimeSpan timeout);
}