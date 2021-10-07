using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    public event EventHandler OnKeyChanged;

    [SerializeField] private AudioSource keysoundeffect;
        [SerializeField] private AudioSource finishSound;
  private List<Key.KeyType> keyList;

  private void Awake ()
  {
      keyList = new List<Key.KeyType>();

  }

   public List<Key.KeyType> GetkeyList()
   {
       return keyList;
   }
  public void AddKey (Key.KeyType keyType)
  {
      Debug.Log ("Added Key:" + keyType);
      keyList.Add(keyType);
      OnKeyChanged?.Invoke(this,EventArgs.Empty);
  }

  public void RemoveKey (Key.KeyType keyType)
  {
      keyList.Remove (keyType);
      OnKeyChanged?.Invoke(this,EventArgs.Empty);
  }

  public bool ContainsKey (Key.KeyType keyType)
  {
      return keyList.Contains(keyType);
  }

  private void OnTriggerEnter2D (Collider2D collider)
  {
      Key key = collider.GetComponent <Key> ();
      if (key != null)
      {
          AddKey(key.GetKeyType());
          keysoundeffect.Play();
          Destroy (key.gameObject);
      }

      finish keyDoor = collider.GetComponent <finish> ();
      if (keyDoor != null)
      {
         if (ContainsKey(keyDoor.GetKeyType ())) 
         {
             //Currently holding key to open this door
            RemoveKey(keyDoor.GetKeyType ());
            finishSound.Play();
             keyDoor.OpenDoor ();
             
         }
      }

  }
}
