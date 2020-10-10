using TMPro;
using UnityEngine;

public class BienvenidaMnager : MonoBehaviour
{
    public TMP_InputField userName;
    private DataManager _dataManager;
    
    public void registerNewUser()
    {
        _dataManager.CreatePlayer(userName.text);
    }
    // Start is called before the first frame update
    void Start()
    {
        _dataManager = GameObject.FindWithTag("GameController").GetComponent<DataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
