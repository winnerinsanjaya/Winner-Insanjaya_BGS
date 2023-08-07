using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BGS.Player;
using BGS.Currency;

namespace BGS.Shop
{
    public class ItemEquip : MonoBehaviour
    {
        public static ItemEquip instance;

        private void Awake()
        {
            instance = this;
        }

        public void OnEquipItem(int x, int y)
        {
            switch (x)
            {
                case 8:
                    EquipWeapon(y);
                    break;
                case 7:
                    EquipBoots(y);
                    break;
                case 6:
                    EquipBottom(y);
                    break;
                case 5:
                    EquipGloves(y);
                    break;
                case 4:
                    EquipTop(y);
                    break;
                case 3:
                    EquipHeadAcc(y);
                    break;
                case 2:
                    EquipHead(y);
                    break;
                case 1:
                    EquipFace(y);
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
            OnPreviewItem(x,y);
        }

        private void EquipFace(int y)
        {
            PlayerAcc.instance.playerAccStruct.face.face.sprite = ShopItem.instance.playerAccSpriteStruct.faceSprite[y].face;
            ShopItem.instance.playerAccEquip.faceSprite = y;
        }

        private void EquipHead(int y)
        {
            PlayerAcc.instance.playerAccStruct.head.head.sprite = ShopItem.instance.playerAccSpriteStruct.headSprite[y].head;
            ShopItem.instance.playerAccEquip.headSprite = y;
        }
        private void EquipHeadAcc(int y)
        {
            PlayerAcc.instance.playerAccStruct.headAcc.headAcc.sprite = ShopItem.instance.playerAccSpriteStruct.headAccSprite[y].headAcc;
            ShopItem.instance.playerAccEquip.headAccSprite = y;
        }

        private void EquipTop(int y)
        {
            PlayerAcc.instance.playerAccStruct.top.bodyUp.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].bodyUp;
            PlayerAcc.instance.playerAccStruct.top.shoulderLeft.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].shoulderLeft;
            PlayerAcc.instance.playerAccStruct.top.shoulderRight.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].shoulderRight;

            ShopItem.instance.playerAccEquip.topSprite = y;
        }
        private void EquipGloves(int y)
        {
            PlayerAcc.instance.playerAccStruct.gloves.leftElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].leftElbow;
            PlayerAcc.instance.playerAccStruct.gloves.rightElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].rightElbow;
            PlayerAcc.instance.playerAccStruct.gloves.leftWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].leftWrist;
            PlayerAcc.instance.playerAccStruct.gloves.rightWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].rightWrist;

            ShopItem.instance.playerAccEquip.glovesSprite = y;
        }

        private void EquipBottom(int y)
        {
            PlayerAcc.instance.playerAccStruct.bottom.pelvis.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].pelvis;
            PlayerAcc.instance.playerAccStruct.bottom.legLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].legLeft;
            PlayerAcc.instance.playerAccStruct.bottom.legRight.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].legRight;

            ShopItem.instance.playerAccEquip.bottomSprite = y;
        }

        private void EquipBoots(int y)
        {
            PlayerAcc.instance.playerAccStruct.boots.bootsLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].bootsLeft;
            PlayerAcc.instance.playerAccStruct.boots.bootsRight.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].bootsRight;

            ShopItem.instance.playerAccEquip.bootsSprite = y;
        }

        private void EquipWeapon(int y)
        {
            PlayerAcc.instance.playerAccStruct.weapon.weaponL.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].weapon;
            PlayerAcc.instance.playerAccStruct.weapon.weaponR.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].weapon;

            ShopItem.instance.playerAccEquip.weaponSprite = y;
        }




        public void OnPreviewItem(int x, int y)
        {
            switch (x)
            {
                case 8:
                    PreviewWeapon(y);
                    break;
                case 7:
                    PreviewBoots(y);
                    break;
                case 6:
                    PreviewBottom(y);
                    break;
                case 5:
                    PreviewGloves(y);
                    break;
                case 4:
                    PreviewTop(y);
                    break;
                case 3:
                    PreviewHeadAcc(y);
                    break;
                case 2:
                    PreviewHead(y);
                    break;
                case 1:
                    PreviewFace(y);
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void PreviewFace(int y)
        {
            PlayerAccCam.instance.playerAccStruct.face.face.sprite = ShopItem.instance.playerAccSpriteStruct.faceSprite[y].face;
        }

        private void PreviewHead(int y)
        {
            PlayerAccCam.instance.playerAccStruct.head.head.sprite = ShopItem.instance.playerAccSpriteStruct.headSprite[y].head;
        }
        private void PreviewHeadAcc(int y)
        {
            PlayerAccCam.instance.playerAccStruct.headAcc.headAcc.sprite = ShopItem.instance.playerAccSpriteStruct.headAccSprite[y].headAcc;
        }

        private void PreviewTop(int y)
        {
            PlayerAccCam.instance.playerAccStruct.top.bodyUp.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].bodyUp;
            PlayerAccCam.instance.playerAccStruct.top.shoulderLeft.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].shoulderLeft;
            PlayerAccCam.instance.playerAccStruct.top.shoulderRight.sprite = ShopItem.instance.playerAccSpriteStruct.topSprite[y].shoulderRight;
        }
        private void PreviewGloves(int y)
        {
            PlayerAccCam.instance.playerAccStruct.gloves.leftElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].leftElbow;
            PlayerAccCam.instance.playerAccStruct.gloves.rightElbow.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].rightElbow;
            PlayerAccCam.instance.playerAccStruct.gloves.leftWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].leftWrist;
            PlayerAccCam.instance.playerAccStruct.gloves.rightWrist.sprite = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].rightWrist;
        }

        private void PreviewBottom(int y)
        {
            PlayerAccCam.instance.playerAccStruct.bottom.pelvis.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].pelvis;
            PlayerAccCam.instance.playerAccStruct.bottom.legLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].legLeft;
            PlayerAccCam.instance.playerAccStruct.bottom.legRight.sprite = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].legRight;
        }

        private void PreviewBoots(int y)
        {
            PlayerAccCam.instance.playerAccStruct.boots.bootsLeft.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].bootsLeft;
            PlayerAccCam.instance.playerAccStruct.boots.bootsRight.sprite = ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].bootsRight;
        }

        private void PreviewWeapon(int y)
        {
            PlayerAccCam.instance.playerAccStruct.weapon.weaponL.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].weapon;
            PlayerAccCam.instance.playerAccStruct.weapon.weaponR.sprite = ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].weapon;
        }
    }
}
