namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskKafkaVersionState = { assignments: ResizeArray<aws.DataAwsMskKafkaVersion.DataAwsMskKafkaVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_kafka_version">aws_msk_kafka_version</a>.
    /// </summary>
    type DataAwsMskKafkaVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskKafkaVersionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsMskKafkaVersionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_kafka_version#id-1">DataAwsMskKafkaVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskKafkaVersionState, value: string) : DataAwsMskKafkaVersionState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskKafkaVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_kafka_version#preferred_versions-1">DataAwsMskKafkaVersion#preferred_versions</a>.
        /// </summary>
        [<CustomOperation "preferred_versions">]
        member _.PreferredVersions(state: DataAwsMskKafkaVersionState, value: seq<string>) : DataAwsMskKafkaVersionState =
            state.assignments.Add(fun config -> config.PreferredVersions <- (value |> Seq.toArray))
            state : DataAwsMskKafkaVersionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_kafka_version#version-1">DataAwsMskKafkaVersion#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsMskKafkaVersionState, value: string) : DataAwsMskKafkaVersionState =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsMskKafkaVersionState

        member _.Run(state: DataAwsMskKafkaVersionState) : aws.DataAwsMskKafkaVersion.DataAwsMskKafkaVersion =
            let config = aws.DataAwsMskKafkaVersion.DataAwsMskKafkaVersionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskKafkaVersion.DataAwsMskKafkaVersion(StackContext.get (), logicalId, config)
