using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ArmyManagement : MonoBehaviour
{
    public Army armyScript;
    public GameObject armyManagement;

    public void SetArmyManagement()
    {
        armyManagement.transform.Find("nameText").GetComponent<Text>().text = armyScript.leadingHero.heroName;
        armyManagement.transform.Find("Hero").GetComponent<Image>().sprite = armyScript.leadingHero.heroSprite;
    }
}
