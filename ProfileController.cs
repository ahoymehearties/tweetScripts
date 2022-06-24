using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Here be namespaces

public class ProfileController : MonoBehaviour // Here we declare the class ProfileController, which is a MonoBehaviour script. It can be changed if I knew what to change it to.
{
    public TMP_Text tweetField; // public declaration of variable tweetField, which is of type TMP_Text.)
    private List<ProfileSO> profiles = new List<ProfileSO>(); // We declare a private variable called "profiles", which declares that it should instantiate a new instance of our ProfileSO class. We do this as a list.
    public TMP_Text likes; // We declare a public variable of type TMP_Text (because we are rendering it as text, not a number), which we call "likes."

    // Start is called before the first frame update
    void Start() 
    {
        Object[] profileObjects = Resources.LoadAll("", typeof(ProfileSO)); /*  Within the start method we declare a variable of type Object[] (which is an array, but I don't know why)
                                                                             *  called profileObjects. This is the Loadall method within the Resources class, which takes a string argument
                                                                             *  and another argument, which could be a type, among other things, it would seem. */                                                                          *  for
        

        foreach (Object profile in profileObjects) // For every profile instance (which we defined within the class... but why is it singular?!) 
        {
            profiles.Add((ProfileSO)profile);  /* Use the Add method within the profiles field, which takes a single argument that is tough to parse.
                                                It adds (instantiates a class object) of ProfileSO (as a `profile`)? */
        }

        ProfileSO firstProfile = profiles[0]; // declare a firstProfile variable of type ProfileSO, which is the first index of the profiles field.
        Tweet firstTweet = firstProfile.tweets[0]; // declare a variable firstTweet of type Tweet (our Tweet class, in this instance), as the first index of the tweets field within the firstProfile variable we just set.


        tweetField.text = firstTweet.text; // set the text property of tweetField to the text property of firstTweet
        likes.text = firstTweet.likes.ToString(); // set the text property of the likes field to the likes property of firstTweet, but use the ToString() method since it's a number.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
