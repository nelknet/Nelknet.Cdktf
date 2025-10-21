namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointServicePrivateDnsVerificationState<'ServiceId> = { assignments: ResizeArray<aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_private_dns_verification">aws_vpc_endpoint_service_private_dns_verification</a>.
    /// </summary>
    type VpcEndpointServicePrivateDnsVerificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointServicePrivateDnsVerificationState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServicePrivateDnsVerificationState<Missing>)

        member _.Zero(()) : VpcEndpointServicePrivateDnsVerificationState<Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServicePrivateDnsVerificationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_private_dns_verification#service_id-1">VpcEndpointServicePrivateDnsVerification#service_id</a>.
        /// </summary>
        [<CustomOperation "service_id">]
        member _.ServiceId(state: VpcEndpointServicePrivateDnsVerificationState<Missing>, value: string) : VpcEndpointServicePrivateDnsVerificationState<Present> =
            state.assignments.Add(fun config -> config.ServiceId <- value)
            ({ assignments = state.assignments } : VpcEndpointServicePrivateDnsVerificationState<Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_private_dns_verification#timeouts-1">VpcEndpointServicePrivateDnsVerification#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcEndpointServicePrivateDnsVerificationState<'ServiceId>, value: aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerificationTimeouts) : VpcEndpointServicePrivateDnsVerificationState<'ServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcEndpointServicePrivateDnsVerificationState<'ServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_private_dns_verification#wait_for_verification-1">VpcEndpointServicePrivateDnsVerification#wait_for_verification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_verification">]
        member _.WaitForVerification(state: VpcEndpointServicePrivateDnsVerificationState<'ServiceId>, value: bool) : VpcEndpointServicePrivateDnsVerificationState<'ServiceId> =
            state.assignments.Add(fun config -> config.WaitForVerification <- value)
            state : VpcEndpointServicePrivateDnsVerificationState<'ServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_private_dns_verification#wait_for_verification-1">VpcEndpointServicePrivateDnsVerification#wait_for_verification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_verification">]
        member _.WaitForVerification(state: VpcEndpointServicePrivateDnsVerificationState<'ServiceId>, value: HashiCorp.Cdktf.IResolvable) : VpcEndpointServicePrivateDnsVerificationState<'ServiceId> =
            state.assignments.Add(fun config -> config.WaitForVerification <- value)
            state : VpcEndpointServicePrivateDnsVerificationState<'ServiceId>

        member _.Run(state: VpcEndpointServicePrivateDnsVerificationState<Present>) : aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerification =
            let config = aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerificationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointServicePrivateDnsVerification: missing required arguments. Must call: service_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointServicePrivateDnsVerificationState<_>) : aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerification =
            Unchecked.defaultof<aws.VpcEndpointServicePrivateDnsVerification.VpcEndpointServicePrivateDnsVerification>
