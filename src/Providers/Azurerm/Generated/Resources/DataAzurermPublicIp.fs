namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPublicIpState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPublicIp.DataAzurermPublicIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip">azurerm_public_ip</a>.
    /// </summary>
    type DataAzurermPublicIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPublicIpState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPublicIpState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#name-1">DataAzurermPublicIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPublicIpState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPublicIpState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPublicIpState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#resource_group_name-1">DataAzurermPublicIp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPublicIpState<'Name, Missing>, value: string) : DataAzurermPublicIpState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPublicIpState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#id-1">DataAzurermPublicIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPublicIpState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPublicIpState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPublicIpState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ip#timeouts-1">DataAzurermPublicIp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPublicIpState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPublicIp.DataAzurermPublicIpTimeouts) : DataAzurermPublicIpState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPublicIpState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPublicIpState<Present, Present>) : azurerm.DataAzurermPublicIp.DataAzurermPublicIp =
            let config = azurerm.DataAzurermPublicIp.DataAzurermPublicIpConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPublicIp.DataAzurermPublicIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPublicIp: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPublicIpState<_, _>) : azurerm.DataAzurermPublicIp.DataAzurermPublicIp =
            Unchecked.defaultof<azurerm.DataAzurermPublicIp.DataAzurermPublicIp>
