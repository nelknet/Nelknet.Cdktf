namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataShareAccount.DataShareAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account">azurerm_data_share_account</a>.
    /// </summary>
    type DataShareAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataShareAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataShareAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataShareAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#identity-1">DataShareAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DataShareAccountState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataShareAccount.DataShareAccountIdentity) : DataShareAccountState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : DataShareAccountState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#location-1">DataShareAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataShareAccountState<'Identity, Missing, 'Name, 'ResourceGroupName>, value: string) : DataShareAccountState<'Identity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataShareAccountState<'Identity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#name-1">DataShareAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataShareAccountState<'Identity, 'Location, Missing, 'ResourceGroupName>, value: string) : DataShareAccountState<'Identity, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataShareAccountState<'Identity, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#resource_group_name-1">DataShareAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataShareAccountState<'Identity, 'Location, 'Name, Missing>, value: string) : DataShareAccountState<'Identity, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataShareAccountState<'Identity, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#id-1">DataShareAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: string) : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#tags-1">DataShareAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_share_account#timeouts-1">DataShareAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataShareAccount.DataShareAccountTimeouts) : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataShareAccountState<'Identity, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DataShareAccountState<Present, Present, Present, Present>) : azurerm.DataShareAccount.DataShareAccount =
            let config = azurerm.DataShareAccount.DataShareAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataShareAccount.DataShareAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataShareAccount: missing required arguments. Must call: identity, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataShareAccountState<_, _, _, _>) : azurerm.DataShareAccount.DataShareAccount =
            Unchecked.defaultof<azurerm.DataShareAccount.DataShareAccount>
