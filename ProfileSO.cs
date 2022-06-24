using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu]
public class ProfileSO : ScriptableObject // We declare our class, which is the name of the file, and identify it as a ScriptableObject data container. It's a Unity thing. 
{
    public string Name; // We declare a Name field publicly, since we want to access it from UI, and have it accessible outside the class
    public Sprite avatar; // We declare the avatar field as a Sprite, again publicly
    public string bio; // We declare the bio string, again publicly
    public string handle; // We declare the handle string, again publicly

    [SerializeField] public Tweet[] tweets; // We declare the tweets var as a public Tweet type, and we make it an array, since we know we'll have a lot of them. We also Serialize it into our array.
    
}
