namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> = { assignments: ResizeArray<azurerm.BlueprintAssignment.BlueprintAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment">azurerm_blueprint_assignment</a>.
    /// </summary>
    type BlueprintAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : BlueprintAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BlueprintAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BlueprintAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BlueprintAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#identity-1">BlueprintAssignment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: BlueprintAssignmentState<Missing, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: azurerm.BlueprintAssignment.BlueprintAssignmentIdentity) : BlueprintAssignmentState<Present, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : BlueprintAssignmentState<Present, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#location-1">BlueprintAssignment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: BlueprintAssignmentState<'Identity, Missing, 'Name, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, Present, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : BlueprintAssignmentState<'Identity, Present, 'Name, 'TargetSubscriptionId, 'VersionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#name-1">BlueprintAssignment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BlueprintAssignmentState<'Identity, 'Location, Missing, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, Present, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BlueprintAssignmentState<'Identity, 'Location, Present, 'TargetSubscriptionId, 'VersionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#target_subscription_id-1">BlueprintAssignment#target_subscription_id</a>.
        /// </summary>
        [<CustomOperation "target_subscription_id">]
        member _.TargetSubscriptionId(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, Missing, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, Present, 'VersionId> =
            state.assignments.Add(fun config -> config.TargetSubscriptionId <- value)
            ({ assignments = state.assignments } : BlueprintAssignmentState<'Identity, 'Location, 'Name, Present, 'VersionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#version_id-1">BlueprintAssignment#version_id</a>.
        /// </summary>
        [<CustomOperation "version_id">]
        member _.VersionId(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, Missing>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, Present> =
            state.assignments.Add(fun config -> config.VersionId <- value)
            ({ assignments = state.assignments } : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#id-1">BlueprintAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#lock_exclude_actions-1">BlueprintAssignment#lock_exclude_actions</a>.
        /// </summary>
        [<CustomOperation "lock_exclude_actions">]
        member _.LockExcludeActions(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: seq<string>) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.LockExcludeActions <- (value |> Seq.toArray))
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#lock_exclude_principals-1">BlueprintAssignment#lock_exclude_principals</a>.
        /// </summary>
        [<CustomOperation "lock_exclude_principals">]
        member _.LockExcludePrincipals(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: seq<string>) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.LockExcludePrincipals <- (value |> Seq.toArray))
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#lock_mode-1">BlueprintAssignment#lock_mode</a>.
        /// </summary>
        [<CustomOperation "lock_mode">]
        member _.LockMode(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.LockMode <- value)
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#parameter_values-1">BlueprintAssignment#parameter_values</a>.
        /// </summary>
        [<CustomOperation "parameter_values">]
        member _.ParameterValues(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.ParameterValues <- value)
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#resource_groups-1">BlueprintAssignment#resource_groups</a>.
        /// </summary>
        [<CustomOperation "resource_groups">]
        member _.ResourceGroups(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: string) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.ResourceGroups <- value)
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/blueprint_assignment#timeouts-1">BlueprintAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>, value: azurerm.BlueprintAssignment.BlueprintAssignmentTimeouts) : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BlueprintAssignmentState<'Identity, 'Location, 'Name, 'TargetSubscriptionId, 'VersionId>

        member _.Run(state: BlueprintAssignmentState<Present, Present, Present, Present, Present>) : azurerm.BlueprintAssignment.BlueprintAssignment =
            let config = azurerm.BlueprintAssignment.BlueprintAssignmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.BlueprintAssignment.BlueprintAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.blueprintAssignment: missing required arguments. Must call: identity, location, name, target_subscription_id, version_id.", 9999, IsError = true)>]
        member _.Run(_: BlueprintAssignmentState<_, _, _, _, _>) : azurerm.BlueprintAssignment.BlueprintAssignment =
            Unchecked.defaultof<azurerm.BlueprintAssignment.BlueprintAssignment>
