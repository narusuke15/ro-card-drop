using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDropButton : CustomButton
{
    public Text ResultText;
	public GameObject  PoringCard;
    protected override void OnClick()
    {
		bool cardFounded = false;
        int cardDropRate = 1;
        for (int i = 0; i < 50000; i++)
        {
            float t = Random.Range(0, 10000);
            Debug.Log(t);
            if (t < cardDropRate) // == 0
            {
				PoringCard.SetActive(true);
				cardFounded = true;
                Debug.Log("YEAH : " + t);
				ResultText.text = "you have to kill " + (i + 1) + " poring to get this";
				break;
            }
        }
		if(!cardFounded){
			ResultText.text = "50,000 poring died but no card found";
		}
    }
}
