using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelLerp : MonoBehaviour
{
    [SerializeField]

    public GameObject startPoint;
    public GameObject endPoint;

    public float timer;

    public GameObject panel;
    [Range(0,1)]
    public float lerpSpeed;
  
    public void PanelSlide()
    {
        if(lerpSpeed >=1)
        {
            StartCoroutine(ClosePanel());
           
        }
        if(lerpSpeed <= 0)
        {
            StartCoroutine(openPanel());
            
        }
    }

    IEnumerator ClosePanel()
    {
        while (lerpSpeed != 0)
        {
            lerpSpeed -= Time.deltaTime * timer;
            panel.transform.position = Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpSpeed);    
            yield return new WaitForEndOfFrame();
            if(lerpSpeed  <= 0)
            {
                lerpSpeed = 0;
            }
        }

    }
    IEnumerator openPanel()
    {
        while(lerpSpeed != 1)
        {
            lerpSpeed += Time.deltaTime * timer;
            panel.transform.position = Vector3.Lerp(startPoint.transform.position, endPoint.transform.position, lerpSpeed);
            yield return new WaitForEndOfFrame();
            if(lerpSpeed >= 1)
            {
                lerpSpeed = 1;
            }
        }
       
    }
}
