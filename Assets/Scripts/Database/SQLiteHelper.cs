using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class SQLiteHelper : MonoBehaviour
{
    private IDbCommand dbcmd;
    private IDataReader reader;
    private IDbConnection dbcon;
    
    // Start is called before the first frame update
    void Start()
    {
        string connection = "URI=file:" + Application.persistentDataPath + "/allchemist";
        dbcon = new SqliteConnection(connection);
        dbcon.Open();

        dbcmd = dbcon.CreateCommand();
        string q_createTable = 
            "CREATE TABLE IF NOT EXISTS bichos (id INTEGER PRIMARY KEY AUTOINCREMENT, family_top VARCHAR(10), family_bottom VARCHAR(10), purity VARCHAR(20), material VARCHAR(20))";

        dbcmd.CommandText = q_createTable;
        reader = dbcmd.ExecuteReader();
        
        dbcon.Close();
    }

    public void CreateBicho(Bicho _bicho)
    {
        dbcon.Open();
        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO bichos " +
                           "(id, family_top, family_bottom, purity, material) " +
                           "VALUES " +
                           "("+ _bicho.ID + "," + _bicho.FamilyTop.ToString()+ "," + _bicho.FamilyBottom.ToString() + "," + _bicho.Purity.ToString() + "," + _bicho.Material.ToString()+")";
        cmnd.ExecuteNonQuery();
        dbcon.Close();
    }

    public Bicho GetBicho(int _id)
    {
        Bicho bicho = null;
        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader;
        string query ="SELECT * FROM bichos WHERE ID=" + _id;
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        while (reader.Read())
        {
            bicho = new Bicho((int)reader[0], (Bicho.Families)reader[1], (Bicho.Families)reader[2], (Bicho.Purities)reader[3], (Bicho.Materials)reader[4]);
        }
        dbcon.Close();
        return bicho;
    }
    
    public Bicho[] GetBichos()
    {
        Bicho[] bicho = null;
        int i = 0;
        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader;
        string query ="SELECT * FROM bichos";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        while (reader.Read())
        {
            bicho[i] = new Bicho((int)reader[0], (Bicho.Families)reader[1], (Bicho.Families)reader[2], (Bicho.Purities)reader[3], (Bicho.Materials)reader[4]);
            i++;
        }
        dbcon.Close();
        return bicho;
    }

    public void DeleteBicho(int _id)
    {
        Bicho bicho = null;
        IDbCommand cmnd_read = dbcon.CreateCommand();
        IDataReader reader;
        string query ="DELETE FROM bichos WHERE ID=" + _id;
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        dbcon.Close();
    }
}
