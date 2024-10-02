using LineDataAccess.Model;

namespace LineDataAccess.Providers;

public interface ILineDAO
{
    IEnumerable<Line> GetAll();
    Line? Get(int id);
    bool Delete(int id);
    bool Update(Line line);
    int Insert(Line line);
}