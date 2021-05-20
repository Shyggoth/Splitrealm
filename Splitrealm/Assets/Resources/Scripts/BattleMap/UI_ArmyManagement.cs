using UnityEngine;
using UnityEngine.UI;

namespace Splitrealm
{
    public class UI_ArmyManagement : MonoBehaviour
    {
        public Player player;
        public GameObject armyManagement;
        public GameObject heroGO;
        public GameObject imot1GO;
        public GameObject imot2GO;
        public GameObject imot3GO;
        public GameObject imot4GO;

        public void OnEnable()
        {
            player = GameObject.Find("Player").GetComponent<Player>();
            heroGO.GetComponentInChildren<Text>().text = player.army.GetComponent<Army>().leadingHero.name;
            heroGO.GetComponent<Image>().sprite = player.army.GetComponent<Army>().leadingHero.heroSprite;
            imot1GO.GetComponent<Image>().sprite = player.army.GetComponent<Army>().units[0].unitSprite;
            imot1GO.transform.Find("amountText").GetComponent<Text>().text = player.army.GetComponent<Army>().amounts[0].ToString();
            imot1GO.transform.Find("typeText").GetComponent<Text>().text = player.army.GetComponent<Army>().units[0].type;
            imot2GO.GetComponent<Image>().sprite = player.army.GetComponent<Army>().units[1].unitSprite;
            imot2GO.transform.Find("amountText").GetComponent<Text>().text = player.army.GetComponent<Army>().amounts[1].ToString();
            imot2GO.transform.Find("typeText").GetComponent<Text>().text = player.army.GetComponent<Army>().units[1].type;
        }

        public void SetArmyManagement()
        {
            //armyManagement.transform.Find("nameText").GetComponent<Text>().text = armyScript.leadingHero.heroName;
            //armyManagement.transform.Find("Hero").GetComponent<Image>().sprite = armyScript.leadingHero.heroSprite;
        }

        public void SetAmount()
        {

        }

        public void GetAmount()
        {

        }

        public void SetHeroSprite()
        {

        }

        public void SetHeroName()
        {

        }

        public void SetUnit1()
        {

        }
    }
}