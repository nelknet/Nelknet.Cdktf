namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IvschatLoggingConfigurationState = { assignments: ResizeArray<aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration">aws_ivschat_logging_configuration</a>.
    /// </summary>
    type IvschatLoggingConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IvschatLoggingConfigurationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IvschatLoggingConfigurationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// destination_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#destination_configuration-1">IvschatLoggingConfiguration#destination_configuration</a>
        /// </summary>
        [<CustomOperation "destination_configuration">]
        member _.DestinationConfiguration(state: IvschatLoggingConfigurationState, value: aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationDestinationConfiguration) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.DestinationConfiguration <- value)
            state : IvschatLoggingConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#id-1">IvschatLoggingConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IvschatLoggingConfigurationState, value: string) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IvschatLoggingConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#name-1">IvschatLoggingConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IvschatLoggingConfigurationState, value: string) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IvschatLoggingConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#tags-1">IvschatLoggingConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IvschatLoggingConfigurationState, value: seq<string * string>) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IvschatLoggingConfigurationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#tags_all-1">IvschatLoggingConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IvschatLoggingConfigurationState, value: seq<string * string>) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IvschatLoggingConfigurationState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_logging_configuration#timeouts-1">IvschatLoggingConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IvschatLoggingConfigurationState, value: aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationTimeouts) : IvschatLoggingConfigurationState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IvschatLoggingConfigurationState

        member _.Run(state: IvschatLoggingConfigurationState) : aws.IvschatLoggingConfiguration.IvschatLoggingConfiguration =
            let config = aws.IvschatLoggingConfiguration.IvschatLoggingConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.IvschatLoggingConfiguration.IvschatLoggingConfiguration(StackContext.get (), logicalId, config)
