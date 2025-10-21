namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name> = { assignments: ResizeArray<aws.AppintegrationsEventIntegration.AppintegrationsEventIntegrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration">aws_appintegrations_event_integration</a>.
    /// </summary>
    type AppintegrationsEventIntegrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppintegrationsEventIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppintegrationsEventIntegrationState<Missing, Missing, Missing>)

        member _.Zero(()) : AppintegrationsEventIntegrationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppintegrationsEventIntegrationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#eventbridge_bus-1">AppintegrationsEventIntegration#eventbridge_bus</a>.
        /// </summary>
        [<CustomOperation "eventbridge_bus">]
        member _.EventbridgeBus(state: AppintegrationsEventIntegrationState<Missing, 'EventFilter, 'Name>, value: string) : AppintegrationsEventIntegrationState<Present, 'EventFilter, 'Name> =
            state.assignments.Add(fun config -> config.EventbridgeBus <- value)
            ({ assignments = state.assignments } : AppintegrationsEventIntegrationState<Present, 'EventFilter, 'Name>)

        /// <summary>
        /// event_filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#event_filter-1">AppintegrationsEventIntegration#event_filter</a>
        /// </summary>
        [<CustomOperation "event_filter">]
        member _.EventFilter(state: AppintegrationsEventIntegrationState<'EventbridgeBus, Missing, 'Name>, value: aws.AppintegrationsEventIntegration.AppintegrationsEventIntegrationEventFilter) : AppintegrationsEventIntegrationState<'EventbridgeBus, Present, 'Name> =
            state.assignments.Add(fun config -> config.EventFilter <- value)
            ({ assignments = state.assignments } : AppintegrationsEventIntegrationState<'EventbridgeBus, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#name-1">AppintegrationsEventIntegration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, Missing>, value: string) : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#description-1">AppintegrationsEventIntegration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>, value: string) : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#id-1">AppintegrationsEventIntegration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>, value: string) : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#tags-1">AppintegrationsEventIntegration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>, value: seq<string * string>) : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appintegrations_event_integration#tags_all-1">AppintegrationsEventIntegration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>, value: seq<string * string>) : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppintegrationsEventIntegrationState<'EventbridgeBus, 'EventFilter, 'Name>

        member _.Run(state: AppintegrationsEventIntegrationState<Present, Present, Present>) : aws.AppintegrationsEventIntegration.AppintegrationsEventIntegration =
            let config = aws.AppintegrationsEventIntegration.AppintegrationsEventIntegrationConfig()
            for setter in state.assignments do
                setter config
            aws.AppintegrationsEventIntegration.AppintegrationsEventIntegration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appintegrationsEventIntegration: missing required arguments. Must call: eventbridge_bus, event_filter, name.", 9999, IsError = true)>]
        member _.Run(_: AppintegrationsEventIntegrationState<_, _, _>) : aws.AppintegrationsEventIntegration.AppintegrationsEventIntegration =
            Unchecked.defaultof<aws.AppintegrationsEventIntegration.AppintegrationsEventIntegration>
