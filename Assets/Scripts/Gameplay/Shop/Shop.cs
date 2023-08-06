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


        public void GetItems(int idx)
        {
            switch (idx)
            {
                case 8:
                    print("Why hello there good sir! Let me teach you about Trigonometry!");
                    break;
                case 7:
                    print("Why hello there good sir! Let me teach you about Trigonometry!");
                    break;
                case 6:
                    print("Why hello there good sir! Let me teach you about Trigonometry!");
                    break;
                case 5:
                    print("Why hello there good sir! Let me teach you about Trigonometry!");
                    break;
                case 4:
                    print("Hello and good day!");
                    break;
                case 3:
                    print("Whadya want?");
                    break;
                case 2:
                    print("Grog SMASH!");
                    break;
                case 1:
                    GetFace();
                    break;
                default:
                    print("Incorrect intelligence level.");
                    break;
            }
        }

        private void GetFace()
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
            }
        }


    }
}
