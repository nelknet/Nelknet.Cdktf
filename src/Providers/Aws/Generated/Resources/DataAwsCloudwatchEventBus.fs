namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudwatchEventBusState<'Name> = { assignments: ResizeArray<aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_bus">aws_cloudwatch_event_bus</a>.
    /// </summary>
    type DataAwsCloudwatchEventBusBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudwatchEventBusState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchEventBusState<Missing>)

        member _.Zero(()) : DataAwsCloudwatchEventBusState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudwatchEventBusState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_bus#name-1">DataAwsCloudwatchEventBus#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsCloudwatchEventBusState<Missing>, value: string) : DataAwsCloudwatchEventBusState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsCloudwatchEventBusState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudwatch_event_bus#id-1">DataAwsCloudwatchEventBus#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudwatchEventBusState<'Name>, value: string) : DataAwsCloudwatchEventBusState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCloudwatchEventBusState<'Name>

        member _.Run(state: DataAwsCloudwatchEventBusState<Present>) : aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBus =
            let config = aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBusConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudwatchEventBus: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudwatchEventBusState<_>) : aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBus =
            Unchecked.defaultof<aws.DataAwsCloudwatchEventBus.DataAwsCloudwatchEventBus>
