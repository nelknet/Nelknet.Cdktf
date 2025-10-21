namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> = { assignments: ResizeArray<azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgridConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid">azurerm_digital_twins_endpoint_eventgrid</a>.
    /// </summary>
    type DigitalTwinsEndpointEventgridBuilder(logicalId: string) =
        member _.Yield(_: unit) : DigitalTwinsEndpointEventgridState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointEventgridState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DigitalTwinsEndpointEventgridState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsEndpointEventgridState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#digital_twins_id-1">DigitalTwinsEndpointEventgrid#digital_twins_id</a>.
        /// </summary>
        [<CustomOperation "digital_twins_id">]
        member _.DigitalTwinsId(state: DigitalTwinsEndpointEventgridState<Missing, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<Present, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.DigitalTwinsId <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventgridState<Present, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#eventgrid_topic_endpoint-1">DigitalTwinsEndpointEventgrid#eventgrid_topic_endpoint</a>.
        /// </summary>
        [<CustomOperation "eventgrid_topic_endpoint">]
        member _.EventgridTopicEndpoint(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, Missing, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, Present, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.EventgridTopicEndpoint <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, Present, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#eventgrid_topic_primary_access_key-1">DigitalTwinsEndpointEventgrid#eventgrid_topic_primary_access_key</a>.
        /// </summary>
        [<CustomOperation "eventgrid_topic_primary_access_key">]
        member _.EventgridTopicPrimaryAccessKey(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, Missing, 'EventgridTopicSecondaryAccessKey, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, Present, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.EventgridTopicPrimaryAccessKey <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, Present, 'EventgridTopicSecondaryAccessKey, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#eventgrid_topic_secondary_access_key-1">DigitalTwinsEndpointEventgrid#eventgrid_topic_secondary_access_key</a>.
        /// </summary>
        [<CustomOperation "eventgrid_topic_secondary_access_key">]
        member _.EventgridTopicSecondaryAccessKey(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, Missing, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, Present, 'Name> =
            state.assignments.Add(fun config -> config.EventgridTopicSecondaryAccessKey <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#name-1">DigitalTwinsEndpointEventgrid#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, Missing>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#dead_letter_storage_secret-1">DigitalTwinsEndpointEventgrid#dead_letter_storage_secret</a>.
        /// </summary>
        [<CustomOperation "dead_letter_storage_secret">]
        member _.DeadLetterStorageSecret(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.DeadLetterStorageSecret <- value)
            state : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#id-1">DigitalTwinsEndpointEventgrid#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>, value: string) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_endpoint_eventgrid#timeouts-1">DigitalTwinsEndpointEventgrid#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>, value: azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgridTimeouts) : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DigitalTwinsEndpointEventgridState<'DigitalTwinsId, 'EventgridTopicEndpoint, 'EventgridTopicPrimaryAccessKey, 'EventgridTopicSecondaryAccessKey, 'Name>

        member _.Run(state: DigitalTwinsEndpointEventgridState<Present, Present, Present, Present, Present>) : azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgrid =
            let config = azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgridConfig()
            for setter in state.assignments do
                setter config
            azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgrid(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.digitalTwinsEndpointEventgrid: missing required arguments. Must call: digital_twins_id, eventgrid_topic_endpoint, eventgrid_topic_primary_access_key, eventgrid_topic_secondary_access_key, name.", 9999, IsError = true)>]
        member _.Run(_: DigitalTwinsEndpointEventgridState<_, _, _, _, _>) : azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgrid =
            Unchecked.defaultof<azurerm.DigitalTwinsEndpointEventgrid.DigitalTwinsEndpointEventgrid>
