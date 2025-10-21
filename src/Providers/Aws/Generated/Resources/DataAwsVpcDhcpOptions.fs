namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcDhcpOptionsState = { assignments: ResizeArray<aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options">aws_vpc_dhcp_options</a>.
    /// </summary>
    type DataAwsVpcDhcpOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcDhcpOptionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcDhcpOptionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#dhcp_options_id-1">DataAwsVpcDhcpOptions#dhcp_options_id</a>.
        /// </summary>
        [<CustomOperation "dhcp_options_id">]
        member _.DhcpOptionsId(state: DataAwsVpcDhcpOptionsState, value: string) : DataAwsVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.DhcpOptionsId <- value)
            state : DataAwsVpcDhcpOptionsState

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#filter-1">DataAwsVpcDhcpOptions#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcDhcpOptionsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#id-1">DataAwsVpcDhcpOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcDhcpOptionsState, value: string) : DataAwsVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#tags-1">DataAwsVpcDhcpOptions#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcDhcpOptionsState, value: seq<string * string>) : DataAwsVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcDhcpOptionsState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_dhcp_options#timeouts-1">DataAwsVpcDhcpOptions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcDhcpOptionsState, value: aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsTimeouts) : DataAwsVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcDhcpOptionsState

        member _.Run(state: DataAwsVpcDhcpOptionsState) : aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptions =
            let config = aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcDhcpOptions.DataAwsVpcDhcpOptions(StackContext.get (), logicalId, config)
