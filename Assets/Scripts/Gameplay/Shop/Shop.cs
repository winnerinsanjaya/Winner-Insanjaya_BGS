using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BGS.Player;

namespace BGS.Shop {
    public class Shop : MonoBehaviour
    {
        public static Shop instance;

        [SerializeField]
        private Transform shopItemContainer;

        [SerializeField]
        private GameObject shopItemPrefabs;

        [SerializeField]
        private GameObject itemDetailContainer;

        private itemDetail _itemDetail;

        [SerializeField]
        private GameObject shopCanvas;

        private void Awake()
        {
            instance = this;
        }

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
            ResetPreview();
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

        private void ResetPreview()
        {
            PlayerAccCam.instance.playerAccStruct.face.face.sprite = PlayerAcc.instance.playerAccStruct.face.face.sprite;
            PlayerAccCam.instance.playerAccStruct.head.head.sprite = PlayerAcc.instance.playerAccStruct.head.head.sprite;
            PlayerAccCam.instance.playerAccStruct.headAcc.headAcc.sprite = PlayerAcc.instance.playerAccStruct.headAcc.headAcc.sprite;
            PlayerAccCam.instance.playerAccStruct.top.bodyUp.sprite = PlayerAcc.instance.playerAccStruct.top.bodyUp.sprite;
            PlayerAccCam.instance.playerAccStruct.top.shoulderLeft.sprite = PlayerAcc.instance.playerAccStruct.top.shoulderLeft.sprite;
            PlayerAccCam.instance.playerAccStruct.top.shoulderRight.sprite = PlayerAcc.instance.playerAccStruct.top.shoulderRight.sprite;
            PlayerAccCam.instance.playerAccStruct.gloves.leftElbow.sprite = PlayerAcc.instance.playerAccStruct.gloves.leftElbow.sprite;
            PlayerAccCam.instance.playerAccStruct.gloves.rightElbow.sprite = PlayerAcc.instance.playerAccStruct.gloves.rightElbow.sprite;
            PlayerAccCam.instance.playerAccStruct.gloves.leftWrist.sprite = PlayerAcc.instance.playerAccStruct.gloves.leftWrist.sprite;
            PlayerAccCam.instance.playerAccStruct.gloves.rightWrist.sprite = PlayerAcc.instance.playerAccStruct.gloves.rightWrist.sprite;
            PlayerAccCam.instance.playerAccStruct.bottom.pelvis.sprite = PlayerAcc.instance.playerAccStruct.bottom.pelvis.sprite;
            PlayerAccCam.instance.playerAccStruct.bottom.legLeft.sprite = PlayerAcc.instance.playerAccStruct.bottom.legLeft.sprite;
            PlayerAccCam.instance.playerAccStruct.bottom.legRight.sprite = PlayerAcc.instance.playerAccStruct.bottom.legRight.sprite;
            PlayerAccCam.instance.playerAccStruct.boots.bootsLeft.sprite = PlayerAcc.instance.playerAccStruct.boots.bootsLeft.sprite;
            PlayerAccCam.instance.playerAccStruct.boots.bootsRight.sprite = PlayerAcc.instance.playerAccStruct.boots.bootsRight.sprite;
            PlayerAccCam.instance.playerAccStruct.weapon.weaponL.sprite = PlayerAcc.instance.playerAccStruct.weapon.weaponL.sprite;
            PlayerAccCam.instance.playerAccStruct.weapon.weaponR.sprite = PlayerAcc.instance.playerAccStruct.weapon.weaponR.sprite;

        }
        private void ClearItem()
        {
            itemDetailContainer.SetActive(false);
            foreach (Transform child in shopItemContainer)
            {
                Destroy(child.gameObject);
            }
        }

        public void ResetShop()
        {
            itemDetailContainer.SetActive(false);
            ClearItem();
            ResetPreview();
        }

        public void SetShopping(bool isShopping)
        {
            if (isShopping)
            {
                shopCanvas.SetActive(true);
                Time.timeScale = 0;
                return;
            }

            if (!isShopping)
            {
                ResetShop();
                shopCanvas.SetActive(false);
                Time.timeScale = 1;
                return;
            }
        }

    }
}
