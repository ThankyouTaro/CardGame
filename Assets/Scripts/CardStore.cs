using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset cardData;
    public List<Card> cardList = new List<Card>();
    void Start()
    {
        LoadCardData();
        //TestLoad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadCardData()
    {
        string[] dataRow = cardData.text.Split('\n');
        foreach (var row in dataRow)
        {
            string[] rowArray = row.Split(',');
            if (rowArray[0] is "#")
            {
                continue;
            }
            else if (rowArray[0] is "monster")
            {
                int id = int.Parse(rowArray[1]);
                string name = rowArray[2];
                int atk = int.Parse(rowArray[3]);
                int health = int.Parse(rowArray[4]);
                MonsterCard monsterCard = new MonsterCard(id, name, atk, health);
                cardList.Add(monsterCard);

                //Debug.Log("Card:" + monsterCard.card_name);
            }
            else if (rowArray[0] is "spell")
            {
                int id = int.Parse(rowArray[1]);
                string name = rowArray[2];
                string effect = rowArray[3];
                MagicCard magicCard = new MagicCard(id, name, effect);
                cardList.Add(magicCard);
            }
        }
    }
    public void TestLoad()
    {
        foreach(var item in cardList)
        {
            Debug.Log("Card: " + item.ToString() + item.card_name);
        }
    }
    public Card RandomCard()
    {
        Card card = cardList[Random.Range(0, cardList.Count)];
        return card;
    }
}
