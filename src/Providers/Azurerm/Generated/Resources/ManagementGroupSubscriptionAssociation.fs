namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId> = { assignments: ResizeArray<azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_subscription_association">azurerm_management_group_subscription_association</a>.
    /// </summary>
    type ManagementGroupSubscriptionAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ManagementGroupSubscriptionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupSubscriptionAssociationState<Missing, Missing>)

        member _.Zero(()) : ManagementGroupSubscriptionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ManagementGroupSubscriptionAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_subscription_association#management_group_id-1">ManagementGroupSubscriptionAssociation#management_group_id</a>.
        /// </summary>
        [<CustomOperation "management_group_id">]
        member _.ManagementGroupId(state: ManagementGroupSubscriptionAssociationState<Missing, 'SubscriptionId>, value: string) : ManagementGroupSubscriptionAssociationState<Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ManagementGroupId <- value)
            ({ assignments = state.assignments } : ManagementGroupSubscriptionAssociationState<Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_subscription_association#subscription_id-1">ManagementGroupSubscriptionAssociation#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: ManagementGroupSubscriptionAssociationState<'ManagementGroupId, Missing>, value: string) : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_subscription_association#id-1">ManagementGroupSubscriptionAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId>, value: string) : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/management_group_subscription_association#timeouts-1">ManagementGroupSubscriptionAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId>, value: azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociationTimeouts) : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ManagementGroupSubscriptionAssociationState<'ManagementGroupId, 'SubscriptionId>

        member _.Run(state: ManagementGroupSubscriptionAssociationState<Present, Present>) : azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociation =
            let config = azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.managementGroupSubscriptionAssociation: missing required arguments. Must call: management_group_id, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: ManagementGroupSubscriptionAssociationState<_, _>) : azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociation =
            Unchecked.defaultof<azurerm.ManagementGroupSubscriptionAssociation.ManagementGroupSubscriptionAssociation>
