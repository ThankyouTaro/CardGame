using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    // Start is called before the first frame update
    public int id;
    public string card_name;
    // Constructor
    public Card(int _id, string _name)
    {
        this.id = _id;
        this.card_name = _name;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class MonsterCard : Card
{
    public int attack;
    public int healthPoint;
    public int healthPointMax;
    public MonsterCard(int _id, string _name, int _attack, int _healthPointMax) : base(_id, _name)
    {
        
        this.attack = _attack;
        this.healthPoint = _healthPointMax;
        this.healthPointMax = _healthPointMax;
    }
}
public class MagicCard : Card
{
    public string effect;
    public MagicCard(int _id, string _name, string _effect) : base(_id, _name)
    {
        this.effect = _effect;
    }
}