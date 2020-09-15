using System;

[Serializable]
public class Player
{
    //primary attributes
    private string name;
    private int coins;
    
    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Coins
    {
        get => coins;
        set => coins = value;
    }

    //store boosts
    private int coinBoost;
    private int bichoBoost;
    private int arenaBoost;
    
    public int CoinBoost
    {
        get => coinBoost;
        set => coinBoost = value;
    }

    public int BichoBoost
    {
        get => bichoBoost;
        set => bichoBoost = value;
    }

    public int ArenaBoost
    {
        get => arenaBoost;
        set => arenaBoost = value;
    }
}
