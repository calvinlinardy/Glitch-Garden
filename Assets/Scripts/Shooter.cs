using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectille = null, gun = null;

    public void Fire()
    {
        Instantiate(projectille, gun.transform.position, transform.rotation);
    }
}
