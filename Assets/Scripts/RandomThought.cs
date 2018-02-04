using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomThought : MonoBehaviour
{
    private Text m_text;
    public string[] thoughts;
    private int temp;

    // Use this for initialization
    void Start()
    {
        m_text = GetComponent<Text>();
        temp = Random.Range(0, thoughts.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            int rando = Random.Range(0, thoughts.Length);
            while (temp == rando)
            {
                rando = Random.Range(0, thoughts.Length);
            }


            m_text.text = thoughts[rando];
            temp = rando;

        }
    }
}
