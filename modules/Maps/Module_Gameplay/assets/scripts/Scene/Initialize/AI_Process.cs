function Module_Gameplay::AI_Process(%this)
{

%Vector_2D_World_Position=%this.Sprite_AI.Position;

%Sprite_Target=%this.Sprite_Computer_Objective;

if (%this.Sprite_AI.class$="Class_Spook")
{

%Sprite_Target=%this.Sprite_Player;

}

if (%this.Sprite_AI.Int_Health>50||%this.Sprite_AI.class$="Class_Spook")
{

%Float_X_Distance=mAbs(%this.Sprite_AI.Position.X-%Sprite_Target.Position.X);

%Float_Y_Distance=mAbs(%this.Sprite_AI.Position.Y-%Sprite_Target.Position.Y);

if (%Float_X_Distance>=%Float_Y_Distance)
{

if (%this.Sprite_AI.Position.X<%Sprite_Target.Position.X)//Go right.
{

//Check if can move right. if not, move up or down.

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Undo addition.

if (%this.Sprite_AI.Position.Y<%Sprite_Target.Position.Y)//Below
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Go up.

}
else//Above
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Go down.

}

}

}
else//Go left.
{

//Check if can move left. if not, move up or down.

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Undo subtraction.

if (%this.Sprite_AI.Position.Y<%Sprite_Target.Position.Y)//Below
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Go up.

}
else//Above
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Go down.

}

}

}

}
else
{

if (%this.Sprite_AI.Position.Y<%Sprite_Target.Position.Y)//Go up.
{

//Check if can move up. if not, move left or right.

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Undo addition.

if (%this.Sprite_AI.Position.X<%Sprite_Target.Position.X)//Left
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Go right.

}
else//Right
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Go left.

}

}

}
else//Go down.
{

//Check if can move down. if not, move left or right.

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Undo subtraction.

if (%this.Sprite_AI.Position.X<%Sprite_Target.Position.X)//Left
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Go right.

}
else//Right
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Go left.

}

}

}

}

}
else//Run away from player.
{

//Pick above and right for collisions.
//If none, randomly choose
//If any, randomly choose in the unobstructed direction.

%Vector_2D_Pick_Point=%Vector_2D_World_Position;

%Vector_2D_Pick_Point.X+=%this.Vector_2D_Floor_Size.X;

%String_Right_Pick_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Pick_Point,bit(26),"","collision");

%Vector_2D_Pick_Point.X-=%this.Vector_2D_Floor_Size.X;

%Vector_2D_Pick_Point.Y+=%this.Vector_2D_Floor_Size.Y;

%String_Up_Pick_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Pick_Point,bit(26),"","collision");

if (!getWordCount(%String_Right_Pick_List)&&!getWordCount(%String_Up_Pick_List))
{

%Char_Random_Direction=getRandom(0,3);

if (%Char_Random_Direction==0)//Up
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;

}
else if (%Char_Random_Direction==1)//Down
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;

}
else if (%Char_Random_Direction==2)//Left
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;

}
else if (%Char_Random_Direction==3)//Right
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;

}

}
else if (!getWordCount(%String_Right_Pick_List))
{

%Char_Random_Direction=getRandom(0,1);

if (%Char_Random_Direction==0)//Left
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;

}
else if (%Char_Random_Direction==1)//Right
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;

}

}
else
{

%Char_Random_Direction=getRandom(0,1);

if (%Char_Random_Direction==0)//Up
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;

}
else if (%Char_Random_Direction==1)//Down
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;

}

}

/*%Float_X_Distance=mAbs(%this.Sprite_AI.Position.X-%this.Sprite_Player.Position.X);

%Float_Y_Distance=mAbs(%this.Sprite_AI.Position.Y-%this.Sprite_Player.Position.Y);

if (%Float_X_Distance<=%Float_Y_Distance)
{

if (%this.Sprite_AI.Position.X<%this.Sprite_Player.Position.X)//Go left.
{

//Check if can move right. if not, move up or down.

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Undo subtraction.

if (%this.Sprite_AI.Position.Y<%this.Sprite_Player.Position.Y)//Below
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Go down.

}
else//Above
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Go up.

}

}

}
else//Go right.
{

//Check if can move left. if not, move up or down.

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Undo addition.

if (%this.Sprite_AI.Position.Y<%this.Sprite_Player.Position.Y)//Below
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Go down.

}
else//Above
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Go up.

}

}

}

}
else
{

if (%this.Sprite_AI.Position.Y<%this.Sprite_Player.Position.Y)//Go down.
{

//Check if can move up. if not, move left or right.

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;//Undo subtraction.

if (%this.Sprite_AI.Position.X<%this.Sprite_Player.Position.X)//Left
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Go left.

}
else//Right
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Go right.

}

}

}
else//Go up.
{

//Check if can move down. if not, move left or right.

%Vector_2D_World_Position.Y+=%this.Vector_2D_Floor_Size.Y;

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_World_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%Vector_2D_World_Position.Y-=%this.Vector_2D_Floor_Size.Y;//Undo addition.

if (%this.Sprite_AI.Position.X<%this.Sprite_Player.Position.X)//Left
{

%Vector_2D_World_Position.X-=%this.Vector_2D_Floor_Size.X;//Go left.

}
else//Right
{

%Vector_2D_World_Position.X+=%this.Vector_2D_Floor_Size.X;//Go right.

}

}

}

}*/

}

