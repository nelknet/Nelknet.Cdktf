namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsNetworkAclsState = { assignments: ResizeArray<aws.DataAwsNetworkAcls.DataAwsNetworkAclsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls">aws_network_acls</a>.
    /// </summary>
    type DataAwsNetworkAclsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsNetworkAclsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsNetworkAclsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#filter-1">DataAwsNetworkAcls#filter</a> Accepts: aws.IResolvable | aws.DataAwsNetworkAcls.DataAwsNetworkAclsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsNetworkAclsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsNetworkAclsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsNetworkAclsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#id-1">DataAwsNetworkAcls#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsNetworkAclsState, value: string) : DataAwsNetworkAclsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsNetworkAclsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#tags-1">DataAwsNetworkAcls#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsNetworkAclsState, value: seq<string * string>) : DataAwsNetworkAclsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsNetworkAclsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#timeouts-1">DataAwsNetworkAcls#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsNetworkAclsState, value: aws.DataAwsNetworkAcls.DataAwsNetworkAclsTimeouts) : DataAwsNetworkAclsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsNetworkAclsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_acls#vpc_id-1">DataAwsNetworkAcls#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsNetworkAclsState, value: string) : DataAwsNetworkAclsState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsNetworkAclsState

        member _.Run(state: DataAwsNetworkAclsState) : aws.DataAwsNetworkAcls.DataAwsNetworkAcls =
            let config = aws.DataAwsNetworkAcls.DataAwsNetworkAclsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsNetworkAcls.DataAwsNetworkAcls(StackContext.get (), logicalId, config)
