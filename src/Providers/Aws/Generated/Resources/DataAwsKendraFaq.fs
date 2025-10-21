namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKendraFaqState<'FaqId, 'IndexId> = { assignments: ResizeArray<aws.DataAwsKendraFaq.DataAwsKendraFaqConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_faq">aws_kendra_faq</a>.
    /// </summary>
    type DataAwsKendraFaqBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKendraFaqState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraFaqState<Missing, Missing>)

        member _.Zero(()) : DataAwsKendraFaqState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraFaqState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_faq#faq_id-1">DataAwsKendraFaq#faq_id</a>.
        /// </summary>
        [<CustomOperation "faq_id">]
        member _.FaqId(state: DataAwsKendraFaqState<Missing, 'IndexId>, value: string) : DataAwsKendraFaqState<Present, 'IndexId> =
            state.assignments.Add(fun config -> config.FaqId <- value)
            ({ assignments = state.assignments } : DataAwsKendraFaqState<Present, 'IndexId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_faq#index_id-1">DataAwsKendraFaq#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: DataAwsKendraFaqState<'FaqId, Missing>, value: string) : DataAwsKendraFaqState<'FaqId, Present> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : DataAwsKendraFaqState<'FaqId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_faq#id-1">DataAwsKendraFaq#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKendraFaqState<'FaqId, 'IndexId>, value: string) : DataAwsKendraFaqState<'FaqId, 'IndexId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKendraFaqState<'FaqId, 'IndexId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_faq#tags-1">DataAwsKendraFaq#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKendraFaqState<'FaqId, 'IndexId>, value: seq<string * string>) : DataAwsKendraFaqState<'FaqId, 'IndexId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKendraFaqState<'FaqId, 'IndexId>

        member _.Run(state: DataAwsKendraFaqState<Present, Present>) : aws.DataAwsKendraFaq.DataAwsKendraFaq =
            let config = aws.DataAwsKendraFaq.DataAwsKendraFaqConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKendraFaq.DataAwsKendraFaq(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKendraFaq: missing required arguments. Must call: faq_id, index_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKendraFaqState<_, _>) : aws.DataAwsKendraFaq.DataAwsKendraFaq =
            Unchecked.defaultof<aws.DataAwsKendraFaq.DataAwsKendraFaq>
