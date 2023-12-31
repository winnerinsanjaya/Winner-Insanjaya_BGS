using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using BGS.Shop;
using BGS.Currency;

public class PlayfabDataLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayFabClientAPI.IsClientLoggedIn())
        {
            PushData();
        }
    }

    private void PushData()
    {
        Debug.Log("PUSHED");
        ShopItem.instance.playerAccSpriteStructOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned;
        //SetDataToScriptableObject();

        ShopItem.instance.playerAccEquip = PlayfabDatabase.instance.playerAccEquip;
        EquipLastItem();

        PlayerCurrency.instance.SetMoney(PlayfabDatabase.instance.playerMoney);
    }

    private void SetDataToScriptableObject()
    {
        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.faceSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.faceSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.faceSprite[i].isOwned;
        }
        
        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.headSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.headSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.headSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.headAccSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.headAccSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.headAccSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.topSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.topSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.topSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.glovesSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.glovesSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.glovesSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.bottomSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.bottomSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.bottomSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.bootsSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.bootsSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.bootsSprite[i].isOwned;
        }

        for (int i = 0; i < PlayfabDatabase.instance.playerAccSpriteStructOwned.weaponSprite.Count; i++)
        {
            ShopItem.instance.playerAccSpriteStruct.weaponSprite[i].priceOwned.isOwned = PlayfabDatabase.instance.playerAccSpriteStructOwned.weaponSprite[i].isOwned;
        }
    }

    private void EquipLastItem()
    {
        ItemEquip.instance.OnEquipItem(1, ShopItem.instance.playerAccEquip.faceSprite);
        ItemEquip.instance.OnEquipItem(2, ShopItem.instance.playerAccEquip.headSprite);
        ItemEquip.instance.OnEquipItem(3, ShopItem.instance.playerAccEquip.headAccSprite);
        ItemEquip.instance.OnEquipItem(4, ShopItem.instance.playerAccEquip.topSprite);
        ItemEquip.instance.OnEquipItem(5, ShopItem.instance.playerAccEquip.glovesSprite);
        ItemEquip.instance.OnEquipItem(6, ShopItem.instance.playerAccEquip.bottomSprite);
        ItemEquip.instance.OnEquipItem(7, ShopItem.instance.playerAccEquip.bootsSprite);
        ItemEquip.instance.OnEquipItem(8, ShopItem.instance.playerAccEquip.weaponSprite);
    }
}
