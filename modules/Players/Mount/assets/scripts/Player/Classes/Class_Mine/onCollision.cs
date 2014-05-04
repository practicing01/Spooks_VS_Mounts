function Class_Mine::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object!=%this.Sprite_Parent&&(%Colliding_Object.class$="Class_Mount"||%Colliding_Object.class$="Class_Spook"))
{

%Colliding_Object.Update_Health(10,-1);

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(Module_Player_Mount.Ass_Image_Explosion);
Animation="Module_Player_Mount:Animation_Explosion";
class="Class_Bolt";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Explosion);

//%Colliding_Object.setLinearVelocityPolar(Vector2AngleToPoint(%this.Position,%Colliding_Object.Position),100);

%this.safeDelete();

}

}
