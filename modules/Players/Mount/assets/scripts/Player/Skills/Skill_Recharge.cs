function Module_Player_Mount::Recharge(%this,%Sprite_Player,%Int_Counter)
{

if (!isObject(%Sprite_Player)){return;}

if (%Int_Counter>=10||%Sprite_Player.Int_Health>=100)
{

%Sprite_Player.Bool_Recharging=false;

return;

}

if (%Sprite_Player.Bool_Spotted||%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Recharge=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Recharge_Effect_Size;
Animation="Module_Player_Spook:Animation_Bolt";
class="Class_Bolt";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Recharge);

}

%Sprite_Player.Update_Health(10,1);

%Sprite_Player.Schedule_Recharge=schedule(1000,0,"Module_Player_Mount::Recharge",%this,%Sprite_Player,%Int_Counter+1);

}

function Module_Player_Mount::Skill_Recharge(%this,%Sprite_Player)
{

if (%Sprite_Player.Bool_Hacking){return;}

if (%Sprite_Player.Bool_Shielded)
{

%Sprite_Player.Bool_Shielded=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}

if (%Sprite_Player.Bool_Recharging)
{

%Sprite_Player.Bool_Recharging=false;

cancel(%Sprite_Player.Schedule_Recharge);

}
else
{

%Sprite_Player.Bool_Recharging=true;

%Sprite_Player.Schedule_Recharge=schedule(1000,0,"Module_Player_Mount::Recharge",%this,%Sprite_Player,0);

}

}
