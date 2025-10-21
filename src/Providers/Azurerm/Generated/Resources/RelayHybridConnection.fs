namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.RelayHybridConnection.RelayHybridConnectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection">azurerm_relay_hybrid_connection</a>.
    /// </summary>
    type RelayHybridConnectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RelayHybridConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayHybridConnectionState<Missing, Missing, Missing>)

        member _.Zero(()) : RelayHybridConnectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayHybridConnectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#name-1">RelayHybridConnection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RelayHybridConnectionState<Missing, 'RelayNamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionState<Present, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionState<Present, 'RelayNamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#relay_namespace_name-1">RelayHybridConnection#relay_namespace_name</a>.
        /// </summary>
        [<CustomOperation "relay_namespace_name">]
        member _.RelayNamespaceName(state: RelayHybridConnectionState<'Name, Missing, 'ResourceGroupName>, value: string) : RelayHybridConnectionState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RelayNamespaceName <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#resource_group_name-1">RelayHybridConnection#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, Missing>, value: string) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionState<'Name, 'RelayNamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#id-1">RelayHybridConnection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#requires_client_authorization-1">RelayHybridConnection#requires_client_authorization</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_client_authorization">]
        member _.RequiresClientAuthorization(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>, value: bool) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RequiresClientAuthorization <- value)
            state : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#requires_client_authorization-1">RelayHybridConnection#requires_client_authorization</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "requires_client_authorization">]
        member _.RequiresClientAuthorization(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RequiresClientAuthorization <- value)
            state : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#timeouts-1">RelayHybridConnection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>, value: azurerm.RelayHybridConnection.RelayHybridConnectionTimeouts) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection#user_metadata-1">RelayHybridConnection#user_metadata</a>.
        /// </summary>
        [<CustomOperation "user_metadata">]
        member _.UserMetadata(state: RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UserMetadata <- value)
            state : RelayHybridConnectionState<'Name, 'RelayNamespaceName, 'ResourceGroupName>

        member _.Run(state: RelayHybridConnectionState<Present, Present, Present>) : azurerm.RelayHybridConnection.RelayHybridConnection =
            let config = azurerm.RelayHybridConnection.RelayHybridConnectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.RelayHybridConnection.RelayHybridConnection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.relayHybridConnection: missing required arguments. Must call: name, relay_namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: RelayHybridConnectionState<_, _, _>) : azurerm.RelayHybridConnection.RelayHybridConnection =
            Unchecked.defaultof<azurerm.RelayHybridConnection.RelayHybridConnection>
