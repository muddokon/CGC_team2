using UnityEngine;

[RequireComponent(typeof(SQLiteHelper))]
public class DataManager : MonoBehaviour
{
    [SerializeField] private SQLiteHelper _helper;
    private Player _player;
    private Bicho[] _bichos;
    //private BichoTop[] _bichos;

    /*public void LoadGame()
    {
        _player = JsonUtility.FromJson<Player>(TextReader.ReadString("Assets/Resources/player.json")[0]);
        var savedFile = TextReader.ReadString("Assets/Resources/bichos.json");
        var i = 0;
        foreach (var savedBicho in savedFile)
        {
            _bichos[i] = JsonUtility.FromJson<BichoTop>(savedBicho);
            i++;
        }
    }*/

    public void CreatePlayer(string name)
    {
        /*Player player = new Player(name,0,0,0,0);
        TextReader.WriteString("Assets/Resources/player.json",JsonUtility.ToJson(player));*/
        PlayerPrefs.SetString("playername",name);
    }

    public string GetPlayer()
    {
        //return JsonUtility.FromJson<Player>(TextReader.ReadString("Assets/Resources/player.json")[0]);
        return PlayerPrefs.GetString("playername");
    }

    public Bicho[] GetBichos()
    {
        //return JsonUtility.FromJson<BichoTop[]>(TextReader.ReadString("Assets/Resources/bichos.txt"));
        return _helper.GetBichos();
    }
    
    public Bicho GetBicho(int _id)
    {
        //return JsonUtility.FromJson<BichoTop[]>(TextReader.ReadString("Assets/Resources/bichos.txt"));
        return _helper.GetBicho(_id);
    }
}
