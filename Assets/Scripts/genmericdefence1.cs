using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genmericdefence1 : MonoBehaviour
{
    void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            collision.gameObject.GetComponent<enemy>().health -= Time.deltaTime * 1.0f;
        }
    }
}
