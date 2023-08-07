using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BGS.Player
{
    public class PlayerAcc : MonoBehaviour
    {
        public static PlayerAcc instance;
        public PlayerAccStruct playerAccStruct;

        private void Awake()
        {
            instance = this;
        }
    }
}
