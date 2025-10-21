namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermIothubState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermIothub.DataAzurermIothubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub">azurerm_iothub</a>.
    /// </summary>
    type DataAzurermIothubBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermIothubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubState<Missing, Missing>)

        member _.Zero(()) : DataAzurermIothubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermIothubState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#name-1">DataAzurermIothub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermIothubState<Missing, 'ResourceGroupName>, value: string) : DataAzurermIothubState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermIothubState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#resource_group_name-1">DataAzurermIothub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermIothubState<'Name, Missing>, value: string) : DataAzurermIothubState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermIothubState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#id-1">DataAzurermIothub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermIothubState<'Name, 'ResourceGroupName>, value: string) : DataAzurermIothubState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermIothubState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#tags-1">DataAzurermIothub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermIothubState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermIothubState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermIothubState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub#timeouts-1">DataAzurermIothub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermIothubState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermIothub.DataAzurermIothubTimeouts) : DataAzurermIothubState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermIothubState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermIothubState<Present, Present>) : azurerm.DataAzurermIothub.DataAzurermIothub =
            let config = azurerm.DataAzurermIothub.DataAzurermIothubConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermIothub.DataAzurermIothub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermIothub: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermIothubState<_, _>) : azurerm.DataAzurermIothub.DataAzurermIothub =
            Unchecked.defaultof<azurerm.DataAzurermIothub.DataAzurermIothub>
