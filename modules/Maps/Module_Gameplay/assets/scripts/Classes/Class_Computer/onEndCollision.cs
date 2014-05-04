function Class_Computer::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==0)
{

%Colliding_Object.Bool_Hacking=false;

}

if (%Colliding_Object==%this.Module_ID_Parent.Sprite_Player)
{

cancel(%this.Schedule_Progress);

%this.Progress(0);

}

}
