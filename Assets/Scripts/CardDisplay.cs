using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour{
    public Card card;
    public Text nameText;
    public Text descriptionText;
    public Image artworkImage;
    
    public Text attackText;
    public Text defenseText;
    public int durationText;
    public Text manaCostText;
    void Start () {
        nameText.text = card.name;
        descriptionText.text = card.description;

        artworkImage.sprite = card.artwork;

        attackText.text = card.attack.ToString();
        defenseText.text = card.defense.ToString();
        durationText = card.duration;
        manaCostText.text = card.manaCost.ToString();
    }
}