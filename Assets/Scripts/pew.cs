using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pew : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);

        Debug.Log(hit.collider.gameObject.tag);

        if (hit.collider.gameObject.tag == "enemy")
        {
            GameObject enemy = hit.collider.gameObject;

            if (Input.GetMouseButton(0))
            {
                enemy.GetComponent<enemy>().health -= Time.deltaTime * 3.0f;
            }

            GameObject.Find("UItext").GetComponent<Text>().text = "enemy health: " + enemy.GetComponent<enemy>().health.ToString("F2");
        }
        else
        {
            GameObject.Find("UItext").GetComponent<Text>().text = "";
        }
    }


}
