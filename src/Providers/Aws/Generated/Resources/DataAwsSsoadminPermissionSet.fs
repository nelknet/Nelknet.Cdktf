namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminPermissionSetState<'InstanceArn> = { assignments: ResizeArray<aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set">aws_ssoadmin_permission_set</a>.
    /// </summary>
    type DataAwsSsoadminPermissionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminPermissionSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPermissionSetState<Missing>)

        member _.Zero(()) : DataAwsSsoadminPermissionSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPermissionSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set#instance_arn-1">DataAwsSsoadminPermissionSet#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: DataAwsSsoadminPermissionSetState<Missing>, value: string) : DataAwsSsoadminPermissionSetState<Present> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminPermissionSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set#arn-1">DataAwsSsoadminPermissionSet#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSsoadminPermissionSetState<'InstanceArn>, value: string) : DataAwsSsoadminPermissionSetState<'InstanceArn> =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsSsoadminPermissionSetState<'InstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set#id-1">DataAwsSsoadminPermissionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSsoadminPermissionSetState<'InstanceArn>, value: string) : DataAwsSsoadminPermissionSetState<'InstanceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSsoadminPermissionSetState<'InstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set#name-1">DataAwsSsoadminPermissionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSsoadminPermissionSetState<'InstanceArn>, value: string) : DataAwsSsoadminPermissionSetState<'InstanceArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsSsoadminPermissionSetState<'InstanceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_permission_set#tags-1">DataAwsSsoadminPermissionSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSsoadminPermissionSetState<'InstanceArn>, value: seq<string * string>) : DataAwsSsoadminPermissionSetState<'InstanceArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSsoadminPermissionSetState<'InstanceArn>

        member _.Run(state: DataAwsSsoadminPermissionSetState<Present>) : aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSet =
            let config = aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsoadminPermissionSet: missing required arguments. Must call: instance_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsoadminPermissionSetState<_>) : aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSet =
            Unchecked.defaultof<aws.DataAwsSsoadminPermissionSet.DataAwsSsoadminPermissionSet>
