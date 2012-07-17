using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MainGameProject
{
    class SprinningEnemy : BasicModel
    {
        Matrix rotation = Matrix.Identity;  
      
		public SprinningEnemy(Model m) : base(m)
        {

        }

        public override void Update()
        {
            rotation *= Matrix.CreateRotationY(MathHelper.Pi / 180);
        }

        public override Matrix GetWorld()
        {
            return world * rotation;
        }
    }
}
