using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace BGS.Shop
{
    public class ShopTrigger : MonoBehaviour
    {
        [SerializeField]
        private Button okButton;
        [SerializeField]
        private Button noButton;

        [SerializeField]
        private GameObject shopCanvas;


        private void OnEnable()
        {
            okButton.onClick.AddListener(OnYesButton);
            noButton.onClick.AddListener(OnCloseButton);
        }
        private void OnDisable()
        {
            okButton.onClick.RemoveAllListeners();
            okButton.onClick.RemoveAllListeners();
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                shopCanvas.SetActive(true);
                
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Shop.instance.ResetShop();
                shopCanvas.SetActive(false);
            }
        }

        public void OnYesButton()
        {
            Shop.instance.SetShopping(true);
            shopCanvas.SetActive(false);
        }

        public void OnCloseButton()
        {
            Shop.instance.ResetShop();
            shopCanvas.SetActive(false);
        }
    }
}
