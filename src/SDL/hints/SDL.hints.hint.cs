namespace SDL3;

public static unsafe partial class SDL
{
	public static partial class Hint
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
		/// A variable controlling response to <see cref="FIXME:SDL_assert"/> failures.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ASSERT">documentation</see> for more details.
		/// </remarks>
		public const string Assert = "SDL_ASSERT";

		/// <summary>
		/// Specify the default ALSA audio device name.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_ALSA_DEFAULT_DEVICE">documentation</see> for more details.
		/// </remarks>
		public const string AudioAlsaDefaultDevice = "SDL_AUDIO_ALSA_DEFAULT_DEVICE";

		/// <summary>
		/// A variable controlling the audio category on iOS and macOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_CATEGORY">documentation</see> for more details.
		/// </remarks>
		public const string AudioCategory = "SDL_AUDIO_CATEGORY";

		/// <summary>
		/// A variable controlling the default audio channel count.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_CHANNELS">documentation</see> for more details.
		/// </remarks>
		public const string AudioChannels = "SDL_AUDIO_CHANNELS";

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
		/// Specify the input file when recording audio using the disk audio driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DISK_INPUT_FILE">documentation</see> for more details.
		/// </remarks>
		public const string AudioDiskInputFile = "SDL_AUDIO_DISK_INPUT_FILE";

		/// <summary>
		/// Specify the output file when playing audio using the disk audio driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DISK_OUTPUT_FILE">documentation</see> for more details.
		/// </remarks>
		public const string AudioDiskOutputFile = "SDL_AUDIO_DISK_OUTPUT_FILE";

		/// <summary>
		/// A variable controlling the audio rate when using the disk audio driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DISK_TIMESCALE">documentation</see> for more details.
		/// </remarks>
		public const string AudioDiskTimescale = "SDL_AUDIO_DISK_TIMESCALE";

		/// <summary>
		/// A variable that specifies an audio backend to use.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string AudioDriver = "SDL_AUDIO_DRIVER";

		/// <summary>
		/// A variable controlling the audio rate when using the dummy audio driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_DUMMY_TIMESCALE">documentation</see> for more details.
		/// </remarks>
		public const string AudioDummyTimescale = "SDL_AUDIO_DUMMY_TIMESCALE";

		/// <summary>
		/// A variable controlling the default audio format.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_FORMAT">documentation</see> for more details.
		/// </remarks>
		public const string AudioFormat = "SDL_AUDIO_FORMAT";

		/// <summary>
		/// A variable controlling the default audio frequency.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_AUDIO_FREQUENCY">documentation</see> for more details.
		/// </remarks>
		public const string AudioFrequency = "SDL_AUDIO_FREQUENCY";

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
		/// Override for <see cref="GetDisplayUsableBounds(SDL_DisplayId, SDL_Rect*)"/>.
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
		/// A variable containing a list of evdev devices to use if udev is not available.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_EVDEV_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string EvdevDevices = "SDL_EVDEV_DEVICES";

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
		public const string GamecontrollerIgnoreDevices = "SDL_GAMECONTROLLER_IGNORE_DEVICES";

		/// <summary>
		/// If set, all devices will be skipped when scanning for game controllers except for the ones listed in this variable.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT">documentation</see> for more details.
		/// </remarks>
		public const string GamecontrollerIgnoreDevicesExcept = "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT";

		/// <summary>
		/// A variable that controls whether the device's built-in accelerometer and gyro should be used as sensors for gamepads.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLER_SENSOR_FUSION">documentation</see> for more details.
		/// </remarks>
		public const string GamecontrollerSensorFusion = "SDL_GAMECONTROLLER_SENSOR_FUSION";

		/// <summary>
		/// A variable that lets you manually hint extra gamecontroller db entries.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLERCONFIG">documentation</see> for more details.
		/// </remarks>
		public const string GamecontrollerConfig = "SDL_GAMECONTROLLERCONFIG";

		/// <summary>
		/// A variable that lets you provide a file with extra gamecontroller db entries.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_GAMECONTROLLERCONFIG_FILE">documentation</see> for more details.
		/// </remarks>
		public const string GamecontrollerConfigFile = "SDL_GAMECONTROLLERCONFIG_FILE";

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
		/// A variable to control whether <see cref="HidEnumerate(ushort, ushort)"/> enumerates all HID devices or only controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_ENUMERATE_ONLY_CONTROLLERS">documentation</see> for more details.
		/// </remarks>
		public const string HidapiEnumerateOnlyControllers = "SDL_HIDAPI_ENUMERATE_ONLY_CONTROLLERS";

		/// <summary>
		/// A variable containing a list of devices to ignore in <see cref="HidEnumerate(ushort, ushort)"/>.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_IGNORE_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string HidapiIgnoreDevices = "SDL_HIDAPI_IGNORE_DEVICES";

		/// <summary>
		/// A variable to control whether HIDAPI uses libusb for device access.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_LIBUSB">documentation</see> for more details.
		/// </remarks>
		public const string HidapiLibusb = "SDL_HIDAPI_LIBUSB";

		/// <summary>
		/// A variable to control whether HIDAPI uses libusb only for whitelisted devices.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_LIBUSB_WHITELIST">documentation</see> for more details.
		/// </remarks>
		public const string HidapiLibusbWhitelist = "SDL_HIDAPI_LIBUSB_WHITELIST";

		/// <summary>
		/// A variable to control whether HIDAPI uses udev for device detection.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_HIDAPI_UDEV">documentation</see> for more details.
		/// </remarks>
		public const string HidapiUdev = "SDL_HIDAPI_UDEV";

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
		/// A variable that lets you enable joystick (and gamecontroller) events even when your app is in the background.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickAllowBackgroundEvents = "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS";

