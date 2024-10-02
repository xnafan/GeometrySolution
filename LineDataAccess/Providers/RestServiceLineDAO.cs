using LineDataAccess.Model;
using LineDataAccess.Providers;
using RestSharp;

namespace GeometryWindowsUI.Provider;

public class RestServiceLineDAO : ILineDAO
{
    public string BaseUrl { get; private set; }
    private RestClient _client;

    public RestServiceLineDAO(string baseUrl)
    {
        BaseUrl = baseUrl;
        _client = new RestClient(BaseUrl);
    }

    public IEnumerable<Line> GetAll() 
    {
        return _client.Get<IEnumerable<Line>>(new RestRequest()) ?? new List<Line>();
    }

    public Line? Get(int id)
    {
        var request = new RestRequest($"{id}");
        return _client.Get<Line>(request);
    }

    public bool Delete(int id)
    {
        var request = new RestRequest($"{id}", Method.Delete);
        return _client.Delete<bool>(request);
    }

    public bool Update(Line line)
    {
        var request = new RestRequest().AddBody(line);
        return _client.Put<bool>(request);
    }

    public int Insert(Line line)
    {
        var request = new RestRequest("", Method.Post);
        request.AddBody(line);
        return (_client.Post<int>(request));
    }
}