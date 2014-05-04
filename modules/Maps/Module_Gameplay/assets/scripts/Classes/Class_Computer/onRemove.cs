function Class_Computer::onRemove(%this)
{

%this.GuiSpriteCtrl_Computer_Progress_Bar.deleteObjects();

%this.GuiSpriteCtrl_Computer_Progress_Bar.delete();

cancel(%this.Schedule_Progress);

}
