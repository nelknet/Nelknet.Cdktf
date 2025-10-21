namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotIndexingConfigurationState = { assignments: ResizeArray<aws.IotIndexingConfiguration.IotIndexingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration">aws_iot_indexing_configuration</a>.
    /// </summary>
    type IotIndexingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotIndexingConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IotIndexingConfigurationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#id-1">IotIndexingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotIndexingConfigurationState, value: string) : IotIndexingConfigurationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotIndexingConfigurationState

        /// <summary>
        /// thing_group_indexing_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_group_indexing_configuration-1">IotIndexingConfiguration#thing_group_indexing_configuration</a>
        /// </summary>
        [<CustomOperation "thing_group_indexing_configuration">]
        member _.ThingGroupIndexingConfiguration(state: IotIndexingConfigurationState, value: aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration) : IotIndexingConfigurationState =
            state.assignments.Add(fun config -> config.ThingGroupIndexingConfiguration <- value)
            state : IotIndexingConfigurationState

        /// <summary>
        /// thing_indexing_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#thing_indexing_configuration-1">IotIndexingConfiguration#thing_indexing_configuration</a>
        /// </summary>
        [<CustomOperation "thing_indexing_configuration">]
        member _.ThingIndexingConfiguration(state: IotIndexingConfigurationState, value: aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration) : IotIndexingConfigurationState =
            state.assignments.Add(fun config -> config.ThingIndexingConfiguration <- value)
            state : IotIndexingConfigurationState

        member _.Run(state: IotIndexingConfigurationState) : aws.IotIndexingConfiguration.IotIndexingConfiguration =
            let config = aws.IotIndexingConfiguration.IotIndexingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.IotIndexingConfiguration.IotIndexingConfiguration(StackContext.get (), logicalId, config)
