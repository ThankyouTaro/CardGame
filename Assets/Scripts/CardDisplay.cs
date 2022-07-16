using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI effectText;

    public Image backgroundImage;

    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {
        nameText.text = card.card_name;
        if (card is MonsterCard)
        {
            var monster = card as MonsterCard;
            attackText.text = monster.attack.ToString();
            healthText.text = monster.healthPoint.ToString();
            effectText.gameObject.SetActive(false);
        }
        else if (card is MagicCard)
        {
            var magic = card as MagicCard;
            effectText.text = magic.effect;
            attackText.gameObject.SetActive(false);
            healthText.gameObject.SetActive(false);
        }
    }
}
