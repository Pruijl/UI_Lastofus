using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using System.Collections.Generic;

public class Soundscript : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] AudioClip Buttonsounds;
    [SerializeField] AudioSource audioSource;
    //[SerializeField] List<AudioSource> audioSources;


   /* public void Start()
    {
        audioSources = new List<AudioSource>();
    }
*/

    public void OnPointerEnter(PointerEventData eventData)
    {
       

        audioSource.PlayOneShot(Buttonsounds);



        //audioSource.PlayOneShot(Buttonsounds);

    }



}