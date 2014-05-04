function Class_Computer::Progress(%this,%Char_Operation)
{

if (%Char_Operation)//Increase
{

if (%this.Module_ID_Parent.Sprite_Player.Bool_Stealthed)
{

%this.Module_ID_Parent.Sprite_Player.Bool_Stealthed=false;

%this.Module_ID_Parent.Sprite_Player.setBlendColor(1,1,1,1);

}

if (%this.Module_ID_Parent.Sprite_Player.Bool_Shielded)
{

%this.Module_ID_Parent.Sprite_Player.Bool_Shielded=false;

%this.Module_ID_Parent.Sprite_Player.setBlendColor(1,1,1,1);

}

if (%this.Module_ID_Parent.Sprite_Player.Bool_Recharging)
{

%this.Module_ID_Parent.Sprite_Player.Bool_Recharging=false;

cancel(%this.Module_ID_Parent.Sprite_Player.Schedule_Recharge);

}

%this.Int_Progress+=5;

}
else//Decrease
{

%this.Int_Progress--;

}

%Int_Extent=(%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Vector_2D_Size.X*%this.Int_Progress)/100;

%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Extent.X=%Int_Extent;

if (%this.Int_Progress>=100)
{

%this.Int_Progress=0;

%Int_Extent=(%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Vector_2D_Size.X*%this.Int_Progress)/100;

%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Extent.X=%Int_Extent;

%ScriptObject_World_Tile_Slot=%this.Module_ID_Parent.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.Module_ID_Parent.SimSet_World_Tile_Slots.getCount()-1));

%this.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

if (%this.Module_ID_Parent.Sprite_Player.class$="Class_Spook")
{

%this.Module_ID_Parent.Int_Spook_Score+=5;

}
else
{

%this.Module_ID_Parent.Int_Mount_Score+=5;

}

%this.Module_ID_Parent.Score_Update();

return;

}
else if (%this.Int_Progress<=0)
{

%this.Int_Progress=0;

%Int_Extent=(%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Vector_2D_Size.X*%this.Int_Progress)/100;

%this.GuiSpriteCtrl_Computer_Progress_Bar.GuiSpriteCtrl_Computer_Progress.Extent.X=%Int_Extent;

%ScriptObject_World_Tile_Slot=%this.Module_ID_Parent.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.Module_ID_Parent.SimSet_World_Tile_Slots.getCount()-1));

%this.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

return;

}

%this.Schedule_Progress=schedule(1000,0,"Class_Computer::Progress",%this,%Char_Operation);

}

function Class_Computer::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==0)
{

%Colliding_Object.Bool_Hacking=true;

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

if (%Colliding_Object==%this.Module_ID_Parent.Sprite_Player)
{

cancel(%this.Schedule_Progress);

%this.Progress(1);

}

}
