using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCtrl : MonoBehaviour
{
    public Image CursorGaugeImage;
    private Vector3 ScreenCenter;
    private float GaugeTimer = 0.0f;
    private bool isTriggered = false;
    public Text TextUI;

    // Start is called before the first frame update
    void Start()
    {
        ScreenCenter = new Vector3(Camera.main.pixelWidth / 2, Camera.main.pixelHeight / 2);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(ScreenCenter);
        RaycastHit hit;
        CursorGaugeImage.fillAmount = GaugeTimer;

        
        if (Physics.Raycast(ray, out hit, 100.0f))
        {
            //바닥을 볼 시 게이지 초기화
            if (hit.collider.gameObject.name == "Quad")
                GaugeTimer = 0.0f;

            //게이지 상승
            GaugeTimer += 1.0f / 3.0f * Time.deltaTime;

            //게이지가 다 차면 이벤트 실행
            if (GaugeTimer >= 1.0f || isTriggered)
            {
                TextUI.text = hit.collider.GetComponent<ObjectText>().text;
                GaugeTimer = 0.0f;
                isTriggered = false;
            }
        }
        else
            //이벤트 완료후 게이지 초기화
            GaugeTimer = 0.0f;
    }
}
