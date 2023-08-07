using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;

using BGS.Shop;

public class PlayfabDatabase : MonoBehaviour
{
    public static PlayfabDatabase instance;
    public static UnityAction OnGetAccData;
    public static UnityAction OnGetAccDataErrorEvent;
    public static UnityAction OnGetMoneyData;
    public static UnityAction OnGetMoneyErrorEvent;
    public static UnityAction OnGetEquipData;
    public static UnityAction OnGetEquipErrorEvent;

    [Header("GameData")]
    public PlayerAccSpriteStructOwned playerAccSpriteStructOwned = new PlayerAccSpriteStructOwned();
    public PlayerAccEquip playerAccEquip = new PlayerAccEquip();
    public int playerMoney;

    public string playfabId;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }


    private void OnEnable()
    {
        PlayfabManager.OnLogin += GetAccData;
        PlayfabManager.OnLogin += GetMoneyData;
        PlayfabManager.OnLogin += GetEquipData;
    }

    private void OnDisable()
    {
        PlayfabManager.OnLogin -= GetAccData;
        PlayfabManager.OnLogin -= GetMoneyData;
        PlayfabManager.OnLogin -= GetEquipData;
    }

    public void GetAccData()
    {
        var request = new GetUserDataRequest()
        {
            PlayFabId = this.playfabId,
            Keys = null
        };

        PlayFabClientAPI.GetUserData(request, OnGetAccDataSuccess, error => Debug.Log(error));
    }

    private void OnGetAccDataSuccess(GetUserDataResult result)
    {
        if (result.Data.ContainsKey("PlayerAccSpriteStructOwned"))
        {
            PlayerAccSpriteStructOwned data = JsonConvert.DeserializeObject<PlayerAccSpriteStructOwned>(result.Data["PlayerAccSpriteStructOwned"].Value);
            playerAccSpriteStructOwned = data;
        }
        else
        {
            //var userRequest = JsonUtility.ToJson(ShopItem.instance.playerAccSpriteStructOwned);



            playerAccSpriteStructOwned = ShopItem.instance.playerAccSpriteStructOwned;

            SetAccData();
        }

        OnGetAccData?.Invoke();
    }

    public void SetAccData()
    {
        var request = new UpdateUserDataRequest()
        {
            Data = new Dictionary<string, string>()
                {
                    {"PlayerAccSpriteStructOwned", JsonConvert.SerializeObject(playerAccSpriteStructOwned)}
                }
        };
        PlayFabClientAPI.UpdateUserData(request, OnSetAccDataSuccess, OnGetAccDataError);
    }

    private void OnGetAccDataError(PlayFabError obj)
    {
        OnGetAccDataErrorEvent?.Invoke();
    }
    private void OnSetAccDataSuccess(UpdateUserDataResult obj)
    {
        StartCoroutine(GetAccData_Coroutine());
    }

    IEnumerator GetAccData_Coroutine()
    {
        yield return new WaitForSeconds(0.7f);
        GetAccData();
    }



    public void GetMoneyData()
    {
        var request = new GetUserDataRequest()
        {
            PlayFabId = this.playfabId,
            Keys = null
        };

        PlayFabClientAPI.GetUserData(request, OnGetMoneyDataSuccess, error => Debug.Log(error));
    }

    private void OnGetMoneyDataSuccess(GetUserDataResult result)
    {
        if (result.Data.ContainsKey("PlayerMoney"))
        {
            
            playerMoney = int.Parse( result.Data["PlayerMoney"].Value);
        }
        else
        {

            playerMoney = 0;

            SetMoneyData();
        }

        OnGetMoneyData?.Invoke();
    }

    public void SetMoneyData()
    {
        var request = new UpdateUserDataRequest()
        {
            Data = new Dictionary<string, string>()
                {
                    {"PlayerMoney", playerMoney.ToString()}
                }
        };
        PlayFabClientAPI.UpdateUserData(request, OnGetMoneyDataError, OnGetMoneyDataError);
    }

    private void OnGetMoneyDataError(PlayFabError obj)
    {
        OnGetAccDataErrorEvent?.Invoke();
    }
    private void OnGetMoneyDataError(UpdateUserDataResult obj)
    {
        StartCoroutine(GetMoneyData_Coroutine());
    }

    IEnumerator GetMoneyData_Coroutine()
    {
        yield return new WaitForSeconds(0.7f);
        GetMoneyData();
    }


    public void GetEquipData()
    {
        var request = new GetUserDataRequest()
        {
            PlayFabId = this.playfabId,
            Keys = null
        };

        PlayFabClientAPI.GetUserData(request, OnGetEquipDataSuccess, error => Debug.Log(error));
    }

    private void OnGetEquipDataSuccess(GetUserDataResult result)
    {
        if (result.Data.ContainsKey("PlayerAccEquip"))
        {
            PlayerAccEquip data = JsonConvert.DeserializeObject<PlayerAccEquip>(result.Data["PlayerAccEquip"].Value);
            playerAccEquip = data;
        }
        else
        {
            //var userRequest = JsonUtility.ToJson(ShopItem.instance.playerAccSpriteStructOwned);



            playerAccEquip = ShopItem.instance.playerAccEquip;

            SetEquipData();
        }

        OnGetEquipData?.Invoke();
    }

    public void SetEquipData()
    {
        var request = new UpdateUserDataRequest()
        {
            Data = new Dictionary<string, string>()
                {
                    {"PlayerAccEquip", JsonConvert.SerializeObject(playerAccEquip)}
                }
        };
        PlayFabClientAPI.UpdateUserData(request, OnSetEquipDataSuccess, OnGetEquipDataError);
    }

    private void OnGetEquipDataError(PlayFabError obj)
    {
        OnGetEquipErrorEvent?.Invoke();
    }
    private void OnSetEquipDataSuccess(UpdateUserDataResult obj)
    {
        StartCoroutine(GetEquipData_Coroutine());
    }

    IEnumerator GetEquipData_Coroutine()
    {
        yield return new WaitForSeconds(0.7f);
        GetEquipData();
    }
}
