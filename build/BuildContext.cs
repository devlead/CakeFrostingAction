using Cake.Common.Build.GitHubActions;
using Cake.Common.Build;
using Cake.Core;
using Cake.Frosting;
using Cake.Core.IO;
using Cake.Common.IO;

public class BuildContext : FrostingContext
{
    public bool Delay { get; set; }
    public IGitHubActionsProvider GitHubActionsProvider { get; }
    public DirectoryPath ArtifactPath { get; }
    public string ArtifactName { get; }

    public BuildContext(ICakeContext context)
        : base(context)
    {
        Delay = context.Arguments.HasArgument("delay");
        GitHubActionsProvider = context.GitHubActions();
        ArtifactPath = context.MakeAbsolute(DirectoryPath.FromString("./bin"));
        ArtifactName = $"MyArtifact_{context.Environment.Platform.Family}";
    }
}
