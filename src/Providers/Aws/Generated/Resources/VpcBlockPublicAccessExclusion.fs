namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode> = { assignments: ResizeArray<aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion">aws_vpc_block_public_access_exclusion</a>.
    /// </summary>
    type VpcBlockPublicAccessExclusionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcBlockPublicAccessExclusionState<Missing> =
            ({ assignments = ResizeArray() } : VpcBlockPublicAccessExclusionState<Missing>)

        member _.Zero(()) : VpcBlockPublicAccessExclusionState<Missing> =
            ({ assignments = ResizeArray() } : VpcBlockPublicAccessExclusionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion#internet_gateway_exclusion_mode-1">VpcBlockPublicAccessExclusion#internet_gateway_exclusion_mode</a>.
        /// </summary>
        [<CustomOperation "internet_gateway_exclusion_mode">]
        member _.InternetGatewayExclusionMode(state: VpcBlockPublicAccessExclusionState<Missing>, value: string) : VpcBlockPublicAccessExclusionState<Present> =
            state.assignments.Add(fun config -> config.InternetGatewayExclusionMode <- value)
            ({ assignments = state.assignments } : VpcBlockPublicAccessExclusionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion#subnet_id-1">VpcBlockPublicAccessExclusion#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>, value: string) : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion#tags-1">VpcBlockPublicAccessExclusion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>, value: seq<string * string>) : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion#timeouts-1">VpcBlockPublicAccessExclusion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>, value: aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusionTimeouts) : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_block_public_access_exclusion#vpc_id-1">VpcBlockPublicAccessExclusion#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>, value: string) : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            state : VpcBlockPublicAccessExclusionState<'InternetGatewayExclusionMode>

        member _.Run(state: VpcBlockPublicAccessExclusionState<Present>) : aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusion =
            let config = aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusionConfig()
            for setter in state.assignments do
                setter config
            aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcBlockPublicAccessExclusion: missing required arguments. Must call: internet_gateway_exclusion_mode.", 9999, IsError = true)>]
        member _.Run(_: VpcBlockPublicAccessExclusionState<_>) : aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusion =
            Unchecked.defaultof<aws.VpcBlockPublicAccessExclusion.VpcBlockPublicAccessExclusion>
