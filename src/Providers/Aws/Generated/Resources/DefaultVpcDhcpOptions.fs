namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DefaultVpcDhcpOptionsState = { assignments: ResizeArray<aws.DefaultVpcDhcpOptions.DefaultVpcDhcpOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc_dhcp_options">aws_default_vpc_dhcp_options</a>.
    /// </summary>
    type DefaultVpcDhcpOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DefaultVpcDhcpOptionsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DefaultVpcDhcpOptionsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc_dhcp_options#id-1">DefaultVpcDhcpOptions#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DefaultVpcDhcpOptionsState, value: string) : DefaultVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DefaultVpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc_dhcp_options#owner_id-1">DefaultVpcDhcpOptions#owner_id</a>.
        /// </summary>
        [<CustomOperation "owner_id">]
        member _.OwnerId(state: DefaultVpcDhcpOptionsState, value: string) : DefaultVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.OwnerId <- value)
            state : DefaultVpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc_dhcp_options#tags-1">DefaultVpcDhcpOptions#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DefaultVpcDhcpOptionsState, value: seq<string * string>) : DefaultVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DefaultVpcDhcpOptionsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/default_vpc_dhcp_options#tags_all-1">DefaultVpcDhcpOptions#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DefaultVpcDhcpOptionsState, value: seq<string * string>) : DefaultVpcDhcpOptionsState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DefaultVpcDhcpOptionsState

        member _.Run(state: DefaultVpcDhcpOptionsState) : aws.DefaultVpcDhcpOptions.DefaultVpcDhcpOptions =
            let config = aws.DefaultVpcDhcpOptions.DefaultVpcDhcpOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.DefaultVpcDhcpOptions.DefaultVpcDhcpOptions(StackContext.get (), logicalId, config)
