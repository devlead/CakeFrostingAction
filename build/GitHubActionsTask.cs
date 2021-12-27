using System.Threading.Tasks;
using Cake.Frosting;

[TaskName("GitHubActions")]
[IsDependentOn(typeof(WorldTask))]
public sealed class GitHubActionsTask : AsyncFrostingTask<BuildContext>
{
    // Tasks can be asynchronous
    public override async Task RunAsync(BuildContext context)
     => await context.GitHubActionsProvider.Commands.UploadArtifact(
            context.ArtifactPath,
            context.ArtifactName
        );
    public override bool ShouldRun(BuildContext context)
        => context.GitHubActionsProvider.IsRunningOnGitHubActions;
}
