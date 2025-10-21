namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSubnetState = { assignments: ResizeArray<aws.DataAwsSubnet.DataAwsSubnetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet">aws_subnet</a>.
    /// </summary>
    type DataAwsSubnetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSubnetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSubnetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#availability_zone-1">DataAwsSubnet#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#availability_zone_id-1">DataAwsSubnet#availability_zone_id</a>.
        /// </summary>
        [<CustomOperation "availability_zone_id">]
        member _.AvailabilityZoneId(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.AvailabilityZoneId <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#cidr_block-1">DataAwsSubnet#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#default_for_az-1">DataAwsSubnet#default_for_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_for_az">]
        member _.DefaultForAz(state: DataAwsSubnetState, value: bool) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.DefaultForAz <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#default_for_az-1">DataAwsSubnet#default_for_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default_for_az">]
        member _.DefaultForAz(state: DataAwsSubnetState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.DefaultForAz <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#filter-1">DataAwsSubnet#filter</a> Accepts: aws.IResolvable | aws.DataAwsSubnet.DataAwsSubnetFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsSubnetState, value: HashiCorp.Cdktf.IResolvable) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#id-1">DataAwsSubnet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#ipv6_cidr_block-1">DataAwsSubnet#ipv6_cidr_block</a>.
        /// </summary>
        [<CustomOperation "ipv6_cidr_block">]
        member _.Ipv6CidrBlock(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.Ipv6CidrBlock <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#state-1">DataAwsSubnet#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#tags-1">DataAwsSubnet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSubnetState, value: seq<string * string>) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSubnetState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#timeouts-1">DataAwsSubnet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsSubnetState, value: aws.DataAwsSubnet.DataAwsSubnetTimeouts) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsSubnetState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/subnet#vpc_id-1">DataAwsSubnet#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: DataAwsSubnetState, value: string) : DataAwsSubnetState =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : DataAwsSubnetState

        member _.Run(state: DataAwsSubnetState) : aws.DataAwsSubnet.DataAwsSubnet =
            let config = aws.DataAwsSubnet.DataAwsSubnetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSubnet.DataAwsSubnet(StackContext.get (), logicalId, config)
