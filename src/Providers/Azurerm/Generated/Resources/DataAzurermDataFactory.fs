namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataFactoryState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDataFactory.DataAzurermDataFactoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory">azurerm_data_factory</a>.
    /// </summary>
    type DataAzurermDataFactoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataFactoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataFactoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataFactoryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#name-1">DataAzurermDataFactory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataFactoryState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDataFactoryState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataFactoryState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#resource_group_name-1">DataAzurermDataFactory#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDataFactoryState<'Name, Missing>, value: string) : DataAzurermDataFactoryState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDataFactoryState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#id-1">DataAzurermDataFactory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataFactoryState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDataFactoryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataFactoryState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory#timeouts-1">DataAzurermDataFactory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataFactoryState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDataFactory.DataAzurermDataFactoryTimeouts) : DataAzurermDataFactoryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataFactoryState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDataFactoryState<Present, Present>) : azurerm.DataAzurermDataFactory.DataAzurermDataFactory =
            let config = azurerm.DataAzurermDataFactory.DataAzurermDataFactoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataFactory.DataAzurermDataFactory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataFactory: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataFactoryState<_, _>) : azurerm.DataAzurermDataFactory.DataAzurermDataFactory =
            Unchecked.defaultof<azurerm.DataAzurermDataFactory.DataAzurermDataFactory>
