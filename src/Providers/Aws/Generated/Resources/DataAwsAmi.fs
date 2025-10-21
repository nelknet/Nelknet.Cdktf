namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAmiState = { assignments: ResizeArray<aws.DataAwsAmi.DataAwsAmiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami">aws_ami</a>.
    /// </summary>
    type DataAwsAmiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAmiState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAmiState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#executable_users-1">DataAwsAmi#executable_users</a>.
        /// </summary>
        [<CustomOperation "executable_users">]
        member _.ExecutableUsers(state: DataAwsAmiState, value: seq<string>) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.ExecutableUsers <- (value |> Seq.toArray))
            state : DataAwsAmiState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#filter-1">DataAwsAmi#filter</a> Accepts: aws.IResolvable | aws.DataAwsAmi.DataAwsAmiFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsAmiState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#id-1">DataAwsAmi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAmiState, value: string) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#include_deprecated-1">DataAwsAmi#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsAmiState, value: bool) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#include_deprecated-1">DataAwsAmi#include_deprecated</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_deprecated">]
        member _.IncludeDeprecated(state: DataAwsAmiState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.IncludeDeprecated <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#most_recent-1">DataAwsAmi#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAmiState, value: bool) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#most_recent-1">DataAwsAmi#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAmiState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#name_regex-1">DataAwsAmi#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsAmiState, value: string) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#owners-1">DataAwsAmi#owners</a>.
        /// </summary>
        [<CustomOperation "owners">]
        member _.Owners(state: DataAwsAmiState, value: seq<string>) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.Owners <- (value |> Seq.toArray))
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#tags-1">DataAwsAmi#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAmiState, value: seq<string * string>) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAmiState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#timeouts-1">DataAwsAmi#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsAmiState, value: aws.DataAwsAmi.DataAwsAmiTimeouts) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsAmiState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami#uefi_data-1">DataAwsAmi#uefi_data</a>.
        /// </summary>
        [<CustomOperation "uefi_data">]
        member _.UefiData(state: DataAwsAmiState, value: string) : DataAwsAmiState =
            state.assignments.Add(fun config -> config.UefiData <- value)
            state : DataAwsAmiState

        member _.Run(state: DataAwsAmiState) : aws.DataAwsAmi.DataAwsAmi =
            let config = aws.DataAwsAmi.DataAwsAmiConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAmi.DataAwsAmi(StackContext.get (), logicalId, config)
