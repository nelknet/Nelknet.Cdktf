namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix">azurerm_public_ip_prefix</a>.
    /// </summary>
    type DataAzurermPublicIpPrefixBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPublicIpPrefixState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpPrefixState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPublicIpPrefixState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpPrefixState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#name-1">DataAzurermPublicIpPrefix#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPublicIpPrefixState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPublicIpPrefixState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPublicIpPrefixState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#resource_group_name-1">DataAzurermPublicIpPrefix#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPublicIpPrefixState<'Name, Missing>, value: string) : DataAzurermPublicIpPrefixState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPublicIpPrefixState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#id-1">DataAzurermPublicIpPrefix#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip_prefix#timeouts-1">DataAzurermPublicIpPrefix#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixTimeouts) : DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPublicIpPrefixState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPublicIpPrefixState<Present, Present>) : azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefix =
            let config = azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefixConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefix(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPublicIpPrefix: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPublicIpPrefixState<_, _>) : azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefix =
            Unchecked.defaultof<azurerm.DataAzurermPublicIpPrefix.DataAzurermPublicIpPrefix>
