namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermClientConfigState = { assignments: ResizeArray<azurerm.DataAzurermClientConfig.DataAzurermClientConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config">azurerm_client_config</a>.
    /// </summary>
    type DataAzurermClientConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermClientConfigState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAzurermClientConfigState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config#id-1">DataAzurermClientConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermClientConfigState, value: string) : DataAzurermClientConfigState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermClientConfigState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/client_config#timeouts-1">DataAzurermClientConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermClientConfigState, value: azurerm.DataAzurermClientConfig.DataAzurermClientConfigTimeouts) : DataAzurermClientConfigState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermClientConfigState

        member _.Run(state: DataAzurermClientConfigState) : azurerm.DataAzurermClientConfig.DataAzurermClientConfig =
            let config = azurerm.DataAzurermClientConfig.DataAzurermClientConfigConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermClientConfig.DataAzurermClientConfig(StackContext.get (), logicalId, config)
