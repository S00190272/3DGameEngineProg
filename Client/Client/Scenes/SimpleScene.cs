﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Engine.Base;
using Client.GameObjects;
using Client.Scripts;
using System.Diagnostics;

namespace Client.Scenes
{
    /*______________________________________________________________________
    
        Add Component to Scene
    */
    class SimpleScene : Scene
    {
        DebugComponent cube1Debug;
        DebugComponent cube2Debug;
        public SimpleScene() : base()
        {

        }

        public override void Initialize()
        {
            AddObject(new Ground("plane", new Vector3(0, -2, 0)));

            AddObject(new SimplePlayerObject(new Vector3(0, 0, 10)));
            AddObject(new SimpleMeshObjects("cube", new Vector3(0, 10, -10)));
           // AddObject(new Ground)

            //var Cube1 = new SimpleMeshObjects("cube", new Vector3(0, 0,-10));
            //var Cube2 = new SimpleMeshObjects("cube", new Vector3(0, 0, -10));
            //AddObject(Cube1);
            //AddObject(Cube2);
            
            base.Initialize();

            //cube1Debug = Cube1.GetComponent<DebugComponent>();
            //cube2Debug = Cube2.GetComponent<DebugComponent>();

        }
        public override void Update()
        {
            //if (cube1Debug.AABB.Intersects(cube2Debug.AABB)) 
            //{
            //    Debug.WriteLine("Collision");
            //}
            //else
            //{
            //    Debug.WriteLine("No Collision");
            //}

            base.Update();
        }
    }
}
