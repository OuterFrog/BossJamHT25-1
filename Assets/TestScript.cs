using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] int test;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        test++;
        //gabbe was here
        Debug.Log(test);
    }
}
