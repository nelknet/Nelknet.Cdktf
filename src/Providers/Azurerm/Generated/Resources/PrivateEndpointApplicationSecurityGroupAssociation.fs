namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId> = { assignments: ResizeArray<azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint_application_security_group_association">azurerm_private_endpoint_application_security_group_association</a>.
    /// </summary>
    type PrivateEndpointApplicationSecurityGroupAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PrivateEndpointApplicationSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateEndpointApplicationSecurityGroupAssociationState<Missing, Missing>)

        member _.Zero(()) : PrivateEndpointApplicationSecurityGroupAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : PrivateEndpointApplicationSecurityGroupAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint_application_security_group_association#application_security_group_id-1">PrivateEndpointApplicationSecurityGroupAssociation#application_security_group_id</a>.
        /// </summary>
        [<CustomOperation "application_security_group_id">]
        member _.ApplicationSecurityGroupId(state: PrivateEndpointApplicationSecurityGroupAssociationState<Missing, 'PrivateEndpointId>, value: string) : PrivateEndpointApplicationSecurityGroupAssociationState<Present, 'PrivateEndpointId> =
            state.assignments.Add(fun config -> config.ApplicationSecurityGroupId <- value)
            ({ assignments = state.assignments } : PrivateEndpointApplicationSecurityGroupAssociationState<Present, 'PrivateEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint_application_security_group_association#private_endpoint_id-1">PrivateEndpointApplicationSecurityGroupAssociation#private_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "private_endpoint_id">]
        member _.PrivateEndpointId(state: PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Missing>, value: string) : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.PrivateEndpointId <- value)
            ({ assignments = state.assignments } : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint_application_security_group_association#id-1">PrivateEndpointApplicationSecurityGroupAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId>, value: string) : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint_application_security_group_association#timeouts-1">PrivateEndpointApplicationSecurityGroupAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId>, value: azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociationTimeouts) : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PrivateEndpointApplicationSecurityGroupAssociationState<'ApplicationSecurityGroupId, 'PrivateEndpointId>

        member _.Run(state: PrivateEndpointApplicationSecurityGroupAssociationState<Present, Present>) : azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociation =
            let config = azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.privateEndpointApplicationSecurityGroupAssociation: missing required arguments. Must call: application_security_group_id, private_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: PrivateEndpointApplicationSecurityGroupAssociationState<_, _>) : azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociation =
            Unchecked.defaultof<azurerm.PrivateEndpointApplicationSecurityGroupAssociation.PrivateEndpointApplicationSecurityGroupAssociation>
