using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BGS.Shop
{
    public class ShopTrigger : MonoBehaviour
    {
        [SerializeField]
        private GameObject shopCanvas;
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
    }
}
