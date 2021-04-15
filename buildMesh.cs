using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildMesh : MonoBehaviour
{

    //public variables for Top
    public Vector3 vertLeftTopFront = new Vector3(-1, 1, 1);
    public Vector3 vertRightTopFront = new Vector3(1, 1, 1);
    public Vector3 vertRightTopBack = new Vector3(1, 1, -1);
    public Vector3 vertLeftTopBack = new Vector3(-1, 1, -1);

    //public variables for Bottom
    public Vector3 vertLeftBottomFront = new Vector3(-1, -1, 1);
    public Vector3 vertRightBottomFront = new Vector3(1, -1, 1);
    public Vector3 vertRightBottomBack = new Vector3(1, -1, -1);
    public Vector3 vertLeftBottomBack = new Vector3(-1, -1, -1);


    // Start is called before the first frame update
    void Start()
    {

        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = mf.mesh;

        //Vertices

        Vector3[] vertices = new Vector3[]
        {
            //frontface
            vertLeftTopFront,   //Left top front 0
            vertRightTopFront,    //right top front 1
            vertLeftBottomFront,  //left bottom front 2
            vertRightBottomFront,   //right bottom front 3
       
            //backface
          
            vertRightTopBack, //right top back 4 
            vertLeftTopBack, //left top back 5 
            vertRightBottomBack, //right bottom back 6
            vertLeftBottomBack,  // left bottom back 7

            //left face 
           
            vertLeftTopBack, //left top back 8
            vertLeftTopFront, //left top front 9
            vertLeftBottomBack, //left bottom back 10
            vertLeftBottomFront, //left bottom front 11

            // right face

            vertRightTopFront, //right top front 12
            vertRightTopBack, //right top back 13 
            vertRightBottomFront, //right bottom front 14 
            vertRightBottomBack,  //right bootom back 15

            //top face 

             vertLeftTopBack, //left top back 16 
             vertRightTopBack, //right top back 17
             vertLeftTopFront, //left top front  18 
             vertRightTopFront, //right top front 19

            // bottom face
            
             vertLeftBottomFront, //left bottom front 20
             vertRightBottomFront, //right bottom front 21
             vertLeftBottomBack, // left bottom back 22
             vertRightBottomBack  //right bottom back 23 



        };

        //Triangles

        int[] triangles = new int[]
        {
            //frontface
            0,2,3,      //first triangle
            3,1,0,       //second triangle

            //backface
            4,6,7,      //first triangle
            7,5,4,       //second triangle

            //leftface
            8,10,11,      //first triangle
            11,9,8,       //second triangle

            //rightface
            12,14,15,      //first triangle
            15,13,12,       //second triangle

            //topface
            16,18,19,      //first triangle
            19,17,16,       //second triangle

            //backface
            20,22,23,      //first triangle
            23,21,20,       //second triangle


        };

        //UVs
        
        Vector2[] uvs = new Vector2[]
        {
            //frontface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0),

            //backface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0),

            //leftface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0),

            //rightface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0),

            //topface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0),

            //bottomface . 0,0 bottom left , 1,1 top right
            new Vector2(0,1),
            new Vector2(0,0),
            new Vector2(1,1),
            new Vector2(1,0)


        };

        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
