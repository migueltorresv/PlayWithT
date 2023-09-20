using UnityEngine;

public class Rampa : MonoBehaviour
{
   [SerializeField] private string _nameTriggerAnim;

   public string NameTriggerAnim
   {
      get => _nameTriggerAnim;
      set => _nameTriggerAnim = value;
   }
}
