using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public int hasarDurum;
    void Hasar(int hasarMiktar)
    {
        hasarDurum -= hasarMiktar;

        if (hasarDurum < 1)
        {
            hasarDurum = 0;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hasar(5);
        }
    }
}
