using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBackground : MonoBehaviour
{
    public GameObject backgroundImage;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        scaleBackgroundImageFitScreenSize();
    }

    // Update is called once per frame
    private void scaleBackgroundImageFitScreenSize()
    {
        // Get Device Screen Aspect ===========
        Vector2 deviceScreenResolution = new Vector2(Screen.width, Screen.height);
        print(deviceScreenResolution);

        float srcHeight = Screen.height;
        float scrWidth = Screen.width;

        float DEVICE_SCREEN_ASPECT = scrWidth / srcHeight;
        print("DEVICE_SCREEN_ASPECT: " + DEVICE_SCREEN_ASPECT.ToString());

        // Set Main Camera Aspect = Device Aspect
        mainCam.aspect = DEVICE_SCREEN_ASPECT;
        // Scale Background Image to fit with Camera Size
        float camHeight = 100.0f * mainCam.orthographicSize * 2.0f;
        float camWidth = camHeight * DEVICE_SCREEN_ASPECT;
        print("camHeight: " + camHeight.ToString());
        print("camWidth: " + camWidth.ToString());

        // Get Background Image Size
        SpriteRenderer backgroundImageSR = backgroundImage.GetComponent<SpriteRenderer>();
        float bgImgH = backgroundImageSR.sprite.rect.height;
        float bgImgW = backgroundImageSR.sprite.rect.width;

        print("bgImgH: " + bgImgH.ToString());
        print("bgImgW: " + bgImgW.ToString());

        //Calculate Ratio for Scaling
        float bgImg_scale_ratio_Height = camHeight / bgImgH;
        float bgImg_scale_ratio_Width = camWidth / bgImgW;

        backgroundImage.transform.localScale = new Vector3(bgImg_scale_ratio_Width, bgImg_scale_ratio_Height, 1);

    }
}
