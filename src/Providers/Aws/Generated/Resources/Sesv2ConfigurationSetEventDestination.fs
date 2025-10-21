namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, 'EventDestinationName> = { assignments: ResizeArray<aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination">aws_sesv2_configuration_set_event_destination</a>.
    /// </summary>
    type Sesv2ConfigurationSetEventDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Sesv2ConfigurationSetEventDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2ConfigurationSetEventDestinationState<Missing, Missing, Missing>)

        member _.Zero(()) : Sesv2ConfigurationSetEventDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Sesv2ConfigurationSetEventDestinationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#configuration_set_name-1">Sesv2ConfigurationSetEventDestination#configuration_set_name</a>.
        /// </summary>
        [<CustomOperation "configuration_set_name">]
        member _.ConfigurationSetName(state: Sesv2ConfigurationSetEventDestinationState<Missing, 'EventDestination, 'EventDestinationName>, value: string) : Sesv2ConfigurationSetEventDestinationState<Present, 'EventDestination, 'EventDestinationName> =
            state.assignments.Add(fun config -> config.ConfigurationSetName <- value)
            ({ assignments = state.assignments } : Sesv2ConfigurationSetEventDestinationState<Present, 'EventDestination, 'EventDestinationName>)

        /// <summary>
        /// event_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#event_destination-1">Sesv2ConfigurationSetEventDestination#event_destination</a>
        /// </summary>
        [<CustomOperation "event_destination">]
        member _.EventDestination(state: Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, Missing, 'EventDestinationName>, value: aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationEventDestination) : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, Present, 'EventDestinationName> =
            state.assignments.Add(fun config -> config.EventDestination <- value)
            ({ assignments = state.assignments } : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, Present, 'EventDestinationName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#event_destination_name-1">Sesv2ConfigurationSetEventDestination#event_destination_name</a>.
        /// </summary>
        [<CustomOperation "event_destination_name">]
        member _.EventDestinationName(state: Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, Missing>, value: string) : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, Present> =
            state.assignments.Add(fun config -> config.EventDestinationName <- value)
            ({ assignments = state.assignments } : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set_event_destination#id-1">Sesv2ConfigurationSetEventDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, 'EventDestinationName>, value: string) : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, 'EventDestinationName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Sesv2ConfigurationSetEventDestinationState<'ConfigurationSetName, 'EventDestination, 'EventDestinationName>

        member _.Run(state: Sesv2ConfigurationSetEventDestinationState<Present, Present, Present>) : aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestination =
            let config = aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesv2ConfigurationSetEventDestination: missing required arguments. Must call: configuration_set_name, event_destination, event_destination_name.", 9999, IsError = true)>]
        member _.Run(_: Sesv2ConfigurationSetEventDestinationState<_, _, _>) : aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestination =
            Unchecked.defaultof<aws.Sesv2ConfigurationSetEventDestination.Sesv2ConfigurationSetEventDestination>
