namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminPermissionSetsState<'InstanceArn> = { assignments: ResizeArray<aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSetsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_sets">aws_ssoadmin_permission_sets</a>.
    /// </summary>
    type DataAwsSsoadminPermissionSetsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminPermissionSetsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPermissionSetsState<Missing>)

        member _.Zero(()) : DataAwsSsoadminPermissionSetsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPermissionSetsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_sets#instance_arn-1">DataAwsSsoadminPermissionSets#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: DataAwsSsoadminPermissionSetsState<Missing>, value: string) : DataAwsSsoadminPermissionSetsState<Present> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminPermissionSetsState<Present>)

        member _.Run(state: DataAwsSsoadminPermissionSetsState<Present>) : aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSets =
            let config = aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSetsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSets(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsoadminPermissionSets: missing required arguments. Must call: instance_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsoadminPermissionSetsState<_>) : aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSets =
            Unchecked.defaultof<aws.DataAwsSsoadminPermissionSets.DataAwsSsoadminPermissionSets>
