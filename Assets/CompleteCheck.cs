using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteCheck : MonoBehaviour
{
    public AudioSource R;

    public AudioSource W;

    public static CompleteCheck Instance;

    public bool _passed;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        _passed = false;
    }
    public void CheckIfPassCP2()
    {
        CameraShake.instance.StopShake();
        _passed=true;
        if (GameManager.Instance.correctInCP2)
        {
            GameManager.Instance.AddScore(40, "Selected the correct direction + 40 points");
            UIManager.Instance.zimu.ShowTextinTimelineWithParam("Congratulations, you have learned the correct escape direction in the event of a landslide.", R.clip.length);
            R.Play();
            Invoke("Continue",R.clip.length);
        }
        else
        {
            GameManager.Instance.SubtractScore(40, "Selected the wrong direction - 40 points");
            UIManager.Instance.zimu.ShowTextinTimelineWithParam("You have chosen the wrong escape direction and failed to escape.", W.clip.length);
            W.Play();
            Invoke("Continue",W.clip.length);
        }
    }

    public void Continue()
    {
        Debug.Log("123");
        CameraShake.instance.StopShake();
        UIManager.Instance.timeline.Resume();
    }
}
