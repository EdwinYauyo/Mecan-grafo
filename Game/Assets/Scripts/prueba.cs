using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class prueba : MonoBehaviour
{
    private Text gt;
    public Text meta;
    void Start()
    {
        gt = GetComponent<Text>();
    }

    void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if (c==' ') // space?
            {
                
                Debug.Log("space");
                if (gt.text == meta.text)
                {
                    Debug.Log("correcto");
                }
                else Debug.Log("incorrecto");
                gt.text += c;
            }
            else
            {
                gt.text += c;
            }
        }
    }
}
