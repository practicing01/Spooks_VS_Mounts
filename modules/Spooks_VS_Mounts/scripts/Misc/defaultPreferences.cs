//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

/// Game
$Game::CompanyName              = "MourningDoveSoft";
$Game::ProductName              = "Spooks_VS_Mounts Game";

//hello world settings
$pref::Spooks_VS_Mounts::defaultBackgroundColor = "Black";
$pref::Spooks_VS_Mounts::metricsOption   = false;
$pref::Spooks_VS_Mounts::fpsmetricsOption = true;
$pref::Spooks_VS_Mounts::jointsOption    = false;
$pref::Spooks_VS_Mounts::wireframeOption = false;
$pref::Spooks_VS_Mounts::aabbOption      = false;
$pref::Spooks_VS_Mounts::oobbOption      = false;
$pref::Spooks_VS_Mounts::sleepOption     = false;
$pref::Spooks_VS_Mounts::collisionOption = false;
$pref::Spooks_VS_Mounts::positionOption  = false;
$pref::Spooks_VS_Mounts::sortOption      = false;
$pref::Spooks_VS_Mounts::cameraMouseZoomRate = 0.01;
$pref::Spooks_VS_Mounts::cameraTouchZoomRate = 0.001;

/// iOS
$pref::iOS::ScreenOrientation   = $iOS::constant::Landscape;
$pref::iOS::ScreenDepth		    = 32;
$pref::iOS::UseGameKit          = 0;
$pref::iOS::UseMusic            = 0;
$pref::iOS::UseMoviePlayer      = 0;
$pref::iOS::UseAutoRotate       = 1;
$pref::iOS::EnableOrientationRotation = 1;
$pref::iOS::EnableOtherOrientationRotation = 1;   
$pref::iOS::StatusBarType       = 0;

/// Audio
$pref::Audio::driver = "OpenAL";
$pref::Audio::forceMaxDistanceUpdate = 0;
$pref::Audio::environmentEnabled = 0;
$pref::Audio::masterVolume   = 1.0;
$pref::Audio::channelVolume1 = 1.0;
$pref::Audio::channelVolume2 = 1.0;
$pref::Audio::channelVolume3 = 1.0;
$pref::Audio::sfxVolume = 1.0;
$pref::Audio::musicVolume = 1.0;

/// T2D
$pref::T2D::ParticlePlayerEmissionRateScale = 1.0;
$pref::T2D::ParticlePlayerSizeScale = 1.0;
$pref::T2D::ParticlePlayerForceScale = 1.0;
$pref::T2D::warnFileDeprecated = 1;
$pref::T2D::warnSceneOccupancy = 1;

/// Video
$pref::Video::appliedPref = 0;
$pref::Video::disableVerticalSync = 1;
$pref::Video::displayDevice = "OpenGL";
$pref::Video::preferOpenGL = 1;
$pref::Video::fullScreen = 0;
$pref::Video::defaultResolution = "800 480";
$pref::Video::windowedRes = "800 480 32";
$pref::OpenGL::gammaCorrection = 0.5;

/// Fonts.
$Gui::fontCacheDirectory = expandPath( "^Spooks_VS_Mounts/fonts" );
