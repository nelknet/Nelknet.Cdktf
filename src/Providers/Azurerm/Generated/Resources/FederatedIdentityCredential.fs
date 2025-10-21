namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject> = { assignments: ResizeArray<azurerm.FederatedIdentityCredential.FederatedIdentityCredentialConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential">azurerm_federated_identity_credential</a>.
    /// </summary>
    type FederatedIdentityCredentialBuilder(logicalId: string) =
        member _.Yield(_: unit) : FederatedIdentityCredentialState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FederatedIdentityCredentialState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FederatedIdentityCredentialState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FederatedIdentityCredentialState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#audience-1">FederatedIdentityCredential#audience</a>.
        /// </summary>
        [<CustomOperation "audience">]
        member _.Audience(state: FederatedIdentityCredentialState<Missing, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>, value: seq<string>) : FederatedIdentityCredentialState<Present, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.Audience <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<Present, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#issuer-1">FederatedIdentityCredential#issuer</a>.
        /// </summary>
        [<CustomOperation "issuer">]
        member _.Issuer(state: FederatedIdentityCredentialState<'Audience, Missing, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>, value: string) : FederatedIdentityCredentialState<'Audience, Present, 'Name, 'ParentId, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.Issuer <- value)
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<'Audience, Present, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#name-1">FederatedIdentityCredential#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FederatedIdentityCredentialState<'Audience, 'Issuer, Missing, 'ParentId, 'ResourceGroupName, 'Subject>, value: string) : FederatedIdentityCredentialState<'Audience, 'Issuer, Present, 'ParentId, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<'Audience, 'Issuer, Present, 'ParentId, 'ResourceGroupName, 'Subject>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#parent_id-1">FederatedIdentityCredential#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, Missing, 'ResourceGroupName, 'Subject>, value: string) : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, Present, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, Present, 'ResourceGroupName, 'Subject>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#resource_group_name-1">FederatedIdentityCredential#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, Missing, 'Subject>, value: string) : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, Present, 'Subject> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, Present, 'Subject>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#subject-1">FederatedIdentityCredential#subject</a>.
        /// </summary>
        [<CustomOperation "subject">]
        member _.Subject(state: FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, Missing>, value: string) : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Subject <- value)
            ({ assignments = state.assignments } : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#id-1">FederatedIdentityCredential#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>, value: string) : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/federated_identity_credential#timeouts-1">FederatedIdentityCredential#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>, value: azurerm.FederatedIdentityCredential.FederatedIdentityCredentialTimeouts) : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FederatedIdentityCredentialState<'Audience, 'Issuer, 'Name, 'ParentId, 'ResourceGroupName, 'Subject>

        member _.Run(state: FederatedIdentityCredentialState<Present, Present, Present, Present, Present, Present>) : azurerm.FederatedIdentityCredential.FederatedIdentityCredential =
            let config = azurerm.FederatedIdentityCredential.FederatedIdentityCredentialConfig()
            for setter in state.assignments do
                setter config
            azurerm.FederatedIdentityCredential.FederatedIdentityCredential(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.federatedIdentityCredential: missing required arguments. Must call: audience, issuer, name, parent_id, resource_group_name, subject.", 9999, IsError = true)>]
        member _.Run(_: FederatedIdentityCredentialState<_, _, _, _, _, _>) : azurerm.FederatedIdentityCredential.FederatedIdentityCredential =
            Unchecked.defaultof<azurerm.FederatedIdentityCredential.FederatedIdentityCredential>
