using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova Carta", menuName = "Carta", order = 1)]
public class CardScriptableObject : ScriptableObject
{
    public string cardName;

    [TextArea]
    public string actionDescription, cardLore;

    public int currentHealth, attackPower, manaCost;

    public Sprite characterSprite, bgSprite;
}
