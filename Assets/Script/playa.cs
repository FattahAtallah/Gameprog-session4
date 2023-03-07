using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playa : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public Changescene CS;
    void Start()
    {
        rawImageVideo.SetActive(false);
    }

    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }

    IEnumerator WaitAndChange()
    {
        yield return new WaitForSeconds(12.0f);
        CS.ChangeMyScene("menu");
    }


    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
