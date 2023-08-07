using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BGS.scriptable;


namespace BGS.Player
{
    public class PlayerAnim : MonoBehaviour
    {
        public AnimList[] animList;

        private int selectAnim;

        public Animator animator;
        public Animator animatorFaceCam;

        public int animationLayer;

        public List<string> states = new List<string>();

        private void Start()
        {
            foreach (AnimList al in animList)
            {
                for (int i = 0; i < al.stateName.Count; i++)
                {
                    string s = al.stateName[i];
                    states.Add(s);
                }
            }
            animator = animator.GetComponent<Animator>();
            animatorFaceCam = animatorFaceCam.GetComponent<Animator>();
            SelectAnimation(selectAnim);
        }

        private void OnEnable()
        {
            SelectAnimation(selectAnim);
        }

        public void SelectAnimation(int index)
        {
            if (index < 0 || index >= states.Count || animator == null)
                return;
            selectAnim = index;
            animator.Play(states[index], animationLayer);
            animatorFaceCam.Play(states[index], animationLayer);
        }
    }
}
