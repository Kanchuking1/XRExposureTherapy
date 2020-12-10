using UnityEngine;

public class StagBeetleHandler : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 5f;

    [SerializeField]
    float rotationRadius = 0.2f;

    Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        rotationRadius = Random.Range(0.1f,0.5f);

        transform.RotateAround(initialPosition + Vector3.right * rotationRadius ,Vector3.up,rotationSpeed*Time.deltaTime);
    }
}
