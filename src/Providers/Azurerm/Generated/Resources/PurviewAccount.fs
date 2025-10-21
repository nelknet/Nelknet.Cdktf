namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.PurviewAccount.PurviewAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account">azurerm_purview_account</a>.
    /// </summary>
    type PurviewAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : PurviewAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PurviewAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PurviewAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PurviewAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#identity-1">PurviewAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: PurviewAccountState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.PurviewAccount.PurviewAccountIdentity) : PurviewAccountState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : PurviewAccountState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#location-1">PurviewAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PurviewAccountState<'Identity, Missing, 'Name, 'ResourceGroupName>, value: string) : PurviewAccountState<'Identity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PurviewAccountState<'Identity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#name-1">PurviewAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PurviewAccountState<'Identity, 'Location, Missing, 'ResourceGroupName>, value: string) : PurviewAccountState<'Identity, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PurviewAccountState<'Identity, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#resource_group_name-1">PurviewAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PurviewAccountState<'Identity, 'Location, 'Name, Missing>, value: string) : PurviewAccountState<'Identity, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PurviewAccountState<'Identity, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#id-1">PurviewAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#managed_resource_group_name-1">PurviewAccount#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#public_network_enabled-1">PurviewAccount#public_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_enabled">]
        member _.PublicNetworkEnabled(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: bool) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkEnabled <- value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#public_network_enabled-1">PurviewAccount#public_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_enabled">]
        member _.PublicNetworkEnabled(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkEnabled <- value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#tags-1">PurviewAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/purview_account#timeouts-1">PurviewAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.PurviewAccount.PurviewAccountTimeouts) : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PurviewAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: PurviewAccountState<Present, Present, Present, Present>) : azurerm.PurviewAccount.PurviewAccount =
            let config = azurerm.PurviewAccount.PurviewAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.PurviewAccount.PurviewAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.purviewAccount: missing required arguments. Must call: identity, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: PurviewAccountState<_, _, _, _>) : azurerm.PurviewAccount.PurviewAccount =
            Unchecked.defaultof<azurerm.PurviewAccount.PurviewAccount>
