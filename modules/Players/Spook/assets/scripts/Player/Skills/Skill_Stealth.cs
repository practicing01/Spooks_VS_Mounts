function Module_Player_Spook::Skill_Stealth(%this,%Sprite_Player)
{

if (%Sprite_Player.Bool_Hacking){return;}

%Sprite_Smoke=new Sprite()
{

Position=%Sprite_Player.Position;
Size=%this.Vector_2D_Stealth_Effect_Size;
Animation="Module_Player_Spook:Animation_Stealth";
class="Class_Stealth";

SceneLayer=15;

Module_ID_Parent=%this;

};

Scene_Spooks_VS_Mounts.add(%Sprite_Smoke);

if (%Sprite_Player.Bool_Stealthed)
{

%Sprite_Player.Bool_Stealthed=false;

if (%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Player.setBlendColor(1,1,1,1);

}
else
{

%Sprite_Player.setBlendColor(1,1,1,0);

}

}
else
{

%Sprite_Player.Bool_Stealthed=true;

if (%Sprite_Player==Module_Gameplay.Sprite_Player)
{

%Sprite_Player.setBlendColor(1,1,1,0.5);

}
else
{

%Sprite_Player.setBlendColor(1,1,1,0);

}

}

}
