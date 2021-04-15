using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

   public float Health;
   public float healthOverTime;

  public float Stamina;
  public float staminaOverTime;

  public float Hunger;
  public float hungerOverTime;


   public Slider HealthBar;
   public Slider StaminaBar;
   public Slider HungerBar;
   
   public float minAmount = 5f;
   public float sprintSpeed = 5f;

   Rigidbody myBody;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        HealthBar.maxValue = Health;
        StaminaBar.maxValue = Stamina;
        HungerBar.maxValue = Hunger;



        updateUI();


    }

    // Update is called once per frame
    void Update()
    {
      CalculateValues();  
    }


   private void CalculateValues()
   {
        Hunger -= hungerOverTime * Time.deltaTime;

        if(Hunger<=minAmount)
        {
            Health -= healthOverTime * Time.deltaTime;
            Stamina -= staminaOverTime * Time.deltaTime;
        }


        if (myBody.velocity.magnitude >= sprintSpeed && myBody.velocity.y == 0)
        {
            Stamina -= staminaOverTime * Time.deltaTime;
            Hunger -= hungerOverTime * Time.deltaTime;
        }
        else
        {
            Stamina += staminaOverTime * Time.deltaTime;
        }

        if (Health <= 0)
        {
            print("PLAYER HAS DIED");
        }



        updateUI();
   }

   private void updateUI()
   {
        Health = Mathf.Clamp(Health, 0, 100f);
        Stamina= Mathf.Clamp(Stamina, 0, 100f);
        Hunger = Mathf.Clamp(Hunger, 0, 100f);



        HealthBar.value = Health;
        StaminaBar.value = Stamina;
        HungerBar.value = Hunger;
        
   }

    public void TakeDamage(float amnt)
    {
        Health -= amnt;
        updateUI();
    }










}
