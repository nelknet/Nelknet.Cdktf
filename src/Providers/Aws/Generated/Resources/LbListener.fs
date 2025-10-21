namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbListenerState<'DefaultAction, 'LoadBalancerArn> = { assignments: ResizeArray<aws.LbListener.LbListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener">aws_lb_listener</a>.
    /// </summary>
    type LbListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerState<Missing, Missing>)

        member _.Zero(()) : LbListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbListenerState<Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#default_action-1">LbListener#default_action</a> Accepts: aws.IResolvable | aws.LbListener.LbListenerDefaultAction[]
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: LbListenerState<Missing, 'LoadBalancerArn>, value: HashiCorp.Cdktf.IResolvable) : LbListenerState<Present, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : LbListenerState<Present, 'LoadBalancerArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#load_balancer_arn-1">LbListener#load_balancer_arn</a>.
        /// </summary>
        [<CustomOperation "load_balancer_arn">]
        member _.LoadBalancerArn(state: LbListenerState<'DefaultAction, Missing>, value: string) : LbListenerState<'DefaultAction, Present> =
            state.assignments.Add(fun config -> config.LoadBalancerArn <- value)
            ({ assignments = state.assignments } : LbListenerState<'DefaultAction, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#alpn_policy-1">LbListener#alpn_policy</a>.
        /// </summary>
        [<CustomOperation "alpn_policy">]
        member _.AlpnPolicy(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.AlpnPolicy <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#certificate_arn-1">LbListener#certificate_arn</a>.
        /// </summary>
        [<CustomOperation "certificate_arn">]
        member _.CertificateArn(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.CertificateArn <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#id-1">LbListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// mutual_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#mutual_authentication-1">LbListener#mutual_authentication</a>
        /// </summary>
        [<CustomOperation "mutual_authentication">]
        member _.MutualAuthentication(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: aws.LbListener.LbListenerMutualAuthentication) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.MutualAuthentication <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#port-1">LbListener#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: double) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#protocol-1">LbListener#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_issuer_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_issuer_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_issuer_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertIssuerHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_leaf_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_leaf_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_leaf_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertLeafHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_serial_number_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertSerialNumberHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_subject_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_subject_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_subject_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertSubjectHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_mtls_clientcert_validity_header_name-1">LbListener#routing_http_request_x_amzn_mtls_clientcert_validity_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_mtls_clientcert_validity_header_name">]
        member _.RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznMtlsClientcertValidityHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_tls_cipher_suite_header_name-1">LbListener#routing_http_request_x_amzn_tls_cipher_suite_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_tls_cipher_suite_header_name">]
        member _.RoutingHttpRequestXAmznTlsCipherSuiteHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznTlsCipherSuiteHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_request_x_amzn_tls_version_header_name-1">LbListener#routing_http_request_x_amzn_tls_version_header_name</a>.
        /// </summary>
        [<CustomOperation "routing_http_request_x_amzn_tls_version_header_name">]
        member _.RoutingHttpRequestXAmznTlsVersionHeaderName(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpRequestXAmznTlsVersionHeaderName <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_allow_credentials_header_value-1">LbListener#routing_http_response_access_control_allow_credentials_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_credentials_header_value">]
        member _.RoutingHttpResponseAccessControlAllowCredentialsHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowCredentialsHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_allow_headers_header_value-1">LbListener#routing_http_response_access_control_allow_headers_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_headers_header_value">]
        member _.RoutingHttpResponseAccessControlAllowHeadersHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowHeadersHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_allow_methods_header_value-1">LbListener#routing_http_response_access_control_allow_methods_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_methods_header_value">]
        member _.RoutingHttpResponseAccessControlAllowMethodsHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowMethodsHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_allow_origin_header_value-1">LbListener#routing_http_response_access_control_allow_origin_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_allow_origin_header_value">]
        member _.RoutingHttpResponseAccessControlAllowOriginHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlAllowOriginHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_expose_headers_header_value-1">LbListener#routing_http_response_access_control_expose_headers_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_expose_headers_header_value">]
        member _.RoutingHttpResponseAccessControlExposeHeadersHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlExposeHeadersHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_access_control_max_age_header_value-1">LbListener#routing_http_response_access_control_max_age_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_access_control_max_age_header_value">]
        member _.RoutingHttpResponseAccessControlMaxAgeHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseAccessControlMaxAgeHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_content_security_policy_header_value-1">LbListener#routing_http_response_content_security_policy_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_content_security_policy_header_value">]
        member _.RoutingHttpResponseContentSecurityPolicyHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseContentSecurityPolicyHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_server_enabled-1">LbListener#routing_http_response_server_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "routing_http_response_server_enabled">]
        member _.RoutingHttpResponseServerEnabled(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: bool) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseServerEnabled <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_server_enabled-1">LbListener#routing_http_response_server_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "routing_http_response_server_enabled">]
        member _.RoutingHttpResponseServerEnabled(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: HashiCorp.Cdktf.IResolvable) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseServerEnabled <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_strict_transport_security_header_value-1">LbListener#routing_http_response_strict_transport_security_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_strict_transport_security_header_value">]
        member _.RoutingHttpResponseStrictTransportSecurityHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseStrictTransportSecurityHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_x_content_type_options_header_value-1">LbListener#routing_http_response_x_content_type_options_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_x_content_type_options_header_value">]
        member _.RoutingHttpResponseXContentTypeOptionsHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseXContentTypeOptionsHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#routing_http_response_x_frame_options_header_value-1">LbListener#routing_http_response_x_frame_options_header_value</a>.
        /// </summary>
        [<CustomOperation "routing_http_response_x_frame_options_header_value">]
        member _.RoutingHttpResponseXFrameOptionsHeaderValue(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.RoutingHttpResponseXFrameOptionsHeaderValue <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#ssl_policy-1">LbListener#ssl_policy</a>.
        /// </summary>
        [<CustomOperation "ssl_policy">]
        member _.SslPolicy(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: string) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.SslPolicy <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#tags-1">LbListener#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: seq<string * string>) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#tags_all-1">LbListener#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: seq<string * string>) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#tcp_idle_timeout_seconds-1">LbListener#tcp_idle_timeout_seconds</a>.
        /// </summary>
        [<CustomOperation "tcp_idle_timeout_seconds">]
        member _.TcpIdleTimeoutSeconds(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: double) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.TcpIdleTimeoutSeconds <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_listener#timeouts-1">LbListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbListenerState<'DefaultAction, 'LoadBalancerArn>, value: aws.LbListener.LbListenerTimeouts) : LbListenerState<'DefaultAction, 'LoadBalancerArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbListenerState<'DefaultAction, 'LoadBalancerArn>

        member _.Run(state: LbListenerState<Present, Present>) : aws.LbListener.LbListener =
            let config = aws.LbListener.LbListenerConfig()
            for setter in state.assignments do
                setter config
            aws.LbListener.LbListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbListener: missing required arguments. Must call: default_action, load_balancer_arn.", 9999, IsError = true)>]
        member _.Run(_: LbListenerState<_, _>) : aws.LbListener.LbListener =
            Unchecked.defaultof<aws.LbListener.LbListener>