		/// <summary>
		/// A variable containing a list of arcade stick style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickArcadestickDevices = "SDL_JOYSTICK_ARCADESTICK_DEVICES";

		/// <summary>
		/// A variable containing a list of devices that are not arcade stick style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickArcadestickDevicesExcluded = "SDL_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable containing a list of devices that should not be considered joysticks.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_BLACKLIST_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickBlacklistDevices = "SDL_JOYSTICK_BLACKLIST_DEVICES";

		/// <summary>
		/// A variable containing a list of devices that should be considered joysticks.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickBlacklistDevicesExcluded = "SDL_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable containing a comma separated list of devices to open as joysticks.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_DEVICE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickDevice = "SDL_JOYSTICK_DEVICE";

		/// <summary>
		/// A variable controlling whether DirectInput should be used for controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_DIRECTINPUT">documentation</see> for more details.
		/// </remarks>
		public const string JoystickDirectInput = "SDL_JOYSTICK_DIRECTINPUT";

		/// <summary>
		/// A variable containing a list of flightstick style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickFlightstickDevices = "SDL_JOYSTICK_FLIGHTSTICK_DEVICES";

		/// <summary>
		/// A variable containing a list of devices that are not flightstick style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickFlightstickDevicesExcluded = "SDL_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable controlling whether GameInput should be used for controller handling on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_GAMEINPUT">documentation</see> for more details.
		/// </remarks>
		public const string JoystickGameInput = "SDL_JOYSTICK_GAMEINPUT";

		/// <summary>
		/// A variable containing a list of devices known to have a GameCube form factor.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_GAMECUBE_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickGamecubeDevices = "SDL_JOYSTICK_GAMECUBE_DEVICES";

		/// <summary>
		/// A variable containing a list of devices known not to have a GameCube form factor.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickGamecubeDevicesExcluded = "SDL_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable controlling whether the HIDAPI joystick drivers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapi = "SDL_JOYSTICK_HIDAPI";

		/// <summary>
		/// A variable controlling whether Nintendo Switch Joy-Con controllers will be combined into a single Pro-like controller
		/// when using the HIDAPI driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiCombineJoyCons = "SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Nintendo GameCube controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiGamecube = "SDL_JOYSTICK_HIDAPI_GAMECUBE";

		/// <summary>
		/// A variable controlling whether rumble is used to implement the GameCube controller's 3 rumble modes, Stop(0), Rumble(1),
		/// and StopHard(2).
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiGamecubeRumbleBrake = "SDL_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Nintendo Switch Joy-Cons should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiJoyCons = "SDL_JOYSTICK_HIDAPI_JOY_CONS";

		/// <summary>
		/// A variable controlling whether the Home button LED should be turned on when a Nintendo Switch Joy-Con controller is opened.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiJoyConHomeLed = "SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Amazon Luna controllers connected via Bluetooth should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_LUNA">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiLuna = "SDL_JOYSTICK_HIDAPI_LUNA";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Nintendo Online classic controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiNintendoClassic = "SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for PS3 controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS3">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS3 = "SDL_JOYSTICK_HIDAPI_PS3";

		/// <summary>
		/// A variable controlling whether the Sony driver (sixaxis.sys) for PS3 controllers (Sixaxis/DualShock 3) should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS3SixaxisDriver = "SDL_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for PS4 controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS4">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS4 = "SDL_JOYSTICK_HIDAPI_PS4";

		/// <summary>
		/// A variable controlling the update rate of the PS4 controller over Bluetooth when using the HIDAPI driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS4_REPORT_INTERVAL">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS4ReportInterval = "SDL_JOYSTICK_HIDAPI_PS4_REPORT_INTERVAL";

		/// <summary>
		/// A variable controlling whether extended input reports should be used for PS4 controllers when using the HIDAPI driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS4Rumble = "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for PS5 controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS5">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS5 = "SDL_JOYSTICK_HIDAPI_PS5";

		/// <summary>
		/// A variable controlling whether the player LEDs should be lit to indicate which player is associated with a PS5 controller.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS5PlayerLed = "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED";

		/// <summary>
		/// A variable controlling whether extended input reports should be used for PS5 controllers when using the HIDAPI driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiPS5Rumble = "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for NVIDIA SHIELD controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_SHIELD">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiShield = "SDL_JOYSTICK_HIDAPI_SHIELD";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Google Stadia controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_STADIA">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiStadia = "SDL_JOYSTICK_HIDAPI_STADIA";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Bluetooth Steam Controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_STEAM">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiSteam = "SDL_JOYSTICK_HIDAPI_STEAM";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for the Steam Deck builtin controller should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_STEAMDECK">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiSteamdeck = "SDL_JOYSTICK_HIDAPI_STEAMDECK";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Nintendo Switch controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_SWITCH">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiSwitch = "SDL_JOYSTICK_HIDAPI_SWITCH";

		/// <summary>
		/// A variable controlling whether the Home button LED should be turned on when a Nintendo Switch Pro controller is opened.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiSwitchHomeLed = "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED";

		/// <summary>
		/// A variable controlling whether the player LEDs should be lit to indicate which player is associated with a
		/// Nintendo Switch controller.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiSwitchPlayerLed = "SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED";

		/// <summary>
		/// A variable controlling whether Nintendo Switch Joy-Con controllers will be in vertical mode when using the HIDAPI driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiVerticalJoyCons = "SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for Nintendo Wii and Wii U controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_WII">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiWii = "SDL_JOYSTICK_HIDAPI_WII";

