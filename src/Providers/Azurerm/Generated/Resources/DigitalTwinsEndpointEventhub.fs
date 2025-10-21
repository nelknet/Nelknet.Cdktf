namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name> = { assignments: ResizeArray<azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub">azurerm_digital_twins_endpoint_eventhub</a>.
    /// </summary>
    type DigitalTwinsEndpointEventhubBuilder(logicalId: string) =
        member _.Yield(_: unit) : DigitalTwinsEndpointEventhubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointEventhubState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DigitalTwinsEndpointEventhubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointEventhubState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#digital_twins_id-1">DigitalTwinsEndpointEventhub#digital_twins_id</a>.
        /// </summary>
        [<CustomOperation "digital_twins_id">]
        member _.DigitalTwinsId(state: DigitalTwinsEndpointEventhubState<Missing, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>, value: string) : DigitalTwinsEndpointEventhubState<Present, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.DigitalTwinsId <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventhubState<Present, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#eventhub_primary_connection_string-1">DigitalTwinsEndpointEventhub#eventhub_primary_connection_string</a>.
        /// </summary>
        [<CustomOperation "eventhub_primary_connection_string">]
        member _.EventhubPrimaryConnectionString(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, Missing, 'EventhubSecondaryConnectionString, 'Name>, value: string) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, Present, 'EventhubSecondaryConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.EventhubPrimaryConnectionString <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, Present, 'EventhubSecondaryConnectionString, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#eventhub_secondary_connection_string-1">DigitalTwinsEndpointEventhub#eventhub_secondary_connection_string</a>.
        /// </summary>
        [<CustomOperation "eventhub_secondary_connection_string">]
        member _.EventhubSecondaryConnectionString(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, Missing, 'Name>, value: string) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, Present, 'Name> =
            state.assignments.Add(fun config -> config.EventhubSecondaryConnectionString <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#name-1">DigitalTwinsEndpointEventhub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, Missing>, value: string) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#dead_letter_storage_secret-1">DigitalTwinsEndpointEventhub#dead_letter_storage_secret</a>.
        /// </summary>
        [<CustomOperation "dead_letter_storage_secret">]
        member _.DeadLetterStorageSecret(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>, value: string) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.DeadLetterStorageSecret <- value)
            state : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#id-1">DigitalTwinsEndpointEventhub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>, value: string) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventhub#timeouts-1">DigitalTwinsEndpointEventhub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>, value: azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubTimeouts) : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DigitalTwinsEndpointEventhubState<'DigitalTwinsId, 'EventhubPrimaryConnectionString, 'EventhubSecondaryConnectionString, 'Name>

        member _.Run(state: DigitalTwinsEndpointEventhubState<Present, Present, Present, Present>) : azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub =
            let config = azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhubConfig()
            for setter in state.assignments do
                setter config
            azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.digitalTwinsEndpointEventhub: missing required arguments. Must call: digital_twins_id, eventhub_primary_connection_string, eventhub_secondary_connection_string, name.", 9999, IsError = true)>]
        member _.Run(_: DigitalTwinsEndpointEventhubState<_, _, _, _>) : azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub =
            Unchecked.defaultof<azurerm.DigitalTwinsEndpointEventhub.DigitalTwinsEndpointEventhub>
