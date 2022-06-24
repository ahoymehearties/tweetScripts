using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

    [Serializable] public class Tweet // We declare our class, which is Tweet, and we make it public. And serializable, since we're going to make many of these.

{
    [TextArea] // We tell Unity to use a textarea
    public string text; // We declare a text var of string type

    public int likes; // We declare a likes var of int type
    public int retweets; // We declare a retweets var of int type

    public Sprite image; // We declare an image var of Sprite type
}
