using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    public int a = 0;
    // Start is called before the first frame update
    public void aPlus()
    {
        a += 1;
    }

    // Update is called once per frame
    public void aConsole()
    {
        print(a);
    }
}
