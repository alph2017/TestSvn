using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit : MonoBehaviour
{
    public string  unitName;  //角色名称
    public int unitLevel;   //角色等级

    public GameObject equiped_weapon;

    public string Unit_fade_name;

//角色当前状态++++++++++++++++++++++++++++
    public int current_HP;  // 角色当前生命值
    public int  exp;  //经验
    public int double_dam_rate;

    public Image unit_hp;
    public Image unit_exp;

//加权影响结果++++++++++++++++++++++++++++
    public int damage;    //角色攻击力
    public int max_HP;    //角色生命值上限
    public int protect;   // 护甲
    public int magic_protect; //魔抗

   

// 角色初始自定义属性+++++++++++++++++++++++++++
    public int gif;     //资质
    public int  power;   //力量
    public int  swift;  //敏捷
    public int  body_enhance;  //体质
    public int lucky;    //幸运

//角色交互+++++++++++++++++++++++++++++++++++
    public int feelling_forPlayer;

// 技能++++++++++++++++++++++++++++++++++++

    
    public bool TakeDamage(int  out_damage){
        current_HP=current_HP-out_damage;
      
        if(current_HP<=0){
            return true;
        }else
        {
            return false;
        }
    }

//装备栏===============================================


}
