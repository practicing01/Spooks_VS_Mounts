function Module_Player_Spook::Reset_Bolt_Speed(%this,%Sprite_Player)
{

if (!isObject(%Sprite_Player)){return;}

if (%Sprite_Player.Int_Current_Speed<=5)
{

%Sprite_Player.Int_Current_Speed=%Sprite_Player.Int_Speed;

}

}

function Module_Player_Spook::Skill_Bolt(%this,%Sprite_Player)
{

if (%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Target=Module_Gameplay.Sprite_AI;

}
else
{

%Sprite_Target=Module_Gameplay.Sprite_Player;

}

if (%Sprite_Target.Bool_Spotted)
{

if (%Sprite_Player.Bool_Stealthed)
{

%Sprite_Player.Bool_Stealthed=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}

%Sprite_Bolt=new Sprite()
{

Position=%Sprite_Target.Position;
Size=%this.Vector_2D_Bolt_Effect_Size;
Animation="Module_Player_Spook:Animation_Bolt";
class="Class_Bolt";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Bolt);

if (%Sprite_Target.Int_Current_Speed>5)
{

%Sprite_Target.Int_Current_Speed=5;

schedule(5000,0,"Module_Player_Spook::Reset_Bolt_Speed",%this,%Sprite_Target);

}

}

}
