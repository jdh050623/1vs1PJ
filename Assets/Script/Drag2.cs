using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
/*Vector3 velo = Vector3.zero;
transform.position = Vector3.SmoothDamp(transform.position, Animal_Pos, ref velo, 0.05f);*/
public class Drag2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    public static Drag2 instance;

    RectTransform rectTransform;
    CanvasGroup canvasGroup;
    [SerializeField] Canvas canvas;

    bool DragOn = false;//�巡�׸� �ϰ� ������ ������ �Լ�
    bool DragOut = false;//�巡�׸� ���ϰ� �ϴ� �Լ�
    bool Clear = false;//Ŭ���� ������ ������ �Լ�
    bool Destory = false;//������ �����ϰ� ���ִ� �Լ�

    public GameObject AnimalShadow;
    public GameObject DifferentShadow;
    Vector3 Animal_Pos;

    public void Start()
    {
        GameManager_1.instance.ClearCount = 0;
        Animal_Pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    private void Update()
    {
        GoBack();
        ClearAnimal();
        /*if(ClearCount == 2)
        {
            //SceneManager.LoadScene("");
        }*/
    }
    private void GoBack()//�巡�׸� �������� ������Ʈ�� ���� ��ҷ� ���ư��� ����
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
                new Vector3(AnimalShadow.transform.position.x, AnimalShadow.transform.position.y, 0), 3f);
            StartCoroutine("Stop");
            if (Destory == true)
            {
                
                Debug.Log("d??");
                Destroy(this.gameObject);
                AnimalShadow.SetActive(false);
                if(GameManager_1.instance.ClearCount == 0)
                {
                    StartCoroutine("Stop");
                    DifferentShadow.SetActive(true);
                }
                Debug.Log("����");
 
                GameManager_1.instance.ClearCount += 1;
                Destory = false;
                
            }
            
        }
    }
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(1.5f);
        Destory = true;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        //if (collision.tag == "Owl")
        if (collision.gameObject == AnimalShadow)
        {
            Debug.Log("dd");
            Clear = true;
            DragOut = true;
        }
    }
    private void Awake()
    {
        instance = this;
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
            // ���� �̵��� ���ؼ� �󸶳� �̵��ߴ����� ������
            // ĵ������ �����ϰ� ����� �ϱ� ������
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