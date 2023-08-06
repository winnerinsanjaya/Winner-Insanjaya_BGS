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
        }
    }
}
