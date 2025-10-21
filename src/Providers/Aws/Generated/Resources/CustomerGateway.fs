namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CustomerGatewayState<'Type> = { assignments: ResizeArray<aws.CustomerGateway.CustomerGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway">aws_customer_gateway</a>.
    /// </summary>
    type CustomerGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : CustomerGatewayState<Missing> =
            ({ assignments = ResizeArray() } : CustomerGatewayState<Missing>)

        member _.Zero(()) : CustomerGatewayState<Missing> =
            ({ assignments = ResizeArray() } : CustomerGatewayState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#type-1">CustomerGateway#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: CustomerGatewayState<Missing>, value: string) : CustomerGatewayState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : CustomerGatewayState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#bgp_asn-1">CustomerGateway#bgp_asn</a>.
        /// </summary>
        [<CustomOperation "bgp_asn">]
        member _.BgpAsn(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.BgpAsn <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#bgp_asn_extended-1">CustomerGateway#bgp_asn_extended</a>.
        /// </summary>
        [<CustomOperation "bgp_asn_extended">]
        member _.BgpAsnExtended(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.BgpAsnExtended <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#certificate_arn-1">CustomerGateway#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#device_name-1">CustomerGateway#device_name</a>.
        /// </summary>
        [<CustomOperation "device_name">]
        member _.DeviceName(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.DeviceName <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#id-1">CustomerGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#ip_address-1">CustomerGateway#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: CustomerGatewayState<'Type>, value: string) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#tags-1">CustomerGateway#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CustomerGatewayState<'Type>, value: seq<string * string>) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CustomerGatewayState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/customer_gateway#tags_all-1">CustomerGateway#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CustomerGatewayState<'Type>, value: seq<string * string>) : CustomerGatewayState<'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CustomerGatewayState<'Type>

        member _.Run(state: CustomerGatewayState<Present>) : aws.CustomerGateway.CustomerGateway =
            let config = aws.CustomerGateway.CustomerGatewayConfig()
            for setter in state.assignments do
                setter config
            aws.CustomerGateway.CustomerGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.customerGateway: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: CustomerGatewayState<_>) : aws.CustomerGateway.CustomerGateway =
            Unchecked.defaultof<aws.CustomerGateway.CustomerGateway>
