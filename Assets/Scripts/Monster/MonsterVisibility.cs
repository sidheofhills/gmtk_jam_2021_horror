using System.Collections.Generic;
using UnityEngine;

public class MonsterVisibility : MonoBehaviour
{
    [SerializeField]  private GameData gameData;
    private SpriteRenderer[] spriteRenderer;
    [SerializeField] AnimationCurve visScaleDependancyCurve;
    
    
    private GameObject chosenLampsContainer;       
    private List<LampLight> chosenLampList = new List<LampLight>();
    
    private float visiblityValue;
    private float lightOnValue;

    private int lampOrder;
    private int layerBodyOrder;
    private int layerEyesOrder; // eyes should be always above body
    //  use position.x to learn where monster is - on the left or on the right
    private float prevScaleValFitted;
    private float curScaleValFitted;

    private float prevAnimCurveValue;
    private float curAnimCurveValue;
    [SerializeField] private float zeroThreshold = 0.01f;

    private Transform monsterTransform;


    //tmp params
    private float testCurPosX;

    // Start is called before the first frame update
    void Awake()
    {       
        spriteRenderer = GetComponentsInChildren<SpriteRenderer>();  //for sorting layer      

    }

    

    private List<LampLight> LampListMaker()
    {
        LampLight[] lampStorage = chosenLampsContainer.GetComponentsInChildren<LampLight>();
        
        chosenLampList.AddRange(lampStorage);
        
        
        
            return chosenLampList;
    }


    // Update is called once per frame
    void Update()
    {
        VisibilityChanger();
    }
    private void VisibilityChanger()
    {

        prevScaleValFitted = curScaleValFitted;
        curScaleValFitted = Mathf.Lerp(0.1f, 1, Mathf.InverseLerp(gameData.startingScale, gameData.deathScale, transform.localScale.x));

        prevAnimCurveValue = visScaleDependancyCurve.Evaluate(prevScaleValFitted);
        curAnimCurveValue = visScaleDependancyCurve.Evaluate(curScaleValFitted);

        lightOnValue = chosenLampList[lampOrder].LightOn;

        if (curAnimCurveValue < zeroThreshold && prevAnimCurveValue > zeroThreshold) 
        {
            lampOrder++;
            layerBodyOrder +=2;
            layerEyesOrder +=2;
            LayersOrderUpdate();
        }

        visiblityValue = lightOnValue * curAnimCurveValue;

        spriteRenderer[1].color = new Vector4(spriteRenderer[1].color.r, spriteRenderer[1].color.g, spriteRenderer[0].color.b, visiblityValue);


    }



        private void OnEnable()
    {
        
        
        
        //light on 
        ChosenLampListAssignment();
        

        lampOrder = 0;
        layerBodyOrder = 0;
        layerEyesOrder = 1;

        LayersOrderUpdate();
    }

    private void ChosenLampListAssignment()
    {
        float currentXpos = transform.position.x;
        testCurPosX = currentXpos;
        //Debug.Log(currentXpos + " curXpos in " + this.gameObject.name + transform.GetInstanceID());
        if (currentXpos < 0.0f)
        {
            chosenLampsContainer = GameObject.FindGameObjectWithTag("left");
            if (chosenLampsContainer == null) Debug.Log("No game object with tag LEFT found in the scene");
        }
        else
        {
            chosenLampsContainer = GameObject.FindGameObjectWithTag("right");
            if (chosenLampsContainer == null) Debug.Log("No game object with tag RIGHT found in the scene");
        }

        LampListMaker();

    }

    private void LayersOrderUpdate()
    {
        spriteRenderer[0].sortingOrder = layerEyesOrder;
        spriteRenderer[1].sortingOrder = layerBodyOrder;
        
    }
}
