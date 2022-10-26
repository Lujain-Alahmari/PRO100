using UnityEngine;

public class pipes : MonoBehaviour
{
   [SerializeField] Vector3 moveSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime;
    }
}
