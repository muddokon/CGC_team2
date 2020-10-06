using UnityEngine;

public class DataManager : MonoBehaviour
{
    private Player _player;
    //private Bicho[] _bichos;
    private BichoTop[] _bichos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        _player = JsonUtility.FromJson<Player>(TextReader.ReadString("Assets/Resources/player.txt")[0]);
        var savedFile = TextReader.ReadString("Assets/Resources/bichos.txt");
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

    public void CreatePlayer()
    {
        
    }

    public void GetPlayer()
    {
        
    }

    public void GetBicho()
    {
        
    }
}
