namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId> = { assignments: ResizeArray<aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target">aws_ssm_maintenance_window_target</a>.
    /// </summary>
    type SsmMaintenanceWindowTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmMaintenanceWindowTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowTargetState<Missing, Missing, Missing>)

        member _.Zero(()) : SsmMaintenanceWindowTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmMaintenanceWindowTargetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#resource_type-1">SsmMaintenanceWindowTarget#resource_type</a>.
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: SsmMaintenanceWindowTargetState<Missing, 'Targets, 'WindowId>, value: string) : SsmMaintenanceWindowTargetState<Present, 'Targets, 'WindowId> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTargetState<Present, 'Targets, 'WindowId>)

        /// <summary>
        /// targets block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#targets-1">SsmMaintenanceWindowTarget#targets</a> Accepts: aws.IResolvable | aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTargetTargets[]
        /// </summary>
        [<CustomOperation "targets">]
        member _.Targets(state: SsmMaintenanceWindowTargetState<'ResourceType, Missing, 'WindowId>, value: HashiCorp.Cdktf.IResolvable) : SsmMaintenanceWindowTargetState<'ResourceType, Present, 'WindowId> =
            state.assignments.Add(fun config -> config.Targets <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTargetState<'ResourceType, Present, 'WindowId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#window_id-1">SsmMaintenanceWindowTarget#window_id</a>.
        /// </summary>
        [<CustomOperation "window_id">]
        member _.WindowId(state: SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, Missing>, value: string) : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, Present> =
            state.assignments.Add(fun config -> config.WindowId <- value)
            ({ assignments = state.assignments } : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#description-1">SsmMaintenanceWindowTarget#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>, value: string) : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#id-1">SsmMaintenanceWindowTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>, value: string) : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#name-1">SsmMaintenanceWindowTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>, value: string) : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_maintenance_window_target#owner_information-1">SsmMaintenanceWindowTarget#owner_information</a>.
        /// </summary>
        [<CustomOperation "owner_information">]
        member _.OwnerInformation(state: SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>, value: string) : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId> =
            state.assignments.Add(fun config -> config.OwnerInformation <- value)
            state : SsmMaintenanceWindowTargetState<'ResourceType, 'Targets, 'WindowId>

        member _.Run(state: SsmMaintenanceWindowTargetState<Present, Present, Present>) : aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTarget =
            let config = aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTargetConfig()
            for setter in state.assignments do
                setter config
            aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmMaintenanceWindowTarget: missing required arguments. Must call: resource_type, targets, window_id.", 9999, IsError = true)>]
        member _.Run(_: SsmMaintenanceWindowTargetState<_, _, _>) : aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTarget =
            Unchecked.defaultof<aws.SsmMaintenanceWindowTarget.SsmMaintenanceWindowTarget>
