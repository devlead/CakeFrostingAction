DotNetRun(
    "./build/Build.csproj",
    new ProcessArgumentBuilder()
        .AppendSwitch("--target", "=", Argument("target", "Default")));