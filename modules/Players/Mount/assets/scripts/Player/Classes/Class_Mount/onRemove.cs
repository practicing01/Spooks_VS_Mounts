function Class_Mount::onRemove(%this)
{

%this.SimSet_Move_Steps.deleteObjects();

%this.SimSet_Move_Steps.delete();

%this.Simset_Animations_Stand_Up.deleteObjects();

%this.Simset_Animations_Stand_Up.delete();

%this.Simset_Animations_Stand_Down.deleteObjects();

%this.Simset_Animations_Stand_Down.delete();

%this.Simset_Animations_Stand_Left.deleteObjects();

%this.Simset_Animations_Stand_Left.delete();

%this.Simset_Animations_Stand_Right.deleteObjects();

%this.Simset_Animations_Stand_Right.delete();

%this.Simset_Animations_Run_Up.deleteObjects();

%this.Simset_Animations_Run_Up.delete();

%this.Simset_Animations_Run_Down.deleteObjects();

%this.Simset_Animations_Run_Down.delete();

%this.Simset_Animations_Run_Left.deleteObjects();

%this.Simset_Animations_Run_Left.delete();

%this.Simset_Animations_Run_Right.deleteObjects();

%this.Simset_Animations_Run_Right.delete();

}