/***************************************************************************************************************/

if (%Vector_2D_World_Position.X>%this.Vector_2D_World_Limits.X||%Vector_2D_World_Position.X<0
||%Vector_2D_World_Position.Y>%this.Vector_2D_World_Limits.Y||%Vector_2D_World_Position.Y<0)
{

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

return;

}

if (%this.Sprite_AI.SimSet_Move_Steps.getCount())
{

%ScriptObject_Move_Step=%this.Sprite_AI.SimSet_Move_Steps.getObject(0);

%this.Sprite_AI.SimSet_Move_Steps.remove(%ScriptObject_Move_Step);

%this.Sprite_AI.SimSet_Move_Steps.deleteObjects();

%this.Sprite_AI.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

%Float_Angle=Vector2AngleToPoint(%this.Sprite_AI.Position,%Vector_2D_World_Position);

%Float_Distance=Vector2Distance(%this.Sprite_AI.Position,%Vector_2D_World_Position);

/***************************************************************************************************************/

if (%Float_Angle>=45&&%Float_Angle<=135)//Up
{

%Float_Distance=%Float_Distance/%this.Vector_2D_Floor_Size.Y;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(90,%this.Vector_2D_Floor_Size.Y);

%Vector_2D_Position=Vector2Add(%this.Sprite_AI.Position,%Vector_2D_Position);

if (!%this.Sprite_AI.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

return;

}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=90;

Float_Magnitude=%this.Vector_2D_Floor_Size.Y;

Char_Direction=0;

};

%this.Sprite_AI.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Sprite_AI.Bool_Moving)
{

%this.Sprite_AI.moveTo(%Vector_2D_Position,%this.Sprite_AI.Int_Current_Speed,true,true);

%this.Sprite_AI.Char_Direction=0;

%this.Sprite_AI.playAnimation
(
%this.Sprite_AI.Simset_Animations_Run_Up.
getObject(
getRandom(0,%this.Sprite_AI.Simset_Animations_Run_Up.getCount()-1)
)
.String_Animation
);

}

}
else if (%Float_Angle<=-45&&%Float_Angle>=-135)//Down
{

%Float_Distance=%Float_Distance/%this.Vector_2D_Floor_Size.Y;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(-90,%this.Vector_2D_Floor_Size.Y);

%Vector_2D_Position=Vector2Add(%this.Sprite_AI.Position,%Vector_2D_Position);

if (!%this.Sprite_AI.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

return;

}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=-90;

Float_Magnitude=%this.Vector_2D_Floor_Size.Y;

Char_Direction=1;

};

%this.Sprite_AI.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Sprite_AI.Bool_Moving)
{

%this.Sprite_AI.moveTo(%Vector_2D_Position,%this.Sprite_AI.Int_Current_Speed,true,true);

%this.Sprite_AI.Char_Direction=1;

%this.Sprite_AI.playAnimation
(
%this.Sprite_AI.Simset_Animations_Run_Down.
getObject(
getRandom(0,%this.Sprite_AI.Simset_Animations_Run_Down.getCount()-1)
)
.String_Animation
);

}

}
else if ((%Float_Angle<=-135&&%Float_Angle>=-180)||(%Float_Angle>=135&&%Float_Angle<=180))//Left
{

%Float_Distance=%Float_Distance/%this.Vector_2D_Floor_Size.X;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(180,%this.Vector_2D_Floor_Size.X);

%Vector_2D_Position=Vector2Add(%this.Sprite_AI.Position,%Vector_2D_Position);

if (!%this.Sprite_AI.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

return;

}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=180;

Float_Magnitude=%this.Vector_2D_Floor_Size.X;

Char_Direction=2;

};

%this.Sprite_AI.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Sprite_AI.Bool_Moving)
{

%this.Sprite_AI.moveTo(%Vector_2D_Position,%this.Sprite_AI.Int_Current_Speed,true,true);

%this.Sprite_AI.Char_Direction=2;

%this.Sprite_AI.playAnimation
(
%this.Sprite_AI.Simset_Animations_Run_Left.
getObject(
getRandom(0,%this.Sprite_AI.Simset_Animations_Run_Left.getCount()-1)
)
.String_Animation
);

}

}
else if ((%Float_Angle<=0&&%Float_Angle>=-45)||(%Float_Angle>=0&&%Float_Angle<=45))//Right
{

%Float_Distance=%Float_Distance/%this.Vector_2D_Floor_Size.X;

%Float_Distance=mRound(%Float_Distance);

if (%Float_Distance==0){%Float_Distance=1;}

%Vector_2D_Position=Vector2Direction(0,%this.Vector_2D_Floor_Size.X);

%Vector_2D_Position=Vector2Add(%this.Sprite_AI.Position,%Vector_2D_Position);

if (!%this.Sprite_AI.Bool_Moving)
{

%String_Object_List=Scene_Spooks_VS_Mounts.pickPoint(%Vector_2D_Position,bit(26),"","collision");

if (getWordCount(%String_Object_List))
{

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

return;

}

}

for (%x=0;%x<%Float_Distance;%x++)
{

%ScriptObject_Move_Step=new ScriptObject()
{

Float_Angle=0;

Float_Magnitude=%this.Vector_2D_Floor_Size.X;

Char_Direction=3;

};

%this.Sprite_AI.SimSet_Move_Steps.add(%ScriptObject_Move_Step);

}

if (!%this.Sprite_AI.Bool_Moving)
{

%this.Sprite_AI.moveTo(%Vector_2D_Position,%this.Sprite_AI.Int_Current_Speed,true,true);

%this.Sprite_AI.Char_Direction=3;

%this.Sprite_AI.playAnimation
(
%this.Sprite_AI.Simset_Animations_Run_Right.
getObject(
getRandom(0,%this.Sprite_AI.Simset_Animations_Run_Right.getCount()-1)
)
.String_Animation
);

}

}

