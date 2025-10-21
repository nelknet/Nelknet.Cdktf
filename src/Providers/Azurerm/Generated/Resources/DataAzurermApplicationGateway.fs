namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway">azurerm_application_gateway</a>.
    /// </summary>
    type DataAzurermApplicationGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApplicationGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationGatewayState<Missing, Missing>)

        member _.Zero(()) : DataAzurermApplicationGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#name-1">DataAzurermApplicationGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApplicationGatewayState<Missing, 'ResourceGroupName>, value: string) : DataAzurermApplicationGatewayState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationGatewayState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#resource_group_name-1">DataAzurermApplicationGateway#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApplicationGatewayState<'Name, Missing>, value: string) : DataAzurermApplicationGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationGatewayState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#id-1">DataAzurermApplicationGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName>, value: string) : DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_gateway#timeouts-1">DataAzurermApplicationGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayTimeouts) : DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApplicationGatewayState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApplicationGatewayState<Present, Present>) : azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway =
            let config = azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApplicationGateway: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApplicationGatewayState<_, _>) : azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway =
            Unchecked.defaultof<azurerm.DataAzurermApplicationGateway.DataAzurermApplicationGateway>
