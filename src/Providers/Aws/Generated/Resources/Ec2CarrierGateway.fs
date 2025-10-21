namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2CarrierGatewayState<'VpcId> = { assignments: ResizeArray<aws.Ec2CarrierGateway.Ec2CarrierGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_carrier_gateway">aws_ec2_carrier_gateway</a>.
    /// </summary>
    type Ec2CarrierGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2CarrierGatewayState<Missing> =
            ({ assignments = ResizeArray() } : Ec2CarrierGatewayState<Missing>)

        member _.Zero(()) : Ec2CarrierGatewayState<Missing> =
            ({ assignments = ResizeArray() } : Ec2CarrierGatewayState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_carrier_gateway#vpc_id-1">Ec2CarrierGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: Ec2CarrierGatewayState<Missing>, value: string) : Ec2CarrierGatewayState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : Ec2CarrierGatewayState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_carrier_gateway#id-1">Ec2CarrierGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2CarrierGatewayState<'VpcId>, value: string) : Ec2CarrierGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2CarrierGatewayState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_carrier_gateway#tags-1">Ec2CarrierGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2CarrierGatewayState<'VpcId>, value: seq<string * string>) : Ec2CarrierGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2CarrierGatewayState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_carrier_gateway#tags_all-1">Ec2CarrierGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2CarrierGatewayState<'VpcId>, value: seq<string * string>) : Ec2CarrierGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2CarrierGatewayState<'VpcId>

        member _.Run(state: Ec2CarrierGatewayState<Present>) : aws.Ec2CarrierGateway.Ec2CarrierGateway =
            let config = aws.Ec2CarrierGateway.Ec2CarrierGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2CarrierGateway.Ec2CarrierGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2CarrierGateway: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: Ec2CarrierGatewayState<_>) : aws.Ec2CarrierGateway.Ec2CarrierGateway =
            Unchecked.defaultof<aws.Ec2CarrierGateway.Ec2CarrierGateway>
