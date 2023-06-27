using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinManager : MonoBehaviour
{
    public int numberOfCoins;
    public FloatEvent onMoneyChanged;
    public TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = "Coins: " + numberOfCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
        coinsText.text = "Coins: " + numberOfCoins.ToString();
    }

    public void AddPoint()
    {
        numberOfCoins++;
        GameStateManager.EconomyManager.AddMoney(numberOfCoins);
        onMoneyChanged.Raise(numberOfCoins);
        coinsText.text = "Coins: " + numberOfCoins.ToString();
    }
}