%this.Sprite_AI.Bool_Moving=true;

/***************************************************************************************************************/

//Player distance check, then raycast.

//if ai is spook:
//check if player snared, if not snare
//randomly choose wether to throw shurikens or not
//if not then stealth, charge then melee

//if ai is mount:
//if player out of range check if health below 50%
//if so make sure recharge is on, move in a random direction a random amount of tiles and reschedule.
//if at 100% randomly choose wether to drop a mine or not
//randomly choose wether the mine is radiation or not
//if player is in range
//check if health is above 50%
//if so, use rifle
//if not use shield and randomly choose a direction to move a random amount of tiles.

%Float_Player_Distance=Vector2Distance(%this.Sprite_Player.Position,%this.Sprite_AI.Position);

if (%Float_Player_Distance<=%this.Float_Visibility_Ray_Distance)
{

%String_Objects=Scene_Spooks_VS_Mounts.pickRay(%this.Sprite_AI.Position,%this.Sprite_Player.Position,bit(26),"","collision");

if (getWordCount(%String_Objects))//Target obstructed.
{

%this.Sprite_Player.Bool_Spotted=false;

}
else if (!%this.Sprite_Player.Bool_Stealthed)//Target visible.
{

%this.Sprite_Player.Bool_Spotted=true;

}

if (%this.Sprite_AI.class$="Class_Mount")
{

//Shield or Recharge

if (%this.Sprite_AI.Int_Health<50)
{

if (%this.Sprite_Player.Bool_Spotted&&!%this.Sprite_AI.Bool_Shielded)
{

%this.Sprite_AI.Module_ID_Parent.Skill_Shield(%this.Sprite_AI);

}
else if (!%this.Sprite_Player.Bool_Spotted&&!%this.Sprite_AI.Bool_Recharging)
{

%this.Sprite_AI.Module_ID_Parent.Skill_Recharge(%this.Sprite_AI);

}

}
else
{

%this.Sprite_AI.Module_ID_Parent.Skill_Rifle(%this.Sprite_AI);

}

}
else if (%this.Sprite_AI.class$="Class_Spook")
{

if (%this.Sprite_Player.Int_Current_Speed>5&&%this.Sprite_Player.Bool_Spotted)
{

%this.Sprite_AI.Module_ID_Parent.Skill_Bolt(%this.Sprite_AI);

%this.Sprite_AI.Module_ID_Parent.Skill_Stealth(%this.Sprite_AI);

}
else if (%Float_Player_Distance>%this.Sprite_AI.Size.Y*1.5&&%this.Sprite_Player.Bool_Spotted)//Shuriken
{

%this.Sprite_AI.Module_ID_Parent.Skill_Shuriken(%this.Sprite_AI);

%this.Sprite_AI.Module_ID_Parent.Skill_Stealth(%this.Sprite_AI);

}
else if (%Float_Player_Distance<=%this.Sprite_AI.Size.Y*1.5)
{

%this.Sprite_AI.Module_ID_Parent.Skill_Charge(%this.Sprite_AI);

%this.Sprite_AI.Module_ID_Parent.Skill_Melee(%this.Sprite_AI);

%this.Sprite_AI.Module_ID_Parent.Skill_Stealth(%this.Sprite_AI);

}

}

}
else//Out of range.
{

%this.Sprite_Player.Bool_Spotted=false;

if (%this.Sprite_AI.class$="Class_Mount")
{

//Recharge

if (%this.Sprite_AI.Int_Health<50&&!%this.Sprite_AI.Bool_Recharging)
{

%this.Sprite_AI.Module_ID_Parent.Skill_Recharge(%this.Sprite_AI);

}
else if (%this.Sprite_AI.Int_Health==100&&getRandom(0,1))
{

//Mine or Radiation

if (getRandom(0,1))
{

%this.Sprite_AI.Module_ID_Parent.Skill_Mine(%this.Sprite_AI);

}
else
{

%this.Sprite_AI.Module_ID_Parent.Skill_Radiation(%this.Sprite_AI);

}

}

}

}

%this.Schedule_AI=schedule(1000,0,"Module_Gameplay::AI_Process",%this);

}
