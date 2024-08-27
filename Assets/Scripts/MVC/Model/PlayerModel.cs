using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    //数据内容
    private string playerName;
    private int lev;
    private int money;
    private int gem;
    private int power;

    private int hp;
    private int atk;
    private int def;
    private int crit;
    private int miss;
    private int luck;
    //数据相关操作
    //初始化
   public void Init()
    {
        playerName = PlayerPrefs.GetString("PlayerName", "liuchao");
        lev= PlayerPrefs.GetInt("PlayerName", 1);
        money = PlayerPrefs.GetInt("PlayerMoney", 1);
        gem = PlayerPrefs.GetInt("PlayerGem", 1);
        power = PlayerPrefs.GetInt("PlayerPower", 1);

        hp = PlayerPrefs.GetInt("PlayerHp", 1);
    }
    //更新 升级
    public void LevUp()
    {
        //升级更新数据
    }

    public void SaveData()
    {
        //将数据存储到本地
    }
    //保存
}
