namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation> = { assignments: ResizeArray<aws.GameliftBuild.GameliftBuildConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build">aws_gamelift_build</a>.
    /// </summary>
    type GameliftBuildBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftBuildState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftBuildState<Missing, Missing, Missing>)

        member _.Zero(()) : GameliftBuildState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftBuildState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#name-1">GameliftBuild#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GameliftBuildState<Missing, 'OperatingSystem, 'StorageLocation>, value: string) : GameliftBuildState<Present, 'OperatingSystem, 'StorageLocation> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GameliftBuildState<Present, 'OperatingSystem, 'StorageLocation>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#operating_system-1">GameliftBuild#operating_system</a>.
        /// </summary>
        [<CustomOperation "operating_system">]
        member _.OperatingSystem(state: GameliftBuildState<'Name, Missing, 'StorageLocation>, value: string) : GameliftBuildState<'Name, Present, 'StorageLocation> =
            state.assignments.Add(fun config -> config.OperatingSystem <- value)
            ({ assignments = state.assignments } : GameliftBuildState<'Name, Present, 'StorageLocation>)

        /// <summary>
        /// storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#storage_location-1">GameliftBuild#storage_location</a>
        /// </summary>
        [<CustomOperation "storage_location">]
        member _.StorageLocation(state: GameliftBuildState<'Name, 'OperatingSystem, Missing>, value: aws.GameliftBuild.GameliftBuildStorageLocation) : GameliftBuildState<'Name, 'OperatingSystem, Present> =
            state.assignments.Add(fun config -> config.StorageLocation <- value)
            ({ assignments = state.assignments } : GameliftBuildState<'Name, 'OperatingSystem, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#id-1">GameliftBuild#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>, value: string) : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#tags-1">GameliftBuild#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>, value: seq<string * string>) : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#tags_all-1">GameliftBuild#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>, value: seq<string * string>) : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_build#version-1">GameliftBuild#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>, value: string) : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : GameliftBuildState<'Name, 'OperatingSystem, 'StorageLocation>

        member _.Run(state: GameliftBuildState<Present, Present, Present>) : aws.GameliftBuild.GameliftBuild =
            let config = aws.GameliftBuild.GameliftBuildConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftBuild.GameliftBuild(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftBuild: missing required arguments. Must call: name, operating_system, storage_location.", 9999, IsError = true)>]
        member _.Run(_: GameliftBuildState<_, _, _>) : aws.GameliftBuild.GameliftBuild =
            Unchecked.defaultof<aws.GameliftBuild.GameliftBuild>
