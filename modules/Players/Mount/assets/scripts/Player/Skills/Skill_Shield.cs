function Module_Player_Mount::Skill_Shield(%this,%Sprite_Player)
{

if (%Sprite_Player.Bool_Hacking){return;}

%Sprite_Shield=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Shield_Effect_Size;
Animation="Module_Player_Spook:Animation_Stealth";
class="Class_Stealth";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Shield);

if (%Sprite_Player.Bool_Recharging)
{

%Sprite_Player.Bool_Recharging=false;

cancel(%Sprite_Player.Schedule_Recharge);

}

if (%Sprite_Player.Bool_Shielded)
{

%Sprite_Player.Bool_Shielded=false;

%Sprite_Player.setBlendColor(1,1,1,1);

}
else
{

%Sprite_Player.Bool_Shielded=true;

%Sprite_Player.setBlendColor(1,1,0,1);

}

}
