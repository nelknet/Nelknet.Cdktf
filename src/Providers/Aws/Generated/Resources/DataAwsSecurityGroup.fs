namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSecurityGroupState = { assignments: ResizeArray<aws.DataAwsSecurityGroup.DataAwsSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group">aws_security_group</a>.
    /// </summary>
    type DataAwsSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSecurityGroupState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSecurityGroupState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#filter-1">DataAwsSecurityGroup#filter</a> Accepts: aws.IResolvable | aws.DataAwsSecurityGroup.DataAwsSecurityGroupFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSecurityGroupState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#id-1">DataAwsSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSecurityGroupState, value: string) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#name-1">DataAwsSecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSecurityGroupState, value: string) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#tags-1">DataAwsSecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSecurityGroupState, value: seq<string * string>) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSecurityGroupState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#timeouts-1">DataAwsSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsSecurityGroupState, value: aws.DataAwsSecurityGroup.DataAwsSecurityGroupTimeouts) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsSecurityGroupState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/security_group#vpc_id-1">DataAwsSecurityGroup#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsSecurityGroupState, value: string) : DataAwsSecurityGroupState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsSecurityGroupState

        member _.Run(state: DataAwsSecurityGroupState) : aws.DataAwsSecurityGroup.DataAwsSecurityGroup =
            let config = aws.DataAwsSecurityGroup.DataAwsSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSecurityGroup.DataAwsSecurityGroup(StackContext.get (), logicalId, config)
