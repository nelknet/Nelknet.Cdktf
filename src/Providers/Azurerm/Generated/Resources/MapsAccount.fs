namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.MapsAccount.MapsAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account">azurerm_maps_account</a>.
    /// </summary>
    type MapsAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : MapsAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MapsAccountState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MapsAccountState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MapsAccountState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#location-1">MapsAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MapsAccountState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : MapsAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MapsAccountState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#name-1">MapsAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MapsAccountState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : MapsAccountState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MapsAccountState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#resource_group_name-1">MapsAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MapsAccountState<'Location, 'Name, Missing, 'SkuName>, value: string) : MapsAccountState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MapsAccountState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#sku_name-1">MapsAccount#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : MapsAccountState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// cors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#cors-1">MapsAccount#cors</a>
        /// </summary>
        [<CustomOperation "cors">]
        member _.Cors(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.MapsAccount.MapsAccountCors) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Cors <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// data_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#data_store-1">MapsAccount#data_store</a> Accepts: azurerm.IResolvable | azurerm.MapsAccount.MapsAccountDataStore[]
        /// </summary>
        [<CustomOperation "data_store">]
        member _.DataStore(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.DataStore <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#id-1">MapsAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#identity-1">MapsAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.MapsAccount.MapsAccountIdentity) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#local_authentication_enabled-1">MapsAccount#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#local_authentication_enabled-1">MapsAccount#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#tags-1">MapsAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maps_account#timeouts-1">MapsAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.MapsAccount.MapsAccountTimeouts) : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MapsAccountState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: MapsAccountState<Present, Present, Present, Present>) : azurerm.MapsAccount.MapsAccount =
            let config = azurerm.MapsAccount.MapsAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.MapsAccount.MapsAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mapsAccount: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: MapsAccountState<_, _, _, _>) : azurerm.MapsAccount.MapsAccount =
            Unchecked.defaultof<azurerm.MapsAccount.MapsAccount>
