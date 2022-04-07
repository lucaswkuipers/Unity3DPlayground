using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] public GameObject targetObject;
    [SerializeField] public float xOffset, yOffset, zOffset;

    private void Update()
    {
        transform.Translate(V)
    }
}
