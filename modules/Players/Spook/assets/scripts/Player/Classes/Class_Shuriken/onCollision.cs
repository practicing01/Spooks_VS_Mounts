function Class_Shuriken::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object!=%this.Sprite_Parent)
{

if (%Colliding_Object.SceneGroup==0)
{

%Colliding_Object.Update_Health(10,-1);

}

%this.safeDelete();

}

}
