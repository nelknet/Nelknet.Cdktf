namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAmiIdsState<'Owners> = { assignments: ResizeArray<aws.DataAwsAmiIds.DataAwsAmiIdsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids">aws_ami_ids</a>.
    /// </summary>
    type DataAwsAmiIdsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAmiIdsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAmiIdsState<Missing>)

        member _.Zero(()) : DataAwsAmiIdsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAmiIdsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#owners-1">DataAwsAmiIds#owners</a>.
        /// </summary>
        [<CustomOperation "owners">]
        member _.Owners(state: DataAwsAmiIdsState<Missing>, value: seq<string>) : DataAwsAmiIdsState<Present> =
            state.assignments.Add(fun config -> config.Owners <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DataAwsAmiIdsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#executable_users-1">DataAwsAmiIds#executable_users</a>.
        /// </summary>
        [<CustomOperation "executable_users">]
        member _.ExecutableUsers(state: DataAwsAmiIdsState<'Owners>, value: seq<string>) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.ExecutableUsers <- (value |> Seq.toArray))
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#filter-1">DataAwsAmiIds#filter</a> Accepts: aws.IResolvable | aws.DataAwsAmiIds.DataAwsAmiIdsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsAmiIdsState<'Owners>, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#id-1">DataAwsAmiIds#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAmiIdsState<'Owners>, value: string) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#include_deprecated-1">DataAwsAmiIds#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsAmiIdsState<'Owners>, value: bool) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#include_deprecated-1">DataAwsAmiIds#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsAmiIdsState<'Owners>, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#name_regex-1">DataAwsAmiIds#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsAmiIdsState<'Owners>, value: string) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#sort_ascending-1">DataAwsAmiIds#sort_ascending</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sort_ascending">]
        member _.SortAscending(state: DataAwsAmiIdsState<'Owners>, value: bool) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.SortAscending <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#sort_ascending-1">DataAwsAmiIds#sort_ascending</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "sort_ascending">]
        member _.SortAscending(state: DataAwsAmiIdsState<'Owners>, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.SortAscending <- value)
            state : DataAwsAmiIdsState<'Owners>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#timeouts-1">DataAwsAmiIds#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAmiIdsState<'Owners>, value: aws.DataAwsAmiIds.DataAwsAmiIdsTimeouts) : DataAwsAmiIdsState<'Owners> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAmiIdsState<'Owners>

        member _.Run(state: DataAwsAmiIdsState<Present>) : aws.DataAwsAmiIds.DataAwsAmiIds =
            let config = aws.DataAwsAmiIds.DataAwsAmiIdsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAmiIds.DataAwsAmiIds(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAmiIds: missing required arguments. Must call: owners.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAmiIdsState<_>) : aws.DataAwsAmiIds.DataAwsAmiIds =
            Unchecked.defaultof<aws.DataAwsAmiIds.DataAwsAmiIds>
