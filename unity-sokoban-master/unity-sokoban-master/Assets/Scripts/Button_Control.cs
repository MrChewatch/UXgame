using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Control : MonoBehaviour
{
    public PlayerController Con;

    void Start()
    {
        Con =  GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        
    }

    public void w()
    {
        Con.verticleInput = 1;
        StartCoroutine(ExecuteAfterTime(0.1f,0,true));
    }

    public void A()
    {
        Con.horizontalInput = -1;
        StartCoroutine(ExecuteAfterTime(0.1f, 0, false));
    }
    public void S()
    {
        Con.verticleInput = -1;
        StartCoroutine(ExecuteAfterTime(0.1f, 0, true));
    }
    public void D()
    {
        Con.horizontalInput = 1;
        StartCoroutine(ExecuteAfterTime(0.1f, 0, false));
    }

    IEnumerator ExecuteAfterTime(float time,int input,bool vert)
    {
        yield return new WaitForSeconds(time);

        if (vert)
        {
            Con.verticleInput = input;
        }
        else
        {
            Con.horizontalInput = input;
        }
    }

    public void regame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
