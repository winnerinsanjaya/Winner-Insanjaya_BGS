using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BGS.Currency
{
    public class PlayerCurrency : MonoBehaviour
    {
        public static PlayerCurrency instance;


        [SerializeField]
        private TextMeshProUGUI moneyText;
        
        [SerializeField]
        private int playerMoney;

        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            UpdateMoneyUI();
        }


        public void DecreaseMoney(int amt)
        {
            playerMoney -= amt;
            UpdateMoneyUI();
        }

        public void IncreaseMoney(int amt)
        {
            playerMoney += amt;
            UpdateMoneyUI();
        }

        public int CheckMoney()
        {
            Debug.Log(playerMoney);
            return playerMoney;
        }

        private void UpdateMoneyUI()
        {
            moneyText.text = "Money = " + playerMoney;
        }
    }
}