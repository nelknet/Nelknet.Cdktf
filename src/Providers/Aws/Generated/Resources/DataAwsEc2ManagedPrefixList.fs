namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEc2ManagedPrefixListState = { assignments: ResizeArray<aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list">aws_ec2_managed_prefix_list</a>.
    /// </summary>
    type DataAwsEc2ManagedPrefixListBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEc2ManagedPrefixListState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEc2ManagedPrefixListState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#filter-1">DataAwsEc2ManagedPrefixList#filter</a> Accepts: aws.IResolvable | aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEc2ManagedPrefixListState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEc2ManagedPrefixListState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEc2ManagedPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#id-1">DataAwsEc2ManagedPrefixList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEc2ManagedPrefixListState, value: string) : DataAwsEc2ManagedPrefixListState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEc2ManagedPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#name-1">DataAwsEc2ManagedPrefixList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsEc2ManagedPrefixListState, value: string) : DataAwsEc2ManagedPrefixListState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsEc2ManagedPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#tags-1">DataAwsEc2ManagedPrefixList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEc2ManagedPrefixListState, value: seq<string * string>) : DataAwsEc2ManagedPrefixListState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEc2ManagedPrefixListState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_managed_prefix_list#timeouts-1">DataAwsEc2ManagedPrefixList#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEc2ManagedPrefixListState, value: aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListTimeouts) : DataAwsEc2ManagedPrefixListState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEc2ManagedPrefixListState

        member _.Run(state: DataAwsEc2ManagedPrefixListState) : aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixList =
            let config = aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixListConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEc2ManagedPrefixList.DataAwsEc2ManagedPrefixList(StackContext.get (), logicalId, config)
