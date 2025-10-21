namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance">azurerm_digital_twins_instance</a>.
    /// </summary>
    type DataAzurermDigitalTwinsInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDigitalTwinsInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDigitalTwinsInstanceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDigitalTwinsInstanceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDigitalTwinsInstanceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#name-1">DataAzurermDigitalTwinsInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDigitalTwinsInstanceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDigitalTwinsInstanceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDigitalTwinsInstanceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#resource_group_name-1">DataAzurermDigitalTwinsInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDigitalTwinsInstanceState<'Name, Missing>, value: string) : DataAzurermDigitalTwinsInstanceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDigitalTwinsInstanceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#id-1">DataAzurermDigitalTwinsInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/digital_twins_instance#timeouts-1">DataAzurermDigitalTwinsInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceTimeouts) : DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDigitalTwinsInstanceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDigitalTwinsInstanceState<Present, Present>) : azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstance =
            let config = azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDigitalTwinsInstance: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDigitalTwinsInstanceState<_, _>) : azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstance =
            Unchecked.defaultof<azurerm.DataAzurermDigitalTwinsInstance.DataAzurermDigitalTwinsInstance>
