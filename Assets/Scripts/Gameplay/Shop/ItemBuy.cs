using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BGS.Player;
using BGS.Currency;
using PlayFab;

namespace BGS.Shop
{
    public class ItemBuy : MonoBehaviour
    {
        public static ItemBuy instance;

        private void Awake()
        {
            instance = this;
        }

        public void OnBuyItem(int x, int y)
        {
            switch (x)
            {
                case 8:
                    BuyWeapon(y);
                    break;
                case 7:
                    BuyBoots(y);
                    break;
                case 6:
                    BuyBottom(y);
                    break;
                case 5:
                    BuyGloves(y);
                    break;
                case 4:
                    BuyTop(y);
                    break;
                case 3:
                    BuyHeadAcc(y);
                    break;
                case 2:
                    BuyHead(y);
                    break;
                case 1:
                    BuyFace(y);
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
            UpdateToPlayFabs();
        }

        private void BuyFace(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.faceSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.faceSprite[y].isOwned = true;
        }
        private void BuyHead(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.headSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.headSprite[y].isOwned = true;
        }
        private void BuyHeadAcc(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.headAccSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.headAccSprite[y].isOwned = true;
        }
        private void BuyTop(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.topSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.topSprite[y].isOwned = true;
        }
        private void BuyGloves(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.glovesSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.glovesSprite[y].isOwned = true;
        }
        private void BuyBottom(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.bottomSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.bottomSprite[y].isOwned = true;
        }
        private void BuyBoots(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.bootsSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.bootsSprite[y].isOwned = true;
        }
        private void BuyWeapon(int y)
        {
            ShopItem.instance.playerAccSpriteStruct.weaponSprite[y].priceOwned.isOwned = true;
            ShopItem.instance.playerAccSpriteStructOwned.weaponSprite[y].isOwned = true;

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
