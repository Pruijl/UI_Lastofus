using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;


public class NewMonoBehaviourScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler


{
    [SerializeField] AudioClip Buttonsounds;
    [SerializeField] AudioSource audioSource;
    //[SerializeField] RectTransform button;
    Vector3 buttonposition;
    bool isSoundPlaying = false;
    bool isButtonMoved = false;




    void Start()
    {
        Buttonposition();

    }


    void Buttonposition()
    {
        buttonposition = gameObject.transform.position;
    }

    void OnPointerClick(PointerEventData eventData)
    {
        ReverseButtonsIntro();

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!isSoundPlaying)
        {
            audioSource.PlayOneShot(Buttonsounds);
            isSoundPlaying = true;
        }
        Animatebutton();
        print("test" + gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ReverseButtonsIntro();
        print("Out button" + gameObject.name);
        isSoundPlaying = false;
    }


    void Animatebutton()
    {
        if (!isButtonMoved)
        {
            gameObject.transform.DOMove(buttonposition + new Vector3(10, 0, 0), 0.5f).SetEase(Ease.OutBounce);
            isButtonMoved = true;
        }
    }

    public void ReverseButtonsIntro()
    {
        if (isButtonMoved)
        {
            gameObject.transform.DOMove(buttonposition, 0.5f).SetEase(Ease.OutBounce);
            isButtonMoved = false;
        }
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        OnPointerClick(eventData);
    }
}

