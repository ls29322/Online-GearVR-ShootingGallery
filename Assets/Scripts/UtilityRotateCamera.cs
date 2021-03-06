﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UtilityRotateCamera : MonoBehaviour {

    public float sensivility = 0.5f;

    private Vector2 m_mousePositionRef = Vector2.zero;

    private void Update()
    {       
        if (Input.GetMouseButtonDown(1))
        {
            m_mousePositionRef = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            transform.localEulerAngles += new Vector3(m_mousePositionRef.y - Input.mousePosition.y, Input.mousePosition.x - m_mousePositionRef.x, 0) * sensivility;
            m_mousePositionRef = Input.mousePosition;
        }
    }

}
