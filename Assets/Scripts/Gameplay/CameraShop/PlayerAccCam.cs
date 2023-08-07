using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BGS.Player
{
    public class PlayerAccCam : MonoBehaviour
    {
        public static PlayerAccCam instance;
        public PlayerAccStruct playerAccStruct;

        private void Awake()
        {
            instance = this;
        }
    }
}