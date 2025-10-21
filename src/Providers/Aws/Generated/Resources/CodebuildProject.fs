namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> = { assignments: ResizeArray<aws.CodebuildProject.CodebuildProjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project">aws_codebuild_project</a>.
    /// </summary>
    type CodebuildProjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodebuildProjectState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildProjectState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodebuildProjectState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodebuildProjectState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// artifacts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#artifacts-1">CodebuildProject#artifacts</a>
        /// </summary>
        [<CustomOperation "artifacts">]
        member _.Artifacts(state: CodebuildProjectState<Missing, 'Environment, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectArtifacts) : CodebuildProjectState<Present, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Artifacts <- value)
            ({ assignments = state.assignments } : CodebuildProjectState<Present, 'Environment, 'Name, 'ServiceRole, 'Source>)

        /// <summary>
        /// environment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#environment-1">CodebuildProject#environment</a>
        /// </summary>
        [<CustomOperation "environment">]
        member _.Environment(state: CodebuildProjectState<'Artifacts, Missing, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectEnvironment) : CodebuildProjectState<'Artifacts, Present, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Environment <- value)
            ({ assignments = state.assignments } : CodebuildProjectState<'Artifacts, Present, 'Name, 'ServiceRole, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#name-1">CodebuildProject#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CodebuildProjectState<'Artifacts, 'Environment, Missing, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, Present, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CodebuildProjectState<'Artifacts, 'Environment, Present, 'ServiceRole, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#service_role-1">CodebuildProject#service_role</a>.
        /// </summary>
        [<CustomOperation "service_role">]
        member _.ServiceRole(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, Missing, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, Present, 'Source> =
            state.assignments.Add(fun config -> config.ServiceRole <- value)
            ({ assignments = state.assignments } : CodebuildProjectState<'Artifacts, 'Environment, 'Name, Present, 'Source>)

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source-1">CodebuildProject#source</a>
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, Missing>, value: aws.CodebuildProject.CodebuildProjectSource) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#badge_enabled-1">CodebuildProject#badge_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "badge_enabled">]
        member _.BadgeEnabled(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: bool) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.BadgeEnabled <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#badge_enabled-1">CodebuildProject#badge_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "badge_enabled">]
        member _.BadgeEnabled(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: HashiCorp.Cdktf.IResolvable) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.BadgeEnabled <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// build_batch_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#build_batch_config-1">CodebuildProject#build_batch_config</a>
        /// </summary>
        [<CustomOperation "build_batch_config">]
        member _.BuildBatchConfig(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectBuildBatchConfig) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.BuildBatchConfig <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#build_timeout-1">CodebuildProject#build_timeout</a>.
        /// </summary>
        [<CustomOperation "build_timeout">]
        member _.BuildTimeout(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: double) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.BuildTimeout <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// cache block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#cache-1">CodebuildProject#cache</a>
        /// </summary>
        [<CustomOperation "cache">]
        member _.Cache(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectCache) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Cache <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#concurrent_build_limit-1">CodebuildProject#concurrent_build_limit</a>.
        /// </summary>
        [<CustomOperation "concurrent_build_limit">]
        member _.ConcurrentBuildLimit(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: double) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.ConcurrentBuildLimit <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#description-1">CodebuildProject#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#encryption_key-1">CodebuildProject#encryption_key</a>.
        /// </summary>
        [<CustomOperation "encryption_key">]
        member _.EncryptionKey(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.EncryptionKey <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// file_system_locations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#file_system_locations-1">CodebuildProject#file_system_locations</a> Accepts: aws.IResolvable | aws.CodebuildProject.CodebuildProjectFileSystemLocations[]
        /// </summary>
        [<CustomOperation "file_system_locations">]
        member _.FileSystemLocations(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: HashiCorp.Cdktf.IResolvable) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.FileSystemLocations <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#id-1">CodebuildProject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// logs_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#logs_config-1">CodebuildProject#logs_config</a>
        /// </summary>
        [<CustomOperation "logs_config">]
        member _.LogsConfig(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectLogsConfig) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.LogsConfig <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#project_visibility-1">CodebuildProject#project_visibility</a>.
        /// </summary>
        [<CustomOperation "project_visibility">]
        member _.ProjectVisibility(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.ProjectVisibility <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#queued_timeout-1">CodebuildProject#queued_timeout</a>.
        /// </summary>
        [<CustomOperation "queued_timeout">]
        member _.QueuedTimeout(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: double) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.QueuedTimeout <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#resource_access_role-1">CodebuildProject#resource_access_role</a>.
        /// </summary>
        [<CustomOperation "resource_access_role">]
        member _.ResourceAccessRole(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.ResourceAccessRole <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// secondary_artifacts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#secondary_artifacts-1">CodebuildProject#secondary_artifacts</a> Accepts: aws.IResolvable | aws.CodebuildProject.CodebuildProjectSecondaryArtifacts[]
        /// </summary>
        [<CustomOperation "secondary_artifacts">]
        member _.SecondaryArtifacts(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: HashiCorp.Cdktf.IResolvable) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.SecondaryArtifacts <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// secondary_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#secondary_sources-1">CodebuildProject#secondary_sources</a> Accepts: aws.IResolvable | aws.CodebuildProject.CodebuildProjectSecondarySources[]
        /// </summary>
        [<CustomOperation "secondary_sources">]
        member _.SecondarySources(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: HashiCorp.Cdktf.IResolvable) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.SecondarySources <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// secondary_source_version block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#secondary_source_version-1">CodebuildProject#secondary_source_version</a> Accepts: aws.IResolvable | aws.CodebuildProject.CodebuildProjectSecondarySourceVersion[]
        /// </summary>
        [<CustomOperation "secondary_source_version">]
        member _.SecondarySourceVersion(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: HashiCorp.Cdktf.IResolvable) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.SecondarySourceVersion <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_version-1">CodebuildProject#source_version</a>.
        /// </summary>
        [<CustomOperation "source_version">]
        member _.SourceVersion(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: string) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.SourceVersion <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#tags-1">CodebuildProject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: seq<string * string>) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#tags_all-1">CodebuildProject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: seq<string * string>) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#vpc_config-1">CodebuildProject#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>, value: aws.CodebuildProject.CodebuildProjectVpcConfig) : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : CodebuildProjectState<'Artifacts, 'Environment, 'Name, 'ServiceRole, 'Source>

        member _.Run(state: CodebuildProjectState<Present, Present, Present, Present, Present>) : aws.CodebuildProject.CodebuildProject =
            let config = aws.CodebuildProject.CodebuildProjectConfig()
            for setter in state.assignments do
                setter config
            aws.CodebuildProject.CodebuildProject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codebuildProject: missing required arguments. Must call: artifacts, environment, name, service_role, source.", 9999, IsError = true)>]
        member _.Run(_: CodebuildProjectState<_, _, _, _, _>) : aws.CodebuildProject.CodebuildProject =
            Unchecked.defaultof<aws.CodebuildProject.CodebuildProject>
