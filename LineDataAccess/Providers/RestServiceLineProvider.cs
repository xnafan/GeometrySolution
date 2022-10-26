using LineDataAccess.Model;
using LineDataAccess.Providers;
using RestSharp;

namespace GeometryWindowsUI.Provider
{
    public class RestServiceLineProvider : ILineProvider
    {
        public string BaseUrl { get; private set; }
        private RestClient _client;

        public RestServiceLineProvider(string baseUrl)
        {
            BaseUrl = baseUrl;
            _client = new RestClient(BaseUrl);
        }

        public IEnumerable<Line> GetLines() 
        {
            return _client.Get<IEnumerable<Line>>(new RestRequest()) ?? new List<Line>();
        }

        public Line? GetLine(int id)
        {
            var request = new RestRequest($"{id}");
            return _client.Get<Line>(request);
        }

        public bool DeleteLine(int id)
        {
            var request = new RestRequest($"{id}", Method.Delete);
            return _client.Delete<bool>(request);
        }

        public bool UpdateLine(Line line)
        {
            var request = new RestRequest();
            request.AddBody(line);
            return _client.Put<bool>(request);
        }

        public int AddLine(Line line)
        {
            var request = new RestRequest("", Method.Post);
            request.AddBody(line);
            return (_client.Post<int>(request));
        }
    }
}