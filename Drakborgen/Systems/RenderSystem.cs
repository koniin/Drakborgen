﻿using Drakborgen.Components;
using Gengine.EntityComponentSystem;

namespace Drakborgen.Systems {
    public class RenderSystem : EntityProcessingSystem{
        public override void Process(Entity entity, float dt){
            var movement = entity.GetComponent<PhysicsComponent>();
            var render = entity.GetComponent<RenderComponent>();

            render.RenderPosition = movement.Position;
        }
    }
}
