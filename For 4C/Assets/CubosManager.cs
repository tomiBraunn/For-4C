using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosManager : MonoBehaviour
{
    public CuboScript [] cuboScripts;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cuboScripts.Length; i++)
        {
            Debug.Log(cuboScripts[0].esPersistente);
            if (cuboScripts[i].esPersistente != true)
            {
                Destroy(cuboScripts[i].gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
