using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollisions : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI CoinText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            //Debug.Log("is done!");
            AddCoin();
            other.gameObject.SetActive(false);
        }
    }
    public void AddCoin()
    {
        Score++;
        CoinText.text = "Score: " + Score.ToString();
    }
}
