namespace SDL_cs;

/// <summary>
/// The collection of hints used across SDL.
/// </summary>
public static class SDL_Hint
{
	/// <summary>
	/// Specify the behavior of Alt+Tab while the keyboard is grabbed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED">documentation</see> for more details.
	/// </remarks>
	public const string AllowAltTabWhileGrabbed = "SDL_ALLOW_ALT_TAB_WHILE_GRABBED";

	/// <summary>
	/// A variable to control whether the SDL activity is allowed to be re-created.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ANDROID_ALLOW_RECREATE_ACTIVITY">documentation</see> for more details.
	/// </remarks>
	public const string AndroidAllowRecreateActivity = "SDL_ANDROID_ALLOW_RECREATE_ACTIVITY";

	/// <summary>
	/// A variable to control whether the event loop will block itself when the app is paused.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ANDROID_BLOCK_ON_PAUSE">documentation</see> for more details.
	/// </remarks>
	public const string AndroidBlockOnPause = "SDL_ANDROID_BLOCK_ON_PAUSE";

	/// <summary>
	/// A variable to control whether SDL will pause audio in background.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO">documentation</see> for more details.
	/// </remarks>
	public const string AndroidBlockOnPausePauseAudio = "SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO";

	/// <summary>
	/// A variable to control whether we trap the Android back button to handle it manually.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ANDROID_TRAP_BACK_BUTTON">documentation</see> for more details.
	/// </remarks>
	public const string AndroidTrapBackButton = "SDL_ANDROID_TRAP_BACK_BUTTON";

	/// <summary>
	/// A variable setting the app ID string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_APP_ID">documentation</see> for more details.
	/// </remarks>
	public const string AppId = "SDL_APP_ID";

	/// <summary>
	/// Specify an application name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_APP_NAME">documentation</see> for more details.
	/// </remarks>
	public const string AppName = "SDL_APP_NAME";

	/// <summary>
	/// A variable controlling whether controllers used with the Apple TV generate UI events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS">documentation</see> for more details.
	/// </remarks>
	public const string AppleTVControllerUIEvents = "SDL_APPLE_TV_CONTROLLER_UI_EVENTS";

	/// <summary>
	/// A variable controlling whether the Apple TV remote's joystick axes will automatically match the rotation of the remote.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION">documentation</see> for more details.
	/// </remarks>
	public const string AppleTVRemoteAllowRotation = "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";

	/// <summary>
	/// A variable controlling the audio category on iOS and macOS.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_CATEGORY">documentation</see> for more details.
	/// </remarks>
	public const string AudioCategory = "SDL_AUDIO_CATEGORY";

	/// <summary>
	/// Specify an application name for an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DEVICE_APP_NAME">documentation</see> for more details.
	/// </remarks>
	public const string AudioDeviceAppName = "SDL_AUDIO_DEVICE_APP_NAME";

	/// <summary>
	/// Specify an application icon name for an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DEVICE_APP_ICON_NAME">documentation</see> for more details.
	/// </remarks>
	public const string AudioDeviceAppIconName = "SDL_AUDIO_DEVICE_APP_ICON_NAME";

	/// <summary>
	/// A variable controlling device buffer size.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DEVICE_SAMPLE_FRAMES">documentation</see> for more details.
	/// </remarks>
	public const string AudioDeviceSampleFrames = "SDL_AUDIO_DEVICE_SAMPLE_FRAMES";

	/// <summary>
	/// Specify an audio stream name for an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DEVICE_STREAM_NAME">documentation</see> for more details.
	/// </remarks>
	public const string AudioDeviceStreamName = "SDL_AUDIO_DEVICE_STREAM_NAME";

	/// <summary>
	/// Specify an application role for an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DEVICE_STREAM_ROLE">documentation</see> for more details.
	/// </remarks>
	public const string AudioDeviceStreamRole = "SDL_AUDIO_DEVICE_STREAM_ROLE";

	/// <summary>
	/// A variable that specifies an audio backend to use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DRIVER">documentation</see> for more details.
	/// </remarks>
	public const string AudioDriver = "SDL_AUDIO_DRIVER";

