using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }
}
