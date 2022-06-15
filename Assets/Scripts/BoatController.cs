using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoatController : MonoBehaviour
{

    public GameObject player;
    public TextMeshProUGUI UyariMesaji;
    public Transform teleportTarget;
    public float BoatSpeed = 20.0f;
    public float turnSpeed = 25.0f;


    void Update()
    {
        if ((player.transform.position - this.transform.position).sqrMagnitude < 15 * 15)
        {
            UyariMesaji.gameObject.SetActive(true); // bir seferliðine çalýþmasýný saðlamam lazým
            if(Input.GetKey(KeyCode.B))
            {
                //playeri güverteye aldým
                Debug.Log("burasý çalýþýyor");
                player.transform.position = teleportTarget.transform.position;
                UyariMesaji.gameObject.SetActive(false);
            }

            // Gemi Hareketi

            if (Input.GetKey(KeyCode.I))
            {
                transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward, BoatSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.K))
            {
                transform.position = Vector3.Lerp(transform.position, transform.position - transform.forward, BoatSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -1);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
            }


        }
        else
        {
            UyariMesaji.gameObject.SetActive(false);
        }
    }
}
