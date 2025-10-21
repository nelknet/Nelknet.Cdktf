namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId> = { assignments: ResizeArray<azurerm.IotcentralOrganization.IotcentralOrganizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization">azurerm_iotcentral_organization</a>.
    /// </summary>
    type IotcentralOrganizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotcentralOrganizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotcentralOrganizationState<Missing, Missing, Missing>)

        member _.Zero(()) : IotcentralOrganizationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotcentralOrganizationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#display_name-1">IotcentralOrganization#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: IotcentralOrganizationState<Missing, 'IotcentralApplicationId, 'OrganizationId>, value: string) : IotcentralOrganizationState<Present, 'IotcentralApplicationId, 'OrganizationId> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            ({ assignments = state.assignments } : IotcentralOrganizationState<Present, 'IotcentralApplicationId, 'OrganizationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#iotcentral_application_id-1">IotcentralOrganization#iotcentral_application_id</a>.
        /// </summary>
        [<CustomOperation "iotcentral_application_id">]
        member _.IotcentralApplicationId(state: IotcentralOrganizationState<'DisplayName, Missing, 'OrganizationId>, value: string) : IotcentralOrganizationState<'DisplayName, Present, 'OrganizationId> =
            state.assignments.Add(fun config -> config.IotcentralApplicationId <- value)
            ({ assignments = state.assignments } : IotcentralOrganizationState<'DisplayName, Present, 'OrganizationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#organization_id-1">IotcentralOrganization#organization_id</a>.
        /// </summary>
        [<CustomOperation "organization_id">]
        member _.OrganizationId(state: IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, Missing>, value: string) : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, Present> =
            state.assignments.Add(fun config -> config.OrganizationId <- value)
            ({ assignments = state.assignments } : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#id-1">IotcentralOrganization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>, value: string) : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#parent_organization_id-1">IotcentralOrganization#parent_organization_id</a>.
        /// </summary>
        [<CustomOperation "parent_organization_id">]
        member _.ParentOrganizationId(state: IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>, value: string) : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId> =
            state.assignments.Add(fun config -> config.ParentOrganizationId <- value)
            state : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_organization#timeouts-1">IotcentralOrganization#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>, value: azurerm.IotcentralOrganization.IotcentralOrganizationTimeouts) : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotcentralOrganizationState<'DisplayName, 'IotcentralApplicationId, 'OrganizationId>

        member _.Run(state: IotcentralOrganizationState<Present, Present, Present>) : azurerm.IotcentralOrganization.IotcentralOrganization =
            let config = azurerm.IotcentralOrganization.IotcentralOrganizationConfig()
            for setter in state.assignments do
                setter config
            azurerm.IotcentralOrganization.IotcentralOrganization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iotcentralOrganization: missing required arguments. Must call: display_name, iotcentral_application_id, organization_id.", 9999, IsError = true)>]
        member _.Run(_: IotcentralOrganizationState<_, _, _>) : azurerm.IotcentralOrganization.IotcentralOrganization =
            Unchecked.defaultof<azurerm.IotcentralOrganization.IotcentralOrganization>
