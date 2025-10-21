namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermHealthcareService.DataAzurermHealthcareServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service">azurerm_healthcare_service</a>.
    /// </summary>
    type DataAzurermHealthcareServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermHealthcareServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermHealthcareServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermHealthcareServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#location-1">DataAzurermHealthcareService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataAzurermHealthcareServiceState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermHealthcareServiceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareServiceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#name-1">DataAzurermHealthcareService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermHealthcareServiceState<'Location, Missing, 'ResourceGroupName>, value: string) : DataAzurermHealthcareServiceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareServiceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#resource_group_name-1">DataAzurermHealthcareService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermHealthcareServiceState<'Location, 'Name, Missing>, value: string) : DataAzurermHealthcareServiceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermHealthcareServiceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#id-1">DataAzurermHealthcareService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/healthcare_service#timeouts-1">DataAzurermHealthcareService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermHealthcareService.DataAzurermHealthcareServiceTimeouts) : DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermHealthcareServiceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermHealthcareServiceState<Present, Present, Present>) : azurerm.DataAzurermHealthcareService.DataAzurermHealthcareService =
            let config = azurerm.DataAzurermHealthcareService.DataAzurermHealthcareServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermHealthcareService.DataAzurermHealthcareService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermHealthcareService: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermHealthcareServiceState<_, _, _>) : azurerm.DataAzurermHealthcareService.DataAzurermHealthcareService =
            Unchecked.defaultof<azurerm.DataAzurermHealthcareService.DataAzurermHealthcareService>
