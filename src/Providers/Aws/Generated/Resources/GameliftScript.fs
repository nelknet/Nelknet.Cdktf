namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftScriptState<'Name> = { assignments: ResizeArray<aws.GameliftScript.GameliftScriptConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script">aws_gamelift_script</a>.
    /// </summary>
    type GameliftScriptBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftScriptState<Missing> =
            ({ assignments = ResizeArray() } : GameliftScriptState<Missing>)

        member _.Zero(()) : GameliftScriptState<Missing> =
            ({ assignments = ResizeArray() } : GameliftScriptState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#name-1">GameliftScript#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GameliftScriptState<Missing>, value: string) : GameliftScriptState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GameliftScriptState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#id-1">GameliftScript#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftScriptState<'Name>, value: string) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftScriptState<'Name>

        /// <summary>
        /// storage_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#storage_location-1">GameliftScript#storage_location</a>
        /// </summary>
        [<CustomOperation "storage_location">]
        member _.StorageLocation(state: GameliftScriptState<'Name>, value: aws.GameliftScript.GameliftScriptStorageLocation) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.StorageLocation <- value)
            state : GameliftScriptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#tags-1">GameliftScript#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftScriptState<'Name>, value: seq<string * string>) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftScriptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#tags_all-1">GameliftScript#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftScriptState<'Name>, value: seq<string * string>) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftScriptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#version-1">GameliftScript#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: GameliftScriptState<'Name>, value: string) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : GameliftScriptState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_script#zip_file-1">GameliftScript#zip_file</a>.
        /// </summary>
        [<CustomOperation "zip_file">]
        member _.ZipFile(state: GameliftScriptState<'Name>, value: string) : GameliftScriptState<'Name> =
            state.assignments.Add(fun config -> config.ZipFile <- value)
            state : GameliftScriptState<'Name>

        member _.Run(state: GameliftScriptState<Present>) : aws.GameliftScript.GameliftScript =
            let config = aws.GameliftScript.GameliftScriptConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftScript.GameliftScript(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftScript: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GameliftScriptState<_>) : aws.GameliftScript.GameliftScript =
            Unchecked.defaultof<aws.GameliftScript.GameliftScript>
