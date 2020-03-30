using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDoor : MonoBehaviour
{
    private GameObject mainDoor;
    private Transform doorTrans;
    private void Start()
    {
        mainDoor = GameObject.Find("MainDoor");
        doorTrans = mainDoor.GetComponent<Transform>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GetComponent<BoxCollider>().enabled = false;
            Debug.Log("The door is closing!");

            StartCoroutine(closeDoor());
            mainDoor.GetComponent<BoxCollider>().size = new Vector3(1, 10, 1);
        }

        IEnumerator closeDoor()
        {
            yield return new WaitForEndOfFrame();

            doorTrans.localScale = new Vector3(5, doorTrans.localScale.y + 1f * Time.deltaTime, 1);
            if (doorTrans.localScale.y <= 30)
            {
                StartCoroutine(closeDoor());
            }
        }
    }
}
