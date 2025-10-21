namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevopsguruEventSourcesConfigState = { assignments: ResizeArray<aws.DevopsguruEventSourcesConfig.DevopsguruEventSourcesConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config">aws_devopsguru_event_sources_config</a>.
    /// </summary>
    type DevopsguruEventSourcesConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevopsguruEventSourcesConfigState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DevopsguruEventSourcesConfigState =
            { assignments = ResizeArray() }

        /// <summary>
        /// event_sources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_event_sources_config#event_sources-1">DevopsguruEventSourcesConfig#event_sources</a> Accepts: aws.IResolvable | aws.DevopsguruEventSourcesConfig.DevopsguruEventSourcesConfigEventSources[]
        /// </summary>
        [<CustomOperation "event_sources">]
        member _.EventSources(state: DevopsguruEventSourcesConfigState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruEventSourcesConfigState =
            state.assignments.Add(fun config -> config.EventSources <- value)
            state : DevopsguruEventSourcesConfigState

        member _.Run(state: DevopsguruEventSourcesConfigState) : aws.DevopsguruEventSourcesConfig.DevopsguruEventSourcesConfig =
            let config = aws.DevopsguruEventSourcesConfig.DevopsguruEventSourcesConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DevopsguruEventSourcesConfig.DevopsguruEventSourcesConfig(StackContext.get (), logicalId, config)
