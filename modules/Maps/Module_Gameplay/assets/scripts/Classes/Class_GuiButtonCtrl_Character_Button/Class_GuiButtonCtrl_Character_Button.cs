function Module_Gameplay::Character_Set(%this,%GuiButtonCtrl)
{

%this.Module_ID_Player=%GuiButtonCtrl.Module_ID_Parent;

Module_Player_Spook.Gui_Select_Destroy();

Module_Player_Mount.Gui_Select_Destroy();

%this.Sprite_Player=%this.Module_ID_Player.Player_Spawn();

%this.Module_ID_Player.Gui_Gameplay_Initialize();

%this.Sprite_Player.playAnimation
(
%this.Sprite_Player.Simset_Animations_Stand_Down.
getObject(
getRandom(0,%this.Sprite_Player.Simset_Animations_Stand_Down.getCount()-1)
)
.String_Animation
);

/***********************************************************************************************************/

if (%this.Module_ID_Player$="Module_Player_Spook")
{

%this.Module_ID_AI="Module_Player_Mount";

}
else
{

%this.Module_ID_AI="Module_Player_Spook";

}

%this.Sprite_AI=%this.Module_ID_AI.Player_Spawn();

%this.Sprite_AI.playAnimation
(
%this.Sprite_AI.Simset_Animations_Stand_Down.
getObject(
getRandom(0,%this.Sprite_AI.Simset_Animations_Stand_Down.getCount()-1)
)
.String_Animation
);

%this.Sprite_AI.setBlendColor(1,1,1,0);

/***********************************************************************************************************/

%this.Input_Initialize();

%this.World_Limits_Initialize();

%this.Floor_Initialize();

%this.Obstacles_Grid_Initialize();

%this.Score_Initialize();

%this.Computer_Objective_Initialize();

%this.Roamer_Initialize();

%this.Schedule_Visibility_Ray=schedule(1000,0,"Module_Gameplay::Visibility_Ray_Initialize",%this,%this.Schedule_Visibility_Ray);

%ScriptObject_World_Tile_Slot=%this.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.SimSet_World_Tile_Slots.getCount()-1));

%this.Sprite_Player.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

%ScriptObject_World_Tile_Slot=%this.SimSet_World_Tile_Slots.getObject(getRandom(0,%this.SimSet_World_Tile_Slots.getCount()-1));

%this.Sprite_AI.Position=%ScriptObject_World_Tile_Slot.Vector_2D_Position;

Window_Spooks_VS_Mounts.mount(%this.Sprite_Player,"0 0",0,true,false);

%this.AI_Process();

}

function Class_GuiButtonCtrl_Character_Button::onAction(%this)
{

schedule(0,0,"Module_Gameplay::Character_Set",Module_Gameplay,%this);

}
