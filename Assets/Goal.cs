using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("�S�[��!");

        clearText.SetActive(true);
        nextButton.SetActive(true);
    }
    // Start is called before the first frame update
}
