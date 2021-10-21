using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;
using System;

public class VigentteManager : MonoBehaviour
{
    [SerializeField]
    float intesnity = 0.75f; //how intense the vignette is 
    [SerializeField]
    float duration = 0.5f; //how long the vignette takes to appear and disappear 
    [SerializeField]
    private Volume volume;
    Vignette vignette;
    [SerializeField]
    InputActionReference continuousMove; //prepares it to check for continous moevement later
    // Start is called before the first frame update
    private void Awake()
    {
        continuousMove.action.performed += FadeIn; //when continous movement starts fade in
        continuousMove.action.canceled += FadeOut; //when continous movement ends fade out

        if (volume.profile.TryGet(out Vignette vignette)) 
        {
            this.vignette = vignette; //sets the vignette in script to the private vignette above. 
        }
    }

    private void FadeIn(InputAction.CallbackContext obj) //method for fading in 
    {
        if (obj.ReadValue<Vector2>() != Vector2.zero) //if control stick is not on 0 then run this 
        {
            StartCoroutine(Fade(intesnity, 0)); //tells it to start the fade in 
        }
    }

    private void FadeOut(InputAction.CallbackContext obj) //if control stick is on 0 then run this
    {
        StartCoroutine(Fade(0, intesnity)); //tells the fade in to stop
    }

    IEnumerator Fade(float startValue, float endValue)
    {
        float elapsedTime = 0.0f;
        float blend = elapsedTime / duration;
        float intesnity = Mathf.Lerp(startValue, endValue, blend);
        ApplyValue(intesnity);
        yield return null;
    }

    void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }

   
}
