using TMPro;
using UnityEngine;
using DG.Tweening;

public class onoff : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI  on;
    [SerializeField] TextMeshProUGUI  off;
    [SerializeField] GameObject buttontext;
    Vector3 originalposition; 
    


    

    public void onclicked()
    {
        if (on.isActiveAndEnabled == true)
        {
            on.gameObject.SetActive(false);
        }
        else
        {
            on.gameObject.SetActive(true);
            buttontext.transform.position += Vector3.right *10;
            on.transform.position += Vector3.right * 10;


        }
    }

    public void offclicked()
    {
        if (off.isActiveAndEnabled == false)
        {
            off.gameObject.SetActive(true);
            buttontext.transform.position += -Vector3.right * 10;
            on.transform.position += -Vector3.right * 10;
        }
        else
        {
            off.gameObject.SetActive(false);
        }
    }
}

