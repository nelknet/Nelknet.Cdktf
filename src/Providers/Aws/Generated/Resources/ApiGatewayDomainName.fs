namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayDomainNameState<'DomainName> = { assignments: ResizeArray<aws.ApiGatewayDomainName.ApiGatewayDomainNameConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name">aws_api_gateway_domain_name</a>.
    /// </summary>
    type ApiGatewayDomainNameBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayDomainNameState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDomainNameState<Missing>)

        member _.Zero(()) : ApiGatewayDomainNameState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayDomainNameState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#domain_name-1">ApiGatewayDomainName#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ApiGatewayDomainNameState<Missing>, value: string) : ApiGatewayDomainNameState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ApiGatewayDomainNameState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#certificate_arn-1">ApiGatewayDomainName#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#certificate_body-1">ApiGatewayDomainName#certificate_body</a>.
        /// </summary>
        [<CustomOperation "certificate_body">]
        member _.CertificateBody(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.CertificateBody <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#certificate_chain-1">ApiGatewayDomainName#certificate_chain</a>.
        /// </summary>
        [<CustomOperation "certificate_chain">]
        member _.CertificateChain(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.CertificateChain <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#certificate_name-1">ApiGatewayDomainName#certificate_name</a>.
        /// </summary>
        [<CustomOperation "certificate_name">]
        member _.CertificateName(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.CertificateName <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#certificate_private_key-1">ApiGatewayDomainName#certificate_private_key</a>.
        /// </summary>
        [<CustomOperation "certificate_private_key">]
        member _.CertificatePrivateKey(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.CertificatePrivateKey <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// endpoint_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#endpoint_configuration-1">ApiGatewayDomainName#endpoint_configuration</a>
        /// </summary>
        [<CustomOperation "endpoint_configuration">]
        member _.EndpointConfiguration(state: ApiGatewayDomainNameState<'DomainName>, value: aws.ApiGatewayDomainName.ApiGatewayDomainNameEndpointConfiguration) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.EndpointConfiguration <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#id-1">ApiGatewayDomainName#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// mutual_tls_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#mutual_tls_authentication-1">ApiGatewayDomainName#mutual_tls_authentication</a>
        /// </summary>
        [<CustomOperation "mutual_tls_authentication">]
        member _.MutualTlsAuthentication(state: ApiGatewayDomainNameState<'DomainName>, value: aws.ApiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthentication) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.MutualTlsAuthentication <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#ownership_verification_certificate_arn-1">ApiGatewayDomainName#ownership_verification_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "ownership_verification_certificate_arn">]
        member _.OwnershipVerificationCertificateArn(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.OwnershipVerificationCertificateArn <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#policy-1">ApiGatewayDomainName#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#regional_certificate_arn-1">ApiGatewayDomainName#regional_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "regional_certificate_arn">]
        member _.RegionalCertificateArn(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.RegionalCertificateArn <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#regional_certificate_name-1">ApiGatewayDomainName#regional_certificate_name</a>.
        /// </summary>
        [<CustomOperation "regional_certificate_name">]
        member _.RegionalCertificateName(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.RegionalCertificateName <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#security_policy-1">ApiGatewayDomainName#security_policy</a>.
        /// </summary>
        [<CustomOperation "security_policy">]
        member _.SecurityPolicy(state: ApiGatewayDomainNameState<'DomainName>, value: string) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.SecurityPolicy <- value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#tags-1">ApiGatewayDomainName#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayDomainNameState<'DomainName>, value: seq<string * string>) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayDomainNameState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#tags_all-1">ApiGatewayDomainName#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayDomainNameState<'DomainName>, value: seq<string * string>) : ApiGatewayDomainNameState<'DomainName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayDomainNameState<'DomainName>

        member _.Run(state: ApiGatewayDomainNameState<Present>) : aws.ApiGatewayDomainName.ApiGatewayDomainName =
            let config = aws.ApiGatewayDomainName.ApiGatewayDomainNameConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayDomainName.ApiGatewayDomainName(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayDomainName: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayDomainNameState<_>) : aws.ApiGatewayDomainName.ApiGatewayDomainName =
            Unchecked.defaultof<aws.ApiGatewayDomainName.ApiGatewayDomainName>
