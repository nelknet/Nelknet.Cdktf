namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerControlState<'Name> = { assignments: ResizeArray<aws.AuditmanagerControl.AuditmanagerControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control">aws_auditmanager_control</a>.
    /// </summary>
    type AuditmanagerControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerControlState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerControlState<Missing>)

        member _.Zero(()) : AuditmanagerControlState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerControlState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#name-1">AuditmanagerControl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AuditmanagerControlState<Missing>, value: string) : AuditmanagerControlState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AuditmanagerControlState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#action_plan_instructions-1">AuditmanagerControl#action_plan_instructions</a>.
        /// </summary>
        [<CustomOperation "action_plan_instructions">]
        member _.ActionPlanInstructions(state: AuditmanagerControlState<'Name>, value: string) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.ActionPlanInstructions <- value)
            state : AuditmanagerControlState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#action_plan_title-1">AuditmanagerControl#action_plan_title</a>.
        /// </summary>
        [<CustomOperation "action_plan_title">]
        member _.ActionPlanTitle(state: AuditmanagerControlState<'Name>, value: string) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.ActionPlanTitle <- value)
            state : AuditmanagerControlState<'Name>

        /// <summary>
        /// control_mapping_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#control_mapping_sources-1">AuditmanagerControl#control_mapping_sources</a> Accepts: aws.IResolvable | aws.AuditmanagerControl.AuditmanagerControlControlMappingSources[]
        /// </summary>
        [<CustomOperation "control_mapping_sources">]
        member _.ControlMappingSources(state: AuditmanagerControlState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.ControlMappingSources <- value)
            state : AuditmanagerControlState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#description-1">AuditmanagerControl#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AuditmanagerControlState<'Name>, value: string) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AuditmanagerControlState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#tags-1">AuditmanagerControl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AuditmanagerControlState<'Name>, value: seq<string * string>) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AuditmanagerControlState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_control#testing_information-1">AuditmanagerControl#testing_information</a>.
        /// </summary>
        [<CustomOperation "testing_information">]
        member _.TestingInformation(state: AuditmanagerControlState<'Name>, value: string) : AuditmanagerControlState<'Name> =
            state.assignments.Add(fun config -> config.TestingInformation <- value)
            state : AuditmanagerControlState<'Name>

        member _.Run(state: AuditmanagerControlState<Present>) : aws.AuditmanagerControl.AuditmanagerControl =
            let config = aws.AuditmanagerControl.AuditmanagerControlConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerControl.AuditmanagerControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerControl: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerControlState<_>) : aws.AuditmanagerControl.AuditmanagerControl =
            Unchecked.defaultof<aws.AuditmanagerControl.AuditmanagerControl>
