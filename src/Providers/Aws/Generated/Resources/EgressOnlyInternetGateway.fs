namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EgressOnlyInternetGatewayState<'VpcId> = { assignments: ResizeArray<aws.EgressOnlyInternetGateway.EgressOnlyInternetGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/egress_only_internet_gateway">aws_egress_only_internet_gateway</a>.
    /// </summary>
    type EgressOnlyInternetGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : EgressOnlyInternetGatewayState<Missing> =
            ({ assignments = ResizeArray() } : EgressOnlyInternetGatewayState<Missing>)

        member _.Zero(()) : EgressOnlyInternetGatewayState<Missing> =
            ({ assignments = ResizeArray() } : EgressOnlyInternetGatewayState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/egress_only_internet_gateway#vpc_id-1">EgressOnlyInternetGateway#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: EgressOnlyInternetGatewayState<Missing>, value: string) : EgressOnlyInternetGatewayState<Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : EgressOnlyInternetGatewayState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/egress_only_internet_gateway#id-1">EgressOnlyInternetGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EgressOnlyInternetGatewayState<'VpcId>, value: string) : EgressOnlyInternetGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EgressOnlyInternetGatewayState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/egress_only_internet_gateway#tags-1">EgressOnlyInternetGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EgressOnlyInternetGatewayState<'VpcId>, value: seq<string * string>) : EgressOnlyInternetGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EgressOnlyInternetGatewayState<'VpcId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/egress_only_internet_gateway#tags_all-1">EgressOnlyInternetGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EgressOnlyInternetGatewayState<'VpcId>, value: seq<string * string>) : EgressOnlyInternetGatewayState<'VpcId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EgressOnlyInternetGatewayState<'VpcId>

        member _.Run(state: EgressOnlyInternetGatewayState<Present>) : aws.EgressOnlyInternetGateway.EgressOnlyInternetGateway =
            let config = aws.EgressOnlyInternetGateway.EgressOnlyInternetGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.EgressOnlyInternetGateway.EgressOnlyInternetGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.egressOnlyInternetGateway: missing required arguments. Must call: vpc_id.", 9999, IsError = true)>]
        member _.Run(_: EgressOnlyInternetGatewayState<_>) : aws.EgressOnlyInternetGateway.EgressOnlyInternetGateway =
            Unchecked.defaultof<aws.EgressOnlyInternetGateway.EgressOnlyInternetGateway>
