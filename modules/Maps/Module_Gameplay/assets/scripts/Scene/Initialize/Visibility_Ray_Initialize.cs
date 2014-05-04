function Module_Gameplay::Visibility_Ray_Initialize(%this,%Schedule_Visibility_Ray)
{

if (!isObject(%this.Sprite_Player)||!isObject(%this.Sprite_AI))
{

return;

}

if (Vector2Distance(%this.Sprite_Player.Position,%this.Sprite_AI.Position)<=%this.Float_Visibility_Ray_Distance)
{

%String_Objects=Scene_Spooks_VS_Mounts.pickRay(%this.Sprite_Player.Position,%this.Sprite_AI.Position,bit(26),"","collision");

if (getWordCount(%String_Objects))
{

%this.Sprite_AI.setBlendColor(1,1,1,0);//Target obstructed.

%this.Sprite_AI.Bool_Spotted=false;

}
else if (!%this.Sprite_AI.Bool_Stealthed)
{

if (!%this.Sprite_AI.Bool_Shielded)
{

%this.Sprite_AI.setBlendColor(1,1,1,1);//Target visible.

}
else
{

%this.Sprite_AI.setBlendColor(1,1,0,1);//Target visible.

}

%this.Sprite_AI.Bool_Spotted=true;

}

}
else//Out of range.
{

%this.Sprite_AI.setBlendColor(1,1,1,0);

%this.Sprite_AI.Bool_Spotted=false;

}

%Schedule_Visibility_Ray=schedule(1000,0,"Module_Gameplay::Visibility_Ray_Initialize",%this,%Schedule_Visibility_Ray);

}
