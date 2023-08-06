using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BGS.Shop
{
    public class DoorOpen : MonoBehaviour
    {
        [SerializeField]
        private Transform leftDoor;
        [SerializeField]
        private Transform rightDoor;

        private Vector3 leftOriginPos;
        private Vector3 rightOriginPos; 
        
        private Vector3 leftTargetPos;
        private Vector3 rightTargetPos;

        [SerializeField]
        private float speed;


        private bool isOpening;
        private bool isClosing;

        private void Start()
        {
            Calculate();
        }

        private void Calculate()
        {
            leftOriginPos = leftDoor.position;
            rightOriginPos = rightDoor.position;

            leftTargetPos = new Vector3(leftOriginPos.x - 1, leftOriginPos.y, leftOriginPos.z);
            rightTargetPos = new Vector3(rightOriginPos.x + 1, rightOriginPos.y, rightOriginPos.z);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                isOpening = true;
                isClosing = false;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                isOpening = false;
                isClosing = true;
            }
        }

        private void Update()
        {
            if (isOpening)
            {
                var step = speed * Time.deltaTime;
                leftDoor.transform.position = Vector3.MoveTowards(leftDoor.transform.position, leftTargetPos, step);
                rightDoor.transform.position = Vector3.MoveTowards(rightDoor.transform.position, rightTargetPos, step);

                if (leftDoor.transform.position == leftTargetPos && rightDoor.transform.position == rightTargetPos)
                {
                    isOpening = false;
                }

                return;
            }


            if (isClosing)
            {
                var step = speed * Time.deltaTime;
                leftDoor.transform.position = Vector3.MoveTowards(leftDoor.transform.position, leftOriginPos, step);
                rightDoor.transform.position = Vector3.MoveTowards(rightDoor.transform.position, rightOriginPos, step);

                if(leftDoor.transform.position == leftOriginPos && rightDoor.transform.position == rightOriginPos)
                {
                    isClosing = false;
                }
                return;
            }
        }
    }
}
