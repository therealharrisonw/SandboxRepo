using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandGrabInteractable : XRGrabInteractable
{
    public List<XRSimpleInteractable> secondHandGrab = new List<XRSimpleInteractable>();

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        foreach (var s in secondHandGrab)
        {
            s.onSelectEnter.AddListener(OnSecondGrab);
            s.onSelectExit.AddListener(OnSecondGrabRelease);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSecondGrab(XRBaseInteractor interactor)
    {
        Debug.Log("Second hand Grab");
    }
    public void OnSecondGrabRelease(XRBaseInteractor interactor)
    {
        Debug.Log("Second Hand Release");
    }

   // protected override void OnSelectEnter(XRBaseInteractor interactor)
    //{
        //base.OnSelectEnter(interactor);
    //}


    public override bool IsSelectableBy(XRBaseInteractor interactor)
    {
        bool grabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectableBy(interactor) && grabbed;
    }
}
