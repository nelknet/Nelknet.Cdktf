namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudAccelerator.SpringCloudAcceleratorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_accelerator">azurerm_spring_cloud_accelerator</a>.
    /// </summary>
    type SpringCloudAcceleratorBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAcceleratorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAcceleratorState<Missing, Missing>)

        member _.Zero(()) : SpringCloudAcceleratorState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAcceleratorState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_accelerator#name-1">SpringCloudAccelerator#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAcceleratorState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudAcceleratorState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAcceleratorState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_accelerator#spring_cloud_service_id-1">SpringCloudAccelerator#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudAcceleratorState<'Name, Missing>, value: string) : SpringCloudAcceleratorState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudAcceleratorState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_accelerator#id-1">SpringCloudAccelerator#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_accelerator#timeouts-1">SpringCloudAccelerator#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudAccelerator.SpringCloudAcceleratorTimeouts) : SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAcceleratorState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudAcceleratorState<Present, Present>) : azurerm.SpringCloudAccelerator.SpringCloudAccelerator =
            let config = azurerm.SpringCloudAccelerator.SpringCloudAcceleratorConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudAccelerator.SpringCloudAccelerator(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudAccelerator: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAcceleratorState<_, _>) : azurerm.SpringCloudAccelerator.SpringCloudAccelerator =
            Unchecked.defaultof<azurerm.SpringCloudAccelerator.SpringCloudAccelerator>
