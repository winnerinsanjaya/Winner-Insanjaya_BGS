using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BGS.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float speed;

        [SerializeField]
        private Animator animator;

        private Vector3 direction;
        //SpriteRenderer spriterender;

        private PlayerAnim playerAnim;

        private float scale;
        //private Animator animator;
        // Start is called before the first frame update
        void Start()
        {
            scale = gameObject.transform.localScale.x;
            playerAnim = gameObject.GetComponent<PlayerAnim>();
            //spriterender = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            direction = new Vector3(horizontal, vertical).normalized;

            AnimateMovement(direction);
            if (horizontal < 0)
            {
                gameObject.transform.localScale = new Vector3(-1 * scale, 1 * scale, 1 * scale);
            }

            if (horizontal > 0)
            {
                gameObject.transform.localScale = new Vector3(1 * scale, 1 * scale, 1 * scale);
            }
        }

        private void FixedUpdate()
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }

        void AnimateMovement(Vector3 direction)
        {
            if (animator != null)
            {
                if (direction.magnitude > 0)
                {
                    playerAnim.SelectAnimation(1);
                }
                else
                {
                    playerAnim.SelectAnimation(0);
                }
            }
        }
    }

}