		/// <summary>
		/// A variable controlling whether the player LEDs should be lit to indicate which player is associated with a Wii controller.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiWiiPlayerLed = "SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for XBox controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXbox = "SDL_JOYSTICK_HIDAPI_XBOX";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for XBox 360 controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX_360">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXbox360 = "SDL_JOYSTICK_HIDAPI_XBOX_360";

		/// <summary>
		/// A variable controlling whether the player LEDs should be lit to indicate which player is associated with an Xbox 360 controller.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXbox360PlayerLed = "SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for XBox 360 wireless controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXbox360Wireless = "SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS";

		/// <summary>
		/// A variable controlling whether the HIDAPI driver for XBox One controllers should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXboxOne = "SDL_JOYSTICK_HIDAPI_XBOX_ONE";

		/// <summary>
		/// A variable controlling whether the Home button LED should be turned on when an Xbox One controller is opened.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickHidapiXboxOneHomeLed = "SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED";

		/// <summary>
		/// A variable controlling whether IOKit should be used for controller handling.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_IOKIT">documentation</see> for more details.
		/// </remarks>
		public const string JoystickIOKit = "SDL_JOYSTICK_IOKIT";

		/// <summary>
		/// A variable controlling whether to use the classic /dev/input/js* joystick interface or the newer /dev/input/event*
		/// joystick interface on Linux.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_LINUX_CLASSIC">documentation</see> for more details.
		/// </remarks>
		public const string JoystickLinuxClassic = "SDL_JOYSTICK_LINUX_CLASSIC";

		/// <summary>
		/// A variable controlling whether joysticks on Linux adhere to their HID-defined deadzones or return unfiltered values.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_LINUX_DEADZONES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickLinuxDeadzones = "SDL_JOYSTICK_LINUX_DEADZONES";

		/// <summary>
		/// A variable controlling whether joysticks on Linux will always treat 'hat' axis inputs (ABS_HAT0X - ABS_HAT3Y) as 8-way digital
		/// hats without checking whether they may be analog.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_LINUX_DIGITAL_HATS">documentation</see> for more details.
		/// </remarks>
		public const string JoystickLinuxDigitalHats = "SDL_JOYSTICK_LINUX_DIGITAL_HATS";

		/// <summary>
		/// A variable controlling whether digital hats on Linux will apply deadzones to their underlying input axes or use unfiltered values.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_LINUX_HAT_DEADZONES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickLinuxHatDeadzones = "SDL_JOYSTICK_LINUX_HAT_DEADZONES";

		/// <summary>
		/// A variable controlling whether GCController should be used for controller handling.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_MFI">documentation</see> for more details.
		/// </remarks>
		public const string JoystickMfi = "SDL_JOYSTICK_MFI";

		/// <summary>
		/// A variable controlling whether the RAWINPUT joystick drivers should be used for better handling XInput-capable devices.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_RAWINPUT">documentation</see> for more details.
		/// </remarks>
		public const string JoystickRawinput = "SDL_JOYSTICK_RAWINPUT";

		/// <summary>
		/// A variable controlling whether the RAWINPUT driver should pull correlated data from XInput.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT">documentation</see> for more details.
		/// </remarks>
		public const string JoystickRawinputCorrelateXInput = "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT";

		/// <summary>
		/// A variable controlling whether the ROG Chakram mice should show up as joysticks.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_ROG_CHAKRAM">documentation</see> for more details.
		/// </remarks>
		public const string JoystickRogChakram = "SDL_JOYSTICK_ROG_CHAKRAM";

		/// <summary>
		/// A variable controlling whether a separate thread should be used for handling joystick detection and raw input messages on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_THREAD">documentation</see> for more details.
		/// </remarks>
		public const string JoystickThread = "SDL_JOYSTICK_THREAD";

		/// <summary>
		/// A variable containing a list of throttle style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_THROTTLE_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickThrottleDevices = "SDL_JOYSTICK_THROTTLE_DEVICES";

		/// <summary>
		/// A variable containing a list of devices that are not throttle style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_THROTTLE_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickThrottleDevicesExcluded = "SDL_JOYSTICK_THROTTLE_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable controlling whether Windows.Gaming.Input should be used for controller handling.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_WGI">documentation</see> for more details.
		/// </remarks>
		public const string JoystickWgi = "SDL_JOYSTICK_WGI";

		/// <summary>
		/// A variable containing a list of wheel style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_WHEEL_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickWheelDevices = "SDL_JOYSTICK_WHEEL_DEVICES";

		/// <summary>
		/// A variable containing a list of devices that are not wheel style controllers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_WHEEL_DEVICES_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string JoystickWheelDevicesExcluded = "SDL_JOYSTICK_WHEEL_DEVICES_EXCLUDED";

		/// <summary>
		/// A variable containing a list of devices known to have all axes centered at zero.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_JOYSTICK_ZERO_CENTERED_DEVICES">documentation</see> for more details.
		/// </remarks>
		public const string JoystickZeroCenteredDevices = "SDL_JOYSTICK_ZERO_CENTERED_DEVICES";

		/// <summary>
		/// A variable that controls keycode representation in keyboard events.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_KEYCODE_OPTIONS">documentation</see> for more details.
		/// </remarks>
		public const string KeycodeOptions = "SDL_KEYCODE_OPTIONS";

		/// <summary>
		/// A variable that controls what KMSDRM device to use.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_KMSDRM_DEVICE_INDEX">documentation</see> for more details.
		/// </remarks>
		public const string KmsdrmDeviceIndex = "SDL_KMSDRM_DEVICE_INDEX";

