using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/*Vector3 velo = Vector3.zero;
transform.position = Vector3.SmoothDamp(transform.position, Animal_Pos, ref velo, 0.05f);*/
public class Drag2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    RectTransform rectTransform;
    CanvasGroup canvasGroup;
    [SerializeField] Canvas canvas;

    bool DragOn = false;//드래그를 하고 있을때 켜지는 함수
    bool DragOut = false;//드래그를 못하게 하는 함수
    bool Clear = false;//클리어 했을때 켜지는 함수

    public GameObject AnimalShadow;
    public GameObject AnimalPos;
    Vector3 Animal_Pos;

    public void Start()
    {
        Instantiate(AnimalPos, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, GameObject.Find("Canvas/PosGroup").transform);
        Animal_Pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    private void Update()
    {
        GoBack();
        ClearAnimal();
    }
    private void GoBack()//드래그를 놓았을때 오브젝트를 원래 장소로 돌아가게 해줌
    {
        if (DragOn == false && Clear == false)//
        {
            Vector3 velo = Vector3.zero;
            transform.position = Vector3.SmoothDamp(transform.position, Animal_Pos, ref velo, 0.05f);
        }
    }
    private void ClearAnimal()
    {
        
        if (Clear == true)
        {
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(AnimalShadow.transform.position.x, AnimalShadow.transform.position.y, 0), 1f);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Owl")
        //if (collision.gameObject == AnimalShadow)
        {
            Clear = true;
            DragOut = true;
        }
    }
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        if(DragOut == false)
        {
            DragOn = true;
            //canvasGroup.alpha = .6f;
            canvasGroup.blocksRaycasts = false;
        }
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (DragOut == false)
        {
            DragOn = true;
            // 이전 이동과 비교해서 얼마나 이동했는지를 보여줌
            // 캔버스의 스케일과 맞춰야 하기 때문에
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }   
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        DragOn = false;
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        /*transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z),
                new Vector3(AnimalPos.transform.position.x, AnimalPos.transform.position.y, 0), 1f);*/
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        DragOn = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        DragOn = true;
    }
}