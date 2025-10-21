namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> = { assignments: ResizeArray<aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment">aws_codecatalyst_dev_environment</a>.
    /// </summary>
    type DataAwsCodecatalystDevEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCodecatalystDevEnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecatalystDevEnvironmentState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsCodecatalystDevEnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsCodecatalystDevEnvironmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#env_id-1">DataAwsCodecatalystDevEnvironment#env_id</a>.
        /// </summary>
        [<CustomOperation "env_id">]
        member _.EnvId(state: DataAwsCodecatalystDevEnvironmentState<Missing, 'ProjectName, 'SpaceName>, value: string) : DataAwsCodecatalystDevEnvironmentState<Present, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.EnvId <- value)
            ({ assignments = state.assignments } : DataAwsCodecatalystDevEnvironmentState<Present, 'ProjectName, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#project_name-1">DataAwsCodecatalystDevEnvironment#project_name</a>.
        /// </summary>
        [<CustomOperation "project_name">]
        member _.ProjectName(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, Missing, 'SpaceName>, value: string) : DataAwsCodecatalystDevEnvironmentState<'EnvId, Present, 'SpaceName> =
            state.assignments.Add(fun config -> config.ProjectName <- value)
            ({ assignments = state.assignments } : DataAwsCodecatalystDevEnvironmentState<'EnvId, Present, 'SpaceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#space_name-1">DataAwsCodecatalystDevEnvironment#space_name</a>.
        /// </summary>
        [<CustomOperation "space_name">]
        member _.SpaceName(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, Missing>, value: string) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, Present> =
            state.assignments.Add(fun config -> config.SpaceName <- value)
            ({ assignments = state.assignments } : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#alias-1">DataAwsCodecatalystDevEnvironment#alias</a>.
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>, value: string) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#creator_id-1">DataAwsCodecatalystDevEnvironment#creator_id</a>.
        /// </summary>
        [<CustomOperation "creator_id">]
        member _.CreatorId(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>, value: string) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.CreatorId <- value)
            state : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#id-1">DataAwsCodecatalystDevEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>, value: string) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>

        /// <summary>
        /// repositories block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#repositories-1">DataAwsCodecatalystDevEnvironment#repositories</a> Accepts: aws.IResolvable | aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironmentRepositories[]
        /// </summary>
        [<CustomOperation "repositories">]
        member _.Repositories(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>, value: HashiCorp.Cdktf.IResolvable) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Repositories <- value)
            state : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/codecatalyst_dev_environment#tags-1">DataAwsCodecatalystDevEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>, value: seq<string * string>) : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCodecatalystDevEnvironmentState<'EnvId, 'ProjectName, 'SpaceName>

        member _.Run(state: DataAwsCodecatalystDevEnvironmentState<Present, Present, Present>) : aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironment =
            let config = aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCodecatalystDevEnvironment: missing required arguments. Must call: env_id, project_name, space_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCodecatalystDevEnvironmentState<_, _, _>) : aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironment =
            Unchecked.defaultof<aws.DataAwsCodecatalystDevEnvironment.DataAwsCodecatalystDevEnvironment>
