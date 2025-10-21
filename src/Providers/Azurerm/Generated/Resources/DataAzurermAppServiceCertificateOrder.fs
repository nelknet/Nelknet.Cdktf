namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order">azurerm_app_service_certificate_order</a>.
    /// </summary>
    type DataAzurermAppServiceCertificateOrderBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppServiceCertificateOrderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceCertificateOrderState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppServiceCertificateOrderState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceCertificateOrderState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#name-1">DataAzurermAppServiceCertificateOrder#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAppServiceCertificateOrderState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAppServiceCertificateOrderState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceCertificateOrderState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#resource_group_name-1">DataAzurermAppServiceCertificateOrder#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAppServiceCertificateOrderState<'Name, Missing>, value: string) : DataAzurermAppServiceCertificateOrderState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceCertificateOrderState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#id-1">DataAzurermAppServiceCertificateOrder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate_order#timeouts-1">DataAzurermAppServiceCertificateOrder#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderTimeouts) : DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppServiceCertificateOrderState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAppServiceCertificateOrderState<Present, Present>) : azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder =
            let config = azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrderConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppServiceCertificateOrder: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppServiceCertificateOrderState<_, _>) : azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder =
            Unchecked.defaultof<azurerm.DataAzurermAppServiceCertificateOrder.DataAzurermAppServiceCertificateOrder>
