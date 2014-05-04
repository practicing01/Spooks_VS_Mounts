function Class_Mount::Update_Health(%this,%Int_Amount,%Char_Operation)
{

if (%this.Bool_Shielded)
{

return;

}

if (%Char_Operation==0)
{

%this.Int_Health=%Int_Amount;

}
else if (%Char_Operation==1)
{

%this.Int_Health+=%Int_Amount;

if (%this.Int_Health>100)
{

%this.Int_Health=100;

}

}
else if (%Char_Operation==-1)
{

%this.Int_Health-=%Int_Amount;

}

if (%this.Int_Health<=0)
{

%this.cancelMoveTo();

%this.onMoveToComplete();

%this.Int_Health=100;

%ScriptObject_World_Tile_Slot=Module_Gameplay.SimSet_World_Tile_Slots.getObject(getRandom(0,Module_Gameplay.SimSet_World_Tile_Slots.getCount()-1));

%this.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

Module_Gameplay.Int_Spook_Score++;

Module_Gameplay.Score_Update();

}

if (%this==Module_Gameplay.Sprite_Player)
{

%Int_Extent=(%this.Module_ID_Parent.GuiSpriteCtrl_Health_Bar.GuiSpriteCtrl_Health_Progress.Vector_2D_Size.X*%this.Int_Health)/100;

%this.Module_ID_Parent.GuiSpriteCtrl_Health_Bar.GuiSpriteCtrl_Health_Progress.Extent.X=%Int_Extent;

}

}
