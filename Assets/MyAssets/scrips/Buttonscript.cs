using UnityEngine;
using UnityEngine.EventSystems;

public class Buttonscript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{



    [SerializeField] GameObject Button;
    Vector3 originalposition;

    void Start()
    {
        Buttonposition();
    }
    void Buttonposition()
    {
        originalposition = Button.transform.position;
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
         Button.transform.position += Vector3.right * 10;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       Button.transform.position += -Vector3.right * 10;
    }
}

   


