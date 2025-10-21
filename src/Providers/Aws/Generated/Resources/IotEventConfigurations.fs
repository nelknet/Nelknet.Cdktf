namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotEventConfigurationsState<'EventConfigurations> = { assignments: ResizeArray<aws.IotEventConfigurations.IotEventConfigurationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_event_configurations">aws_iot_event_configurations</a>.
    /// </summary>
    type IotEventConfigurationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotEventConfigurationsState<Missing> =
            ({ assignments = ResizeArray() } : IotEventConfigurationsState<Missing>)

        member _.Zero(()) : IotEventConfigurationsState<Missing> =
            ({ assignments = ResizeArray() } : IotEventConfigurationsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_event_configurations#event_configurations-1">IotEventConfigurations#event_configurations</a>.
        /// </summary>
        [<CustomOperation "event_configurations">]
        member _.EventConfigurations(state: IotEventConfigurationsState<Missing>, value: seq<string * obj>) : IotEventConfigurationsState<Present> =
            state.assignments.Add(fun config -> config.EventConfigurations <- dict value)
            ({ assignments = state.assignments } : IotEventConfigurationsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_event_configurations#id-1">IotEventConfigurations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotEventConfigurationsState<'EventConfigurations>, value: string) : IotEventConfigurationsState<'EventConfigurations> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotEventConfigurationsState<'EventConfigurations>

        member _.Run(state: IotEventConfigurationsState<Present>) : aws.IotEventConfigurations.IotEventConfigurations =
            let config = aws.IotEventConfigurations.IotEventConfigurationsConfig()
            for setter in state.assignments do
                setter config
            aws.IotEventConfigurations.IotEventConfigurations(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iotEventConfigurations: missing required arguments. Must call: event_configurations.", 9999, IsError = true)>]
        member _.Run(_: IotEventConfigurationsState<_>) : aws.IotEventConfigurations.IotEventConfigurations =
            Unchecked.defaultof<aws.IotEventConfigurations.IotEventConfigurations>
