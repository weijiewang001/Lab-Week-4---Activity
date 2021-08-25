using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;

    public Renderer rend;

    public int num;

    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100 )
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == num)
        {
            rend.enabled = false;
        }
    }
}
