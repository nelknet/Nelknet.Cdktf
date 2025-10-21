namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIothubDpsState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIothubDps.DataAzurermIothubDpsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps">azurerm_iothub_dps</a>.
    /// </summary>
    type DataAzurermIothubDpsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIothubDpsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubDpsState<Missing, Missing>)

        member _.Zero(()) : DataAzurermIothubDpsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubDpsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps#name-1">DataAzurermIothubDps#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIothubDpsState<Missing, 'ResourceGroupName>, value: string) : DataAzurermIothubDpsState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIothubDpsState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps#resource_group_name-1">DataAzurermIothubDps#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIothubDpsState<'Name, Missing>, value: string) : DataAzurermIothubDpsState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubDpsState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps#id-1">DataAzurermIothubDps#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIothubDpsState<'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubDpsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIothubDpsState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps#tags-1">DataAzurermIothubDps#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermIothubDpsState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermIothubDpsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermIothubDpsState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_dps#timeouts-1">DataAzurermIothubDps#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIothubDpsState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIothubDps.DataAzurermIothubDpsTimeouts) : DataAzurermIothubDpsState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIothubDpsState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIothubDpsState<Present, Present>) : azurerm.DataAzurermIothubDps.DataAzurermIothubDps =
            let config = azurerm.DataAzurermIothubDps.DataAzurermIothubDpsConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIothubDps.DataAzurermIothubDps(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIothubDps: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIothubDpsState<_, _>) : azurerm.DataAzurermIothubDps.DataAzurermIothubDps =
            Unchecked.defaultof<azurerm.DataAzurermIothubDps.DataAzurermIothubDps>
