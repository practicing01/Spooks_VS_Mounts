function Class_Spook::onMoveToComplete(%this)
{

if (%this.SimSet_Move_Steps.getCount())
{

%ScriptObject_Move_Step=%this.SimSet_Move_Steps.getObject(0);

%this.SimSet_Move_Steps.remove(%ScriptObject_Move_Step);

%ScriptObject_Move_Step.delete();

}

if (%this.SimSet_Move_Steps.getCount()&&%this.Int_Health>0)
{

%ScriptObject_Move_Step=%this.SimSet_Move_Steps.getObject(0);

%Vector_2D_Position=Vector2Direction(%ScriptObject_Move_Step.Float_Angle,%ScriptObject_Move_Step.Float_Magnitude);

%Vector_2D_Position=Vector2Add(%this.Position,%Vector_2D_Position);

if (%Vector_2D_Position.X<Module_Gameplay.Vector_2D_World_Limits.X&&%Vector_2D_Position.X>0
&&%Vector_2D_Position.Y<Module_Gameplay.Vector_2D_World_Limits.Y&&%Vector_2D_Position.Y>0)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (!getWordCount(%String_Object_List))
{

%this.moveTo(%Vector_2D_Position,%this.Int_Current_Speed,true,true);

if (%this.Char_Direction!=%ScriptObject_Move_Step.Char_Direction)
{

%this.Char_Direction=%ScriptObject_Move_Step.Char_Direction;

if (%this.Char_Direction==0)
{

%this.playAnimation
(
%this.Simset_Animations_Run_Up.
getObject(
getRandom(0,%this.Simset_Animations_Run_Up.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==1)
{

%this.playAnimation
(
%this.Simset_Animations_Run_Down.
getObject(
getRandom(0,%this.Simset_Animations_Run_Down.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==2)
{

%this.playAnimation
(
%this.Simset_Animations_Run_Left.
getObject(
getRandom(0,%this.Simset_Animations_Run_Left.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==3)
{

%this.playAnimation
(
%this.Simset_Animations_Run_Right.
getObject(
getRandom(0,%this.Simset_Animations_Run_Right.getCount()-1)
)
.String_Animation
);

}

}

return;

}

}

}

%this.SimSet_Move_Steps.deleteObjects();

%this.Bool_Moving=false;

if (%this.Char_Direction==0)
{

%this.playAnimation
(
%this.Simset_Animations_Stand_Up.
getObject(
getRandom(0,%this.Simset_Animations_Stand_Up.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==1)
{

%this.playAnimation
(
%this.Simset_Animations_Stand_Down.
getObject(
getRandom(0,%this.Simset_Animations_Stand_Down.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==2)
{

%this.playAnimation
(
%this.Simset_Animations_Stand_Left.
getObject(
getRandom(0,%this.Simset_Animations_Stand_Left.getCount()-1)
)
.String_Animation
);

}
else if (%this.Char_Direction==3)
{

%this.playAnimation
(
%this.Simset_Animations_Stand_Right.
getObject(
getRandom(0,%this.Simset_Animations_Stand_Right.getCount()-1)
)
.String_Animation
);

}

}
