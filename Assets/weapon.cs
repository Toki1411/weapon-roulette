using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public Image weaponImage;

    public Sprite[] weaponImages;

    private void Setup()
    {
        // どの画像を使うか乱数で決める
        int imageIndex = Random.Range(0, weaponImages.Length);

        //　画像を変更する
        weaponImage.sprite = weaponImages[imageIndex];

    }

    public void OnClickButton()
    {
        Setup();
    }

}
