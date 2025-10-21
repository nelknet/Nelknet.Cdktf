namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetappAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermNetappAccount.DataAzurermNetappAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account">azurerm_netapp_account</a>.
    /// </summary>
    type DataAzurermNetappAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetappAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetappAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetappAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account#name-1">DataAzurermNetappAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetappAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermNetappAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetappAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account#resource_group_name-1">DataAzurermNetappAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermNetappAccountState<'Name, Missing>, value: string) : DataAzurermNetappAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermNetappAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account#id-1">DataAzurermNetappAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetappAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermNetappAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetappAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account#identity-1">DataAzurermNetappAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DataAzurermNetappAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetappAccount.DataAzurermNetappAccountIdentity) : DataAzurermNetappAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DataAzurermNetappAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/netapp_account#timeouts-1">DataAzurermNetappAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetappAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermNetappAccount.DataAzurermNetappAccountTimeouts) : DataAzurermNetappAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetappAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermNetappAccountState<Present, Present>) : azurerm.DataAzurermNetappAccount.DataAzurermNetappAccount =
            let config = azurerm.DataAzurermNetappAccount.DataAzurermNetappAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetappAccount.DataAzurermNetappAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetappAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetappAccountState<_, _>) : azurerm.DataAzurermNetappAccount.DataAzurermNetappAccount =
            Unchecked.defaultof<azurerm.DataAzurermNetappAccount.DataAzurermNetappAccount>
