using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BGS.scriptable
{
    [CreateAssetMenu(fileName = "PlayerAccList", menuName = "Scriptable/PlayerAccList")]
    public class PlayerAccList : ScriptableObject
    {
        public List<FaceSprite> faceSprite;

        public List<HeadSprite> headSprite;

        public List<HeadAccSprite> headAccSprite;

        public List<TopSprite> topSprite;

        public List<GlovesSprite> glovesSprite;

        public List<BottomSprite> bottomSprite;

        public List<BootsSprite> bootsSprite;

        public List<WeaponSprite> weaponSprite;
    }
}

