using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSliderEnterChecker : MonoBehaviour
{
    public static SecondSliderEnterChecker Instance;
    public AudioSource audio;
    public bool entered;
    public AvalanceInCP3 secondSlider;
    private void Start() {
        Instance = this;
        entered=false;
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"&&!entered){ {
            Debug.Log("Player entered the second slider");
            entered=true;
            CameraShake.instance.TriggerShake();
            secondSlider.start();
            UIManager.Instance.timeline.Stop();
            audio.Play();
            GameManager.Instance.SubtractScore(20, "Failure to identify signs of secondary landslides - 20 points");
            UIManager.Instance.zimu.ShowTextinTimelineWithParamAndReloadScene("Due to your failure to identify the signs of a secondary landslide, you have been buried by the landslide mass. Please try again.", audio.clip.length);

        }}
    }
}