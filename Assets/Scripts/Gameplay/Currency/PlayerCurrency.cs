using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PlayFab;

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

        public void SetMoney(int amt)
        {
            playerMoney = amt;
            UpdateMoneyUI();
        }

        public void DecreaseMoney(int amt)
        {
            playerMoney -= amt;
            UpdateMoneyUI();
            UpdateMoneyPlayfab();
        }

        public void IncreaseMoney(int amt)
        {
            playerMoney += amt;
            UpdateMoneyUI();
            UpdateMoneyPlayfab();
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

        private void UpdateMoneyPlayfab()
        {
            if (PlayFabClientAPI.IsClientLoggedIn())
            {
                if (PlayfabDatabase.instance == null)
                {
                    return;
                }
                PlayfabDatabase.instance.playerMoney = playerMoney;
                PlayfabDatabase.instance.SetMoneyData();
            }
        }
    }
}