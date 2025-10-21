namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcBlockPublicAccessOptionsState<'InternetGatewayBlockMode> = { assignments: ResizeArray<aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptionsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_options">aws_vpc_block_public_access_options</a>.
    /// </summary>
    type VpcBlockPublicAccessOptionsBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcBlockPublicAccessOptionsState<Missing> =
            ({ assignments = ResizeArray() } : VpcBlockPublicAccessOptionsState<Missing>)

        member _.Zero(()) : VpcBlockPublicAccessOptionsState<Missing> =
            ({ assignments = ResizeArray() } : VpcBlockPublicAccessOptionsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_options#internet_gateway_block_mode-1">VpcBlockPublicAccessOptions#internet_gateway_block_mode</a>.
        /// </summary>
        [<CustomOperation "internet_gateway_block_mode">]
        member _.InternetGatewayBlockMode(state: VpcBlockPublicAccessOptionsState<Missing>, value: string) : VpcBlockPublicAccessOptionsState<Present> =
            state.assignments.Add(fun config -> config.InternetGatewayBlockMode <- value)
            ({ assignments = state.assignments } : VpcBlockPublicAccessOptionsState<Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_options#timeouts-1">VpcBlockPublicAccessOptions#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcBlockPublicAccessOptionsState<'InternetGatewayBlockMode>, value: aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptionsTimeouts) : VpcBlockPublicAccessOptionsState<'InternetGatewayBlockMode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcBlockPublicAccessOptionsState<'InternetGatewayBlockMode>

        member _.Run(state: VpcBlockPublicAccessOptionsState<Present>) : aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptions =
            let config = aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptionsConfig()
            for setter in state.assignments do
                setter config
            aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptions(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcBlockPublicAccessOptions: missing required arguments. Must call: internet_gateway_block_mode.", 9999, IsError = true)>]
        member _.Run(_: VpcBlockPublicAccessOptionsState<_>) : aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptions =
            Unchecked.defaultof<aws.VpcBlockPublicAccessOptions.VpcBlockPublicAccessOptions>
