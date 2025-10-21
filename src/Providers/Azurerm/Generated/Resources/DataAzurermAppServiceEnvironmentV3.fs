namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3">azurerm_app_service_environment_v3</a>.
    /// </summary>
    type DataAzurermAppServiceEnvironmentV3Builder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppServiceEnvironmentV3State<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceEnvironmentV3State<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppServiceEnvironmentV3State<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceEnvironmentV3State<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#name-1">DataAzurermAppServiceEnvironmentV3#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAppServiceEnvironmentV3State<Missing, 'ResourceGroupName>, value: string) : DataAzurermAppServiceEnvironmentV3State<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceEnvironmentV3State<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#resource_group_name-1">DataAzurermAppServiceEnvironmentV3#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAppServiceEnvironmentV3State<'Name, Missing>, value: string) : DataAzurermAppServiceEnvironmentV3State<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceEnvironmentV3State<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#id-1">DataAzurermAppServiceEnvironmentV3#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName>, value: string) : DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#timeouts-1">DataAzurermAppServiceEnvironmentV3#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Timeouts) : DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppServiceEnvironmentV3State<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAppServiceEnvironmentV3State<Present, Present>) : azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3 =
            let config = azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Config()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppServiceEnvironmentV3: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppServiceEnvironmentV3State<_, _>) : azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3 =
            Unchecked.defaultof<azurerm.DataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3>
