function Class_Flame::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.SceneGroup==0)
{

if (!%Colliding_Object.Bool_Shielded)
{

%Colliding_Object.Update_Health(10,-1);

}

}

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=%this.Module_ID_Parent.Vector_2D_Explosion_Size;
Animation="Module_Gameplay:Animation_Explosion";
class="Class_Explosion";
SceneLayer=14;

Module_ID_Parent=%this.Module_ID_Parent;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Explosion);

%this.safeDelete();

}
