using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public float FireRate;
    private float lastFireTime;

    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if (Time.time < lastFireTime + FireRate)
                return;

            lastFireTime = Time.time;
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Target target = hit.collider.GetComponent<Target>();
                if(target != null)
                {
                    PoolingSystem.Instance.DestroyAPS(target.gameObject);
                    EventManager.OnShootFired.Invoke(true);
                }
                EventManager.OnShootFired.Invoke(false);
            }
            else
            {
                EventManager.OnShootFired.Invoke(false);
            }
        }
    }
}
