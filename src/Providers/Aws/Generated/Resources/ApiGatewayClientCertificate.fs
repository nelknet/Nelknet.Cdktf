namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayClientCertificateState = { assignments: ResizeArray<aws.ApiGatewayClientCertificate.ApiGatewayClientCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_client_certificate">aws_api_gateway_client_certificate</a>.
    /// </summary>
    type ApiGatewayClientCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayClientCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : ApiGatewayClientCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_client_certificate#description-1">ApiGatewayClientCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayClientCertificateState, value: string) : ApiGatewayClientCertificateState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayClientCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_client_certificate#id-1">ApiGatewayClientCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayClientCertificateState, value: string) : ApiGatewayClientCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayClientCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_client_certificate#tags-1">ApiGatewayClientCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayClientCertificateState, value: seq<string * string>) : ApiGatewayClientCertificateState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayClientCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_client_certificate#tags_all-1">ApiGatewayClientCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayClientCertificateState, value: seq<string * string>) : ApiGatewayClientCertificateState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayClientCertificateState

        member _.Run(state: ApiGatewayClientCertificateState) : aws.ApiGatewayClientCertificate.ApiGatewayClientCertificate =
            let config = aws.ApiGatewayClientCertificate.ApiGatewayClientCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayClientCertificate.ApiGatewayClientCertificate(StackContext.get (), logicalId, config)
