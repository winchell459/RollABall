using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamond : MonoBehaviour
{
    public Text DiamondText;
    public int DiamondValue = 1;

	public void OnTriggerEnter(Collider other)
	{
        if (other.CompareTag("Player")){
            int diamonds = int.Parse(DiamondText.text);
            diamonds += DiamondValue;
            DiamondText.text = diamonds.ToString();
            Destroy(gameObject);
        }
	}
}
