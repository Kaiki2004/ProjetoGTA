using UnityEngine;

public class followPath : MonoBehaviour
{
    public Transform[] allwayPoints;

    public float rotationSpeed = 3f;
    public float movementSpeed = 3f;

    public int currentTarget;

    void Update()
    {
        Movement();
        Rotate();
        ChangeTarget();
    }

    void Movement()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            allwayPoints[currentTarget].position,
            movementSpeed * Time.deltaTime);
    }

    void Rotate()
    {
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(
                allwayPoints[currentTarget].position - transform.position),
            rotationSpeed * Time.deltaTime);
    }

    void ChangeTarget()
    {
        if (Vector3.Distance(transform.position,
            allwayPoints[currentTarget].position) < 0.1f)
        {
            currentTarget++;

            currentTarget =
                currentTarget % allwayPoints.Length;
        }
    }
}