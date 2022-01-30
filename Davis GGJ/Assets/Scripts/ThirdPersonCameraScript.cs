using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;
public class ThirdPersonCameraScript : MonoBehaviour
{
    //Components
    public CinemachineVirtualCamera TPVCam;
    //Public fields
    public Vector2Reference MouseDelta;
    public float Sensitivity;
    public float Damping;
    public float VerticalRangeUp;
    public float VerticalRangeDown;

    private Vector2 mouseDelta => MouseDelta.Value;
    public float hRotation { get; private set; }
    public float vRotation { get; private set; }
    public bool HasLockTarget { get { return lockTarget != null; } }

    //FPCamera components
    private CinemachineRecomposer recomposer;
    private Transform TPTarget;

    //Lock on
    private GameObject lockTarget = null;

    private void Awake()
    {
        //lock mouse
        TPTarget = TPVCam.m_Follow;
        recomposer = TPVCam.GetComponent<CinemachineRecomposer>();
        LockMouse(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (lockTarget == null)
            CameraRotation();
        else
            CameraRotationLock();
    }

    private void CameraRotationLock()
    {
        Vector3 rotationEuler = TPTarget.transform.rotation.eulerAngles;
        Quaternion lockonRot = Quaternion.LookRotation(lockTarget.transform.position - transform.position);
        hRotation = lockonRot.eulerAngles.y;
        vRotation = lockonRot.eulerAngles.x;
        LerpCameraToValues(0.5f);
    }

    private void CameraRotation()
    {
        
        hRotation += Time.deltaTime * Sensitivity * mouseDelta.x;
        vRotation -= Time.deltaTime * Sensitivity * mouseDelta.y;
        //Clamping vertical looking       
        LerpCameraToValues(1);
    }

    private void LerpCameraToValues(float dampingMultiplier)
    {
        Vector3 originalRotation = TPTarget.transform.rotation.eulerAngles;
        vRotation = Mathf.Clamp(Mathf.DeltaAngle(0, vRotation), -VerticalRangeDown, VerticalRangeUp);
        float lerpFactor = (Damping > 0) ? 10 / (Damping * dampingMultiplier) * Time.deltaTime : 1;
        TPTarget.transform.rotation = Quaternion.Euler(
            originalRotation.x.AngleLerp(vRotation,lerpFactor),
            originalRotation.y.AngleLerp(hRotation, lerpFactor), 
            0);

    }

    private void LockMouse(bool val)
    {
        Cursor.lockState = val ? CursorLockMode.Locked : CursorLockMode.None;
    }

    public void LockOn(LayerMask mask)
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        //Raycast to look for target
        Physics.Raycast(ray, out hit, 1000 ,mask);
        if(hit.collider != null)
        {
            lockTarget = hit.collider.gameObject;
        }
    }

    public void UnLock()
    {
        lockTarget = null;
    }
}