		/// <summary>
		/// A variable that controls whether SDL requires DRM master access in order to initialize the KMSDRM video backend.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER">documentation</see> for more details.
		/// </remarks>
		public const string KmsdrmRequireDrmMaster = "SDL_KMSDRM_REQUIRE_DRM_MASTER";

		/// <summary>
		/// A variable controlling the default SDL log levels.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_LOGGING">documentation</see> for more details.
		/// </remarks>
		public const string Logging = "SDL_LOGGING";

		/// <summary>
		/// A variable controlling whether to force the application to become the foreground process when launched on macOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MAC_BACKGROUND_APP">documentation</see> for more details.
		/// </remarks>
		public const string MacBackgroundApp = "SDL_MAC_BACKGROUND_APP";

		/// <summary>
		/// A variable that determines whether Ctrl+Click should generate a right-click event on macOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK">documentation</see> for more details.
		/// </remarks>
		public const string MacCtrlClickEmulateRightClick = "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK";

		/// <summary>
		/// A variable controlling whether dispatching OpenGL context updates should block the dispatching thread until
		/// the main thread finishes processing on macOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH">documentation</see> for more details.
		/// </remarks>
		public const string MacOpenGLAsyncDispatch = "SDL_MAC_OPENGL_ASYNC_DISPATCH";

		/// <summary>
		/// Request <see cref="FIXME:SDL_AppIterate()"/> be called at a specific rate.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MAIN_CALLBACK_RATE">documentation</see> for more details.
		/// </remarks>
		public const string MainCallbackRate = "SDL_MAIN_CALLBACK_RATE";

		/// <summary>
		/// A variable controlling whether the mouse is captured while mouse buttons are pressed.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_AUTO_CAPTURE">documentation</see> for more details.
		/// </remarks>
		public const string MouseAutoCapture = "SDL_MOUSE_AUTO_CAPTURE";

		/// <summary>
		/// A variable setting the double click radius, in pixels.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS">documentation</see> for more details.
		/// </remarks>
		public const string MouseDoubleClickRadius = "SDL_MOUSE_DOUBLE_CLICK_RADIUS";

		/// <summary>
		/// A variable setting the double click time, in milliseconds.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_DOUBLE_CLICK_TIME">documentation</see> for more details.
		/// </remarks>
		public const string MouseDoubleClickTime = "SDL_MOUSE_DOUBLE_CLICK_TIME";

		/// <summary>
		/// A variable controlling whether warping a hidden mouse cursor will activate relative mouse mode.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_EMULATE_WARP_WITH_RELATIVE">documentation</see> for more details.
		/// </remarks>
		public const string MouseEmulateWarpWithRelative = "SDL_MOUSE_EMULATE_WARP_WITH_RELATIVE";

		/// <summary>
		/// Allow mouse click events when clicking to focus an SDL window.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH">documentation</see> for more details.
		/// </remarks>
		public const string MouseFocusClickthrough = "SDL_MOUSE_FOCUS_CLICKTHROUGH";

		/// <summary>
		/// A variable setting the speed scale for mouse motion, in floating point, when the mouse is not in relative mode.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_NORMAL_SPEED_SCALE">documentation</see> for more details.
		/// </remarks>
		public const string MouseNormalSpeedScale = "SDL_MOUSE_NORMAL_SPEED_SCALE";

		/// <summary>
		/// Controls how often SDL issues cursor confinement commands to the operating system while relative mode is active, in case
		/// the desired confinement state became out-of-sync due to interference from other running programs.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_CLIP_INTERVAL">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeClipInterval = "SDL_MOUSE_RELATIVE_CLIP_INTERVAL";

		/// <summary>
		/// A variable controlling whether the hardware cursor stays visible when relative mode is active.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_CURSOR_VISIBLE">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeCursorVisible = "SDL_MOUSE_RELATIVE_CURSOR_VISIBLE";

		/// <summary>
		/// A variable controlling whether relative mouse mode constrains the mouse to the center of the window.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_MODE_CENTER">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeModeCenter = "SDL_MOUSE_RELATIVE_MODE_CENTER";

		/// <summary>
		/// A variable controlling whether relative mouse mode is implemented using mouse warping.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_MODE_WARP">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeModeWarp = "SDL_MOUSE_RELATIVE_MODE_WARP";

		/// <summary>
		/// A variable setting the scale for mouse motion, in floating point, when the mouse is in relative mode.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeSpeedScale = "SDL_MOUSE_RELATIVE_SPEED_SCALE";

		/// <summary>
		/// A variable controlling whether the system mouse acceleration curve is used for relative mouse motion.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeSystemScale = "SDL_MOUSE_RELATIVE_SYSTEM_SCALE";

		/// <summary>
		/// A variable controlling whether a motion event should be generated for mouse warping in relative mode.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_RELATIVE_WARP_MOTION">documentation</see> for more details.
		/// </remarks>
		public const string MouseRelativeWarpMotion = "SDL_MOUSE_RELATIVE_WARP_MOTION";

		/// <summary>
		/// A variable controlling whether mouse events should generate synthetic touch events.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MOUSE_TOUCH_EVENTS">documentation</see> for more details.
		/// </remarks>
		public const string MouseTouchEvents = "SDL_MOUSE_TOUCH_EVENTS";

		/// <summary>
		/// A variable controlling whether the keyboard should be muted on the console.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_MUTE_CONSOLE_KEYBOARD">documentation</see> for more details.
		/// </remarks>
		public const string MuteConsoleKeyboard = "SDL_MUTE_CONSOLE_KEYBOARD";

