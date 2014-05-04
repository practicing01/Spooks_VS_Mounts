function Module_Player_Spook::Reset_Charge_Speed(%this,%Sprite_Player)
{

if (!isObject(%Sprite_Player)){return;}

if (%Sprite_Player.Int_Current_Speed>=20)
{

%Sprite_Player.Int_Current_Speed=%Sprite_Player.Int_Speed;

}

}

function Module_Player_Spook::Skill_Charge(%this,%Sprite_Player)
{

%Sprite_Charge=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Charge_Effect_Size;
Animation="Module_Player_Spook:Animation_Charge";
class="Class_Charge";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Charge);

if (%Sprite_Player.Int_Current_Speed<20)
{

%Sprite_Player.Int_Current_Speed=20;

schedule(5000,0,"Module_Player_Spook::Reset_Charge_Speed",%this,%Sprite_Player);

}

}
