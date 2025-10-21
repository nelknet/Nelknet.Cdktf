namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxGatewayState<'AmazonSideAsn, 'Name> = { assignments: ResizeArray<aws.DxGateway.DxGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway">aws_dx_gateway</a>.
    /// </summary>
    type DxGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxGatewayState<Missing, Missing>)

        member _.Zero(()) : DxGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DxGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway#amazon_side_asn-1">DxGateway#amazon_side_asn</a>.
        /// </summary>
        [<CustomOperation "amazon_side_asn">]
        member _.AmazonSideAsn(state: DxGatewayState<Missing, 'Name>, value: string) : DxGatewayState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AmazonSideAsn <- value)
            ({ assignments = state.assignments } : DxGatewayState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway#name-1">DxGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxGatewayState<'AmazonSideAsn, Missing>, value: string) : DxGatewayState<'AmazonSideAsn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxGatewayState<'AmazonSideAsn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway#id-1">DxGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxGatewayState<'AmazonSideAsn, 'Name>, value: string) : DxGatewayState<'AmazonSideAsn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxGatewayState<'AmazonSideAsn, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_gateway#timeouts-1">DxGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DxGatewayState<'AmazonSideAsn, 'Name>, value: aws.DxGateway.DxGatewayTimeouts) : DxGatewayState<'AmazonSideAsn, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DxGatewayState<'AmazonSideAsn, 'Name>

        member _.Run(state: DxGatewayState<Present, Present>) : aws.DxGateway.DxGateway =
            let config = aws.DxGateway.DxGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.DxGateway.DxGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxGateway: missing required arguments. Must call: amazon_side_asn, name.", 9999, IsError = true)>]
        member _.Run(_: DxGatewayState<_, _>) : aws.DxGateway.DxGateway =
            Unchecked.defaultof<aws.DxGateway.DxGateway>
