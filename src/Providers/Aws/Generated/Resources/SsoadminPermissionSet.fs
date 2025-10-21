namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminPermissionSetState<'InstanceArn, 'Name> = { assignments: ResizeArray<aws.SsoadminPermissionSet.SsoadminPermissionSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set">aws_ssoadmin_permission_set</a>.
    /// </summary>
    type SsoadminPermissionSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminPermissionSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionSetState<Missing, Missing>)

        member _.Zero(()) : SsoadminPermissionSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminPermissionSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#instance_arn-1">SsoadminPermissionSet#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminPermissionSetState<Missing, 'Name>, value: string) : SsoadminPermissionSetState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminPermissionSetState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#name-1">SsoadminPermissionSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsoadminPermissionSetState<'InstanceArn, Missing>, value: string) : SsoadminPermissionSetState<'InstanceArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsoadminPermissionSetState<'InstanceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#description-1">SsoadminPermissionSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: string) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#id-1">SsoadminPermissionSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: string) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#relay_state-1">SsoadminPermissionSet#relay_state</a>.
        /// </summary>
        [<CustomOperation "relay_state">]
        member _.RelayState(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: string) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.RelayState <- value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#session_duration-1">SsoadminPermissionSet#session_duration</a>.
        /// </summary>
        [<CustomOperation "session_duration">]
        member _.SessionDuration(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: string) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.SessionDuration <- value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#tags-1">SsoadminPermissionSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: seq<string * string>) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#tags_all-1">SsoadminPermissionSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: seq<string * string>) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_permission_set#timeouts-1">SsoadminPermissionSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminPermissionSetState<'InstanceArn, 'Name>, value: aws.SsoadminPermissionSet.SsoadminPermissionSetTimeouts) : SsoadminPermissionSetState<'InstanceArn, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminPermissionSetState<'InstanceArn, 'Name>

        member _.Run(state: SsoadminPermissionSetState<Present, Present>) : aws.SsoadminPermissionSet.SsoadminPermissionSet =
            let config = aws.SsoadminPermissionSet.SsoadminPermissionSetConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminPermissionSet.SsoadminPermissionSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminPermissionSet: missing required arguments. Must call: instance_arn, name.", 9999, IsError = true)>]
        member _.Run(_: SsoadminPermissionSetState<_, _>) : aws.SsoadminPermissionSet.SsoadminPermissionSet =
            Unchecked.defaultof<aws.SsoadminPermissionSet.SsoadminPermissionSet>
