function Class_Roamer::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==0)
{

if (%Colliding_Object.Bool_Stealthed)
{

%Colliding_Object.Bool_Stealthed=false;

%Colliding_Object.setBlendColor(1,1,1,1);

}

if (%Colliding_Object.Bool_Shielded)
{

%Colliding_Object.Bool_Shielded=false;

%Colliding_Object.setBlendColor(1,1,1,1);

}

if (%Colliding_Object.Bool_Recharging)
{

%Colliding_Object.Bool_Recharging=false;

cancel(%Colliding_Object.Schedule_Recharge);

}

}
else if (%Colliding_Object.class$="Class_Mine")//Mines
{

%Colliding_Object.safeDelete();

}

}
