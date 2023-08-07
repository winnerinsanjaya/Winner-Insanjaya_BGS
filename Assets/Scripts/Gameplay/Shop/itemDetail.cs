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

        private int itemIndex;

        private int itemPosition;

        private bool isOwned;

        public void ChangeItemDetail(Sprite spr, float price, bool _isOwned, int idx, int itemPos)
        {
            itemImage.sprite = spr;
            itemPrice = price;
            textPrice.text = "$ " + itemPrice;
            isOwned = _isOwned;
            itemIndex = idx;
            itemPosition = itemPos;

            Debug.Log("INDEXX TOPENG "+ itemPosition);
        }

        public void SetButton(bool _isOwned)
        {
            buyItem.onClick.AddListener(delegate { OnBuyItem(_isOwned); });
            sellItem.onClick.AddListener(delegate { OnSellItem(_isOwned); });
            equipItem.onClick.AddListener(delegate { OnEquipItem(itemIndex); });
        }

        private void OnBuyItem(bool _isOwned)
        {
            //mechanic minus
            _isOwned = true;
            buyItem.interactable = false;
            sellItem.interactable = true;
            equipItem.interactable = true;
        }

        private void OnSellItem(bool _isOwned)
        {
            //mechanic plus
            _isOwned = false;
            buyItem.interactable = true;
            sellItem.interactable = false;
            equipItem.interactable = false;
        }

        private void OnEquipItem(int idx)
        {
            switch (idx)
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
    }
}
