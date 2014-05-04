function Module_Player_Mount::Player_Spawn(%this)
{

%Sprite_Mount=new Sprite()
{

Position="0 0";
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Male_Sprite_2);
Image="Module_Player_Mount:Image_Male_Sprite_2";
class="Class_Mount";
CollisionCallback="true";
SceneLayer=16;

FixedAngle=true;

SceneGroup=0;//Players.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Char_Direction=1;

Bool_Moving=false;

SimSet_Move_Steps=0;

Simset_Animations_Stand_Up=0;

Simset_Animations_Stand_Down=0;

Simset_Animations_Stand_Left=0;

Simset_Animations_Stand_Right=0;

Simset_Animations_Run_Up=0;

Simset_Animations_Run_Down=0;

Simset_Animations_Run_Left=0;

Simset_Animations_Run_Right=0;

SceneObject_Mount_Point=0;

Int_Health=100;

Int_Speed=10;

Int_Current_Speed=10;

Bool_Spotted=false;

Bool_Shielded=false;

Bool_Recharging=false;

Schedule_Recharge=0;

Bool_Hacking=false;

};

%Sprite_Mount.setCollisionGroups(25,26,30);

%Sprite_Mount.Collision_Shape_Index=%Sprite_Mount.createPolygonBoxCollisionShape(%Sprite_Mount.Size);

/****************************************************************************************************/

%Sprite_Mount.SimSet_Move_Steps=new SimSet();

/****************************************************************************************************/

%Sprite_Mount.Simset_Animations_Stand_Up=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Stand_Up";

};

%Sprite_Mount.Simset_Animations_Stand_Up.add(%ScriptObject_Animation);

/****************************************************************************************************/

%Sprite_Mount.Simset_Animations_Stand_Down=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Stand_Down";

};

%Sprite_Mount.Simset_Animations_Stand_Down.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Stand_Left=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Stand_Left";

};

%Sprite_Mount.Simset_Animations_Stand_Left.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Stand_Right=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Stand_Right";

};

%Sprite_Mount.Simset_Animations_Stand_Right.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Run_Up=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Run_Up";

};

%Sprite_Mount.Simset_Animations_Run_Up.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Run_Down=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Run_Down";

};

%Sprite_Mount.Simset_Animations_Run_Down.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Run_Left=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Run_Left";

};

%Sprite_Mount.Simset_Animations_Run_Left.add(%ScriptObject_Animation);

/****************************************************************************************************/
%Sprite_Mount.Simset_Animations_Run_Right=new SimSet();

%ScriptObject_Animation=new ScriptObject()
{

String_Animation="Module_Player_Mount:Animation_Male_Sprite_2_Run_Right";

};

%Sprite_Mount.Simset_Animations_Run_Right.add(%ScriptObject_Animation);

/****************************************************************************************************/

Scene_Spooks_VS_Mounts.add(%Sprite_Mount);

/*%Sprite_Mount.SceneObject_Mount_Point=new SceneObject()
{

Position=%Sprite_Mount.Position;
Size="10 10";
class="Class_Mount_Point";

SceneGroup=26;

Module_ID_Parent=%this;

DefaultDensity=0;

DefaultRestitution=0;

};

%Sprite_Mount.SceneObject_Mount_Point.setSleepingAllowed(false);

Scene_Spooks_VS_Mounts.add(%Sprite_Mount.SceneObject_Mount_Point);

%Sprite_Mount.SceneObject_Mount_Point.mount(%Sprite_Mount,"0 0",
0,true,0);*/

/****************************************************************************************************/

return %Sprite_Mount;

}
