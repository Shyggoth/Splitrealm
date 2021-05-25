using UnityEngine;
using UnityEngine.UI;

namespace Splitrealm
{
    public class UI_ArmyManagement : MonoBehaviour
    {
        public Player player;                       // The player object
        public GameObject armyManagement;           // The army managment gameobject
        public GameObject heroGO;                   // The hero gameobject
        public GameObject imot1GO;                  // The gameobject of the first unit in the army
        public GameObject imot2GO;                  // The gameobject of the second unit in the army
        public GameObject imot3GO;                  // The gameobject of the third unit in the army
        public GameObject imot4GO;                  // The gameobject of the fourth unit in the army

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

        // This method will be used to set an amount of a unit type in the army
        public void SetAmount(int amount)
        {

        }

        // This method will be used to get the amount of a unit type in the army
        public void GetAmount()
        {

        }

        // This method will be used to set the sprite of the hero in the army. Will be used for swaping out heroes.
        public void SetHeroSprite(Sprite heroImage)
        {

        }

        // This method wil be used to set the name of the hero, leading the army. Will be used for swapping out heroes
        public void SetHeroName(string newHeroName)
        {

        }

        // This method will be used to set the units in an army. Used for adding and swapping out units in the army
        public void SetUnit(int unitSlot)
        {

        }
    }
}