using System.Data;
using LineDataAccess.Model;
using Dapper;
using System.Data.SqlClient;
using System.Drawing;

namespace LineDataAccess.Providers;

public class MsSqlLineDAO : ILineDAO
{
    public string ConnectionString { get; set; }

    #region SQL CRUD statements
    private static readonly string INSERT_SQL = "INSERT INTO line (Point1_x, Point1_y, Point2_x, Point2_y) OUTPUT INSERTED.Id VALUES (@Point1_x, @Point1_y, @Point2_x, @Point2_y)";
    private static readonly string DELETE_SQL = "DELETE FROM line WHERE Id=@Id";
    private static readonly string SELECT_ALL_SQL = "SELECT * FROM line";
    private static readonly string SELECT_ONE_SQL = "SELECT * FROM line WHERE Id=@Id";
    private static readonly string UPDATE_SQL = "UPDATE line  SET Point1_x=@Point1_x, Point1_y=@Point1_y, Point2_x = @Point2_x, Point2_y=@Point2_y WHERE Id=@Id";

    #endregion
    public MsSqlLineDAO(string connectionString) => ConnectionString = connectionString;
    private IDbConnection CreateConnection() => new SqlConnection(ConnectionString);

    #region Dapper CRUD
    public int Insert(Line line) => CreateConnection().ExecuteScalar<int>(INSERT_SQL, new FlatLine(line));
    public bool Delete(int id) => CreateConnection().Execute(DELETE_SQL, new { id }) > 0;
    public Line? Get(int id) => CreateConnection().QuerySingle<FlatLine>(SELECT_ONE_SQL).ToLine();
    public IEnumerable<Line> GetAll() => CreateConnection().Query<FlatLine>(SELECT_ALL_SQL).ToList().ConvertAll(flatLine => flatLine.ToLine());
    public bool Update(Line line) => CreateConnection().Execute(UPDATE_SQL, new FlatLine(line)) > 0;
    #endregion

    #region FlatLine helper class for CRUD in DB
    //This struct is a helper class to facilitate conversion
    //to and from a Line to a model object usable by Dapper.
    //The issue it solves is that the Point object attributes on the Line object
    //have their own X and Y attributes, which aren't addressable
    //when saving/loading from DB using Dapper.
    // The FlatLine class stores the two Point structs' X and Y on itself.
    struct FlatLine
    {
        public int Id { get; set; } = 0;
        public int Point1_x { get; set; } = 0;
        public int Point1_y { get; set; } = 0;
        public int Point2_x { get; set; } = 0;
        public int Point2_y { get; set; } = 0;
        public FlatLine() { }
        public FlatLine(Line line)
        {
            Id = line.Id;
            Point1_x = line.Point1.X;
            Point1_y = line.Point1.Y;
            Point2_x = line.Point2.X;
            Point2_y = line.Point2.Y;
        }
        public Line ToLine() => new Line(new Point(Point1_x, Point1_y), new Point(Point2_x, Point2_y)) { Id = this.Id };
    } 
    #endregion

}