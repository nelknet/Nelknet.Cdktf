namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectVocabularyState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectVocabulary.DataAwsConnectVocabularyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary">aws_connect_vocabulary</a>.
    /// </summary>
    type DataAwsConnectVocabularyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectVocabularyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectVocabularyState<Missing>)

        member _.Zero(()) : DataAwsConnectVocabularyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectVocabularyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary#instance_id-1">DataAwsConnectVocabulary#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectVocabularyState<Missing>, value: string) : DataAwsConnectVocabularyState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectVocabularyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary#id-1">DataAwsConnectVocabulary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectVocabularyState<'InstanceId>, value: string) : DataAwsConnectVocabularyState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectVocabularyState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary#name-1">DataAwsConnectVocabulary#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectVocabularyState<'InstanceId>, value: string) : DataAwsConnectVocabularyState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectVocabularyState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary#tags-1">DataAwsConnectVocabulary#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectVocabularyState<'InstanceId>, value: seq<string * string>) : DataAwsConnectVocabularyState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectVocabularyState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_vocabulary#vocabulary_id-1">DataAwsConnectVocabulary#vocabulary_id</a>.
        /// </summary>
        [<CustomOperation "vocabulary_id">]
        member _.VocabularyId(state: DataAwsConnectVocabularyState<'InstanceId>, value: string) : DataAwsConnectVocabularyState<'InstanceId> =
            state.assignments.Add(fun config -> config.VocabularyId <- value)
            state : DataAwsConnectVocabularyState<'InstanceId>

        member _.Run(state: DataAwsConnectVocabularyState<Present>) : aws.DataAwsConnectVocabulary.DataAwsConnectVocabulary =
            let config = aws.DataAwsConnectVocabulary.DataAwsConnectVocabularyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectVocabulary.DataAwsConnectVocabulary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectVocabulary: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectVocabularyState<_>) : aws.DataAwsConnectVocabulary.DataAwsConnectVocabulary =
            Unchecked.defaultof<aws.DataAwsConnectVocabulary.DataAwsConnectVocabulary>
