using System;

[Serializable]
public class Player
{
    public Player(string name, int coins, int coinBoost, int bichoBoost, int arenaBoost)
    {
        this.name = name;
        this.coins = coins;
        this.coinBoost = coinBoost;
        this.bichoBoost = bichoBoost;
        this.arenaBoost = arenaBoost;
    }

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
