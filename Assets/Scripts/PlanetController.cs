using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    public GameObject particleEffect;
    public static bool isDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerManager.planetHealth < 0.05f)
        {
            PlanetBurst();
        }
    }

    public void PlanetBurst()
    {
        particleEffect.SetActive(true);
        particleEffect.transform.SetParent(null);
        
        isDestroyed = true;
        
        Destroy(gameObject);
    }

}
