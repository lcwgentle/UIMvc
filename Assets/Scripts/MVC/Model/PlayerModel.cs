using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel 
{
    //��������
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
    //������ز���
    //��ʼ��
   public void Init()
    {
        playerName = PlayerPrefs.GetString("PlayerName", "liuchao");
        lev= PlayerPrefs.GetInt("PlayerName", 1);
        money = PlayerPrefs.GetInt("PlayerMoney", 1);
        gem = PlayerPrefs.GetInt("PlayerGem", 1);
        power = PlayerPrefs.GetInt("PlayerPower", 1);

        hp = PlayerPrefs.GetInt("PlayerHp", 1);
    }
    //���� ����
    public void LevUp()
    {
        //������������
    }

    public void SaveData()
    {
        //�����ݴ洢������
    }
    //����
}
