namespace SDL3;

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="CreateProcessWithProperties(SDL_PropertiesId)"/>.
		/// </summary>
		public static class ProcessCreate
		{
			/// <summary>
			/// An array of strings containing the program to run, any arguments, and a <see langword="null"/> pointer. This is a
			/// required property.
			/// </summary>
			public const string ArgsPointer = "SDL.process.create.args";

			/// <summary>
			/// An <see cref="FIXME:SDL_Environment"/> pointer. If this property is set, it will be the entire environment for the
			/// process, otherwise the current environment is used.
			/// </summary>
			public const string EnvironmentPointer = "SDL.process.create.environment";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard input for the process comes from, defaults to
			/// <see cref="SDL_ProcessIO.StdioNull"/>.
			/// </summary>
			public const string StdinNumber = "SDL.process.create.stdin_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard input when <see cref="StdinNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StdinPointer = "SDL.process.create.stdin_source";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard output for the process goes go, defaults to
			/// <see cref="SDL_ProcessIO.StdioInherited"/>.
			/// </summary>
			public const string StdoutNumber = "SDL.process.create.stdout_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard output when <see cref="StdoutNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StdoutPointer = "SDL.process.create.stdout_source";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard error for the process goes go, defaults to
			/// <see cref="SDL_ProcessIO.StdioInherited"/>.
			/// </summary>
			public const string StderrNumber = "SDL.process.create.stderr_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard error when <see cref="StderrNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StderrPointer = "SDL.process.create.stderr_source";

			/// <summary>
			/// True if the error output of the process should be redirected into the standard output of the process. This property
			/// has no effect if <see cref="StderrNumber"/> is set.
			/// </summary>
			public const string StderrToStdoutBoolean = "SDL.process.create.stderr_to_stdout";

			/// <summary>
			/// True if the process should run in the background. In this case the default input and output is
			/// <see cref="SDL_ProcessIO.StdioNull"/> and the exitcode of the process is not available, and will always be 0.
			/// </summary>
			public const string BackgroundBoolean = "SDL.process.create.background";
		}

		/// <summary>
		/// Properties used for <see cref="GetProcessProperties(SDL_Process*)"/>.
		/// </summary>
		public static class Process
		{
			/// <summary>
			/// The process ID of the process.
			/// </summary>
			public const string PidNumber = "SDL.process.pid";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> that can be used to write input to the process, if it was created with
			/// <see cref="ProcessCreate.StdinNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StdinPointer = "SDL.process.stdin";

			/// <summary>
			/// A non-blocking <see cref="FIXME:SDL_IOStream"/> that can be used to read output from the process, if it was created
			/// with <see cref="ProcessCreate.StdoutNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StdoutPointer = "SDL.process.stdout";

			/// <summary>
			/// A non-blocking <see cref="FIXME:SDL_IOStream"/> that can be used to read error output from the process, if it was
			/// created with <see cref="ProcessCreate.StderrNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StderrPointer = "SDL.process.stderr";

			/// <summary>
			/// True if the process is running in the background.
			/// </summary>
			public const string BackgroundBoolean = "SDL.process.background";
		}
	}
}