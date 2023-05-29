using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CamerasController : MonoBehaviour
{
    public static CamerasController Instance;

    public CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        Instance = this;
    }

    public void SetCameraTarget(Transform target)
    {
        virtualCamera.m_Follow = target;
    }

}
