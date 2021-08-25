using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    [SerializeField] private GameObject blueObj;

    public GameObject redObj;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(blueObj, new Vector3(-2.0f, 0.0f, 0.0f), Quaternion.identity);
        Instantiate(redObj, new Vector3(2.0f, 0.0f, 0.0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
