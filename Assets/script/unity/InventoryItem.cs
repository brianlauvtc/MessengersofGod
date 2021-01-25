using UnityEngine;
[CreateAssetMenu]
public class InventoryItem : ScriptableObject
{
    public Sprite sprite;
    public string Itemname ;
    public string introduction;
    public int buyprice;
    public int sell_price;
    public type Type;

    public restoretype Restoretype;
    public int restore;


    public int hp_bonus;
    public float Defense_bonus;
    public equipmenttype Equipmenttype;

    public int damage_bonus;
    public weapontype Weapontype;

}
public enum type
{

    prop,           //道具
    equipment,      //裝備
    weapon,          //武器
    crystal,
    missionobject
  

}
public enum equipmenttype
{

    head,          //頭
    clothes,        //衣服
    gloves,         //手套
    shoe,           //鞋
    trouser,      //褲
    weapon          //武器

}
public enum weapontype
{

    Broadsword,     //劍
    gun,            //槍
    wand,           //法杖
    bow             //弓

}

public enum restoretype
{

   hp,
   mp
  

}
