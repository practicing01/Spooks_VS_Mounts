function Class_Gameplay_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (%Vector_2D_World_Position.X>%this.Module_ID_Parent.Vector_2D_World_Limits.X||%Vector_2D_World_Position.X<0
||%Vector_2D_World_Position.Y>%this.Module_ID_Parent.Vector_2D_World_Limits.Y||%Vector_2D_World_Position.Y<0)
{

return;

}

if (%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.getCount())
{

%ScriptObject_Move_Step=%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.getObject(0);

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.remove(%ScriptObject_Move_Step);

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.deleteObjects();

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

%Float_Angle=Vector2AngleToPoint(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_World_Position);

%Float_Distance=Vector2Distance(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_World_Position);

/***************************************************************************************************************/

if (%Float_Angle>=45&&%Float_Angle<=135)//Up
{

%Float_Distance=%Float_Distance/%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(90,%this.Module_ID_Parent.Vector_2D_Floor_Size.Y);

%Vector_2D_Position=Vector2Add(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_Position);

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List)){return;}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=90;

Float_Magnitude=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

Char_Direction=0;

};

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%this.Module_ID_Parent.Sprite_Player.moveTo(%Vector_2D_Position,%this.Module_ID_Parent.Sprite_Player.Int_Current_Speed,true,true);

%this.Module_ID_Parent.Sprite_Player.Char_Direction=0;

%this.Module_ID_Parent.Sprite_Player.playAnimation
(
%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Up.
getObject(
getRandom(0,%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Up.getCount()-1)
)
.String_Animation
);

}

}
else if (%Float_Angle<=-45&&%Float_Angle>=-135)//Down
{

%Float_Distance=%Float_Distance/%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(-90,%this.Module_ID_Parent.Vector_2D_Floor_Size.Y);

%Vector_2D_Position=Vector2Add(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_Position);

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List)){return;}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=-90;

Float_Magnitude=%this.Module_ID_Parent.Vector_2D_Floor_Size.Y;

Char_Direction=1;

};

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%this.Module_ID_Parent.Sprite_Player.moveTo(%Vector_2D_Position,%this.Module_ID_Parent.Sprite_Player.Int_Current_Speed,true,true);

%this.Module_ID_Parent.Sprite_Player.Char_Direction=1;

%this.Module_ID_Parent.Sprite_Player.playAnimation
(
%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Down.
getObject(
getRandom(0,%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Down.getCount()-1)
)
.String_Animation
);

}

}
else if ((%Float_Angle<=-135&&%Float_Angle>=-180)||(%Float_Angle>=135&&%Float_Angle<=180))//Left
{

%Float_Distance=%Float_Distance/%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(180,%this.Module_ID_Parent.Vector_2D_Floor_Size.X);

%Vector_2D_Position=Vector2Add(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_Position);

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List)){return;}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=180;

Float_Magnitude=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

Char_Direction=2;

};

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%this.Module_ID_Parent.Sprite_Player.moveTo(%Vector_2D_Position,%this.Module_ID_Parent.Sprite_Player.Int_Current_Speed,true,true);

%this.Module_ID_Parent.Sprite_Player.Char_Direction=2;

%this.Module_ID_Parent.Sprite_Player.playAnimation
(
%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Left.
getObject(
getRandom(0,%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Left.getCount()-1)
)
.String_Animation
);

}

}
else if ((%Float_Angle<=0&&%Float_Angle>=-45)||(%Float_Angle>=0&&%Float_Angle<=45))//Right
{

%Float_Distance=%Float_Distance/%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(0,%this.Module_ID_Parent.Vector_2D_Floor_Size.X);

%Vector_2D_Position=Vector2Add(%this.Module_ID_Parent.Sprite_Player.Position,%Vector_2D_Position);

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List)){return;}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=0;

Float_Magnitude=%this.Module_ID_Parent.Vector_2D_Floor_Size.X;

Char_Direction=3;

};

%this.Module_ID_Parent.Sprite_Player.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Module_ID_Parent.Sprite_Player.Bool_Moving)
{

%this.Module_ID_Parent.Sprite_Player.moveTo(%Vector_2D_Position,%this.Module_ID_Parent.Sprite_Player.Int_Current_Speed,true,true);

%this.Module_ID_Parent.Sprite_Player.Char_Direction=3;

%this.Module_ID_Parent.Sprite_Player.playAnimation
(
%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Right.
getObject(
getRandom(0,%this.Module_ID_Parent.Sprite_Player.Simset_Animations_Run_Right.getCount()-1)
)
.String_Animation
);

}

}

%this.Module_ID_Parent.Sprite_Player.Bool_Moving=true;

/***************************************************************************************************************/

}

function Class_Gameplay_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Gameplay_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{



}
