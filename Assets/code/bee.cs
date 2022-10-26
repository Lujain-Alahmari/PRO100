using UnityEngine;

public class bee : MonoBehaviour
{
    Rigidbody beeRigidbody;

    // start is called before the first frame update
    void Start()
    {

        Debug.Log("start the game!");

        beeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Playing the game!");

        if (Input.GetKeyDown(KeyCode.Space))

        {
            Debug.Log("Flap!");

            beeRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
