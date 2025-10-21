namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcState = { assignments: ResizeArray<aws.DataAwsVpc.DataAwsVpcConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc">aws_vpc</a>.
    /// </summary>
    type DataAwsVpcBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#cidr_block-1">DataAwsVpc#cidr_block</a>.
        /// </summary>
        [<CustomOperation "cidr_block">]
        member _.CidrBlock(state: DataAwsVpcState, value: string) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.CidrBlock <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#default-1">DataAwsVpc#default</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default">]
        member _.Default(state: DataAwsVpcState, value: bool) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Default <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#default-1">DataAwsVpc#default</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "default">]
        member _.Default(state: DataAwsVpcState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Default <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#dhcp_options_id-1">DataAwsVpc#dhcp_options_id</a>.
        /// </summary>
        [<CustomOperation "dhcp_options_id">]
        member _.DhcpOptionsId(state: DataAwsVpcState, value: string) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.DhcpOptionsId <- value)
            state : DataAwsVpcState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#filter-1">DataAwsVpc#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpc.DataAwsVpcFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#id-1">DataAwsVpc#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcState, value: string) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#state-1">DataAwsVpc#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: DataAwsVpcState, value: string) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.State <- value)
            state : DataAwsVpcState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#tags-1">DataAwsVpc#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcState, value: seq<string * string>) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc#timeouts-1">DataAwsVpc#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcState, value: aws.DataAwsVpc.DataAwsVpcTimeouts) : DataAwsVpcState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcState

        member _.Run(state: DataAwsVpcState) : aws.DataAwsVpc.DataAwsVpc =
            let config = aws.DataAwsVpc.DataAwsVpcConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpc.DataAwsVpc(StackContext.get (), logicalId, config)
