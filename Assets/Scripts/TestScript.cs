using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BMSYS
{

    public class TestScript : MonoBehaviour
    {

        [SerializeField]
        private int index = 1000;

        // Start is called before the first frame update
        void Start()
        {
            Init();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Init()
        {
            Debug.Log($"index={index}");
        }
    }
}