		/// <summary>
		/// Tell SDL not to catch the SIGINT or SIGTERM signals on POSIX platforms.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_NO_SIGNAL_HANDLERS">documentation</see> for more details.
		/// </remarks>
		public const string NoSignalHandlers = "SDL_NO_SIGNAL_HANDLERS";

		/// <summary>
		/// A variable controlling what driver to use for OpenGL ES contexts.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_OPENGL_ES_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string OpenGLEsDriver = "SDL_OPENGL_ES_DRIVER";

		/// <summary>
		/// Specify the OpenGL library to load.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_OPENGL_LIBRARY">documentation</see> for more details.
		/// </remarks>
		public const string OpenGLLibrary = "SDL_OPENGL_LIBRARY";

		/// <summary>
		/// A variable controlling which orientations are allowed on iOS/Android.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ORIENTATIONS">documentation</see> for more details.
		/// </remarks>
		public const string Orientations = "SDL_ORIENTATIONS";

		/// <summary>
		/// A variable controlling the use of a sentinel event when polling the event queue.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_POLL_SENTINEL">documentation</see> for more details.
		/// </remarks>
		public const string PollSentinel = "SDL_POLL_SENTINEL";

		/// <summary>
		/// Override for <see cref="FIXME:SDL_GetPreferredLocales()"/>.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_PREFERRED_LOCALES">documentation</see> for more details.
		/// </remarks>
		public const string PreferredLocales = "SDL_PREFERRED_LOCALES";

		/// <summary>
		/// A variable that decides whether to send <see cref="SDL_EventType.Quit"/> when closing the last window.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE">documentation</see> for more details.
		/// </remarks>
		public const string QuitOnLastWindowClose = "SDL_QUIT_ON_LAST_WINDOW_CLOSE";

		/// <summary>
		/// A variable controlling whether to enable Direct3D 11+'s Debug Layer.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_DIRECT3D11_DEBUG">documentation</see> for more details.
		/// </remarks>
		public const string RenderDirect3D11Debug = "SDL_RENDER_DIRECT3D11_DEBUG";

		/// <summary>
		/// A variable controlling whether the Direct3D device is initialized for thread-safe operations.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_DIRECT3D_THREADSAFE">documentation</see> for more details.
		/// </remarks>
		public const string RenderDirect3DThreadsafe = "SDL_RENDER_DIRECT3D_THREADSAFE";

		/// <summary>
		/// A variable specifying which render driver to use.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string RenderDriver = "SDL_RENDER_DRIVER";

		/// <summary>
		/// A variable controlling how the 2D render API renders lines.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_LINE_METHOD">documentation</see> for more details.
		/// </remarks>
		public const string RenderLineMethod = "SDL_RENDER_LINE_METHOD";

		/// <summary>
		/// A variable controlling whether the Metal render driver select low power device over default one.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_METAL_PREFER_LOW_POWER_DEVICE">documentation</see> for more details.
		/// </remarks>
		public const string RenderMetalPreferLowPowerDevice = "SDL_RENDER_METAL_PREFER_LOW_POWER_DEVICE";

		/// <summary>
		/// A variable controlling whether updates to the SDL screen surface should be synchronized with the vertical
		/// refresh, to avoid tearing.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_VSYNC">documentation</see> for more details.
		/// </remarks>
		public const string RenderVSync = "SDL_RENDER_VSYNC";

		/// <summary>
		/// A variable controlling whether to enable Vulkan Validation Layers.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RENDER_VULKAN_DEBUG">documentation</see> for more details.
		/// </remarks>
		public const string RenderVulkanDebug = "SDL_RENDER_VULKAN_DEBUG";

		/// <summary>
		/// A variable to control whether the return key on the soft keyboard should hide the soft keyboard on Android and iOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RETURN_KEY_HIDES_IME">documentation</see> for more details.
		/// </remarks>
		public const string ReturnKeyHidesIme = "SDL_RETURN_KEY_HIDES_IME";

		/// <summary>
		/// A variable containing a list of ROG gamepad capable mice.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ROG_GAMEPAD_MICE">documentation</see> for more details.
		/// </remarks>
		public const string RogGamepadMice = "SDL_ROG_GAMEPAD_MICE";

		/// <summary>
		/// A variable containing a list of devices that are not ROG gamepad capable mice.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_ROG_GAMEPAD_MICE_EXCLUDED">documentation</see> for more details.
		/// </remarks>
		public const string RogGamepadMiceExcluded = "SDL_ROG_GAMEPAD_MICE_EXCLUDED";

		/// <summary>
		/// A variable controlling which Dispmanx layer to use on a Raspberry PI.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_RPI_VIDEO_LAYER">documentation</see> for more details.
		/// </remarks>
		public const string RpiVideoLayer = "SDL_RPI_VIDEO_LAYER";

		/// <summary>
		/// Specify an "activity name" for screensaver inhibition.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME">documentation</see> for more details.
		/// </remarks>
		public const string ScreensaverInhibitActivityName = "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME";

		/// <summary>
		/// A variable controlling whether SDL calls <c>dbus_shutdown()</c> on quit.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_SHUTDOWN_DBUS_ON_QUIT">documentation</see> for more details.
		/// </remarks>
		public const string ShutdownDbusOnQuit = "SDL_SHUTDOWN_DBUS_ON_QUIT";

		/// <summary>
		/// A variable that specifies a backend to use for title storage.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_STORAGE_TITLE_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string StorageTitleDriver = "SDL_STORAGE_TITLE_DRIVER";

		/// <summary>
		/// A variable that specifies a backend to use for user storage.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_STORAGE_USER_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string StorageUserDriver = "SDL_STORAGE_USER_DRIVER";

