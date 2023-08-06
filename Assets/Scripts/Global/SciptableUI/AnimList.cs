using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BGS.scriptable
{
    [CreateAssetMenu(fileName = "AnimList", menuName = "Scriptable/AnimList")]
    public class AnimList : ScriptableObject
    {
        public List<string> stateName;
    }
}

