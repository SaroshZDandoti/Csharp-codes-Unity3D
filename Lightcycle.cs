using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightcycle : MonoBehaviour
{



    Light testLight;

    public int wait; 




    // Start is called before the first frame update
    void Start()
    {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

      
    IEnumerator Flashing ()
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(wait);
             testLight.enabled = ! testLight.enabled;

        }
    }


}