	/// <summary>
	/// A variable that causes SDL to not ignore audio "monitors".
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_INCLUDE_MONITORS">documentation</see> for more details.
	/// </remarks>
	public const string AudioIncludeMonitors = "SDL_AUDIO_INCLUDE_MONITORS";

	/// <summary>
	/// A variable controlling whether SDL updates joystick state when getting input events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUTO_UPDATE_JOYSTICKS">documentation</see> for more details.
	/// </remarks>
	public const string AutoUpdateJoysticks = "SDL_AUTO_UPDATE_JOYSTICKS";

	/// <summary>
	/// A variable controlling whether SDL updates sensor state when getting input events.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUTO_UPDATE_SENSORS">documentation</see> for more details.
	/// </remarks>
	public const string AutoUpdateSensors = "SDL_AUTO_UPDATE_SENSORS";

	/// <summary>
	/// Prevent SDL from using version 4 of the bitmap header when saving BMPs.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_BMP_SAVE_LEGACY_FORMAT">documentation</see> for more details.
	/// </remarks>
	public const string BmpSaveLegacyFormat = "SDL_BMP_SAVE_LEGACY_FORMAT";

	/// <summary>
	/// A variable that decides what camera backend to use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_CAMERA_DRIVER">documentation</see> for more details.
	/// </remarks>
	public const string CameraDriver = "SDL_CAMERA_DRIVER";

	/// <summary>
	/// A variable that limits what CPU features are available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_CPU_FEATURE_MASK">documentation</see> for more details.
	/// </remarks>
	public const string CpuFeatureMask = "SDL_CPU_FEATURE_MASK";

	/// <summary>
	/// Override for <see cref="SDL.GetDisplayUsableBounds(SDL_DisplayId, out SDL_Rect)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_DISPLAY_USABLE_BOUNDS">documentation</see> for more details.
	/// </remarks>
	public const string DisplayUsableBounds = "SDL_DISPLAY_USABLE_BOUNDS";

	/// <summary>
	/// Disable giving back control to the browser automatically when running with asyncify.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_EMSCRIPTEN_ASYNCIFY">documentation</see> for more details.
	/// </remarks>
	public const string EmscriptenAsyncify = "SDL_EMSCRIPTEN_ASYNCIFY";

	/// <summary>
	/// Specify the CSS selector used for the "default" window/canvas.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_EMSCRIPTEN_CANVAS_SELECTOR">documentation</see> for more details.
	/// </remarks>
	public const string EmscriptenCanvasSelector = "SDL_EMSCRIPTEN_CANVAS_SELECTOR";

	/// <summary>
	/// Override the binding element for keyboard inputs for Emscripten builds.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT">documentation</see> for more details.
	/// </remarks>
	public const string EmscriptenKeyboardElement = "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT";

	/// <summary>
	/// A variable that controls whether the on-screen keyboard should be shown when text input is active.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ENABLE_SCREEN_KEYBOARD">documentation</see> for more details.
	/// </remarks>
	public const string EnableScreenKeyboard = "SDL_ENABLE_SCREEN_KEYBOARD";

	/// <summary>
	/// A variable controlling verbosity of the logging of SDL events pushed onto the internal queue.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_EVENT_LOGGING">documentation</see> for more details.
	/// </remarks>
	public const string EventLogging = "SDL_EVENT_LOGGING";

	/// <summary>
	/// A variable that specifies a dialog backend to use.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_FILE_DIALOG_DRIVER">documentation</see> for more details.
	/// </remarks>
	public const string FileDialogDriver = "SDL_HINT_FILE_DIALOG_DRIVER";

	/// <summary>
	/// A variable controlling whether raising the window should be done more forcefully.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_FORCE_RAISEWINDOW">documentation</see> for more details.
	/// </remarks>
	public const string ForceRaiseWindow = "SDL_FORCE_RAISEWINDOW";

	/// <summary>
	/// A variable controlling how 3D acceleration is used to accelerate the SDL screen surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_FRAMEBUFFER_ACCELERATION">documentation</see> for more details.
	/// </remarks>
	public const string FramebufferAcceleration = "SDL_FRAMEBUFFER_ACCELERATION";

	/// <summary>
	/// A variable containing a list of devices to skip when scanning for game controllers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES">documentation</see> for more details.
	/// </remarks>
	public const string GameControllerIgnoreDevices = "SDL_GAMECONTROLLER_IGNORE_DEVICES";

