using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShoot : MonoBehaviour
{
    public int gunDamage = 1;

    public float fireRate = .025f;

    public float range = 50f;

    public float hitForce = 100f;

    public Transform gunEnd;


    private Camera fpsCamera;

    private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);

    private AudioSource gunAudio;

    private LineRenderer laserLine;

    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();

        gunAudio = GetComponent<AudioSource>();

        fpsCamera = GetComponentInParent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
     

        
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
                nextFire = Time.time + fireRate;
                StartCoroutine(ShotEffect());

            Shoot();
        }
       

    }
    private IEnumerator ShotEffect()
    {
        gunAudio.Play();
        laserLine.enabled = true;

        yield return shotDuration;

        laserLine.enabled = false;
    }
    void Shoot()
    {
        Vector3 rayOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));

        RaycastHit hit;

        laserLine.SetPosition(0, gunEnd.position);

        if (Physics.Raycast(rayOrigin, fpsCamera.transform.forward, out hit, range))
        {
            laserLine.SetPosition(1, hit.point);

            ShootableBox health = hit.collider.GetComponent<ShootableBox>();

            if(health != null)
            {
                health.Damage(gunDamage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * hitForce);
            }
        }
        else
        {
            laserLine.SetPosition(1, fpsCamera.transform.forward * range);
        }
    }
}