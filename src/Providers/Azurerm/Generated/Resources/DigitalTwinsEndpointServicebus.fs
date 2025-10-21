namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> = { assignments: ResizeArray<azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus">azurerm_digital_twins_endpoint_servicebus</a>.
    /// </summary>
    type DigitalTwinsEndpointServicebusBuilder(logicalId: string) =
        member _.Yield(_: unit) : DigitalTwinsEndpointServicebusState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointServicebusState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DigitalTwinsEndpointServicebusState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointServicebusState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#digital_twins_id-1">DigitalTwinsEndpointServicebus#digital_twins_id</a>.
        /// </summary>
        [<CustomOperation "digital_twins_id">]
        member _.DigitalTwinsId(state: DigitalTwinsEndpointServicebusState<Missing, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>, value: string) : DigitalTwinsEndpointServicebusState<Present, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.DigitalTwinsId <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointServicebusState<Present, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#name-1">DigitalTwinsEndpointServicebus#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, Missing, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>, value: string) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, Present, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, Present, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#servicebus_primary_connection_string-1">DigitalTwinsEndpointServicebus#servicebus_primary_connection_string</a>.
        /// </summary>
        [<CustomOperation "servicebus_primary_connection_string">]
        member _.ServicebusPrimaryConnectionString(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, Missing, 'ServicebusSecondaryConnectionString>, value: string) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, Present, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.ServicebusPrimaryConnectionString <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, Present, 'ServicebusSecondaryConnectionString>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#servicebus_secondary_connection_string-1">DigitalTwinsEndpointServicebus#servicebus_secondary_connection_string</a>.
        /// </summary>
        [<CustomOperation "servicebus_secondary_connection_string">]
        member _.ServicebusSecondaryConnectionString(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, Missing>, value: string) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, Present> =
            state.assignments.Add(fun config -> config.ServicebusSecondaryConnectionString <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#dead_letter_storage_secret-1">DigitalTwinsEndpointServicebus#dead_letter_storage_secret</a>.
        /// </summary>
        [<CustomOperation "dead_letter_storage_secret">]
        member _.DeadLetterStorageSecret(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>, value: string) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.DeadLetterStorageSecret <- value)
            state : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#id-1">DigitalTwinsEndpointServicebus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>, value: string) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_servicebus#timeouts-1">DigitalTwinsEndpointServicebus#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>, value: azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebusTimeouts) : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DigitalTwinsEndpointServicebusState<'DigitalTwinsId, 'Name, 'ServicebusPrimaryConnectionString, 'ServicebusSecondaryConnectionString>

        member _.Run(state: DigitalTwinsEndpointServicebusState<Present, Present, Present, Present>) : azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebus =
            let config = azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebusConfig()
            for setter in state.assignments do
                setter config
            azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.digitalTwinsEndpointServicebus: missing required arguments. Must call: digital_twins_id, name, servicebus_primary_connection_string, servicebus_secondary_connection_string.", 9999, IsError = true)>]
        member _.Run(_: DigitalTwinsEndpointServicebusState<_, _, _, _>) : azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebus =
            Unchecked.defaultof<azurerm.DigitalTwinsEndpointServicebus.DigitalTwinsEndpointServicebus>
