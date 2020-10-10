using UnityEngine;

public class DataManager : MonoBehaviour
{
    private Player _player;
    //private Bicho[] _bichos;
    private BichoTop[] _bichos;

    public void LoadGame()
    {
        _player = JsonUtility.FromJson<Player>(TextReader.ReadString("Assets/Resources/player.json")[0]);
        var savedFile = TextReader.ReadString("Assets/Resources/bichos.json");
        var i = 0;
        foreach (var savedBicho in savedFile)
        {
            _bichos[i] = JsonUtility.FromJson<BichoTop>(savedBicho);
            i++;
        }
    }

    public void SaveGame()
    {
        
    }

    public void CreatePlayer(string name)
    {
        Player player = new Player(name,0,0,0,0);
        TextReader.WriteString("Assets/Resources/player.json",JsonUtility.ToJson(player));
    }

    public Player GetPlayer()
    {
        return JsonUtility.FromJson<Player>(TextReader.ReadString("Assets/Resources/player.json")[0]);
    }

    /*public BichoTop[] GetBichos()
    {
        return JsonUtility.FromJson<BichoTop[]>(TextReader.ReadString("Assets/Resources/bichos.txt"));
    }*/
}
