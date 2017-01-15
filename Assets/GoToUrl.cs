using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToUrl : MonoBehaviour
{

    private string Url = "http://wear-studio.com/"

;   private void OnMouseDown()
    {
        Application.OpenURL(Url);
    }
}
