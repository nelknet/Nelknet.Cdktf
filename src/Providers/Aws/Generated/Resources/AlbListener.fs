namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AlbListenerState<'DefaultAction, 'LoadBalancerArn> = { assignments: ResizeArray<aws.AlbListener.AlbListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener">aws_alb_listener</a>.
    /// </summary>
    type AlbListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : AlbListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerState<Missing, Missing>)

        member _.Zero(()) : AlbListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AlbListenerState<Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#default_action-1">AlbListener#default_action</a> Accepts: aws.IResolvable | aws.AlbListener.AlbListenerDefaultAction[]
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: AlbListenerState<Missing, 'LoadBalancerArn>, value: HashiCorp.Cdktf.IResolvable) : AlbListenerState<Present, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : AlbListenerState<Present, 'LoadBalancerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#load_balancer_arn-1">AlbListener#load_balancer_arn</a>.
        /// </summary>
        [<CustomOperation "load_balancer_arn">]
        member _.LoadBalancerArn(state: AlbListenerState<'DefaultAction, Missing>, value: string) : AlbListenerState<'DefaultAction, Present> =
            state.assignments.Add(fun config -> config.LoadBalancerArn <- value)
            ({ assignments = state.assignments } : AlbListenerState<'DefaultAction, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#alpn_policy-1">AlbListener#alpn_policy</a>.
        /// </summary>
        [<CustomOperation "alpn_policy">]
        member _.AlpnPolicy(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.AlpnPolicy <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#certificate_arn-1">AlbListener#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#id-1">AlbListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// mutual_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#mutual_authentication-1">AlbListener#mutual_authentication</a>
        /// </summary>
        [<CustomOperation "mutual_authentication">]
        member _.MutualAuthentication(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: aws.AlbListener.AlbListenerMutualAuthentication) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.MutualAuthentication <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#port-1">AlbListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: double) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#protocol-1">AlbListener#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_issuer_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_issuer_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_issuer_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_leaf_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_leaf_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_leaf_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_subject_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_subject_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_subject_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_mtls_clientcert_validity_header_name-1">AlbListener#routing_http_request_x_amzn_mtls_clientcert_validity_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_validity_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_tls_cipher_suite_header_name-1">AlbListener#routing_http_request_x_amzn_tls_cipher_suite_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_tls_cipher_suite_header_name">]
        member _.RoutingHttpRequestXAmznTlsCipherSuiteHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznTlsCipherSuiteHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_request_x_amzn_tls_version_header_name-1">AlbListener#routing_http_request_x_amzn_tls_version_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_tls_version_header_name">]
        member _.RoutingHttpRequestXAmznTlsVersionHeaderName(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznTlsVersionHeaderName <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_allow_credentials_header_value-1">AlbListener#routing_http_response_access_control_allow_credentials_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_credentials_header_value">]
        member _.RoutingHttpResponseAccessControlAllowCredentialsHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowCredentialsHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_allow_headers_header_value-1">AlbListener#routing_http_response_access_control_allow_headers_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_headers_header_value">]
        member _.RoutingHttpResponseAccessControlAllowHeadersHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowHeadersHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_allow_methods_header_value-1">AlbListener#routing_http_response_access_control_allow_methods_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_methods_header_value">]
        member _.RoutingHttpResponseAccessControlAllowMethodsHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowMethodsHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_allow_origin_header_value-1">AlbListener#routing_http_response_access_control_allow_origin_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_origin_header_value">]
        member _.RoutingHttpResponseAccessControlAllowOriginHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowOriginHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_expose_headers_header_value-1">AlbListener#routing_http_response_access_control_expose_headers_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_expose_headers_header_value">]
        member _.RoutingHttpResponseAccessControlExposeHeadersHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlExposeHeadersHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_access_control_max_age_header_value-1">AlbListener#routing_http_response_access_control_max_age_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_max_age_header_value">]
        member _.RoutingHttpResponseAccessControlMaxAgeHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlMaxAgeHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_content_security_policy_header_value-1">AlbListener#routing_http_response_content_security_policy_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_content_security_policy_header_value">]
        member _.RoutingHttpResponseContentSecurityPolicyHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseContentSecurityPolicyHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_server_enabled-1">AlbListener#routing_http_response_server_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "routing_http_response_server_enabled">]
        member _.RoutingHttpResponseServerEnabled(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: bool) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseServerEnabled <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_server_enabled-1">AlbListener#routing_http_response_server_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "routing_http_response_server_enabled">]
        member _.RoutingHttpResponseServerEnabled(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: HashiCorp.Cdktf.IResolvable) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseServerEnabled <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_strict_transport_security_header_value-1">AlbListener#routing_http_response_strict_transport_security_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_strict_transport_security_header_value">]
        member _.RoutingHttpResponseStrictTransportSecurityHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseStrictTransportSecurityHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_x_content_type_options_header_value-1">AlbListener#routing_http_response_x_content_type_options_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_x_content_type_options_header_value">]
        member _.RoutingHttpResponseXContentTypeOptionsHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseXContentTypeOptionsHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#routing_http_response_x_frame_options_header_value-1">AlbListener#routing_http_response_x_frame_options_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_x_frame_options_header_value">]
        member _.RoutingHttpResponseXFrameOptionsHeaderValue(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseXFrameOptionsHeaderValue <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#ssl_policy-1">AlbListener#ssl_policy</a>.
        /// </summary>
        [<CustomOperation "ssl_policy">]
        member _.SslPolicy(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.SslPolicy <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#tags-1">AlbListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: seq<string * string>) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#tags_all-1">AlbListener#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: seq<string * string>) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#tcp_idle_timeout_seconds-1">AlbListener#tcp_idle_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "tcp_idle_timeout_seconds">]
        member _.TcpIdleTimeoutSeconds(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: double) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.TcpIdleTimeoutSeconds <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_listener#timeouts-1">AlbListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AlbListenerState<'DefaultAction, 'LoadBalancerArn>, value: aws.AlbListener.AlbListenerTimeouts) : AlbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AlbListenerState<'DefaultAction, 'LoadBalancerArn>

        member _.Run(state: AlbListenerState<Present, Present>) : aws.AlbListener.AlbListener =
            let config = aws.AlbListener.AlbListenerConfig()
            for setter in state.assignments do
                setter config
            aws.AlbListener.AlbListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.albListener: missing required arguments. Must call: default_action, load_balancer_arn.", 9999, IsError = true)>]
        member _.Run(_: AlbListenerState<_, _>) : aws.AlbListener.AlbListener =
            Unchecked.defaultof<aws.AlbListener.AlbListener>
