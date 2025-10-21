namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetappAccountState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NetappAccount.NetappAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account">azurerm_netapp_account</a>.
    /// </summary>
    type NetappAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetappAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappAccountState<Missing, Missing, Missing>)

        member _.Zero(()) : NetappAccountState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetappAccountState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#location-1">NetappAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NetappAccountState<Missing, 'Name, 'ResourceGroupName>, value: string) : NetappAccountState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NetappAccountState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#name-1">NetappAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetappAccountState<'Location, Missing, 'ResourceGroupName>, value: string) : NetappAccountState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetappAccountState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#resource_group_name-1">NetappAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NetappAccountState<'Location, 'Name, Missing>, value: string) : NetappAccountState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NetappAccountState<'Location, 'Name, Present>)

        /// <summary>
        /// active_directory block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#active_directory-1">NetappAccount#active_directory</a>
        /// </summary>
        [<CustomOperation "active_directory">]
        member _.ActiveDirectory(state: NetappAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappAccount.NetappAccountActiveDirectory) : NetappAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ActiveDirectory <- value)
            state : NetappAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#id-1">NetappAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetappAccountState<'Location, 'Name, 'ResourceGroupName>, value: string) : NetappAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetappAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#identity-1">NetappAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: NetappAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappAccount.NetappAccountIdentity) : NetappAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : NetappAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#tags-1">NetappAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NetappAccountState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : NetappAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NetappAccountState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_account#timeouts-1">NetappAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetappAccountState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.NetappAccount.NetappAccountTimeouts) : NetappAccountState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetappAccountState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: NetappAccountState<Present, Present, Present>) : azurerm.NetappAccount.NetappAccount =
            let config = azurerm.NetappAccount.NetappAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetappAccount.NetappAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.netappAccount: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NetappAccountState<_, _, _>) : azurerm.NetappAccount.NetappAccount =
            Unchecked.defaultof<azurerm.NetappAccount.NetappAccount>
