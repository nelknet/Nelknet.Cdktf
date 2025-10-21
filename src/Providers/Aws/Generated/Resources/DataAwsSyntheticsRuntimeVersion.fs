namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSyntheticsRuntimeVersionState<'Prefix> = { assignments: ResizeArray<aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_version">aws_synthetics_runtime_version</a>.
    /// </summary>
    type DataAwsSyntheticsRuntimeVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSyntheticsRuntimeVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSyntheticsRuntimeVersionState<Missing>)

        member _.Zero(()) : DataAwsSyntheticsRuntimeVersionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSyntheticsRuntimeVersionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_version#prefix-1">DataAwsSyntheticsRuntimeVersion#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: DataAwsSyntheticsRuntimeVersionState<Missing>, value: string) : DataAwsSyntheticsRuntimeVersionState<Present> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            ({ assignments = state.assignments } : DataAwsSyntheticsRuntimeVersionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_version#latest-1">DataAwsSyntheticsRuntimeVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsSyntheticsRuntimeVersionState<'Prefix>, value: bool) : DataAwsSyntheticsRuntimeVersionState<'Prefix> =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsSyntheticsRuntimeVersionState<'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_version#latest-1">DataAwsSyntheticsRuntimeVersion#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsSyntheticsRuntimeVersionState<'Prefix>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSyntheticsRuntimeVersionState<'Prefix> =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsSyntheticsRuntimeVersionState<'Prefix>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/synthetics_runtime_version#version-1">DataAwsSyntheticsRuntimeVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsSyntheticsRuntimeVersionState<'Prefix>, value: string) : DataAwsSyntheticsRuntimeVersionState<'Prefix> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsSyntheticsRuntimeVersionState<'Prefix>

        member _.Run(state: DataAwsSyntheticsRuntimeVersionState<Present>) : aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersion =
            let config = aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSyntheticsRuntimeVersion: missing required arguments. Must call: prefix.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSyntheticsRuntimeVersionState<_>) : aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersion =
            Unchecked.defaultof<aws.DataAwsSyntheticsRuntimeVersion.DataAwsSyntheticsRuntimeVersion>
