using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BGS.Player;
using BGS.Currency;
using PlayFab;

namespace BGS.Shop
{
    public class ItemSell : MonoBehaviour
    {
        public static ItemSell instance;

        private int itemIndex;

        private void Awake()
        {
            instance = this;
        }

        public void OnSellItem(int x, int y)
        {
            itemIndex = x;
            switch (x)
            {
                case 8:
                    SellWeapon(y);
                    break;
                case 7:
                    SellBoots(y);
                    break;
                case 6:
                    SellBottom(y);
                    break;
                case 5:
                    SellGloves(y);
                    break;
                case 4:
                    SellTop(y);
                    break;
                case 3:
                    SellHeadAcc(y);
                    break;
                case 2:
                    SellHead(y);
                    break;
                case 1:
                    SellFace(y);
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
            UpdateToPlayFabs();
        }

        private void SellFace(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.faceSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.faceSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.faceSprite[y].face;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.face.face.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellHead(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.headSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.headSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.headSprite[y].head;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.head.head.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellHeadAcc(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.headAccSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.headAccSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.headAccSprite[y].headAcc;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.headAcc.headAcc.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellTop(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.topSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.topSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.topSprite[y].bodyUp;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.top.bodyUp.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellGloves(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.glovesSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].leftElbow;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.gloves.leftElbow.sprite;

            CheckSpriteSell(spriteA, spriteB);

        }
        private void SellBottom(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.bottomSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].pelvis;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.bottom.pelvis.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellBoots(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.bootsSprite[y].isOwned = false;

            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].bootsLeft;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.boots.bootsLeft.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }
        private void SellWeapon(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].priceOwned.isOwned = false;
            ShopItem.instance.playerAccSpriteStructOwned.weaponSprite[y].isOwned = false;


            Sprite spriteA = ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].weapon;
            Sprite spriteB = PlayerAcc.instance.playerAccStruct.weapon.weaponL.sprite;

            CheckSpriteSell(spriteA, spriteB);
        }

        private void CheckSpriteSell(Sprite spriteA, Sprite spriteB)
        {
            if (spriteA == spriteB)
            {
                ItemEquip.instance.OnEquipItem(itemIndex, 0);

                ItemBuy.instance.OnBuyItem(itemIndex, 0);
            }
        }


        private void UpdateToPlayFabs()
        {
            if (PlayFabClientAPI.IsClientLoggedIn())
            {
                if (PlayfabDatabase.instance == null)
                {
                    return;
                }

                PlayfabDatabase.instance.playerAccSpriteStructOwned = ShopItem.instance.playerAccSpriteStructOwned;
                PlayfabDatabase.instance.SetAccData();
            }
        }

    }
}
