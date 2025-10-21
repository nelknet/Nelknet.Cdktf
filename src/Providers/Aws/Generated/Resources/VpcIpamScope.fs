namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamScopeState<'IpamId> = { assignments: ResizeArray<aws.VpcIpamScope.VpcIpamScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope">aws_vpc_ipam_scope</a>.
    /// </summary>
    type VpcIpamScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamScopeState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamScopeState<Missing>)

        member _.Zero(()) : VpcIpamScopeState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamScopeState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#ipam_id-1">VpcIpamScope#ipam_id</a>.
        /// </summary>
        [<CustomOperation "ipam_id">]
        member _.IpamId(state: VpcIpamScopeState<Missing>, value: string) : VpcIpamScopeState<Present> =
            state.assignments.Add(fun config -> config.IpamId <- value)
            ({ assignments = state.assignments } : VpcIpamScopeState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#description-1">VpcIpamScope#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VpcIpamScopeState<'IpamId>, value: string) : VpcIpamScopeState<'IpamId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VpcIpamScopeState<'IpamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#id-1">VpcIpamScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamScopeState<'IpamId>, value: string) : VpcIpamScopeState<'IpamId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamScopeState<'IpamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#tags-1">VpcIpamScope#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcIpamScopeState<'IpamId>, value: seq<string * string>) : VpcIpamScopeState<'IpamId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcIpamScopeState<'IpamId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#tags_all-1">VpcIpamScope#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VpcIpamScopeState<'IpamId>, value: seq<string * string>) : VpcIpamScopeState<'IpamId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VpcIpamScopeState<'IpamId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_scope#timeouts-1">VpcIpamScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcIpamScopeState<'IpamId>, value: aws.VpcIpamScope.VpcIpamScopeTimeouts) : VpcIpamScopeState<'IpamId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcIpamScopeState<'IpamId>

        member _.Run(state: VpcIpamScopeState<Present>) : aws.VpcIpamScope.VpcIpamScope =
            let config = aws.VpcIpamScope.VpcIpamScopeConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamScope.VpcIpamScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamScope: missing required arguments. Must call: ipam_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamScopeState<_>) : aws.VpcIpamScope.VpcIpamScope =
            Unchecked.defaultof<aws.VpcIpamScope.VpcIpamScope>