		/// <summary>
		/// Specifies whether <see cref="FIXME:SDL_THREAD_PRIORITY_TIME_CRITICAL"/> should be treated as realtime.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL">documentation</see> for more details.
		/// </remarks>
		public const string ThreadForceRealtimeTimeCritical = "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL";

		/// <summary>
		/// A string specifying additional information to use with <see cref="FIXME:SDL_SetThreadPriority"/>.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_THREAD_PRIORITY_POLICY">documentation</see> for more details.
		/// </remarks>
		public const string ThreadPriorityPolicy = "SDL_THREAD_PRIORITY_POLICY";

		/// <summary>
		/// A variable that controls the timer resolution, in milliseconds.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_TIMER_RESOLUTION">documentation</see> for more details.
		/// </remarks>
		public const string TimerResolution = "SDL_TIMER_RESOLUTION";

		/// <summary>
		/// A variable controlling whether touch events should generate synthetic mouse events.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_TOUCH_MOUSE_EVENTS">documentation</see> for more details.
		/// </remarks>
		public const string TouchMouseEvents = "SDL_TOUCH_MOUSE_EVENTS";

		/// <summary>
		/// A variable controlling whether trackpads should be treated as touch devices.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_TRACKPAD_IS_TOUCH_ONLY">documentation</see> for more details.
		/// </remarks>
		public const string TrackpadIsTouchOnly = "SDL_TRACKPAD_IS_TOUCH_ONLY";

		/// <summary>
		/// A variable controlling whether the Android/tvOS remotes should be listed as joystick devices, instead of
		/// sending keyboard events.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_TV_REMOTE_AS_JOYSTICK">documentation</see> for more details.
		/// </remarks>
		public const string TVRemoteAsJoystick = "SDL_TV_REMOTE_AS_JOYSTICK";

		/// <summary>
		/// A variable controlling whether the screensaver is enabled.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_ALLOW_SCREENSAVER">documentation</see> for more details.
		/// </remarks>
		public const string VideoAllowScreensaver = "SDL_VIDEO_ALLOW_SCREENSAVER";

		/// <summary>
		/// Tell the video driver that we only want a double buffer.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_DOUBLE_BUFFER">documentation</see> for more details.
		/// </remarks>
		public const string VideoDoubleBuffer = "SDL_VIDEO_DOUBLE_BUFFER";

		/// <summary>
		/// A variable that specifies a video backend to use.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_DRIVER">documentation</see> for more details.
		/// </remarks>
		public const string VideoDriver = "SDL_VIDEO_DRIVER";

		/// <summary>
		/// A variable controlling whether the dummy video driver saves output frames.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_DUMMY_SAVE_FRAMES">documentation</see> for more details.
		/// </remarks>
		public const string VideoDummySaveFrames = "SDL_VIDEO_DUMMY_SAVE_FRAMES";

		/// <summary>
		/// If eglGetPlatformDisplay fails, fall back to calling <c>eglGetDisplay</c>.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_EGL_ALLOW_GETDISPLAY_FALLBACK">documentation</see> for more details.
		/// </remarks>
		public const string VideoEGLAllowGetDisplayFallback = "SDL_VIDEO_EGL_ALLOW_GETDISPLAY_FALLBACK";

		/// <summary>
		/// A variable controlling whether the OpenGL context should be created with EGL.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_FORCE_EGL">documentation</see> for more details.
		/// </remarks>
		public const string VideoForceEGL = "SDL_VIDEO_FORCE_EGL";

		/// <summary>
		/// A variable that specifies the policy for fullscreen Spaces on macOS.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES">documentation</see> for more details.
		/// </remarks>
		public const string VideoMacFullscreenSpaces = "SDL_VIDEO_MAC_FULLSCREEN_SPACES";

		/// <summary>
		/// A variable controlling whether fullscreen windows are minimized when they lose focus.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS">documentation</see> for more details.
		/// </remarks>
		public const string VideoMinimizeOnFocusLoss = "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS";

		/// <summary>
		/// A variable controlling whether the offscreen video driver saves output frames.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_OFFSCREEN_SAVE_FRAMES">documentation</see> for more details.
		/// </remarks>
		public const string VideoOffscreenSaveFrames = "SDL_VIDEO_OFFSCREEN_SAVE_FRAMES";

		/// <summary>
		/// A variable controlling whether all window operations will block until complete.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_SYNC_WINDOW_OPERATIONS">documentation</see> for more details.
		/// </remarks>
		public const string VideoVSyncWindowOperations = "SDL_VIDEO_SYNC_WINDOW_OPERATIONS";

		/// <summary>
		/// A variable controlling whether the libdecor Wayland backend is allowed to be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandAllowLibdecor = "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR";

		/// <summary>
		/// Enable or disable hidden mouse pointer warp emulation, needed by some older games.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandEmulateMouseWarp = "SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP";

		/// <summary>
		/// A variable controlling whether video mode emulation is enabled under Wayland.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandModeEmulation = "SDL_VIDEO_WAYLAND_MODE_EMULATION";

		/// <summary>
		/// A variable controlling how modes with a non-native aspect ratio are displayed under Wayland.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_MODE_SCALING">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandModeScaling = "SDL_VIDEO_WAYLAND_MODE_SCALING";

		/// <summary>
		/// A variable controlling whether the libdecor Wayland backend is preferred over native decorations.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandPreferLibdecor = "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR";

		/// <summary>
		/// A variable forcing non-DPI-aware Wayland windows to output at 1:1 scaling.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WAYLAND_SCALE_TO_DISPLAY">documentation</see> for more details.
		/// </remarks>
		public const string VideoWaylandScaleToDisplay = "SDL_VIDEO_WAYLAND_SCALE_TO_DISPLAY";

