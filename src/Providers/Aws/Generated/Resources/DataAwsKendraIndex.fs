namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKendraIndexState<'Id> = { assignments: ResizeArray<aws.DataAwsKendraIndex.DataAwsKendraIndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index">aws_kendra_index</a>.
    /// </summary>
    type DataAwsKendraIndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKendraIndexState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraIndexState<Missing>)

        member _.Zero(()) : DataAwsKendraIndexState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraIndexState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index#id-1">DataAwsKendraIndex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKendraIndexState<Missing>, value: string) : DataAwsKendraIndexState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsKendraIndexState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_index#tags-1">DataAwsKendraIndex#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKendraIndexState<'Id>, value: seq<string * string>) : DataAwsKendraIndexState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKendraIndexState<'Id>

        member _.Run(state: DataAwsKendraIndexState<Present>) : aws.DataAwsKendraIndex.DataAwsKendraIndex =
            let config = aws.DataAwsKendraIndex.DataAwsKendraIndexConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKendraIndex.DataAwsKendraIndex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKendraIndex: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKendraIndexState<_>) : aws.DataAwsKendraIndex.DataAwsKendraIndex =
            Unchecked.defaultof<aws.DataAwsKendraIndex.DataAwsKendraIndex>
