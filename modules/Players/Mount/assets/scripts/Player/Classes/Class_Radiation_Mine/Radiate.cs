function Class_Radiation_Mine::Radiate(%this,%Schedule_Radiate)
{

if (!isObject(%this)||!isObject(%this.Sprite_Target)){return;}

%Float_Distance=Vector2Distance(%this.Position,%this.Sprite_Target.Position);

if (%Float_Distance>%this.Size.X*6)
{

return;

}

%this.Sprite_Target.Update_Health(5,-1);

%Schedule_Radiate=schedule(1000,0,"Class_Radiation_Mine::Radiate",%this,%Schedule_Radiate);

}
