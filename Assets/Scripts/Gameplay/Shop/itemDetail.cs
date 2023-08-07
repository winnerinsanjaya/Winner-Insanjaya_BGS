using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BGS.Player;
using BGS.Currency;
using PlayFab;


namespace BGS.Shop
{
    public class itemDetail : MonoBehaviour
    {

        [SerializeField]
        private Image itemImage;

        [SerializeField]
        private int itemPrice;

        [SerializeField]
        private Text textPrice;

        public Button buyItem;
        public Button sellItem;
        public Button equipItem;
        public Button previewItem;

        private int itemIndex;

        private int itemPosition;

        private bool isOwned;

        private ShopItemData _shopItemData;


        public void ChangeItemDetail(ShopItemData shopItemData,Sprite spr, int idx, int itemPos)
        {
            _shopItemData = shopItemData;
            itemImage.sprite = spr;
            itemPrice = shopItemData.price;
            textPrice.text = "$ " + itemPrice;
            isOwned = shopItemData.isOwned;
            itemIndex = idx;
            itemPosition = itemPos;

            Debug.Log("INDEXX TOPENG "+ itemPosition);
        }

        public void SetButton(bool _isOwned)
        {
            buyItem.onClick.AddListener(OnBuyItem);
            sellItem.onClick.AddListener(OnSellItem);
            equipItem.onClick.AddListener( OnEquipItem);
            previewItem.onClick.AddListener( OnPreviewItem);
        }

        private void OnBuyItem()
        {
            int money = PlayerCurrency.instance.CheckMoney();

            if(money >= itemPrice)
            {
                PlayerCurrency.instance.DecreaseMoney(itemPrice);
                buyItem.interactable = false;
                sellItem.interactable = true;
                equipItem.interactable = true;
                _shopItemData.isOwned = true;
                ItemBuy.instance.OnBuyItem(itemIndex, itemPosition);

                return;
            }
            
            if(money < itemPrice)
            {
                Debug.Log("NotEnouigh");
            }
            
        }
        private void OnSellItem()
        {
            PlayerCurrency.instance.IncreaseMoney(itemPrice);
            buyItem.interactable = true;
            sellItem.interactable = false;
            equipItem.interactable = false;
            _shopItemData.isOwned = false;
            ItemSell.instance.OnSellItem(itemIndex, itemPosition);
        }

        private void OnEquipItem()
        {
            ItemEquip.instance.OnEquipItem(itemIndex, itemPosition);
        }

        private void OnPreviewItem()
        {
            ItemEquip.instance.OnPreviewItem(itemIndex, itemPosition);
        }
    }
}
