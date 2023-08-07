using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BGS.Shop {
    public class Shop : MonoBehaviour
    {
        [SerializeField]
        private Transform shopItemContainer;

        [SerializeField]
        private GameObject shopItemPrefabs;

        [SerializeField]
        private GameObject itemDetailContainer;

        private itemDetail _itemDetail;

        private void Start()
        {
            _itemDetail = itemDetailContainer.GetComponent<itemDetail>();
        }

        public void GetItems(int idx)
        {
            ClearItem();
            switch (idx)
            {
                case 8:
                    GetWeaponData(idx);
                    break;
                case 7:
                    GetBootsData(idx);
                    break;
                case 6:
                    GetBottomData(idx);
                    break;
                case 5:
                    GetGlovesData(idx);
                    break;
                case 4:
                    GetTopData(idx);
                    break;
                case 3:
                    GetHeadAccData(idx);
                    break;
                case 2:
                    GetHeadData(idx);
                    break;
                case 1:
                    GetFace(idx);
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void GetFace(int idx)
        {
            for(int i = 0; i < ShopItem.instance.playerAccSpriteStruct.faceSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.faceSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.faceSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.faceSprite[i].face;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void GetHeadData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.headSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.headSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.headSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.headSprite[i].head;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }
        
        private void GetHeadAccData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.headAccSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.headAccSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.headAccSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.headAccSprite[i].headAcc;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void GetTopData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.topSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.topSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.topSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[i].bodyUp;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void GetGlovesData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.glovesSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.glovesSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.glovesSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[i].leftElbow;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }

        }
        
        private void GetBottomData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.bottomSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.bottomSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.bottomSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[i].pelvis;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void GetBootsData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.bootsSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.bootsSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.bootsSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[i].bootsLeft;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void GetWeaponData(int idx)
        {
            for (int i = 0; i < ShopItem.instance.playerAccSpriteStruct.weaponSprite.Count; i++)
            {
                GameObject item = Instantiate(shopItemPrefabs, shopItemContainer);

                item.name = "Item" + i;

                ShopItemData data = item.GetComponent<ShopItemData>();
                data.price = ShopItem.instance.playerAccSpriteStruct.weaponSprite[i].priceOwned.price;
                data.isOwned = ShopItem.instance.playerAccSpriteStruct.weaponSprite[i].priceOwned.isOwned;

                Image img = item.transform.GetChild(0).GetComponent<Image>();
                img.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[i].weapon;
                data.sprite = img.sprite;

                int n = i;

                Button btn = item.GetComponent<Button>();
                btn.onClick.AddListener(delegate { OnClickItems(data, img.sprite, idx, n, btn); });

            }
        }

        private void OnClickItems( ShopItemData shopItemData, Sprite spr, int idx, int itemPos, Button btn)
        {
            itemDetailContainer.SetActive(true);
            _itemDetail.ChangeItemDetail(shopItemData, spr, idx, itemPos);

            if (shopItemData.isOwned)
            {
                _itemDetail.equipItem.interactable = true;
                _itemDetail.buyItem.interactable = false;
                _itemDetail.sellItem.interactable = true;
            }
            
            if (!shopItemData.isOwned)
            {
                _itemDetail.equipItem.interactable = false;
                _itemDetail.buyItem.interactable = true;
                _itemDetail.sellItem.interactable = false;
            }

            _itemDetail.SetButton(shopItemData.isOwned);

            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(delegate { OnClickItems(shopItemData, spr, idx, itemPos, btn); });


        }

        private void ClearItem()
        {
            foreach (Transform child in shopItemContainer)
            {
                Destroy(child.gameObject);
            }
        }

    }
}
