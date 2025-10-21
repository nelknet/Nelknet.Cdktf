namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, 'VpcEndpointServiceId> = { assignments: ResizeArray<aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_allowed_principal">aws_vpc_endpoint_service_allowed_principal</a>.
    /// </summary>
    type VpcEndpointServiceAllowedPrincipalBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointServiceAllowedPrincipalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServiceAllowedPrincipalState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointServiceAllowedPrincipalState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointServiceAllowedPrincipalState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_allowed_principal#principal_arn-1">VpcEndpointServiceAllowedPrincipal#principal_arn</a>.
        /// </summary>
        [<CustomOperation "principal_arn">]
        member _.PrincipalArn(state: VpcEndpointServiceAllowedPrincipalState<Missing, 'VpcEndpointServiceId>, value: string) : VpcEndpointServiceAllowedPrincipalState<Present, 'VpcEndpointServiceId> =
            state.assignments.Add(fun config -> config.PrincipalArn <- value)
            ({ assignments = state.assignments } : VpcEndpointServiceAllowedPrincipalState<Present, 'VpcEndpointServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_allowed_principal#vpc_endpoint_service_id-1">VpcEndpointServiceAllowedPrincipal#vpc_endpoint_service_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_service_id">]
        member _.VpcEndpointServiceId(state: VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, Missing>, value: string) : VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, Present> =
            state.assignments.Add(fun config -> config.VpcEndpointServiceId <- value)
            ({ assignments = state.assignments } : VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_service_allowed_principal#id-1">VpcEndpointServiceAllowedPrincipal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, 'VpcEndpointServiceId>, value: string) : VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, 'VpcEndpointServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointServiceAllowedPrincipalState<'PrincipalArn, 'VpcEndpointServiceId>

        member _.Run(state: VpcEndpointServiceAllowedPrincipalState<Present, Present>) : aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipal =
            let config = aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipalConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointServiceAllowedPrincipal: missing required arguments. Must call: principal_arn, vpc_endpoint_service_id.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointServiceAllowedPrincipalState<_, _>) : aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipal =
            Unchecked.defaultof<aws.VpcEndpointServiceAllowedPrincipal.VpcEndpointServiceAllowedPrincipal>
