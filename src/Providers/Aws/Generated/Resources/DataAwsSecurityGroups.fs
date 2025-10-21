namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecurityGroupsState = { assignments: ResizeArray<aws.DataAwsSecurityGroups.DataAwsSecurityGroupsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups">aws_security_groups</a>.
    /// </summary>
    type DataAwsSecurityGroupsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecurityGroupsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSecurityGroupsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups#filter-1">DataAwsSecurityGroups#filter</a> Accepts: aws.IResolvable | aws.DataAwsSecurityGroups.DataAwsSecurityGroupsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSecurityGroupsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecurityGroupsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSecurityGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups#id-1">DataAwsSecurityGroups#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecurityGroupsState, value: string) : DataAwsSecurityGroupsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecurityGroupsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups#tags-1">DataAwsSecurityGroups#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSecurityGroupsState, value: seq<string * string>) : DataAwsSecurityGroupsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSecurityGroupsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_groups#timeouts-1">DataAwsSecurityGroups#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsSecurityGroupsState, value: aws.DataAwsSecurityGroups.DataAwsSecurityGroupsTimeouts) : DataAwsSecurityGroupsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsSecurityGroupsState

        member _.Run(state: DataAwsSecurityGroupsState) : aws.DataAwsSecurityGroups.DataAwsSecurityGroups =
            let config = aws.DataAwsSecurityGroups.DataAwsSecurityGroupsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecurityGroups.DataAwsSecurityGroups(StackContext.get (), logicalId, config)
