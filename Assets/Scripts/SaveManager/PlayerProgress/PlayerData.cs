using UnityEngine;
[System.Serializable]
public class PlayerData
{
    // public int level;
    public int currentLevel;

    public int maxLevel;
    public int score;
    public int health;

    public float posX;
    public float posY;
    public float posZ;


    // public PlayerData(int level, int score, float health, float posX, float posY, float posZ)
    // {
    //     this.level = level;
    //     this.score = score;
    //     this.health = health;
    //     this.posX = posX;
    //     this.posY = posY;
    //     this.posZ = posZ;
    // }

    public PlayerData(int currentLevel, int maxLevel, int score, int health, float posX, float posY, float posZ)
    {
        this.currentLevel = currentLevel;

        this.maxLevel = maxLevel;

        this.score = score;

        this.health = health;

        this.posX = posX;

        this.posY = posY;

        this.posZ = posZ;
    }



}
