﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace T_L_O_B_O
{
    class ScissorBuilder : IBuilder
    {
        private GameObject buildObject;
        public void BuildGameOBject(Vector2 position)
        {
            GameObject Scissor = new GameObject();
            Scissor.AddComponent(new Transform(Scissor, position));
            Scissor.AddComponent(new SpriteRenderer(Scissor, "Missing", 1));
            Scissor.AddComponent(new Animator(Scissor));
            //Scissor.AddComponent(new Scissor);
            Scissor.AddComponent(new Collider(Scissor, false));
            buildObject = Scissor;
        }

        public GameObject GetResult()
        {
            return buildObject;
        }
    }
}
