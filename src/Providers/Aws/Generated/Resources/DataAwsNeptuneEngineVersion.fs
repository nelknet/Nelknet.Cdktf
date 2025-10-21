namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNeptuneEngineVersionState = { assignments: ResizeArray<aws.DataAwsNeptuneEngineVersion.DataAwsNeptuneEngineVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version">aws_neptune_engine_version</a>.
    /// </summary>
    type DataAwsNeptuneEngineVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNeptuneEngineVersionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNeptuneEngineVersionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#default_only-1">DataAwsNeptuneEngineVersion#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsNeptuneEngineVersionState, value: bool) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#default_only-1">DataAwsNeptuneEngineVersion#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsNeptuneEngineVersionState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#engine-1">DataAwsNeptuneEngineVersion#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsNeptuneEngineVersionState, value: string) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#has_major_target-1">DataAwsNeptuneEngineVersion#has_major_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_major_target">]
        member _.HasMajorTarget(state: DataAwsNeptuneEngineVersionState, value: bool) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.HasMajorTarget <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#has_major_target-1">DataAwsNeptuneEngineVersion#has_major_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_major_target">]
        member _.HasMajorTarget(state: DataAwsNeptuneEngineVersionState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.HasMajorTarget <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#has_minor_target-1">DataAwsNeptuneEngineVersion#has_minor_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_minor_target">]
        member _.HasMinorTarget(state: DataAwsNeptuneEngineVersionState, value: bool) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.HasMinorTarget <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#has_minor_target-1">DataAwsNeptuneEngineVersion#has_minor_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_minor_target">]
        member _.HasMinorTarget(state: DataAwsNeptuneEngineVersionState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.HasMinorTarget <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#id-1">DataAwsNeptuneEngineVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNeptuneEngineVersionState, value: string) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#latest-1">DataAwsNeptuneEngineVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsNeptuneEngineVersionState, value: bool) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#latest-1">DataAwsNeptuneEngineVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsNeptuneEngineVersionState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#parameter_group_family-1">DataAwsNeptuneEngineVersion#parameter_group_family</a>.
        /// </summary>
        [<CustomOperation "parameter_group_family">]
        member _.ParameterGroupFamily(state: DataAwsNeptuneEngineVersionState, value: string) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.ParameterGroupFamily <- value)
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#preferred_major_targets-1">DataAwsNeptuneEngineVersion#preferred_major_targets</a>.
        /// </summary>
        [<CustomOperation "preferred_major_targets">]
        member _.PreferredMajorTargets(state: DataAwsNeptuneEngineVersionState, value: seq<string>) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.PreferredMajorTargets <- (value |> Seq.toArray))
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#preferred_upgrade_targets-1">DataAwsNeptuneEngineVersion#preferred_upgrade_targets</a>.
        /// </summary>
        [<CustomOperation "preferred_upgrade_targets">]
        member _.PreferredUpgradeTargets(state: DataAwsNeptuneEngineVersionState, value: seq<string>) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.PreferredUpgradeTargets <- (value |> Seq.toArray))
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#preferred_versions-1">DataAwsNeptuneEngineVersion#preferred_versions</a>.
        /// </summary>
        [<CustomOperation "preferred_versions">]
        member _.PreferredVersions(state: DataAwsNeptuneEngineVersionState, value: seq<string>) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.PreferredVersions <- (value |> Seq.toArray))
            state : DataAwsNeptuneEngineVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/neptune_engine_version#version-1">DataAwsNeptuneEngineVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsNeptuneEngineVersionState, value: string) : DataAwsNeptuneEngineVersionState =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsNeptuneEngineVersionState

        member _.Run(state: DataAwsNeptuneEngineVersionState) : aws.DataAwsNeptuneEngineVersion.DataAwsNeptuneEngineVersion =
            let config = aws.DataAwsNeptuneEngineVersion.DataAwsNeptuneEngineVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNeptuneEngineVersion.DataAwsNeptuneEngineVersion(StackContext.get (), logicalId, config)
