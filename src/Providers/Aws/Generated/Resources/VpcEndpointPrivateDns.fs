namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointPrivateDnsState<'PrivateDnsEnabled, 'VpcEndpointId> = { assignments: ResizeArray<aws.VpcEndpointPrivateDns.VpcEndpointPrivateDnsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_private_dns">aws_vpc_endpoint_private_dns</a>.
    /// </summary>
    type VpcEndpointPrivateDnsBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointPrivateDnsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointPrivateDnsState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointPrivateDnsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointPrivateDnsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_private_dns#private_dns_enabled-1">VpcEndpointPrivateDns#private_dns_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_dns_enabled">]
        member _.PrivateDnsEnabled(state: VpcEndpointPrivateDnsState<Missing, 'VpcEndpointId>, value: bool) : VpcEndpointPrivateDnsState<Present, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.PrivateDnsEnabled <- value)
            ({ assignments = state.assignments } : VpcEndpointPrivateDnsState<Present, 'VpcEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_private_dns#private_dns_enabled-1">VpcEndpointPrivateDns#private_dns_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "private_dns_enabled">]
        member _.PrivateDnsEnabled(state: VpcEndpointPrivateDnsState<Missing, 'VpcEndpointId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointPrivateDnsState<Present, 'VpcEndpointId> =
            state.assignments.Add(fun config -> config.PrivateDnsEnabled <- value)
            ({ assignments = state.assignments } : VpcEndpointPrivateDnsState<Present, 'VpcEndpointId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_private_dns#vpc_endpoint_id-1">VpcEndpointPrivateDns#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointPrivateDnsState<'PrivateDnsEnabled, Missing>, value: string) : VpcEndpointPrivateDnsState<'PrivateDnsEnabled, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            ({ assignments = state.assignments } : VpcEndpointPrivateDnsState<'PrivateDnsEnabled, Present>)

        member _.Run(state: VpcEndpointPrivateDnsState<Present, Present>) : aws.VpcEndpointPrivateDns.VpcEndpointPrivateDns =
            let config = aws.VpcEndpointPrivateDns.VpcEndpointPrivateDnsConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointPrivateDns.VpcEndpointPrivateDns(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointPrivateDns: missing required arguments. Must call: private_dns_enabled, vpc_endpoint_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointPrivateDnsState<_, _>) : aws.VpcEndpointPrivateDns.VpcEndpointPrivateDns =
            Unchecked.defaultof<aws.VpcEndpointPrivateDns.VpcEndpointPrivateDns>