		/// <summary>
		/// A variable specifying which shader compiler to preload when using the Chrome ANGLE binaries.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_WIN_D3DCOMPILER">documentation</see> for more details.
		/// </remarks>
		public const string VideoWinD3Dcompiler = "SDL_VIDEO_WIN_D3DCOMPILER";

		/// <summary>
		/// A variable controlling whether the X11 _NET_WM_BYPASS_COMPOSITOR hint should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11NetWMBypassCompositor = "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR";

		/// <summary>
		/// A variable controlling whether the X11 _NET_WM_PING protocol should be supported.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_NET_WM_PING">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11NetWMPing = "SDL_VIDEO_X11_NET_WM_PING";

		/// <summary>
		/// A variable controlling whether SDL uses DirectColor visuals.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_NODIRECTCOLOR">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11NoDirectColor = "SDL_VIDEO_X11_NODIRECTCOLOR";

		/// <summary>
		/// A variable forcing the content scaling factor for X11 displays.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_SCALING_FACTOR">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11ScalingFactor = "SDL_VIDEO_X11_SCALING_FACTOR";

		/// <summary>
		/// A variable forcing the visual ID used for X11 display modes.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_VISUALID">documentation</see> for more details.
		/// </remarks>
		public const string VideoVisualId = "SDL_VIDEO_X11_VISUALID";

		/// <summary>
		/// A variable forcing the visual ID chosen for new X11 windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_WINDOW_VISUALID">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11WindowVisualId = "SDL_VIDEO_X11_WINDOW_VISUALID";

		/// <summary>
		/// A variable controlling whether the X11 XRandR extension should be used.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VIDEO_X11_XRANDR">documentation</see> for more details.
		/// </remarks>
		public const string VideoX11XRandR = "SDL_VIDEO_X11_XRANDR";

		/// <summary>
		/// A variable controlling whether touch should be enabled on the back panel of the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_ENABLE_BACK_TOUCH">documentation</see> for more details.
		/// </remarks>
		public const string VitaEnableBackTouch = "SDL_VITA_ENABLE_BACK_TOUCH";

		/// <summary>
		/// A variable controlling whether touch should be enabled on the front panel of the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_ENABLE_FRONT_TOUCH">documentation</see> for more details.
		/// </remarks>
		public const string VitaEnableFrontTouch = "SDL_VITA_ENABLE_FRONT_TOUCH";

		/// <summary>
		/// A variable controlling the module path on the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_MODULE_PATH">documentation</see> for more details.
		/// </remarks>
		public const string VitaModulePath = "SDL_VITA_MODULE_PATH";

		/// <summary>
		/// A variable controlling whether to perform PVR initialization on the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_PVR_INIT">documentation</see> for more details.
		/// </remarks>
		public const string VitaPvrInit = "SDL_VITA_PVR_INIT";

		/// <summary>
		/// A variable controlling whether OpenGL should be used instead of OpenGL ES on the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_PVR_OPENGL">documentation</see> for more details.
		/// </remarks>
		public const string VitaPvrOpenGL = "SDL_VITA_PVR_OPENGL";

		/// <summary>
		/// A variable overriding the resolution reported on the PlayStation Vita.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_RESOLUTION">documentation</see> for more details.
		/// </remarks>
		public const string VitaResolution = "SDL_VITA_RESOLUTION";

		/// <summary>
		/// A variable controlling which touchpad should generate synthetic mouse events.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VITA_TOUCH_MOUSE_DEVICE">documentation</see> for more details.
		/// </remarks>
		public const string VitaTouchMouseDevice = "SDL_VITA_TOUCH_MOUSE_DEVICE";

		/// <summary>
		/// A variable overriding the display index used in <see cref="SDL_Vulkan_CreateSurface()"/>.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VULKAN_DISPLAY">documentation</see> for more details.
		/// </remarks>
		public const string VulkanDisplay = "SDL_VULKAN_DISPLAY";

		/// <summary>
		/// Specify the Vulkan library to load.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_VULKAN_LIBRARY">documentation</see> for more details.
		/// </remarks>
		public const string VulkanLibrary = "SDL_VULKAN_LIBRARY";

		/// <summary>
		/// A variable controlling the maximum number of chunks in a WAVE file.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WAVE_CHUNK_LIMIT">documentation</see> for more details.
		/// </remarks>
		public const string WaveChunkLimit = "SDL_WAVE_CHUNK_LIMIT";

		/// <summary>
		/// A variable controlling how the fact chunk affects the loading of a WAVE file.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WAVE_FACT_CHUNK">documentation</see> for more details.
		/// </remarks>
		public const string WaveFactChunk = "SDL_WAVE_FACT_CHUNK";

		/// <summary>
		/// A variable controlling how the size of the RIFF chunk affects the loading of a WAVE file.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WAVE_RIFF_CHUNK_SIZE">documentation</see> for more details.
		/// </remarks>
		public const string WaveRiffChunkSize = "SDL_WAVE_RIFF_CHUNK_SIZE";

		/// <summary>
		/// A variable controlling how a truncated WAVE file is handled.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WAVE_TRUNCATION">documentation</see> for more details.
		/// </remarks>
		public const string WaveTruncation = "SDL_WAVE_TRUNCATION";

		/// <summary>
		/// A variable controlling whether the window is activated when the <see cref="SDL.RaiseWindow(SDL_Window*)"/> function is called.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOW_ACTIVATE_WHEN_RAISED">documentation</see> for more details.
		/// </remarks>
		public const string WindowActivateWhenRaised = "SDL_WINDOW_ACTIVATE_WHEN_RAISED";

