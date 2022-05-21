using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //public int num;
    [SerializeField]    //publicでも表示する[属性]
    private int count;

    [SerializeField]
    private Rigidbody rigidBody;

    private void Awake()
    {
        //rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スペースを押したらバウンド止まる
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
