function Class_Radiation_Mine::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object==%this.Sprite_Target)
{

%this.Sprite_Target=0;

cancel(%this.Schedule_Radiate);

}

}
