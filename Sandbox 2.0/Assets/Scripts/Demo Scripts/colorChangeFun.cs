using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangeFun : MonoBehaviour
{
    Renderer objRenderer;
    float timer = 0f;
    [SerializeField]
    private float colorChangeTime;

    // Update is called once per frame
    void Update()
    {
        objRenderer = GetComponent<Renderer>();
        timer += Time.deltaTime;
        if (timer >= colorChangeTime)
        {

            Color newColor = Random.ColorHSV();
            objRenderer.material.color = newColor;
            timer = 0;

        }
    }
}
