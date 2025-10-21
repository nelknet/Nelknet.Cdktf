namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name> = { assignments: ResizeArray<aws.ConnectVocabulary.ConnectVocabularyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary">aws_connect_vocabulary</a>.
    /// </summary>
    type ConnectVocabularyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectVocabularyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectVocabularyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConnectVocabularyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectVocabularyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#content-1">ConnectVocabulary#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: ConnectVocabularyState<Missing, 'InstanceId, 'LanguageCode, 'Name>, value: string) : ConnectVocabularyState<Present, 'InstanceId, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Content <- value)
            ({ assignments = state.assignments } : ConnectVocabularyState<Present, 'InstanceId, 'LanguageCode, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#instance_id-1">ConnectVocabulary#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectVocabularyState<'Content, Missing, 'LanguageCode, 'Name>, value: string) : ConnectVocabularyState<'Content, Present, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectVocabularyState<'Content, Present, 'LanguageCode, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#language_code-1">ConnectVocabulary#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: ConnectVocabularyState<'Content, 'InstanceId, Missing, 'Name>, value: string) : ConnectVocabularyState<'Content, 'InstanceId, Present, 'Name> =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            ({ assignments = state.assignments } : ConnectVocabularyState<'Content, 'InstanceId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#name-1">ConnectVocabulary#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, Missing>, value: string) : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#id-1">ConnectVocabulary#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>, value: string) : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#tags-1">ConnectVocabulary#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>, value: seq<string * string>) : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#tags_all-1">ConnectVocabulary#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>, value: seq<string * string>) : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_vocabulary#timeouts-1">ConnectVocabulary#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>, value: aws.ConnectVocabulary.ConnectVocabularyTimeouts) : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ConnectVocabularyState<'Content, 'InstanceId, 'LanguageCode, 'Name>

        member _.Run(state: ConnectVocabularyState<Present, Present, Present, Present>) : aws.ConnectVocabulary.ConnectVocabulary =
            let config = aws.ConnectVocabulary.ConnectVocabularyConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectVocabulary.ConnectVocabulary(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectVocabulary: missing required arguments. Must call: content, instance_id, language_code, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectVocabularyState<_, _, _, _>) : aws.ConnectVocabulary.ConnectVocabulary =
            Unchecked.defaultof<aws.ConnectVocabulary.ConnectVocabulary>
