using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeButton : MonoBehaviour
{
    public UnityEvent m_eventPush = new UnityEvent();
    public void OnClick()
    {
        Debug.Log("ChangeButton.Clicked");
        m_eventPush.Invoke();
    }
}
