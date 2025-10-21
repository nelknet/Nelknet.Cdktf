namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPublicIpsState<'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPublicIps.DataAzurermPublicIpsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips">azurerm_public_ips</a>.
    /// </summary>
    type DataAzurermPublicIpsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPublicIpsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpsState<Missing>)

        member _.Zero(()) : DataAzurermPublicIpsState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPublicIpsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#resource_group_name-1">DataAzurermPublicIps#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPublicIpsState<Missing>, value: string) : DataAzurermPublicIpsState<Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPublicIpsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#allocation_type-1">DataAzurermPublicIps#allocation_type</a>.
        /// </summary>
        [<CustomOperation "allocation_type">]
        member _.AllocationType(state: DataAzurermPublicIpsState<'ResourceGroupName>, value: string) : DataAzurermPublicIpsState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllocationType <- value)
            state : DataAzurermPublicIpsState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#attachment_status-1">DataAzurermPublicIps#attachment_status</a>.
        /// </summary>
        [<CustomOperation "attachment_status">]
        member _.AttachmentStatus(state: DataAzurermPublicIpsState<'ResourceGroupName>, value: string) : DataAzurermPublicIpsState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AttachmentStatus <- value)
            state : DataAzurermPublicIpsState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#id-1">DataAzurermPublicIps#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPublicIpsState<'ResourceGroupName>, value: string) : DataAzurermPublicIpsState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPublicIpsState<'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#name_prefix-1">DataAzurermPublicIps#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAzurermPublicIpsState<'ResourceGroupName>, value: string) : DataAzurermPublicIpsState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAzurermPublicIpsState<'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/public_ips#timeouts-1">DataAzurermPublicIps#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPublicIpsState<'ResourceGroupName>, value: azurerm.DataAzurermPublicIps.DataAzurermPublicIpsTimeouts) : DataAzurermPublicIpsState<'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPublicIpsState<'ResourceGroupName>

        member _.Run(state: DataAzurermPublicIpsState<Present>) : azurerm.DataAzurermPublicIps.DataAzurermPublicIps =
            let config = azurerm.DataAzurermPublicIps.DataAzurermPublicIpsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPublicIps.DataAzurermPublicIps(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPublicIps: missing required arguments. Must call: resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPublicIpsState<_>) : azurerm.DataAzurermPublicIps.DataAzurermPublicIps =
            Unchecked.defaultof<azurerm.DataAzurermPublicIps.DataAzurermPublicIps>