		/// <summary>
		/// A variable controlling whether the window is activated when the <see cref="SDL.ShowWindow(SDL_Window*)"/> function is called.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOW_ACTIVATE_WHEN_SHOWN">documentation</see> for more details.
		/// </remarks>
		public const string WindowActivateWhenShown = "SDL_WINDOW_ACTIVATE_WHEN_SHOWN";

		/// <summary>
		/// If set to "0" then never set the top-most flag on an SDL Window even if the application requests it.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOW_ALLOW_TOPMOST">documentation</see> for more details.
		/// </remarks>
		public const string WindowAllowTopmost = "SDL_WINDOW_ALLOW_TOPMOST";

		/// <summary>
		/// A variable controlling whether the window frame and title bar are interactive when the cursor is hidden.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN">documentation</see> for more details.
		/// </remarks>
		public const string WindowFrameUsableWhileCursorHidden = "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";

		/// <summary>
		/// A variable controlling whether SDL generates window-close events for Alt+F4 on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_CLOSE_ON_ALT_F4">documentation</see> for more details.
		/// </remarks>
		public const string WindowsCloseOnAltF4 = "SDL_WINDOWS_CLOSE_ON_ALT_F4";

		/// <summary>
		/// A variable controlling whether menus can be opened with their keyboard shortcut (Alt+mnemonic).
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_ENABLE_MENU_MNEMONICS">documentation</see> for more details.
		/// </remarks>
		public const string WindowsEnableMenuMnemonics = "SDL_WINDOWS_ENABLE_MENU_MNEMONICS";

		/// <summary>
		/// A variable controlling whether the windows message loop is processed by SDL.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP">documentation</see> for more details.
		/// </remarks>
		public const string WindowsEnableMessageLoop = "SDL_WINDOWS_ENABLE_MESSAGELOOP";

		/// <summary>
		/// A variable controlling whether GameInput is used for raw keyboard and mouse on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_GAMEINPUT">documentation</see> for more details.
		/// </remarks>
		public const string WindowsGameInput = "SDL_WINDOWS_GAMEINPUT";

		/// <summary>
		/// A variable controlling whether SDL will clear the window contents when the <c>WM_ERASEBKGND</c> message is received.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_ERASE_BACKGROUND_MODE">documentation</see> for more details.
		/// </remarks>
		public const string WindowsEraseBackgroundMode = "SDL_WINDOWS_ERASE_BACKGROUND_MODE";

		/// <summary>
		/// A variable controlling whether SDL uses Critical Sections for mutexes on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS">documentation</see> for more details.
		/// </remarks>
		public const string WindowsForceMutexCriticalSections = "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS";

		/// <summary>
		/// A variable controlling whether SDL uses Kernel Semaphores on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL">documentation</see> for more details.
		/// </remarks>
		public const string WindowsForceSemaphoreKernel = "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL";

		/// <summary>
		/// A variable to specify custom icon resource id from RC file on Windows platform.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_INTRESOURCE_ICON">documentation</see> for more details.
		/// </remarks>
		public const string WindowsIntresourceIcon = "SDL_WINDOWS_INTRESOURCE_ICON";

		/// <summary>
		/// A variable controlling whether raw keyboard events are used on Windows.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_RAW_KEYBOARD">documentation</see> for more details.
		/// </remarks>
		public const string WindowsRawKeyboard = "SDL_WINDOWS_RAW_KEYBOARD";

		/// <summary>
		/// A variable controlling whether SDL uses the D3D9Ex API introduced in Windows Vista, instead of normal D3D9.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINDOWS_USE_D3D9EX">documentation</see> for more details.
		/// </remarks>
		public const string WindowsUseD3D9Ex = "SDL_WINDOWS_USE_D3D9EX";

		/// <summary>
		/// A variable controlling whether back-button-press events on Windows Phone to be marked as handled.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINRT_HANDLE_BACK_BUTTON">documentation</see> for more details.
		/// </remarks>
		public const string WinRTHandleBackButton = "SDL_WINRT_HANDLE_BACK_BUTTON";

		/// <summary>
		/// A variable specifying the label text for a WinRT app's privacy policy link.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINRT_PRIVACY_POLICY_LABEL">documentation</see> for more details.
		/// </remarks>
		public const string WinRTPrivacyPolicyLabel = "SDL_WINRT_PRIVACY_POLICY_LABEL";

		/// <summary>
		/// A variable specifying the URL to a WinRT app's privacy policy.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_WINRT_PRIVACY_POLICY_URL">documentation</see> for more details.
		/// </remarks>
		public const string WinRTPrivacyPolicyUrl = "SDL_WINRT_PRIVACY_POLICY_URL";

		/// <summary>
		/// A variable controlling whether X11 windows are marked as override-redirect.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT">documentation</see> for more details.
		/// </remarks>
		public const string X11ForceOverrideRedirect = "SDL_X11_FORCE_OVERRIDE_REDIRECT";

		/// <summary>
		/// A variable specifying the type of an X11 window.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_X11_WINDOW_TYPE">documentation</see> for more details.
		/// </remarks>
		public const string X11WindowType = "SDL_X11_WINDOW_TYPE";

		/// <summary>
		/// Specify the XCB library to load for the X11 driver.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_X11_XCB_LIBRARY">documentation</see> for more details.
		/// </remarks>
		public const string X11XcbLibrary = "SDL_X11_XCB_LIBRARY";

		/// <summary>
		/// A variable controlling whether XInput should be used for controller handling.
		/// </summary>
		/// <remarks>
		/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HINT_XINPUT_ENABLED">documentation</see> for more details.
		/// </remarks>
		public const string XInputEnabled = "SDL_XINPUT_ENABLED";
	}
}