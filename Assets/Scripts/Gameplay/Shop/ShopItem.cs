using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BGS.scriptable;


namespace BGS.Shop
{
    public class ShopItem : MonoBehaviour
    {
        public static ShopItem instance;
        public PlayerAccList playerAccList;
        public PlayerAccSpriteStruct playerAccSpriteStruct;
        public PlayerAccSpriteStructOwned playerAccSpriteStructOwned;


        private void Awake()
        {
            instance = this;
        }

        private void Start()
        {
            GetAccData();
        }

        private void GetAccData()
        {

            playerAccSpriteStruct.faceSprite = playerAccList.faceSprite;
            playerAccSpriteStruct.headSprite = playerAccList.headSprite;
            playerAccSpriteStruct.headAccSprite = playerAccList.headAccSprite;
            playerAccSpriteStruct.topSprite = playerAccList.topSprite;
            playerAccSpriteStruct.glovesSprite = playerAccList.glovesSprite;
            playerAccSpriteStruct.bottomSprite = playerAccList.bottomSprite;
            playerAccSpriteStruct.bootsSprite = playerAccList.bootsSprite;
            playerAccSpriteStruct.weaponSprite = playerAccList.weaponSprite;

            CreateOwnedList();
            //ToJson();
        }

        private void CreateOwnedList()
        {
            for (int i = 0; i < playerAccSpriteStruct.faceSprite.Count; i++)
            {
                playerAccSpriteStructOwned.faceSprite.Add(playerAccSpriteStruct.faceSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.headSprite.Count; i++)
            {
                playerAccSpriteStructOwned.headSprite.Add(playerAccSpriteStruct.headSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.headAccSprite.Count; i++)
            {
                playerAccSpriteStructOwned.headAccSprite.Add(playerAccSpriteStruct.headAccSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.topSprite.Count; i++)
            {
                playerAccSpriteStructOwned.topSprite.Add(playerAccSpriteStruct.topSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.glovesSprite.Count; i++)
            {
                playerAccSpriteStructOwned.glovesSprite.Add(playerAccSpriteStruct.glovesSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.bottomSprite.Count; i++)
            {
                playerAccSpriteStructOwned.bottomSprite.Add(playerAccSpriteStruct.bottomSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.bootsSprite.Count; i++)
            {
                playerAccSpriteStructOwned.bootsSprite.Add(playerAccSpriteStruct.bootsSprite[i].priceOwned);
            }
            for (int i = 0; i < playerAccSpriteStruct.weaponSprite.Count; i++)
            {
                playerAccSpriteStructOwned.weaponSprite.Add(playerAccSpriteStruct.weaponSprite[i].priceOwned);
            }
        }

        private void ToJson()
        {
            var json = JsonUtility.ToJson(playerAccSpriteStruct);
            Debug.Log(json);

        }
    }
}
