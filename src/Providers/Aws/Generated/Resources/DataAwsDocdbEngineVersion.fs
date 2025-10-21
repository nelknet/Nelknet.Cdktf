namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDocdbEngineVersionState = { assignments: ResizeArray<aws.DataAwsDocdbEngineVersion.DataAwsDocdbEngineVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version">aws_docdb_engine_version</a>.
    /// </summary>
    type DataAwsDocdbEngineVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDocdbEngineVersionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDocdbEngineVersionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version#engine-1">DataAwsDocdbEngineVersion#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsDocdbEngineVersionState, value: string) : DataAwsDocdbEngineVersionState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsDocdbEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version#id-1">DataAwsDocdbEngineVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDocdbEngineVersionState, value: string) : DataAwsDocdbEngineVersionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDocdbEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version#parameter_group_family-1">DataAwsDocdbEngineVersion#parameter_group_family</a>.
        /// </summary>
        [<CustomOperation "parameter_group_family">]
        member _.ParameterGroupFamily(state: DataAwsDocdbEngineVersionState, value: string) : DataAwsDocdbEngineVersionState =
            state.assignments.Add(fun config -> config.ParameterGroupFamily <- value)
            state : DataAwsDocdbEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version#preferred_versions-1">DataAwsDocdbEngineVersion#preferred_versions</a>.
        /// </summary>
        [<CustomOperation "preferred_versions">]
        member _.PreferredVersions(state: DataAwsDocdbEngineVersionState, value: seq<string>) : DataAwsDocdbEngineVersionState =
            state.assignments.Add(fun config -> config.PreferredVersions <- (value |> Seq.toArray))
            state : DataAwsDocdbEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/docdb_engine_version#version-1">DataAwsDocdbEngineVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsDocdbEngineVersionState, value: string) : DataAwsDocdbEngineVersionState =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsDocdbEngineVersionState

        member _.Run(state: DataAwsDocdbEngineVersionState) : aws.DataAwsDocdbEngineVersion.DataAwsDocdbEngineVersion =
            let config = aws.DataAwsDocdbEngineVersion.DataAwsDocdbEngineVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDocdbEngineVersion.DataAwsDocdbEngineVersion(StackContext.get (), logicalId, config)
