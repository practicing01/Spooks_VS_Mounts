function Class_Radiation_Mine::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object!=%this.Sprite_Parent&&(%Colliding_Object.class$="Class_Mount"||%Colliding_Object.class$="Class_Spook"))
{

%this.Sprite_Target=%Colliding_Object;

%this.Schedule_Radiate=schedule(1000,0,"Class_Radiation_Mine::Radiate",%this,%this.Schedule_Radiate);

}

}
