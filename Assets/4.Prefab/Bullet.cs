using UnityEngine;

public class Bullet : MonoBehaviour {

    public Transform target;

    public Vector3 lastPosition;
    public float distanceTravelled = 0;
    public float speed = 100f;
    
    public void Seek(Transform _target)
    {
        target = _target;
    }
    void Start()
    {
        lastPosition = transform.position;
    }

    void Update ()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        transform.position += Vector3.forward * Time.deltaTime;
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
            if (distanceTravelled > 700f)
            {
                Destroy(gameObject);
            }
       /* if (target == null)
        {
            Destroy(gameObject);
            return;
        }*/

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);

	}

}
