namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> = { assignments: ResizeArray<aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group">aws_route53recoveryreadiness_recovery_group</a>.
    /// </summary>
    type Route53RecoveryreadinessRecoveryGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoveryreadinessRecoveryGroupState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessRecoveryGroupState<Missing>)

        member _.Zero(()) : Route53RecoveryreadinessRecoveryGroupState<Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessRecoveryGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#recovery_group_name-1">Route53RecoveryreadinessRecoveryGroup#recovery_group_name</a>.
        /// </summary>
        [<CustomOperation "recovery_group_name">]
        member _.RecoveryGroupName(state: Route53RecoveryreadinessRecoveryGroupState<Missing>, value: string) : Route53RecoveryreadinessRecoveryGroupState<Present> =
            state.assignments.Add(fun config -> config.RecoveryGroupName <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessRecoveryGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#cells-1">Route53RecoveryreadinessRecoveryGroup#cells</a>.
        /// </summary>
        [<CustomOperation "cells">]
        member _.Cells(state: Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>, value: seq<string>) : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> =
            state.assignments.Add(fun config -> config.Cells <- (value |> Seq.toArray))
            state : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#id-1">Route53RecoveryreadinessRecoveryGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>, value: string) : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#tags-1">Route53RecoveryreadinessRecoveryGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>, value: seq<string * string>) : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#tags_all-1">Route53RecoveryreadinessRecoveryGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>, value: seq<string * string>) : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_recovery_group#timeouts-1">Route53RecoveryreadinessRecoveryGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>, value: aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroupTimeouts) : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecoveryreadinessRecoveryGroupState<'RecoveryGroupName>

        member _.Run(state: Route53RecoveryreadinessRecoveryGroupState<Present>) : aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroup =
            let config = aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroupConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoveryreadinessRecoveryGroup: missing required arguments. Must call: recovery_group_name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoveryreadinessRecoveryGroupState<_>) : aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroup =
            Unchecked.defaultof<aws.Route53RecoveryreadinessRecoveryGroup.Route53RecoveryreadinessRecoveryGroup>
