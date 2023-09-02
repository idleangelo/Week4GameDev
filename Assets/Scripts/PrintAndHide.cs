using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int counter = 4;
    // Start is called before the first frame update
    void Start()
    {
        int randomValue = Random.Range(150, 251);
        if (gameObject.CompareTag("Red") && counter == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && counter == randomValue)
        {
            rend.enabled = false;
        }
    }

            // Update is called once per frame
            void Update()
    {
        Debug.Log(gameObject.name + ":" + counter);
        counter++;
    }
}
