namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsEngineVersionState<'Engine> = { assignments: ResizeArray<aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version">aws_rds_engine_version</a>.
    /// </summary>
    type DataAwsRdsEngineVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsEngineVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsEngineVersionState<Missing>)

        member _.Zero(()) : DataAwsRdsEngineVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsEngineVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#engine-1">DataAwsRdsEngineVersion#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsRdsEngineVersionState<Missing>, value: string) : DataAwsRdsEngineVersionState<Present> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : DataAwsRdsEngineVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#default_only-1">DataAwsRdsEngineVersion#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsRdsEngineVersionState<'Engine>, value: bool) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#default_only-1">DataAwsRdsEngineVersion#default_only</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_only">]
        member _.DefaultOnly(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.DefaultOnly <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#filter-1">DataAwsRdsEngineVersion#filter</a> Accepts: aws.IResolvable | aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersionFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#has_major_target-1">DataAwsRdsEngineVersion#has_major_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_major_target">]
        member _.HasMajorTarget(state: DataAwsRdsEngineVersionState<'Engine>, value: bool) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.HasMajorTarget <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#has_major_target-1">DataAwsRdsEngineVersion#has_major_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_major_target">]
        member _.HasMajorTarget(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.HasMajorTarget <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#has_minor_target-1">DataAwsRdsEngineVersion#has_minor_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_minor_target">]
        member _.HasMinorTarget(state: DataAwsRdsEngineVersionState<'Engine>, value: bool) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.HasMinorTarget <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#has_minor_target-1">DataAwsRdsEngineVersion#has_minor_target</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "has_minor_target">]
        member _.HasMinorTarget(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.HasMinorTarget <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#id-1">DataAwsRdsEngineVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsEngineVersionState<'Engine>, value: string) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#include_all-1">DataAwsRdsEngineVersion#include_all</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_all">]
        member _.IncludeAll(state: DataAwsRdsEngineVersionState<'Engine>, value: bool) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.IncludeAll <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#include_all-1">DataAwsRdsEngineVersion#include_all</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_all">]
        member _.IncludeAll(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.IncludeAll <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#latest-1">DataAwsRdsEngineVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsRdsEngineVersionState<'Engine>, value: bool) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#latest-1">DataAwsRdsEngineVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsRdsEngineVersionState<'Engine>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#parameter_group_family-1">DataAwsRdsEngineVersion#parameter_group_family</a>.
        /// </summary>
        [<CustomOperation "parameter_group_family">]
        member _.ParameterGroupFamily(state: DataAwsRdsEngineVersionState<'Engine>, value: string) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.ParameterGroupFamily <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#preferred_major_targets-1">DataAwsRdsEngineVersion#preferred_major_targets</a>.
        /// </summary>
        [<CustomOperation "preferred_major_targets">]
        member _.PreferredMajorTargets(state: DataAwsRdsEngineVersionState<'Engine>, value: seq<string>) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredMajorTargets <- (value |> Seq.toArray))
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#preferred_upgrade_targets-1">DataAwsRdsEngineVersion#preferred_upgrade_targets</a>.
        /// </summary>
        [<CustomOperation "preferred_upgrade_targets">]
        member _.PreferredUpgradeTargets(state: DataAwsRdsEngineVersionState<'Engine>, value: seq<string>) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredUpgradeTargets <- (value |> Seq.toArray))
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#preferred_versions-1">DataAwsRdsEngineVersion#preferred_versions</a>.
        /// </summary>
        [<CustomOperation "preferred_versions">]
        member _.PreferredVersions(state: DataAwsRdsEngineVersionState<'Engine>, value: seq<string>) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.PreferredVersions <- (value |> Seq.toArray))
            state : DataAwsRdsEngineVersionState<'Engine>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_engine_version#version-1">DataAwsRdsEngineVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsRdsEngineVersionState<'Engine>, value: string) : DataAwsRdsEngineVersionState<'Engine> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsRdsEngineVersionState<'Engine>

        member _.Run(state: DataAwsRdsEngineVersionState<Present>) : aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersion =
            let config = aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRdsEngineVersion: missing required arguments. Must call: engine.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRdsEngineVersionState<_>) : aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersion =
            Unchecked.defaultof<aws.DataAwsRdsEngineVersion.DataAwsRdsEngineVersion>
