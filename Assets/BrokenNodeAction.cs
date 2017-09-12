using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class BrokenNodeAction : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject brokenNodeActionObject;

    // Use this for initialization
	void Start () {
        brokenNodeActionObject = GameObject.Find("brokenNode_Btn");
        brokenNodeActionObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("TADAA!!!!!!!!!!!!!!!!");
        Application.OpenURL("http://www.luisbravoa.com/brand-prototype");
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
      
    }

}
