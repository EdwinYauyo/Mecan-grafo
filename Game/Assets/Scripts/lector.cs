using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lector : MonoBehaviour
{
    public GameObject texto;
    public InputField input;
    public GameObject message;
    public string inputt=null;

    // Start is called before the first frame update
    void Start()
    {
        //  message.GetComponent<Text>().text = "";
    }

    public void Comprobar()
    {
        
        inputt = input.text;
        Debug.Log(inputt);
        if (texto.GetComponent<Text>().text == inputt)
        {
            message.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        } 
    }
}
