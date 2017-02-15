using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour {

    int i = 0;    //Iterator = Something that can increase or decrease


    /*
	// Use this for initialization
	void Start () {
        while (i < 10)
        {
            print(i);
            i++;
        }
        print("Done! :D");*/


    public string[] colors;

        void Start () {
            while (i < colors.Length)
            {
                print(colors[i]);
                i++;
            }


            print("Done! :D");



        }
}
