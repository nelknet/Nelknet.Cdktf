namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MskConfigurationState<'Name, 'ServerProperties> = { assignments: ResizeArray<aws.MskConfiguration.MskConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration">aws_msk_configuration</a>.
    /// </summary>
    type MskConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MskConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskConfigurationState<Missing, Missing>)

        member _.Zero(()) : MskConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MskConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration#name-1">MskConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MskConfigurationState<Missing, 'ServerProperties>, value: string) : MskConfigurationState<Present, 'ServerProperties> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MskConfigurationState<Present, 'ServerProperties>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration#server_properties-1">MskConfiguration#server_properties</a>.
        /// </summary>
        [<CustomOperation "server_properties">]
        member _.ServerProperties(state: MskConfigurationState<'Name, Missing>, value: string) : MskConfigurationState<'Name, Present> =
            state.assignments.Add(fun config -> config.ServerProperties <- value)
            ({ assignments = state.assignments } : MskConfigurationState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration#description-1">MskConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MskConfigurationState<'Name, 'ServerProperties>, value: string) : MskConfigurationState<'Name, 'ServerProperties> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MskConfigurationState<'Name, 'ServerProperties>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration#id-1">MskConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MskConfigurationState<'Name, 'ServerProperties>, value: string) : MskConfigurationState<'Name, 'ServerProperties> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MskConfigurationState<'Name, 'ServerProperties>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_configuration#kafka_versions-1">MskConfiguration#kafka_versions</a>.
        /// </summary>
        [<CustomOperation "kafka_versions">]
        member _.KafkaVersions(state: MskConfigurationState<'Name, 'ServerProperties>, value: seq<string>) : MskConfigurationState<'Name, 'ServerProperties> =
            state.assignments.Add(fun config -> config.KafkaVersions <- (value |> Seq.toArray))
            state : MskConfigurationState<'Name, 'ServerProperties>

        member _.Run(state: MskConfigurationState<Present, Present>) : aws.MskConfiguration.MskConfiguration =
            let config = aws.MskConfiguration.MskConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.MskConfiguration.MskConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mskConfiguration: missing required arguments. Must call: name, server_properties.", 9999, IsError = true)>]
        member _.Run(_: MskConfigurationState<_, _>) : aws.MskConfiguration.MskConfiguration =
            Unchecked.defaultof<aws.MskConfiguration.MskConfiguration>
