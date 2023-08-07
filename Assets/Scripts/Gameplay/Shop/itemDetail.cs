using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BGS.Player;


namespace BGS.Shop
{
    public class itemDetail : MonoBehaviour
    {

        [SerializeField]
        private Image itemImage;

        [SerializeField]
        private float itemPrice;

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
            buyItem.onClick.AddListener(delegate { OnBuyItem(_isOwned); });
            sellItem.onClick.AddListener(delegate { OnSellItem(_isOwned); });
            equipItem.onClick.AddListener( OnEquipItem);
            previewItem.onClick.AddListener( OnPreviewItem);
        }

        private void OnBuyItem(bool _isOwned)
        {
            //mechanic minus
            _isOwned = true;
            buyItem.interactable = false;
            sellItem.interactable = true;
            equipItem.interactable = true;
            _shopItemData.isOwned = true;
            SetBoughtItem();
        }

        private void SetBoughtItem()
        {
            switch (itemIndex)
            {
                case 8:
                    BuyWeapon();
                    break;
                case 7:
                    BuyBoots();
                    break;
                case 6:
                    BuyBottom();
                    break;
                case 5:
                    BuyGloves();
                    break;
                case 4:
                    BuyTop();
                    break;
                case 3:
                    BuyHeadAcc();
                    break;
                case 2:
                    BuyHead();
                    break;
                case 1:
                    BuyFace();
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void BuyFace()
        {
            ShopItem.instance.playerAccSpriteStruct.faceSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.faceSprite[itemPosition].isOwned = true;
        }
        private void BuyHead()
        {
            ShopItem.instance.playerAccSpriteStruct.headSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.headSprite[itemPosition].isOwned = true;
        }
        private void BuyHeadAcc()
        {
            ShopItem.instance.playerAccSpriteStruct.headAccSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.headAccSprite[itemPosition].isOwned = true;
        }
        private void BuyTop()
        {
            ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.topSprite[itemPosition].isOwned = true;
        }
        private void BuyGloves()
        {
            ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.glovesSprite[itemPosition].isOwned = true;
        }
        private void BuyBottom()
        {
            ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.bottomSprite[itemPosition].isOwned = true;
        }
        private void BuyBoots()
        {
            ShopItem.instance.playerAccSpriteStruct.bootsSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.bootsSprite[itemPosition].isOwned = true;
        }
        private void BuyWeapon()
        {
            ShopItem.instance.playerAccSpriteStruct.weaponSprite[itemPosition].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.weaponSprite[itemPosition].isOwned = true;

        }

        private void OnSellItem(bool _isOwned)
        {
            //mechanic plus
            _isOwned = false;
            buyItem.interactable = true;
            sellItem.interactable = false;
            equipItem.interactable = false;
        }

        private void OnEquipItem()
        {
            switch (itemIndex)
            {
                case 8:
                    EquipWeapon();
                    break;
                case 7:
                    EquipBoots();
                    break;
                case 6:
                    EquipBottom();
                    break;
                case 5:
                    EquipGloves();
                    break;
                case 4:
                    EquipTop();
                    break;
                case 3:
                    EquipHeadAcc();
                    break;
                case 2:
                    EquipHead();
                    break;
                case 1:
                    EquipFace();
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void EquipFace()
        {
            PlayerAcc.instance.playerAccStruct.face.face.sprite = ShopItem.instance.playerAccSpriteStruct.faceSprite[itemPosition].face;
        }

        private void EquipHead()
        {
            PlayerAcc.instance.playerAccStruct.head.head.sprite = ShopItem.instance.playerAccSpriteStruct.headSprite[itemPosition].head;
        }
        private void EquipHeadAcc()
        {
            PlayerAcc.instance.playerAccStruct.headAcc.headAcc.sprite = ShopItem.instance.playerAccSpriteStruct.headAccSprite[itemPosition].headAcc;
        }
        
        private void EquipTop()
        {
            PlayerAcc.instance.playerAccStruct.top.bodyUp.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].bodyUp;
            PlayerAcc.instance.playerAccStruct.top.shoulderLeft.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].shoulderLeft;
            PlayerAcc.instance.playerAccStruct.top.shoulderRight.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].shoulderRight;
        }
        private void EquipGloves()
        {
            PlayerAcc.instance.playerAccStruct.gloves.leftElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].leftElbow;
            PlayerAcc.instance.playerAccStruct.gloves.rightElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].rightElbow;
            PlayerAcc.instance.playerAccStruct.gloves.leftWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].leftWrist;
            PlayerAcc.instance.playerAccStruct.gloves.rightWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].rightWrist;
        }

        private void EquipBottom()
        {
            PlayerAcc.instance.playerAccStruct.bottom.pelvis.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].pelvis;
            PlayerAcc.instance.playerAccStruct.bottom.legLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].legLeft;
            PlayerAcc.instance.playerAccStruct.bottom.legRight.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].legRight;
        }

        private void EquipBoots()
        {
            PlayerAcc.instance.playerAccStruct.boots.bootsLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[itemPosition].bootsLeft;
            PlayerAcc.instance.playerAccStruct.boots.bootsRight.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[itemPosition].bootsRight;
        }

        private void EquipWeapon()
        {
            PlayerAcc.instance.playerAccStruct.weapon.weaponL.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[itemPosition].weapon;
            PlayerAcc.instance.playerAccStruct.weapon.weaponR.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[itemPosition].weapon;
        }
        private void OnPreviewItem()
        {
            switch (itemIndex)
            {
                case 8:
                    PreviewWeapon();
                    break;
                case 7:
                    PreviewBoots();
                    break;
                case 6:
                    PreviewBottom();
                    break;
                case 5:
                    PreviewGloves();
                    break;
                case 4:
                    PreviewTop();
                    break;
                case 3:
                    PreviewHeadAcc();
                    break;
                case 2:
                    PreviewHead();
                    break;
                case 1:
                    PreviewFace();
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void PreviewFace()
        {
            PlayerAccCam.instance.playerAccStruct.face.face.sprite = ShopItem.instance.playerAccSpriteStruct.faceSprite[itemPosition].face;
        }

        private void PreviewHead()
        {
            PlayerAccCam.instance.playerAccStruct.head.head.sprite = ShopItem.instance.playerAccSpriteStruct.headSprite[itemPosition].head;
        }
        private void PreviewHeadAcc()
        {
            PlayerAccCam.instance.playerAccStruct.headAcc.headAcc.sprite = ShopItem.instance.playerAccSpriteStruct.headAccSprite[itemPosition].headAcc;
        }
        
        private void PreviewTop()
        {
            PlayerAccCam.instance.playerAccStruct.top.bodyUp.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].bodyUp;
            PlayerAccCam.instance.playerAccStruct.top.shoulderLeft.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].shoulderLeft;
            PlayerAccCam.instance.playerAccStruct.top.shoulderRight.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[itemPosition].shoulderRight;
        }
        private void PreviewGloves()
        {
            PlayerAccCam.instance.playerAccStruct.gloves.leftElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].leftElbow;
            PlayerAccCam.instance.playerAccStruct.gloves.rightElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].rightElbow;
            PlayerAccCam.instance.playerAccStruct.gloves.leftWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].leftWrist;
            PlayerAccCam.instance.playerAccStruct.gloves.rightWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[itemPosition].rightWrist;
        }

        private void PreviewBottom()
        {
            PlayerAccCam.instance.playerAccStruct.bottom.pelvis.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].pelvis;
            PlayerAccCam.instance.playerAccStruct.bottom.legLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].legLeft;
            PlayerAccCam.instance.playerAccStruct.bottom.legRight.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[itemPosition].legRight;
        }

        private void PreviewBoots()
        {
            PlayerAccCam.instance.playerAccStruct.boots.bootsLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[itemPosition].bootsLeft;
            PlayerAccCam.instance.playerAccStruct.boots.bootsRight.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[itemPosition].bootsRight;
        }

        private void PreviewWeapon()
        {
            PlayerAccCam.instance.playerAccStruct.weapon.weaponL.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[itemPosition].weapon;
            PlayerAccCam.instance.playerAccStruct.weapon.weaponR.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[itemPosition].weapon;
        }
    }
}
