using UnityEngine;

[RequireComponent(typeof(DataManager))]
public class GameManager : MonoBehaviour
{
    private DataManager _dataManager;

    public Player player;

    private void Awake()
    {
        _dataManager = GetComponent<DataManager>();
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
