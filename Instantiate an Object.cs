
//Instatiating https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
using System;
using Stystem.Collections
using UnityEngine
//Original - an existing object that you want to make a copy of 
//Position - position of the new object 
//Rotation - orientation of the new object
//Parent - Parent that will be assigned to the new object 
//instantiateInWorldSpace - pass true when assigning a parent Object to maintain the world position of the Object
//  instead of setting its position relative to the new parent. Pass false set the Object's position relative to its
//  parent. 
//object the instantiated clone. 

//Description - Clones the object original and returns the clone. 

//this function makes a copy of an object in a similar way to the Duplicate command in the editor. If you are cloning
//a GameObject then you can also optionally specify its position and rotation (these default to the original GameObject's
//positon and rotation otherwise). If you are cloning a Component then the GameObject it is attached to will also be 
//cloned, again with the original position and rotation. 

  //The active status of a GameObject at the time of cloning will be passed on, so if the original is inative then
  //the close will be created in an inactive state too. 

public class Class1 
    //Instintiates 10 copies of Prefab each 2 units apart from each other
{
    public Transform prefab; 
    void start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.Identity);
        }
    }

    //Instantiate is most commonly used to instatiate projectiles, AI enemies, particle explodions or wrecked
    //object replacements. 

    //using UnityEngine 

    //instantiate a rigidbody then set the velocity. 

    Rigidbody protectile; 

    voide Update()
    {
        //ctrl was pressed, launch a projectile 
        if (Input.GetButtonDown) ("Fire"))
            {
            //instantiate the pojectile at the position and rotation of this transform 
            Rigidbody clone;
            clone = Instatnsiate(projectile, transform.position, transform.rotation);

            //Give the cloned object an initial velocity along the current
            //object's Z axis 
            clone.velocity = transform.TransformDirection(Vector3.forward * 10); 
            }
    }

    //Instantiate can also clone script instances directly. The entire game object hierarchy will be cloned
    //and the clone script instance will be returned. 

    public class Missile: MonoBehaviour
    {
        public int timeoutDestrictor; 

        //.....other code....
    }

    public class ExampleClass : MonoBehavior
    {
        //Instantiate a prefab with an attached Missile Script public Missile projectile. 

        void Update()
        {
            //Ctrl was pressed, launch a projectile
            if (Input.GetBottonDown) ("Fire"))
                {
                //instantiate the projectile at the position and rotation of this transform
                Missle clone = (Missile)instnatiate(projectile, transform.position, transform.rotation);

                //set the missles timeout destructor to 5
                clone.timeoutDestructor = 5; 
                }
        }
    }

    //After cloning an object, you can also use GetComponent to set properties on a specific attached to 
    //the cloned object. 

    public static T Initiate(TOriginal);
    public static T Initiate(TOriginal, Transform Parent);
    public static T Initiate(TOriginal, Transform Parent, bool worldPositionStays);
    public static T Initiate(TOriginal, Vector3 position, Quaternion rotation);
    public static T Initiate(TOriginal, Vector3 position, Quaternion rotation, Transform parent);

    //original - Object of type T that you want to make a clone of
    //Returns T object of type T

    //Description - you an also use Generics to instantiate objects. See the Generic Functions page for more details. 

    //in the next example, we initiate our Missle object again, but by using Gemerics we dont need to cast the result. 

    using UnityEngine; 

public class Missle: Monobehaviour
{
    //...other code 
}

public class InstantiateGenericsExample : MonoBegavior
{
    public Missile missile; 
    void Start()
    {
        missile missleCopy = InstantiateGenericsExample<Missile>(missile); 
    }

}
}