	/// <summary>
	/// If set, all devices will be skipped when scanning for game controllers except for the ones listed in this variable.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT">documentation</see> for more details.
	/// </remarks>
	public const string GameControllerIgnoreDevicesExcept = "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT";

	/// <summary>
	/// A variable that controls whether the device's built-in accelerometer and gyro should be used as sensors for gamepads.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLER_SENSOR_FUSION">documentation</see> for more details.
	/// </remarks>
	public const string GameControllerSensorFusion = "SDL_GAMECONTROLLER_SENSOR_FUSION";

	/// <summary>
	/// A variable that lets you manually hint extra gamecontroller db entries.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLERCONFIG">documentation</see> for more details.
	/// </remarks>
	public const string GameControllerConfig = "SDL_GAMECONTROLLERCONFIG";

	/// <summary>
	/// A variable that lets you provide a file with extra gamecontroller db entries.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLERCONFIG_FILE">documentation</see> for more details.
	/// </remarks>
	public const string GameControllerConfigFile = "SDL_GAMECONTROLLERCONFIG_FILE";

	/// <summary>
	/// This variable sets the default text of the TextInput window on GDK platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GDK_TEXTINPUT_DEFAULT_TEXT">documentation</see> for more details.
	/// </remarks>
	public const string GdkTextInputDefaultText = "SDL_GDK_TEXTINPUT_DEFAULT_TEXT";

	/// <summary>
	/// This variable sets the description of the TextInput window on GDK platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GDK_TEXTINPUT_DESCRIPTION">documentation</see> for more details.
	/// </remarks>
	public const string GdkTextInputDescription = "SDL_GDK_TEXTINPUT_DESCRIPTION";

	/// <summary>
	/// This variable sets the maximum input length of the TextInput window on GDK platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GDK_TEXTINPUT_MAX_LENGTH">documentation</see> for more details.
	/// </remarks>
	public const string GdkTextInputMaxLength = "SDL_GDK_TEXTINPUT_MAX_LENGTH";

	/// <summary>
	/// This variable sets the input scope of the TextInput window on GDK platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GDK_TEXTINPUT_SCOPE">documentation</see> for more details.
	/// </remarks>
	public const string GdkTextInputScope = "SDL_GDK_TEXTINPUT_SCOPE";

	/// <summary>
	/// This variable sets the title of the TextInput window on GDK platforms.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GDK_TEXTINPUT_TITLE">documentation</see> for more details.
	/// </remarks>
	public const string GdkTextInputTitle = "SDL_GDK_TEXTINPUT_TITLE";

	/// <summary>
	/// A variable to control whether <see cref="FIXME:SDL_hid_enumerate()"/> enumerates all HID devices or only controllers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_ENUMERATE_ONLY_CONTROLLERS">documentation</see> for more details.
	/// </remarks>
	public const string HidApiEnumerateOnlyControllers = "SDL_HIDAPI_ENUMERATE_ONLY_CONTROLLERS";

	/// <summary>
	/// A variable containing a list of devices to ignore in <see cref="FIXME:SDL_hid_enumerate()"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_IGNORE_DEVICES">documentation</see> for more details.
	/// </remarks>
	public const string HidApiIgnoreDevices = "SDL_HIDAPI_IGNORE_DEVICES";

	/// <summary>
	/// A variable describing what IME UI elements the application can display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_IME_IMPLEMENTED_UI">documentation</see> for more details.
	/// </remarks>
	public const string ImeImplementedUI = "SDL_IME_IMPLEMENTED_UI";

	/// <summary>
	/// A variable controlling whether the home indicator bar on iPhone X should be hidden.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_IOS_HIDE_HOME_INDICATOR">documentation</see> for more details.
	/// </remarks>
	public const string IOSHideHomeIndicator = "SDL_IOS_HIDE_HOME_INDICATOR";

	/// <summary>
	/// A variable controlling whether DirectInput should be used for controllers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_DIRECTINPUT">documentation</see> for more details.
	/// </remarks>
	public const string JoystickDirectInput = "SDL_JOYSTICK_DIRECTINPUT";
}