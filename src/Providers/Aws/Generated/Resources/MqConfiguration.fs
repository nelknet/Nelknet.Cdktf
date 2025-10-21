namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> = { assignments: ResizeArray<aws.MqConfiguration.MqConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration">aws_mq_configuration</a>.
    /// </summary>
    type MqConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MqConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MqConfigurationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MqConfigurationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MqConfigurationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#data-1">MqConfiguration#data</a>.
        /// </summary>
        [<CustomOperation "data">]
        member _.Data(state: MqConfigurationState<Missing, 'EngineType, 'EngineVersion, 'Name>, value: string) : MqConfigurationState<Present, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.Data <- value)
            ({ assignments = state.assignments } : MqConfigurationState<Present, 'EngineType, 'EngineVersion, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#engine_type-1">MqConfiguration#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: MqConfigurationState<'Data, Missing, 'EngineVersion, 'Name>, value: string) : MqConfigurationState<'Data, Present, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.EngineType <- value)
            ({ assignments = state.assignments } : MqConfigurationState<'Data, Present, 'EngineVersion, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#engine_version-1">MqConfiguration#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: MqConfigurationState<'Data, 'EngineType, Missing, 'Name>, value: string) : MqConfigurationState<'Data, 'EngineType, Present, 'Name> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            ({ assignments = state.assignments } : MqConfigurationState<'Data, 'EngineType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#name-1">MqConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, Missing>, value: string) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#authentication_strategy-1">MqConfiguration#authentication_strategy</a>.
        /// </summary>
        [<CustomOperation "authentication_strategy">]
        member _.AuthenticationStrategy(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>, value: string) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.AuthenticationStrategy <- value)
            state : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#description-1">MqConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>, value: string) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#id-1">MqConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>, value: string) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#tags-1">MqConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>, value: seq<string * string>) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_configuration#tags_all-1">MqConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>, value: seq<string * string>) : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MqConfigurationState<'Data, 'EngineType, 'EngineVersion, 'Name>

        member _.Run(state: MqConfigurationState<Present, Present, Present, Present>) : aws.MqConfiguration.MqConfiguration =
            let config = aws.MqConfiguration.MqConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.MqConfiguration.MqConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mqConfiguration: missing required arguments. Must call: data, engine_type, engine_version, name.", 9999, IsError = true)>]
        member _.Run(_: MqConfigurationState<_, _, _, _>) : aws.MqConfiguration.MqConfiguration =
            Unchecked.defaultof<aws.MqConfiguration.MqConfiguration>
