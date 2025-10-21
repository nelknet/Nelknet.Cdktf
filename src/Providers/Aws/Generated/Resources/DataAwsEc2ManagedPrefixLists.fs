namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2ManagedPrefixListsState = { assignments: ResizeArray<aws.DataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists">aws_ec2_managed_prefix_lists</a>.
    /// </summary>
    type DataAwsEc2ManagedPrefixListsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2ManagedPrefixListsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2ManagedPrefixListsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#filter-1">DataAwsEc2ManagedPrefixLists#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2ManagedPrefixListsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2ManagedPrefixListsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2ManagedPrefixListsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#id-1">DataAwsEc2ManagedPrefixLists#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2ManagedPrefixListsState, value: string) : DataAwsEc2ManagedPrefixListsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2ManagedPrefixListsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_lists#tags-1">DataAwsEc2ManagedPrefixLists#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2ManagedPrefixListsState, value: seq<string * string>) : DataAwsEc2ManagedPrefixListsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2ManagedPrefixListsState

        member _.Run(state: DataAwsEc2ManagedPrefixListsState) : aws.DataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixLists =
            let config = aws.DataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixListsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2ManagedPrefixLists.DataAwsEc2ManagedPrefixLists(StackContext.get (), logicalId, config)
