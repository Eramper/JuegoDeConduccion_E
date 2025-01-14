using UnityEngine;

public class Retrovisor : MonoBehaviour
{
 [SerializeField] GameObject mirror;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            mirror.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.R)){
            mirror.SetActive(false);
        }
    }
}
