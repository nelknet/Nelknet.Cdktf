namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamsState = { assignments: ResizeArray<aws.DataAwsVpcIpams.DataAwsVpcIpamsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipams">aws_vpc_ipams</a>.
    /// </summary>
    type DataAwsVpcIpamsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcIpamsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipams#filter-1">DataAwsVpcIpams#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcIpams.DataAwsVpcIpamsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcIpamsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcIpamsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcIpamsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipams#ipam_ids-1">DataAwsVpcIpams#ipam_ids</a>.
        /// </summary>
        [<CustomOperation "ipam_ids">]
        member _.IpamIds(state: DataAwsVpcIpamsState, value: seq<string>) : DataAwsVpcIpamsState =
            state.assignments.Add(fun config -> config.IpamIds <- (value |> Seq.toArray))
            state : DataAwsVpcIpamsState

        member _.Run(state: DataAwsVpcIpamsState) : aws.DataAwsVpcIpams.DataAwsVpcIpams =
            let config = aws.DataAwsVpcIpams.DataAwsVpcIpamsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpams.DataAwsVpcIpams(StackContext.get (), logicalId, config)
