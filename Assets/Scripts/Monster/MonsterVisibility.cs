using System.Collections.Generic;
using UnityEngine;

public class MonsterVisibility : MonoBehaviour
{
    /// <summary>
    /// this one is responsible for monster's visibility. which boils up to 
    /// - what side the monster is on? -  chosenLampList
    /// - is the monster suppose to be seen in current point of time, i.e is he under the lamp's lights? - visScaleDependancyCurve
    /// - is this lamp even on? because they're switching all the time - lightOnValue
    /// - if it's on, is there a flickering property on as well?
    /// 
    /// moreover, monster should be hidden in shadow so it's harder to kill him - bodyCollider
    /// </summary>
    [SerializeField]  private GameData gameData;
    private SpriteRenderer[] spriteRenderers;
    private CapsuleCollider2D bodyCollider;
    private Animator animator;
    [SerializeField] AnimationCurve visScaleDependancyCurve;
    
    
    private GameObject chosenLampsContainer;       
    private List<LampLight> chosenLampList = new List<LampLight>();
    
    private float lightOnValue;  // value that is taken from current light's LightOn property
    private float visiblityValue; //value that is taken from all the parameters

    private int lampOrder; 
    private int layerBodyOrder;
    private int layerEyesOrder; // eyes should be always above body
    //  use position.x to learn where monster is - on the left or on the right
    private float prevScaleValFitted;
    private float curScaleValFitted;

    private float prevAnimCurveValue;
    private float curAnimCurveValue;
    [SerializeField] private float zeroThreshold = 0.01f;


    
    private void Awake() // because on enable goes next
    {       
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>();  //for sorting layer      
        animator = GetComponent<Animator>();
        bodyCollider = GetComponentInChildren<CapsuleCollider2D>();
    }
   

    private void FixedUpdate() // for bodyCollider
    {
        if (spriteRenderers[1].color.a < 0.2f)
        {           
            bodyCollider.enabled = false;            
        }
        else if(spriteRenderers[1].color.a >= 0.2f)
        {
            bodyCollider.enabled = true;
        }
    }

    void Update()
    {
        VisibilityChanger();      
    }
    
    private void VisibilityChanger()
    {

        prevScaleValFitted = curScaleValFitted;
        curScaleValFitted = Mathf.Lerp(0.1f, 1f, Mathf.InverseLerp(gameData.startingScale, gameData.deathScale, transform.localScale.x));

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

        spriteRenderers[1].color = new Vector4(spriteRenderers[1].color.r, spriteRenderers[1].color.g, spriteRenderers[0].color.b, visiblityValue);


    }


        private void OnEnable()
    {

        animator.SetFloat("CycleOffset", 6 - Random.Range(0, 12)); //CycleOffset -6 / 6
        animator.Play(0);  //idle
        //light on 
        ChosenLampListAssignment();

        lampOrder = 0;
        layerBodyOrder = 0;
        layerEyesOrder = 1;

        LayersOrderUpdate();
        
    }

    private void LayersOrderUpdate()
    {
        spriteRenderers[0].sortingOrder = layerEyesOrder;
        spriteRenderers[1].sortingOrder = layerBodyOrder;        
    }
    private void ChosenLampListAssignment()
    {
        float currentXpos = transform.position.x;
        
        
        if (currentXpos < 0.0f)
        {
            chosenLampsContainer = GameObject.FindGameObjectWithTag("left");
            if (chosenLampsContainer is null) Debug.Log("No game object with tag LEFT found in the scene");
            
        }
        else
        {
            chosenLampsContainer = GameObject.FindGameObjectWithTag("right");
            if (chosenLampsContainer is null) Debug.Log("No game object with tag RIGHT found in the scene");
        }

        LampListMaker();
        return;

    }


    private List<LampLight> LampListMaker()
    {
        LampLight[] lampStorage = chosenLampsContainer.GetComponentsInChildren<LampLight>();

        chosenLampList.AddRange(lampStorage);

        return chosenLampList;
    }
}
